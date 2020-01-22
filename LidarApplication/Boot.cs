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

namespace LidarApplication
{
    public partial class Boot : Form
    {
        enum IP_TYPE { INTERNET, LIDAR };
        IPAddress internetAdapterIp;
        IPAddress lidarAdapterIp;
        Configuration configuration = new Configuration();

        public Boot()
        {
            InitializeComponent();
            getExternalIpAddress();
            comboBoxInit();
            inputIpAddress.Mask = "###.###.###.###";
            inputIpAddress.ValidatingType = typeof(IPAddress);
            lidarIp.Mask = "###.###.###.###:####";
            lidarIp.ValidatingType = typeof(IPAddress);
            lidarIp.Text = "192.168.000.001:2111";
            refreshData();
        }

        private void comboBoxInit()
        {
            resolutionComboBox.Items.AddRange(new string[] { "0.25", "0.5" });
            ParityComboBox.Items.AddRange(new string[] { "זוגי", "סימון", "ללא", "אי-זוגי", "רווח" });
            BaudRateComboBox.Items.AddRange(new string[] { "9600", "14400", "19200", "38400", "57600", "115200", "128000" });
            resolutionComboBox.SelectedItem = resolutionComboBox.Items[0];
            ParityComboBox.SelectedItem = ParityComboBox.Items[2];
            BaudRateComboBox.SelectedItem = BaudRateComboBox.Items[2];
            comComboBox.Items.AddRange(SerialPort.GetPortNames());
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                lidarAdapterComboBox.Items.Add(nic.Name);
                interntAdapterComboBox.Items.Add(nic.Name);
            }
        }

        private void getInernalIpByAdapter(string adapterName, IP_TYPE ipType)
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.Name == adapterName)
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            if (ipType == IP_TYPE.INTERNET)
                                internetAdapterIp = new IPAddress(ip.Address.GetAddressBytes());
                            else
                                lidarAdapterIp = new IPAddress(ip.Address.GetAddressBytes());
                            Console.WriteLine("The Ip Address For Adapter " + ni.Name + " Is " + ip.Address.ToString());
                        }
                    }
            }
        }

        private bool getExternalIpAddress()
        {
            serverIpAddress.BackColor = Color.White;
            serverIpAddress.ForeColor = Color.Black;
            try
            {
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                serverIpAddress.Text = externalip;
                Console.Write("External Ip Address Is " + externalip);
            }
            catch (WebException)
            {
                serverIpAddress.Text = "Lost Connection";
                serverIpAddress.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void checkNetwork_Click(object sender, EventArgs e)
        {
            bool result = getExternalIpAddress();
            string text = result ? "החיבור תקין" : "אין חיבור לרשת";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                result ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void checkLidar_Click(object sender, EventArgs e)
        {
            PingReply pingReplay = PingReply.Send(lidarAdapterIp, Lidar.IP);
            bool isSuccess = pingReplay.Status.ToString().Equals("Success");
            string text = isSuccess ? "החיבור לחיישן תקין" : "החיישן לא נמצא";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void lidarAdapterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInernalIpByAdapter(lidarAdapterComboBox.SelectedItem as string, IP_TYPE.LIDAR);
        }

        private void interntAdapterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInernalIpByAdapter(lidarAdapterComboBox.SelectedItem as string, IP_TYPE.INTERNET);
        }

        private void refreshData()
        {
            height.Value = configuration.getHeight();
            angle.Value = configuration.getAngle();
            resolutionComboBox.SelectedItem = configuration.getResolution().ToString();
            highAlert.Value = configuration.getHighAlert();
            lowAlert.Value = configuration.getLowAlert();
            lidarIp.Text = configuration.getLidarIp();
            BaudRateComboBox.SelectedItem = configuration.getBaudRate().ToString();
            ParityComboBox.SelectedItem = configuration.getParity();
            inputIpAddress.Text = configuration.getServerIp();
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

        private void saveConfiguration()
        {
            configuration.setHeight(decimal.ToInt32(height.Value));
            configuration.setAngle(decimal.ToInt32(angle.Value));
            configuration.setResolution(double.Parse(resolutionComboBox.SelectedItem.ToString()));
            configuration.setHighAlert(decimal.ToInt32(highAlert.Value));
            configuration.setLowAlert(decimal.ToInt32(lowAlert.Value));
            configuration.setLidarIp(lidarIp.Text);
            if (comComboBox.SelectedItem != null)
                configuration.setComName(comComboBox.SelectedItem.ToString());
            configuration.setBaudRate(int.Parse(BaudRateComboBox.SelectedItem.ToString()));
            configuration.setParity(ParityComboBox.SelectedItem.ToString());
            configuration.setServerIp(inputIpAddress.Text);
            configuration.setLidarAdapter(lidarAdapterComboBox.SelectedItem.ToString());
            configuration.setInterntAdapter(interntAdapterComboBox.SelectedItem.ToString());
            configuration.save();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            saveConfiguration();
            OperatorMode operatorMode = new OperatorMode();
            this.Hide();
            operatorMode.Closed += (s, args) => this.Close();
            operatorMode.Show();
        }

        private void saveButton_Click(object sender, EventArgs e) { saveConfiguration(); }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}