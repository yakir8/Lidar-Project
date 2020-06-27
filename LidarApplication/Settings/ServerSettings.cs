using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public partial class ServerSettings : BaseSubMenu {
        public ServerSettings(Configuration userConfig) {
            InitializeComponent();
            getExternalIpAddress();
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
        public override void LoadUserConfig() { }
        public override void SaveFormData() { }

    }
}
