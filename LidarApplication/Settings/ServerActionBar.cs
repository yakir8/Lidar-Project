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
    public partial class ServerActionBar : Form {

        private Settings mainMenu;
        public ServerActionBar(Settings mainMenu) {
            InitializeComponent();
            this.mainMenu = mainMenu;
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

        private void btnCheckNetwork_Click(object sender, EventArgs e) {
            bool result = getExternalIpAddress();
            string text = result ? "החיבור תקין" : "אין חיבור לרשת";
            MessageBox.Show(text, "תוצאות הבדיקה", MessageBoxButtons.OK,
                result ? MessageBoxIcon.Information : MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void btnStartServer_Click(Object sender, EventArgs e) {
            OperatorMode operatorMode = new OperatorMode(OperatingMode.SERVER);
            mainMenu.Hide();
            operatorMode.Closed += (s, args) => mainMenu.Show();
            operatorMode.Show();
        }
    }
}
