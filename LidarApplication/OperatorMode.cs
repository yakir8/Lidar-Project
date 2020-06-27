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
        private readonly OperatingMode mode;

        private GPS gps;
        private Lidar lidar;
        private Terminal terminal;
        private Thread pingThread;
        private SerialPort serialPort;
        private SocketSync sendSocket;
        private ServerSocket receiveSocket;

        private List<Obstacle> obstacle = new List<Obstacle>();
        private List<Obstacle> oldObstacle = new List<Obstacle>();
        private Configuration config = new Configuration();

        public OperatorMode(OperatingMode mode) {
            InitializeComponent();
            this.mode = mode;
            DistLabelSetup();
            terminal = new Terminal(lidar);
        }

        private void DistLabelSetup() {
            if (config.getGridEnable()) {
                float ratio = GraphicLidar.GetRatioHeightWidth(config);
                #region Laidar Output Label
                float maxDist = (config.getSideLowAlert() * 10) / GraphicLidarOutput.Zoom;
                float distXStep = (maxDist / 1000) / 3;
                float distYStep = ((maxDist / ratio) / 1000) / 3;
                DistFrontYLabel1.Text = (distYStep).ToString("0.00");
                DistFrontYLabel1.BackColor = Color.Transparent;
                DistFrontYLabel2.Text = (distYStep * 2).ToString("0.00");
                DistFrontYLabel2.BackColor = Color.Transparent;
                DistFrontYLabel3.Text = (distYStep * 3).ToString("0.00");
                DistFrontYLabel3.BackColor = Color.Transparent;

                DistFrontXLabel1.Text = (-distXStep * 3).ToString("0.00");
                DistFrontXLabel1.BackColor = Color.Transparent;
                DistFrontXLabel2.Text = (-distXStep * 2).ToString("0.00");
                DistFrontXLabel2.BackColor = Color.Transparent;
                DistFrontXLabel3.Text = (-distXStep).ToString("0.00");
                DistFrontXLabel3.BackColor = Color.Transparent;
                DistFrontXLabel4.Text = (distXStep).ToString("0.00");
                DistFrontXLabel4.BackColor = Color.Transparent;
                DistFrontXLabel5.Text = (distXStep * 2).ToString("0.00");
                DistFrontXLabel5.BackColor = Color.Transparent;
                DistFrontXLabel6.Text = (distXStep * 3).ToString("0.00");
                DistFrontXLabel6.BackColor = Color.Transparent;
                #endregion

                #region Lidar Alert Label
                float maxDisSide = (config.getSideLowAlert() * 10) / GraphicLidarAlert.Zoom;
                float maxDisFront = (config.getFrontLowAlert() * 10) / GraphicLidarAlert.Zoom;
                distXStep = (maxDisSide / 1000) / 3;
                distYStep = (maxDisFront / 1000) / 3;
                if (maxDisSide / maxDisFront < ratio) {
                    float RatioFactor = (maxDisFront * ratio) / maxDisSide;
                    distXStep = ((maxDisSide * RatioFactor) / 1000) / 3;
                }
                else if (maxDisSide / maxDisFront > ratio) {
                    float RatioFactor = maxDisSide / (maxDisFront * ratio);
                    distYStep = ((maxDisFront * RatioFactor) / 100) / 3;
                }
                DistTopYLabel1.Text = (distYStep).ToString("0.00");
                DistTopYLabel1.BackColor = Color.Transparent;
                DistTopYLabel2.Text = (distYStep * 2).ToString("0.00");
                DistTopYLabel2.BackColor = Color.Transparent;
                DistTopYLabel3.Text = (distYStep * 3).ToString("0.00");
                DistTopYLabel3.BackColor = Color.Transparent;

                DistTopXLabel1.Text = (-distXStep * 3).ToString("0.00");
                DistTopXLabel1.BackColor = Color.Transparent;
                DistTopXLabel2.Text = (-distXStep * 2).ToString("0.00");
                DistTopXLabel2.BackColor = Color.Transparent;
                DistTopXLabel3.Text = (-distXStep).ToString("0.00");
                DistTopXLabel3.BackColor = Color.Transparent;
                DistTopXLabel4.Text = (distXStep).ToString("0.00");
                DistTopXLabel4.BackColor = Color.Transparent;
                DistTopXLabel5.Text = (distXStep * 2).ToString("0.00");
                DistTopXLabel5.BackColor = Color.Transparent;
                DistTopXLabel6.Text = (distXStep * 3).ToString("0.00");
                DistTopXLabel6.BackColor = Color.Transparent;
                #endregion
            }
            else {
                #region Laidar Output Label
                DistFrontYLabel1.Visible = false;
                DistFrontYLabel2.Visible = false;
                DistFrontYLabel3.Visible = false;

                DistFrontXLabel1.Visible = false;
                DistFrontXLabel2.Visible = false;
                DistFrontXLabel3.Visible = false;
                DistFrontXLabel4.Visible = false;
                DistFrontXLabel5.Visible = false;
                DistFrontXLabel6.Visible = false;
                #endregion

                #region Lidar Alert Label
                DistTopYLabel1.Visible = false;
                DistTopYLabel2.Visible = false;
                DistTopYLabel3.Visible = false;

                DistTopXLabel1.Visible = false;
                DistTopXLabel2.Visible = false;
                DistTopXLabel3.Visible = false;
                DistTopXLabel4.Visible = false;
                DistTopXLabel5.Visible = false;
                DistTopXLabel6.Visible = false;
                #endregion
            }
        }

        #region Driver Mode
        private void InitializeDriverMode() {
            serverIP.Text = config.getServerIp();
            string lidarIP = config.getLidarIp();
            string lidarPort = config.getLidarPort();
            lidar = new Lidar(config, lidarIP, int.Parse(lidarPort));
            if (config.getControllerComName() != "כבוי")
                SerialPortConnection();
            if (config.getGPSComName() != "כבוי") {
                gps = new GPS(config);
                gps.StartListening(GpsStatus);
                gpsStatusLabel.Text = gps.getStatus();
                gpsStatusLabel.ForeColor = gps.isFix ? Color.DarkGreen : Color.Red;
            }
            else {
                activeAlert.Columns.RemoveAt(1);
                log.Columns.RemoveAt(2);
            }
            if (config.getInterntAdapter() != "כבוי")
                new Thread(configServerConnection).Start();
        }

        private void LidarInitialization() {
            int startAngle = config.getStartAngle();
            int stopAngle = config.getStopAngle();
            float resolution = config.getResolution();
            string title = "שגיאה";
            string errorMsg = "Lidar -נכשל בביצוע אתחול חיישן ה" + "\n\n" + "?האם ברצונך לנסות שוב";
            while (!lidar.initialization(startAngle, stopAngle, resolution)) {
                if (MessageBox.Show(errorMsg, title, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign) == DialogResult.No) {
                    Close();
                    return;
                }
            }
            lidar.StartScan(ReceiveResults, LiderTimeOut);
        }

        private void SerialPortConnection() {
            Parity parity = (Parity)Configuration.Parity.ToList().IndexOf(config.getControllerParity());
            serialPort = new SerialPort(config.getControllerComName(),
                config.getControllerBaudRate(), parity, 8, StopBits.One);
            serialPort.Open();
        }

        private void configServerConnection() {
            try {
                bool isSucceeded = false;
                int vehicleWidth = config.getVehicleWidth();
                int height = config.getSensorHeightSetup();
                int angle = config.getAngleSetup();
                int sideL = config.getSideLowAlert();
                int sideH = config.getSideHighAlert();
                int FrontL = config.getFrontLowAlert();
                int FrontH = config.getFrontHighAlert();
                int HeightL = config.getHoleLowAlert();
                int HeightH = config.getHoleHighAlert();
                string srvConfig = "Config " + height + " " + angle + " " +
                    vehicleWidth + " " + sideL + " " + sideH + " " +
                    FrontL + " " + FrontH + " " + HeightL + " " + HeightH;
                IPAddress server = IPAddress.Parse(config.getServerIp());
                IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.INTERNET);
                if (my == null || server == null) throw new ProtocolViolationException();
                sendSocket = new SocketSync(my, server, serverPort, ServerTimeOut);
                isSucceeded = sendSocket.Connect();
                if (isSucceeded) isSucceeded = sendSocket.Send(srvConfig, false);
                ServerTimeOut(!isSucceeded);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        #endregion

        #region Server Mode
        private void InitializeServerMode() {
            lidar = new Lidar(config);
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
            serverStatus.Location = new Point(serverStatus.Location.X, serverStatus.Location.Y - 35);
            serverStatusLabel.Location = new Point(serverStatusLabel.Location.X, serverStatusLabel.Location.Y - 35);
            serverIP.Location = new Point(serverIP.Location.X, serverIP.Location.Y - 40);
            serverIPLabel.Location = new Point(serverIPLabel.Location.X, serverIPLabel.Location.Y - 40);
            tableLayoutPanel1.SetColumnSpan(btnTerminal, 3);
            tableLayoutPanel1.SetColumn(btnTerminal, 0);

            receiveSocket = new ServerSocket(serverLocalIP, serverPort, ReceiveResults);
            receiveSocket.StartListening();

            pingThread = new Thread(ServerPing);
            pingThread.IsBackground = true;
            pingThread.Start();
        }
        private void DecodeConfigFromDriver(string strConfig) {
            /* configArr[0] = Config key word
             * configArr[1] = Sensor Height Setup
             * configArr[2] = Sensor Angle Setup
             * configArr[3] = Vehicle Width
             * configArr[4] = Side Low Alert
             * configArr[5] = Side High Alert
             * configArr[6] = Front Low Alert
             * configArr[7] = Front High Alert
             * configArr[8] = Height Low Alert
             * configArr[9] = Height High Alert
             */
            string[] configArr = strConfig.Split(' ');
            if (configArr.Count() == 10) {
                config.setSensorHeightSetup(int.Parse(configArr[1]));
                config.setAngleSetup(int.Parse(configArr[2]));
                config.setVehicleWidth(int.Parse(configArr[3]));
                config.setSideLowAlert(int.Parse(configArr[4]));
                config.setSideHighAlert(int.Parse(configArr[5]));
                config.setFrontLowAlert(int.Parse(configArr[6]));
                config.setFrontHighAlert(int.Parse(configArr[7]));
                config.setHoleLowAlert(int.Parse(configArr[8]));
                config.setHoleHighAlert(int.Parse(configArr[9]));
                Invoke(new MethodInvoker(DistLabelSetup));
            }
            lidar = new Lidar(config);
        }
        #endregion

        #region Scan Data Handle
        private void PastResultsOn(string data) {
            // send data to controller
            if (serialPort != null && serialPort.IsOpen)
                new Thread(() => {
                    if (config.getSerialDataType() == Configuration.DataType[0])
                        serialPort.Write(data);
                    else if (config.getSerialDataType() == Configuration.DataType[1]) {
                        foreach (var it in obstacle.Select((x, i) => new { Value = x, Index = i })) {
                            StringBuilder str = new StringBuilder("מסד: " + (it.Index + 1).ToString() + ",");
                            if (gps != null) str.Append("קורדינטות: " + it.Value.GetLocation(gps) + ",");
                            str.Append("זווית: " + it.Value.GetAngle() + ",");
                            str.Append("צד" + it.Value.GetSideDistance() + ",");
                            str.Append("מרחק" + it.Value.GetFrontDistance() + ",");
                            str.Append("גובה מתחת לחיישן" + it.Value.GetHeight() + ",");
                            str.AppendLine("רמת התראה" + it.Value.GetAleatLevel() + ".");
                            serialPort.Write(str.ToString());
                        }
                    }
                }).Start();
            // send data to server
            if (sendSocket != null)
                new Thread(() => {
                    string serverData = data;
                    if (gps != null) serverData += " Location " + gps.getLocation().ToString();
                    if (gps != null) serverData += " Azimuth " + gps.getAzimuth();
                    if (serverStatus.Text == "מחובר") sendSocket.Send(serverData, false);
                }).Start();
        }

        private void ReceiveDriverResults(string data) {
            if (data.Contains("Config")) DecodeConfigFromDriver(data);
            else if (data.Contains("Location")) {
                List<string> resultsList = data.Split(' ').ToList();
                int index = resultsList.FindIndex(x => x == "Location") + 1;
                Location location = new Location(double.Parse(resultsList[index]),
                    double.Parse(resultsList[index + 1]));
                index = resultsList.FindIndex(x => x == "Azimuth") + 1;
                double azimuth = double.Parse(resultsList[index]);
                gps = new GPS(location, azimuth);
            }
        }

        private void ReceiveResults(string data) {
            if (mode == OperatingMode.DRIVER) PastResultsOn(data);
            else if (mode == OperatingMode.SERVER) ReceiveDriverResults(data);
            try {
                lidar.CreateDistanceList(data);
                this.Invoke(new MethodInvoker(() => { this.Refresh(); }));
                oldObstacle.Clear();
                // copy obstacle to oldObstacle
                oldObstacle.AddRange(obstacle);
                obstacle.Clear();
                BuildActiveAlertList(lidar.GetScanResult());
                BuildLogList();
                if (terminal.Visible)
                    Invoke(new MethodInvoker(() => terminal.insertData(data)));
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void BuildActiveAlertList(List<Obstacle> ScanResult) {
            float resolution = config.getResolution();
            List<ListViewItem> lst = new List<ListViewItem>();
            //find obstacle in the active zone
            ScanResult.ForEach((result) => {
                if (result.isDetectable()) {
                    float angle = result.GetAngles().Last();
                    float radius = result.GetRadius().Last();
                    // If this is a near sample it is the same obstacle
                    if (obstacle.Any() && (angle - obstacle.Last().GetAngles().Last()) <= 1) 
                        obstacle.Last().AddPoint(angle, radius);
                    // new obstacle in the active zone
                    else obstacle.Add(new Obstacle(config, angle, result.GetRadius().Last()));
                }
            });
            for (int i = 0; i < obstacle.Count; i++)
                if (!obstacle[i].InActiveZone()) obstacle.RemoveAt(i);
            // display all obstacle in activeAlert listview 
            foreach (var it in obstacle.Select((x, i) => new { Value = x, Index = i })) {
                ListViewItem lvi = new ListViewItem((it.Index + 1).ToString());
                if (gps != null) lvi.SubItems.Add(it.Value.GetLocation(gps));
                lvi.SubItems.Add(it.Value.GetAngle());
                lvi.SubItems.Add(it.Value.GetSideDistance());
                lvi.SubItems.Add(it.Value.GetFrontDistance());
                lvi.SubItems.Add(it.Value.GetHeight());
                lvi.SubItems.Add(it.Value.GetAleatLevel());
                if (it.Value.GetAleatState() == 2) {
                    lvi.Font = new Font(activeAlert.Font, FontStyle.Bold);
                    lvi.ForeColor = Color.Red;
                }
                lst.Add(lvi);
            }
            if (!this.IsDisposed)
                Invoke(new MethodInvoker(() => {
                    activeAlert.BeginUpdate();
                    activeAlert.Items.Clear();
                    activeAlert.Items.AddRange(lst.ToArray());
                    activeAlert.EndUpdate();
                }));
        }
        private void BuildLogList() {
            foreach (var it in obstacle) {
                if (oldObstacle.TrueForAll(old => !it.isEqule(old))) {
                    ListViewItem lvi = new ListViewItem(DateTime.Now.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));
                    if (gps != null) lvi.SubItems.Add(it.GetLocation(gps));
                    lvi.SubItems.Add(it.GetAngle());
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
        #endregion

        #region Communication Status
        private void LiderTimeOut(bool isTimeOut) {
            if (!this.IsDisposed) {
                try {
                    Invoke(new MethodInvoker(() => {
                        lidarStatus.Text = isTimeOut ? "החיבור אבד" : "מחובר";
                        lidarStatus.ForeColor = isTimeOut ? Color.Red : Color.DarkGreen;
                    }));
                    if (isTimeOut) {
                        //lidar.Restart(ReceiveResults, LiderTimeOut);
                    }
                } catch { }
            }
        }

        private void ServerTimeOut(bool isTimeOut) {
            if (!this.IsDisposed) {
                Invoke(new MethodInvoker(() => {
                    serverStatus.Text = isTimeOut ? "החיבור אבד" : "מחובר";
                    serverStatus.ForeColor = isTimeOut ? Color.Red : Color.DarkGreen;
                }));
                if (isTimeOut) {
                    sendSocket.Disconnect();
                    configServerConnection();
                    //ServerTimeOut(!sendSocket.Connect());
                }
            }
        }

        private void GpsStatus() {
            Invoke(new MethodInvoker(() => {
                if (config.getGPSComName() != "כבוי") {
                    gpsStatusLabel.Text = gps.getStatus();
                    gpsStatusLabel.ForeColor = gps.isFix ? Color.DarkGreen : Color.Red;
                }
                else {
                    gpsStatusLabel.Text = "כבוי";
                    gpsStatusLabel.ForeColor = Color.Black;
                }
            }));
        }

        private void ServerPing() {
            while (true) {
                Thread.Sleep(1000);
                Color color = Color.DarkGreen;
                string status = "מחובר";
                string ip = "000.000.000.000";
                try {
                    ip = new WebClient().DownloadString("http://icanhazip.com");
                    status = "מחובר";
                    color = Color.DarkGreen;
                } catch (WebException) {
                    ip = "000.000.000.000";
                    status = "החיבור אבד";
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

        #region Button Click Event
        private void ReplaceIP_Click(object sender, EventArgs e) {
            lidar.StopScan();
            var result = new Redefine().ShowDialog();
            if (result == DialogResult.OK) {
                lidar.PauseScan();
                config.LoadConfiguration();
                DistLabelSetup();
                // Reconfig lidar settings
                string lidarIP = config.getLidarIp();
                string lidarPort = config.getLidarPort();
                if (lidarIP != Lidar.IP.ToString() || Lidar.PORT != Convert.ToInt32(lidarPort)) {
                    lidar.SetIp(lidarIP);
                    lidar.SetPort(int.Parse(lidarPort));
                }
                LidarInitialization();

                // Reconfig Serial Port
                if (serialPort != null) {
                    serialPort.Close();
                    serialPort = null;
                }
                if (config.getControllerComName() != "כבוי")
                    SerialPortConnection();

                // Reconfig GPS Serial Port
                
                if (gps != null && config.getGPSComName() == "כבוי") {
                    activeAlert.Columns.RemoveAt(1);
                    log.Columns.RemoveAt(2);
                    gps.StopListening();
                    gps = null;
                }
                else if (config.getGPSComName() != "כבוי") {
                    if (activeAlert.Columns.Count == 6) {
                        activeAlert.Columns.Insert(1, "קורדינטות");
                        activeAlert.Columns[1].Width = 300;
                        activeAlert.Columns[1].TextAlign = HorizontalAlignment.Center;
                    }
                    if (log.Columns.Count == 7) {
                         log.Columns.Insert(2, "קורדינטות");
                        log.Columns[2].Width = 300;
                        log.Columns[2].TextAlign = HorizontalAlignment.Center;
                    }
                    gps = new GPS(config);
                    gps.StartListening(GpsStatus);
                }
                // Reconfig Server
                if (sendSocket != null) {
                    sendSocket.Disconnect();
                    sendSocket = null;
                    if (config.getInterntAdapter() != "כבוי")
                        new Thread(configServerConnection).Start();
                }
                lidar.ResumeScan();
            }
            else lidar.ResumeScan();
        }
        private void clearLog_Click(Object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show(
                   "?האם למחוק את הלוג",
                   "אימות פעולה",
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
        private void ZoomClick(Object sender, EventArgs e) {
            if (((Button)sender).Name == "zoomOutLidarOutput") GraphicLidarOutput.Zoom /= 2;
            else if (((Button)sender).Name == "zoomInLidarOutput") GraphicLidarOutput.Zoom *= 2;
            else if (((Button)sender).Name == "zoomOutAlert") GraphicLidarAlert.Zoom /= 2;
            else if (((Button)sender).Name == "zoomInAlert") GraphicLidarAlert.Zoom *= 2;
            DistLabelSetup();
        }

        #endregion

        #region System Event
        private void DrawLidarResult(object sender, PaintEventArgs e) {
            if (((GroupBox)sender).Name == "lidarOutput")
                new GraphicLidarOutput((GroupBox)sender, config)
                    .Draw(e, lidar.GetScanResult());
            else if (((GroupBox)sender).Name == "lidarAlert")
                new GraphicLidarAlert((GroupBox)sender, config)
                    .Draw(e, obstacle);
        }
        private void OperatorMode_Load(object sender, EventArgs e) {
            if (mode == OperatingMode.DRIVER) {
                InitializeDriverMode();
                LidarInitialization();
            }
            else InitializeServerMode();
        }
        private void OperatorMode_FormClosing(Object sender, FormClosingEventArgs e) {
            if (mode == OperatingMode.DRIVER) {
                if (serialPort != null) serialPort.Close();
                if (gps != null) gps.StopListening();
                lidar.StopScan();
            }
            else {
                if (receiveSocket != null) receiveSocket.StopListening();
                if (pingThread != null) pingThread.Abort();
            }
            //Environment.Exit(0);    
        }
        private void OperatorMode_SizeChanged(Object sender, EventArgs e) {
            int r = (int)GraphicLidar.getDiameter(lidarAlert) / 2;
            int leftPadding = (lidarAlert.Size.Width - (int)GraphicLidar.getDiameter(lidarAlert)) / 2;
            int w = (r * 2) / 7;
            int topPadding = lidarAlert.Size.Height - r;
            int step = r / 3;

            #region Laidar Output 
            DistTopXLabel1.Location = new Point(leftPadding - 10, lidarAlert.Size.Height - 25);
            DistTopXLabel2.Location = new Point(leftPadding + w - 15, lidarAlert.Size.Height - 25);
            DistTopXLabel3.Location = new Point(leftPadding + w * 2 + 5, lidarAlert.Size.Height - 25);
            DistTopXLabel4.Location = new Point(leftPadding + w * 5 - 45, lidarAlert.Size.Height - 25);
            DistTopXLabel5.Location = new Point(leftPadding + w * 6 - 25, lidarAlert.Size.Height - 25);
            DistTopXLabel6.Location = new Point(leftPadding + w * 7 - 40, lidarAlert.Size.Height - 25);

            DistTopYLabel1.Location = new Point(leftPadding + 5, lidarAlert.Size.Height - step - 50);
            DistTopYLabel2.Location = new Point(leftPadding + 5, lidarAlert.Size.Height - step * 2 - 50);
            DistTopYLabel3.Location = new Point(lidarAlert.Size.Width / 2 - 30, topPadding - 45);
            #endregion

            #region Lidar Alert 
            DistFrontXLabel1.Location = new Point(leftPadding - 10, lidarAlert.Size.Height - 25);
            DistFrontXLabel2.Location = new Point(leftPadding + w - 15, lidarAlert.Size.Height - 25);
            DistFrontXLabel3.Location = new Point(leftPadding + w * 2 + 5, lidarAlert.Size.Height - 25);
            DistFrontXLabel4.Location = new Point(leftPadding + w * 5 - 45, lidarAlert.Size.Height - 25);
            DistFrontXLabel5.Location = new Point(leftPadding + w * 6 - 25, lidarAlert.Size.Height - 25);
            DistFrontXLabel6.Location = new Point(leftPadding + w * 7 - 40, lidarAlert.Size.Height - 25);

            DistFrontYLabel1.Location = new Point(leftPadding + 5, lidarAlert.Size.Height - step - 50);
            DistFrontYLabel2.Location = new Point(leftPadding + 5, lidarAlert.Size.Height - step * 2 - 50);
            DistFrontYLabel3.Location = new Point(lidarAlert.Size.Width / 2 - 30, topPadding - 45);
            #endregion
        }
        #endregion
    }
}
