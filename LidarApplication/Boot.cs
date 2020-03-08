using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public partial class Boot : Form {
        private IPAddress internetAdapterIp;
        private IPAddress lidarAdapterIp;
        private Configuration configuration = new Configuration();

        public Boot() {
            InitializeComponent();
            getExternalIpAddress();
            comboBoxInit();
            lidarPort.Mask = "0000";
            lidarPort.Text = "2111";
            epLidar.Text = "192.168.0.1";
            refreshData();
        }

        private void comboBoxInit() {
            resolutionComboBox.Items.AddRange(new string[] { "0.25", "0.5" });
            ParityComboBox.Items.AddRange(new string[] { "זוגי", "סימון", "ללא", "אי-זוגי", "רווח" });
            BaudRateComboBox.Items.AddRange(new string[] { "9600", "14400", "19200", "38400", "57600", "115200", "128000" });
            resolutionComboBox.SelectedItem = resolutionComboBox.Items[0];
            ParityComboBox.SelectedItem = ParityComboBox.Items[2];
            BaudRateComboBox.SelectedItem = BaudRateComboBox.Items[2];
            comComboBox.Items.AddRange(SerialPort.GetPortNames());
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces()) {
                lidarAdapterComboBox.Items.Add(nic.Name);
                interntAdapterComboBox.Items.Add(nic.Name);
            }
        }

        private bool getExternalIpAddress() {
            serverIpAddress.BackColor = Color.White;
            serverIpAddress.ForeColor = Color.Black;
            try {
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                serverIpAddress.Text = externalip;
                Console.Write("External Ip Address Is " + externalip);
            } catch (WebException) {
                serverIpAddress.Text = "Lost Connection";
                serverIpAddress.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void checkNetwork_Click(object sender, EventArgs e) {
            bool result = getExternalIpAddress();
            string text = result ? "החיבור תקין" : "אין חיבור לרשת";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                result ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void checkLidar_Click(object sender, EventArgs e) {
            PingReply pingReplay = PingReply.Send(lidarAdapterIp, Lidar.IP);
            bool isSuccess = pingReplay.Status.ToString().Equals("Success");
            string text = isSuccess ? "החיבור לחיישן תקין" : "החיישן לא נמצא";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void lidarAdapterComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            LocalIP.GetLocalIP(lidarAdapterComboBox.SelectedItem as string, LOCAL_IP_TYPE.LIDAR);
        }

        private void interntAdapterComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            LocalIP.GetLocalIP(lidarAdapterComboBox.SelectedItem as string, LOCAL_IP_TYPE.INTERNET);
        }

        private void refreshData() {
            Lidar.IP = IPAddress.Parse(configuration.getLidarIp());
            Lidar.PORT = Convert.ToInt32(configuration.getLidarPort());
            height.Value = configuration.getHeight();
            angle.Value = configuration.getAngle();
            startAngle.Value = configuration.getStartAngle();
            stopAngle.Value = configuration.getStopAngle();
            vehicleWidth.Value = configuration.getVehicleWidth();
            resolutionComboBox.SelectedItem = configuration.getResolution().ToString();
            highAlert.Value = configuration.getHighAlert();
            lowAlert.Value = configuration.getLowAlert();
            epLidar.Text = configuration.getLidarIp();
            lidarPort.Text = configuration.getLidarPort();
            BaudRateComboBox.SelectedItem = configuration.getBaudRate().ToString();
            ParityComboBox.SelectedItem = configuration.getParity();
            epServer.Text = configuration.getServerIp();
            interntAdapterComboBox.SelectedItem = configuration.getInterntAdapter();

            if (comComboBox.Items.Contains(configuration.getComName()))
                comComboBox.SelectedItem = configuration.getComName();
            else if (comComboBox.Items.Count != 0)
                comComboBox.SelectedItem = comComboBox.Items[0];

            if (lidarAdapterComboBox.Items.Contains(configuration.getLidarAdapter()))
                lidarAdapterComboBox.SelectedItem = configuration.getLidarAdapter();
            else if (lidarAdapterComboBox.Items.Count != 0)
                lidarAdapterComboBox.SelectedItem = lidarAdapterComboBox.Items[0];

            if (interntAdapterComboBox.Items.Contains(configuration.getInterntAdapter()))
                interntAdapterComboBox.SelectedItem = configuration.getInterntAdapter();
            else if (interntAdapterComboBox.Items.Count != 0)
                interntAdapterComboBox.SelectedItem = interntAdapterComboBox.Items[0];
        }

        private void saveConfiguration() {
            if (stopAngle.Value < startAngle.Value)
                MessageBox.Show(".זווית התחלה לא יכולה להיות גדולה מזווית סיום",
                    "נתונים לא תקינים", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else {
                configuration.setHeight(decimal.ToInt32(height.Value));
                configuration.setAngle(decimal.ToInt32(angle.Value));
                configuration.setStartAngle(decimal.ToInt32(startAngle.Value));
                configuration.setStopAngle(decimal.ToInt32(stopAngle.Value));
                configuration.setVehicleWidth(decimal.ToInt32(vehicleWidth.Value));
                configuration.setResolution(double.Parse(resolutionComboBox.SelectedItem.ToString()));
                configuration.setHighAlert(decimal.ToInt32(highAlert.Value));
                configuration.setLowAlert(decimal.ToInt32(lowAlert.Value));
                configuration.setLidarIp(epLidar.Text);
                configuration.setLidarPort(lidarPort.Text);
                if (comComboBox.SelectedItem != null)
                    configuration.setComName(comComboBox.SelectedItem.ToString());
                configuration.setBaudRate(int.Parse(BaudRateComboBox.SelectedItem.ToString()));
                configuration.setParity(ParityComboBox.SelectedItem.ToString());
                configuration.setServerIp(epServer.Text);
                configuration.setLidarAdapter(lidarAdapterComboBox.SelectedItem.ToString());
                configuration.setInterntAdapter(interntAdapterComboBox.SelectedItem.ToString());
                configuration.save();
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            if (stopAngle.Value < startAngle.Value)
                MessageBox.Show(".זווית התחלה לא יכולה להיות גדולה מזווית סיום",
                    "נתונים לא תקינים", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else if (comComboBox.SelectedItem == null) {
                string msg = "לא נמצאה יציאה טורית מחוברת" + "\n\n" + "?האם ברצונך להמשיך ללא תקשורת טורית";
                if (MessageBox.Show(msg, "אישור פעולה",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign) == DialogResult.Yes) {
                    saveConfiguration();
                    OperatorMode operatorMode = new OperatorMode(false, OperatingMode.DRIVER);
                    this.Hide();
                    operatorMode.Closed += (s, args) => this.Close();
                    operatorMode.Show();
                }
            }
            else {
                saveConfiguration();
                OperatorMode operatorMode = new OperatorMode(true, OperatingMode.DRIVER);
                this.Hide();
                operatorMode.Closed += (s, args) => this.Close();
                operatorMode.Show();
            }
        }

        private void saveButton_Click(object sender, EventArgs e) { saveConfiguration(); }

        private void cancelButton_Click(object sender, EventArgs e) {
            refreshData();
        }

        private void startServer_Click(Object sender, EventArgs e) {
            OperatorMode operatorMode = new OperatorMode(true, OperatingMode.SERVER);
            this.Hide();
            operatorMode.Closed += (s, args) => this.Close();
            operatorMode.Show();
        }
    }
}