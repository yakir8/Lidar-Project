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
    public partial class MainMenu : Form {
        enum Settings_Mode {Server,Driver }
        private Configuration savedConfig = new Configuration();
        private Configuration userConfig = new Configuration();
        private BaseSubMenu activeForm = null;
        private Form activeActionBar = null;


        public MainMenu() {
            InitializeComponent();
            ShowSubMenu();
            openSubMenu(new OverviewSettings(userConfig), Settings_Mode.Driver);
        }

        private void HideSubMenu() => driverSubMenu.Hide();

        private void ShowSubMenu() => driverSubMenu.Show();

        private void btnDriverMode_Click(Object sender, EventArgs e) {
            openSubMenu(new OverviewSettings(userConfig),Settings_Mode.Driver);
            ShowSubMenu();
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + ((Button)sender).Size.Height);
        }

        private void btnOverview_Click(Object sender, EventArgs e) {
            openSubMenu(new OverviewSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 150);
        }

        private void btnWindowSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new WindowSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 150);
        }

        private void btnSensorSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new SensorSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 150);
        }

        private void btnNetworkSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new NetworkSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 150);
        }

        private void btnSerialSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new SerialSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 150);
        }

        private void btnServerMode_Click(Object sender, EventArgs e) {
            HideSubMenu();
            openSubMenu(new ServerSettings(userConfig), Settings_Mode.Server);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y);
        }
        private void openSubMenu(BaseSubMenu childForm, Settings_Mode mode) {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSettings.Controls.Add(childForm);
            panelSettings.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (mode == Settings_Mode.Server)
                openActionBar(new ServerActionBar());
            else
                openActionBar(new DriverActionBar(savedConfig, userConfig, this, activeForm));
        }

        private void openActionBar(Form childForm) {
            if (activeActionBar != null) activeActionBar.Close();
            activeActionBar = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelActionBar.Controls.Add(childForm);
            panelActionBar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}