using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public partial class LidarTerminal : BaseTerminal {
        private Lidar lidar;
        public LidarTerminal(Lidar lidar) {
            InitializeComponent();
            this.lidar = lidar;
        }

        override public void insertData(string input) {
           if (listData.Items.Count == 0) listData.Items.Add(input);
            // listData.BeginUpdate();
            //listData.Items.Add(input);
            //listData.EndUpdate();
        }

        private void btnSend_Click(Object sender, EventArgs e) {
            const char stx = (char)2;
            const char etx = (char)3;
            if (lidar.Send(stx + inputData.Text + etx)) insertData(stx + inputData.Text + etx);
        }
    }
}
