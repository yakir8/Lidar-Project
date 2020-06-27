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
    public partial class Terminal : Form {

        private BaseTerminal activeForm = null;
        private Lidar lidar;

        public Terminal(Lidar lidar) {
            InitializeComponent();
            this.lidar = lidar;
            openSubMenu(new LidarTerminal(lidar));
        }

        private void openSubMenu(BaseTerminal childForm) {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTerminal.Controls.Add(childForm);
            panelTerminal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void insertData(string data) {
            if (activeForm != null) activeForm.insertData(data);
        }

        private void btnLidar_Click(Object sender, EventArgs e) {
            openSubMenu(new LidarTerminal(lidar));
            cursor.Location = new Point(0, ((Button)sender).Location.Y);
        }

        private void btnServer_Click(Object sender, EventArgs e) {
            cursor.Location = new Point(0, ((Button)sender).Location.Y);
        }

        private void btnGps_Click(Object sender, EventArgs e) {
            cursor.Location = new Point(0, ((Button)sender).Location.Y);
        }
    }
}
