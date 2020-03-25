using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace LidarApplication {

    public enum OperatingMode { SERVER, DRIVER }

    public partial class OperatorMode : Form {

        private const int serverPort = 80;
        private readonly float maxDist;
        private readonly int criticalAlert;
        private readonly int minoricAlert;
        private readonly OperatingMode mode;

        private GPS gps;
        private Lidar lidar;
        private SerialPort serialPort;
        private SocketSync sendSocket;
        private SocketAsync receiveSocket;
        private Terminal terminal = new Terminal();

        private List<Obstacle> obstacle = new List<Obstacle>();
        private List<Obstacle> oldObstacle = new List<Obstacle>();
        private Configuration configuration = new Configuration();

        public OperatorMode(OperatingMode mode) {
            InitializeComponent();
            this.mode = mode;
            criticalAlert = configuration.getSideHighAlert() * 10;
            minoricAlert = configuration.getSideLowAlert() * 10;
            maxDist = Lidar.GetMaxDistance();
            if (mode == OperatingMode.DRIVER)
                InitializeDriverMode();
            else InitializeServerMode();
        }

        private void InitializeDriverMode() {
            serverIP.Text = configuration.getServerIp();
            string lidarIP = configuration.getLidarIp();
            string lidarPort = configuration.getLidarPort();
            lidar = new Lidar(lidarIP, int.Parse(lidarPort));
            if (configuration.getControllerComName() != "כבוי")
                SerialPortConnection();
            if (configuration.getGPSComName() != "כבוי") {
                gps = new GPS();
                gps.StartListening(GpsStatus);
            }
            else {
                activeAlert.Columns.RemoveAt(1);
                log.Columns.RemoveAt(2);
            }
            if (configuration.getInterntAdapter() != "כבוי")
                configServerConnection();
        }

        private void InitializeServerMode() {
            lidar = new Lidar();
            lidarStatus.Hide();
            lidarStatusLabel.Hide();
            ReplaceIP.Hide();
            IPAddress serverLocalIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)) {
                socket.Connect("8.8.8.8", 65530);
                serverLocalIP = (socket.LocalEndPoint as IPEndPoint).Address;
            }
            clearLog.Location = new Point(clearLog.Location.X, clearLog.Location.Y - 40);
            saveLog.Location = new Point(saveLog.Location.X, saveLog.Location.Y - 40);
            serverStatus.Location = new Point(serverStatus.Location.X, serverStatus.Location.Y - 25);
            serverStatusLabel.Location = new Point(serverStatusLabel.Location.X, serverStatusLabel.Location.Y - 25);
            serverIP.Location = new Point(serverIP.Location.X, serverIP.Location.Y - 25);
            serverIPLabel.Location = new Point(serverIPLabel.Location.X, serverIPLabel.Location.Y - 25);
            Thread pingThread = new Thread(ServerPing);
            pingThread.IsBackground = true;
            pingThread.Start();
            receiveSocket = new SocketAsync(serverLocalIP, serverPort, ReceiveResults, LiderTimeOut);
            receiveSocket.StartListening();
        }

        private void LidarInitialization() {
            while (!lidar.initialization(configuration.getStartAngle(),
                configuration.getStopAngle(), configuration.getResolution())) {
                DialogResult dialogResult = MessageBox.Show(
                    "Lidar -נכשל בביצוע אתחול חיישן ה" + "\n\n" + "?האם ברצונך לנסות שוב",
                    "שגיאה",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                if (dialogResult == DialogResult.No) {
                    Close();
                    return;
                }
            }
            receiveSocket = new SocketAsync(LocalIP.GetLocalIP(LOCAL_IP_TYPE.LIDAR),
                Convert.ToInt32(configuration.getLidarPort()), ReceiveResults, LiderTimeOut);
            lidar.StartScan();
            receiveSocket.StartListening();
        }

        private void PastResultsOn(string data) {
            // send data to controller
            if (serialPort != null)
                new Thread(() => {
                    string serverData = data;
                    if (gps != null) serverData += " Location " + gps.getLocation().ToString();
                    if (gps != null) serverData += " Azimuth " + gps.getAzimuth();
                    if (serialPort.IsOpen) serialPort.Write(serverData);
                }).Start();
            // send data to server
            if (sendSocket != null)
                new Thread(() => { sendSocket.SendData(data); }).Start();
        }

        private void ReceiveDriverResults(string data) {
            List<string> resultsList = data.Split(' ').ToList();
            int index = resultsList.FindIndex(x => x == "Location") + 1;
            Location location = new Location(double.Parse(resultsList[index]),
                double.Parse(resultsList[index + 1]));
            index = resultsList.FindIndex(x => x == "Azimuth") + 1;
            double azimuth = double.Parse(resultsList[index]);
            gps = new GPS(location, azimuth);
        }

        private void ReceiveResults(string data) {
            if (mode == OperatingMode.DRIVER) PastResultsOn(data);
            else if (mode == OperatingMode.SERVER) ReceiveDriverResults(data);
            try {
                lidar.CreateDistanceList(data);
                List<Obstacle> ScanResult = lidar.GetScanResult();
                float resolution = configuration.getResolution();
                this.Invoke(new MethodInvoker(() => {
                    this.Refresh();
                    activeAlert.Items.Clear();
                }));
                oldObstacle.Clear();
                // copy obstacle to oldObstacle
                oldObstacle.AddRange(obstacle);
                obstacle.Clear();
                BuildActiveAlertList(ScanResult);
                BuildLogList();
                if (terminal.Visible)
                    Invoke(new MethodInvoker(() => terminal.insertData(data)));
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void BuildActiveAlertList(List<Obstacle> ScanResult) {
            float resolution = configuration.getResolution();
            //find obstacle in the active zone
            for (int i = 0; i < ScanResult.Count; i++) {
                if (ScanResult[i].InActiveZone()) {
                    // If this is a near sample it is the same obstacle
                    if (obstacle.Any() && obstacle.Last().GetAngles().Last() == ((i - 1) * resolution)) {
                        obstacle.Last().AddAngle(i * resolution);
                        obstacle.Last().AddDistance(ScanResult[i].GetH());
                    }
                    // new obstacle in the active zone
                    else obstacle.Add(new Obstacle(i * resolution, ScanResult[i].GetH()));
                }
            }
            // display all obstacle in activeAlert listview 
            foreach (var it in obstacle.Select((x, i) => new { Value = x, Index = i })) {
                ListViewItem lvi = new ListViewItem(it.Index.ToString());
                if (gps != null) lvi.SubItems.Add(it.Value.GetLocation(gps));
                lvi.SubItems.Add(it.Value.GetAverageAngle());
                lvi.SubItems.Add(it.Value.GetSideDistance());
                lvi.SubItems.Add(it.Value.GetFrontDistance());
                lvi.SubItems.Add(it.Value.GetHeight());
                lvi.SubItems.Add(it.Value.GetAleatLevel());
                if (it.Value.GetAleatState() == 2) {
                    lvi.Font = new Font(activeAlert.Font, FontStyle.Bold);
                    lvi.ForeColor = Color.Red;
                }
                this.Invoke(new MethodInvoker(() => { activeAlert.Items.Add(lvi); }));
            }
        }

        private void BuildLogList() {
            foreach (var it in obstacle) {
                if (oldObstacle.TrueForAll(old => !it.isEqule(old))) {
                    ListViewItem lvi = new ListViewItem(DateTime.Now.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));
                    if (gps != null) lvi.SubItems.Add(it.GetLocation(gps));
                    lvi.SubItems.Add(it.GetAverageAngle());
                    lvi.SubItems.Add(it.GetSideDistance());
                    lvi.SubItems.Add(it.GetFrontDistance());
                    lvi.SubItems.Add(it.GetHeight());
                    lvi.SubItems.Add(it.GetAleatLevel());
                    if (it.GetAleatState() == 2) {
                        lvi.Font = new Font(activeAlert.Font, FontStyle.Bold);
                        lvi.ForeColor = Color.Red;
                    }
                    this.Invoke(new MethodInvoker(() => { log.Items.Add(lvi); }));
                }
            }
        }

        private void SerialPortConnection() {
            Parity parity = Parity.None;
            switch (configuration.getControllerParity()) {
                case "רווח":
                    parity = Parity.Space;
                    break;
                case "אי-זוגי":
                    parity = Parity.Odd;
                    break;
                case "ללא":
                    parity = Parity.None;
                    break;
                case "סימון":
                    parity = Parity.Mark;
                    break;
                case "זוגי":
                    parity = Parity.Even;
                    break;
            }
            serialPort = new SerialPort(configuration.getControllerComName(),
                configuration.getControllerBaudRate(), parity, 8, StopBits.One);
            serialPort.Open();
        }

        private bool configServerConnection() {
            try {
                IPAddress server = IPAddress.Parse(configuration.getServerIp());
                IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.INTERNET);
                if (my == null || server == null) throw new ProtocolViolationException();
                sendSocket = new SocketSync(my, server, serverPort, ServerTimeOut);
                return true;
            } catch (Exception e) {
                MessageBox.Show("לא ניתן להתחבר לשרת.", "שגיאת התחברות",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                Console.WriteLine(e);
                return false;
            }
        }

        #region Communication status
        private void LiderTimeOut(bool isTimeOut) {
            Invoke(new MethodInvoker(() => {
                lidarStatus.Text = isTimeOut ? "החיבור אבד" : "מחובר";
                lidarStatus.ForeColor = isTimeOut ? Color.Red : Color.DarkGreen;
            }));
        }

        private void ServerTimeOut(bool isTimeOut) {
            Invoke(new MethodInvoker(() => {
                serverStatus.Text = isTimeOut ? "החיבור אבד" : "מחובר";
                serverStatus.ForeColor = isTimeOut ? Color.Red : Color.DarkGreen;
            }));
        }

        private void GpsStatus() {
            if (configuration.getGPSComName() != "כבוי") {
                gpsStatus.Text = gps.getStatus();
                gpsStatus.ForeColor = gps.isFix ? Color.DarkGreen : Color.Red;
            }
            else {
                gpsStatus.Text = "כבוי";
                gpsStatus.ForeColor = Color.Black;
            }
        }

        private void ServerPing() {
            while (true) {
                Color color = Color.DarkGreen;
                string status = "מחובר";
                string ip = "000.000.000";
                try {
                    ip = new WebClient().DownloadString("http://icanhazip.com");
                    status = "מחובר";
                    color = Color.DarkGreen;
                } catch (WebException) {
                    ip = "000.000.000";
                    status = "מנותק";
                    color = Color.Red;
                }
                Invoke(new MethodInvoker(() => {
                    serverIP.Text = ip;
                    serverStatus.Text = status;
                    serverStatus.ForeColor = color;
                }));
            }
        }
        #endregion

        #region Paint Function
        private void TopViewBox_Paint(object sender, PaintEventArgs e) { PaintTopView(e); }
        private void FrontViewBox_Paint(object sender, PaintEventArgs e) { PaintFrontView(e); }
        private void PaintFrontView(PaintEventArgs e) {
            Graphics l = e.Graphics;
            int radios = frontViewBox.Width - 20;

            // calculate vehicle size
            float heightFactor = (radios / maxDist) * 0.2f;
            float widthFactor = radios / (maxDist * 2);
            float vehicleWidth = configuration.getVehicleWidth() * 10 * widthFactor;
            int vehicleheight = (int)(configuration.getVehicleWidth() * 10 * heightFactor); // convert cm to mm

            int LeftPadding = (frontViewBox.Width - radios) / 2;
            int TopPadding = (frontViewBox.Height - (radios / 2)) - vehicleheight;

            PaintArc(e, topViewBox.Width, topViewBox.Height, vehicleheight, 1);
            PaintFrontViewLine(e, radios / 2, radios, LeftPadding, TopPadding);
            l.FillRectangle(Brushes.Navy, (radios / 2) + LeftPadding - (vehicleWidth / 2),
                frontViewBox.Height - vehicleheight, vehicleWidth, vehicleheight);
            l.Dispose();
        }
        private void PaintTopView(PaintEventArgs e) {
            Graphics l = e.Graphics;
            Pen pen = new Pen(Color.Gray, 1.5f);
            const float dotRadios = 15;
            float radios = topViewBox.Width - 20;
            int LeftPadding = (int)(topViewBox.Width - radios) / 2;
            int TopPadding = (int)(topViewBox.Height - (radios / 2)) - 10;
            float heightFactor = (radios / 2) / (configuration.getSideLowAlert() * 10);
            float widthFactor = radios / (configuration.getSideLowAlert() * 20);
            float center = topViewBox.Width / 2;
            List<Obstacle> ScanResult = lidar.GetScanResult();

            PaintArc(e, topViewBox.Width, topViewBox.Height, 10, 4);
            l.FillEllipse(new SolidBrush(Color.Navy), (topViewBox.Width - dotRadios) / 2,
                topViewBox.Height - 20, dotRadios, dotRadios);
            foreach (Obstacle o in ScanResult) {
                if (o.InActiveZone()) {
                    SolidBrush brush = o.GetAleatState() == 2 ?
                        new SolidBrush(Color.DarkRed) : new SolidBrush(Color.Red);
                    float y = topViewBox.Height - (o.GetH() * heightFactor);
                    float x = -1 * (o.GetX() * widthFactor - topViewBox.Width) - center;
                    PaintObstacle(e, brush, (int)(x + LeftPadding), (int)(y + TopPadding));
                }
            }
            l.Dispose();
        }
        private void PaintFrontViewLine(PaintEventArgs e, float height, float width,
            float leftPadding, float topPadding) {
            List<Obstacle> ScanResult = lidar.GetScanResult();
            if (ScanResult.Any()) {
                List<PointF> points = new List<PointF>();
                float heightFactor = height / maxDist;
                float widthFactor = width / (maxDist * 2);
                float center = width / 2;
                Graphics l = e.Graphics;
                Pen pen = new Pen(Color.Black, 2f);
                foreach (Obstacle o in ScanResult) {
                    float y = height - (o.GetH() * heightFactor);
                    float x = -1 * (o.GetX() * widthFactor - width) - center;
                    points.Add(new PointF(x + leftPadding, y + topPadding));
                }
                e.Graphics.DrawLines(pen, points.ToArray());

            }
        }
        private void PaintArc(PaintEventArgs e, int Width, int Height, int y, int NumberOfCircle) {
            Graphics l = e.Graphics;
            int radios = Width - 20;
            int LeftPadding = (Width - radios) / 2;
            int TopPadding = (Height - (radios / 2)) - y;

            Rectangle rect = new Rectangle(LeftPadding, TopPadding, radios, radios);
            l.FillPie(Brushes.SkyBlue, rect, 0, -180);
            for (int i = 1; i <= NumberOfCircle; i++) {
                radios = ((topViewBox.Width - 20) / NumberOfCircle) * i;
                LeftPadding = (topViewBox.Width - radios) / 2;
                TopPadding = (topViewBox.Height - (radios / 2)) - y;
                rect = new Rectangle(LeftPadding, TopPadding, radios, radios);
                l.DrawArc(new Pen(Color.Gray, 1.5f), rect, 0, -180);
            }
        }
        private void PaintObstacle(PaintEventArgs e, SolidBrush solidBrush, int x, int y) {
            Graphics l = e.Graphics;

            const float dotRadios = 10;
            l.FillEllipse(solidBrush, x, y, dotRadios, dotRadios);
        }

        #endregion

        #region Button Click Event
        private void ReplaceIP_Click(object sender, EventArgs e) {
            using (var form = new ChangeIP(configuration.getServerIp())) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    configuration.setServerIp(form.NewIP.ToString());
                    serverIP.Text = configuration.getServerIp();
                    IPAddress server = IPAddress.Parse(configuration.getServerIp());
                    IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.INTERNET);
                    sendSocket = new SocketSync(my, server, serverPort);
                }
            }
        }
        private void clearLog_Click(Object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show(
                   "?האם למחוק את הלוג",
                   "אימות",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.RightAlign);
            if (dialogResult == DialogResult.Yes) log.Items.Clear();
        }
        private void saveLog_Click(Object sender, EventArgs e) {
            var csv = new StringBuilder();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "ללא שם";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv| Text Files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                    "תאריך", "שעה", "זווית", "צד", "מרחק", "גובה", "רמת התראה");
                csv.AppendLine(newLine);
                foreach (ListViewItem line in log.Items) {
                    newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                   line.SubItems[0].Text, line.SubItems[1].Text, line.SubItems[2].Text,
                   line.SubItems[3].Text, line.SubItems[4].Text, line.SubItems[5].Text,
                   line.SubItems[6].Text);
                    csv.AppendLine(newLine);
                }

            }
            File.WriteAllText(saveFileDialog1.FileName, csv.ToString(), Encoding.UTF8);
        }
        private void btnTerminal_Click(Object sender, EventArgs e) { terminal.ShowDialog(); }
        #endregion

        private void OperatorMode_Load(object sender, EventArgs e) {
            if (mode == OperatingMode.DRIVER)
                LidarInitialization();
        }
        private void OperatorMode_FormClosed(Object sender, FormClosedEventArgs e) {
            if (mode == OperatingMode.DRIVER) {
                if (serialPort != null) serialPort.Close();
                if (gps != null) gps.StopListening();
                new Thread(lidar.StopScan);
            }
            if (receiveSocket != null) receiveSocket.StopListening();
            //Environment.Exit(0);    
        }

    }
}
