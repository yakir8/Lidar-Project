using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public partial class NetworkSettings : BaseSubMenu {

        private Configuration userConfig;

        public NetworkSettings(Configuration userConfig) {
            InitializeComponent();
            this.userConfig = userConfig;
            lidarPort.Mask = "0000";
            interntAdapterComboBox.Items.Add("כבוי");
            lidarAdapterComboBox.Items.Add("כבוי");
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces()) {
                lidarAdapterComboBox.Items.Add(nic.Name);
                interntAdapterComboBox.Items.Add(nic.Name);
            }
            lidarAdapterComboBox.SelectedItem = userConfig.getLidarAdapter();
            interntAdapterComboBox.SelectedItem = userConfig.getInterntAdapter();
        }

        private bool getExternalIpAddress() {
            try {
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                Console.Write("External Ip Address Is " + externalip);
            } catch (WebException) {
                return false;
            }
            return true;
        }

        private void checkLidar_Click(object sender, EventArgs e) {
            Lidar.IP = IPAddress.Parse(epLidar.Text.ToString());
            PingReply pingReplay = PingReply.Send(LocalIP.GetLocalIP(LOCAL_IP_TYPE.LIDAR), Lidar.IP);
            bool isSuccess = pingReplay.Status.ToString().Equals("Success");
            string text = isSuccess ? "החיבור לחיישן תקין" : "החיישן לא נמצא";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void checkNetwork_Click(object sender, EventArgs e) {
            bool result = getExternalIpAddress();
            string text = result ? "החיבור תקין" : "אין חיבור לרשת";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                result ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void NetworkSettings_FormClosing(Object sender, FormClosingEventArgs e) =>
            SaveFormData();

        override public void LoadUserConfig() {
            lidarPort.Text = userConfig.getLidarPort();
            epLidar.Text = userConfig.getLidarIp();
            epServer.Text = userConfig.getServerIp();

            if (lidarAdapterComboBox.Items.Contains(userConfig.getLidarAdapter()))
                lidarAdapterComboBox.SelectedItem = userConfig.getLidarAdapter();
            else if (lidarAdapterComboBox.Items.Count != 0)
                lidarAdapterComboBox.SelectedItem = lidarAdapterComboBox.Items[0];

            if (interntAdapterComboBox.Items.Contains(userConfig.getInterntAdapter()))
                interntAdapterComboBox.SelectedItem = userConfig.getInterntAdapter();
            else if (interntAdapterComboBox.Items.Count != 0)
                interntAdapterComboBox.SelectedItem = interntAdapterComboBox.Items[0];
        }

        override public void SaveFormData() {
            userConfig.setLidarIp(epLidar.Text);
            userConfig.setLidarPort(lidarPort.Text);
            userConfig.setServerIp(epServer.Text);
            if (lidarAdapterComboBox.SelectedItem != null)
                userConfig.setLidarAdapter(lidarAdapterComboBox.SelectedItem.ToString());
            if (interntAdapterComboBox.SelectedItem != null)
                userConfig.setInterntAdapter(interntAdapterComboBox.SelectedItem.ToString());
        }

        private void NetworkSettings_Load(Object sender, EventArgs e) { LoadUserConfig(); }
    }
}
