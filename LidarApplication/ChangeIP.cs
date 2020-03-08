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


namespace LidarApplication {
    public partial class ChangeIP : Form {
        public ChangeIP() { InitializeComponent(); }

        public ChangeIP(string ip) {
            InitializeComponent();
            ipAddressControl.Text = ip;
        }

        public IPAddress NewIP { get; set; }

        private void OK_Click(object sender, EventArgs e) {
            NewIP = new IPAddress(ipAddressControl.GetAddressBytes());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
