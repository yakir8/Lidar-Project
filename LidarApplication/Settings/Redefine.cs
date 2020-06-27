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
    public partial class Redefine : Form {
        enum Settings_Mode { Server, Driver }
        private Configuration savedConfig = new Configuration();
        private Configuration userConfig = new Configuration();
        private BaseSubMenu activeForm = null;

        public Redefine() {
            InitializeComponent();
            ShowSubMenu();
            openSubMenu(new OverviewSettings(userConfig), Settings_Mode.Driver);
        }

        private void HideSubMenu() => driverSubMenu.Hide();

        private void ShowSubMenu() => driverSubMenu.Show();

        private void btnOverview_Click(Object sender, EventArgs e) {
            openSubMenu(new OverviewSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 100);
        }

        private void btnWindowSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new WindowSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 100);
        }

        private void btnSensorSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new SensorSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 100);
        }

        private void btnNetworkSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new NetworkSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 100);
        }

        private void btnSerialSettings_Click(Object sender, EventArgs e) {
            openSubMenu(new SerialSettings(userConfig), Settings_Mode.Driver);
            cursor.Location = new Point(((Button)sender).Size.Width - cursor.Size.Width,
               ((Button)sender).Location.Y + 100);
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
        }

        private void btnSave_Click(Object sender, EventArgs e) {
            activeForm.SaveFormData();
            if (userConfig.getStopAngle() < userConfig.getStartAngle())
                MessageBox.Show(".זווית התחלה לא יכולה להיות גדולה מזווית סיום",
                    "נתונים לא תקינים", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else {
                savedConfig.setSensorHeightSetup(userConfig.getSensorHeightSetup());
                savedConfig.setAngleSetup(userConfig.getAngleSetup());
                savedConfig.setVehicleWidth(userConfig.getVehicleWidth());

                savedConfig.setStartAngle(userConfig.getStartAngle());
                savedConfig.setStopAngle(userConfig.getStopAngle());
                savedConfig.setResolution(userConfig.getResolution());

                savedConfig.setFrontHighAlert(userConfig.getFrontHighAlert());
                savedConfig.setFrontLowAlert(userConfig.getFrontLowAlert());
                savedConfig.setSideHighAlert(userConfig.getSideHighAlert());
                savedConfig.setSideLowAlert(userConfig.getSideLowAlert());
                savedConfig.setHoleHighAlert(userConfig.getHoleHighAlert());
                savedConfig.setHoleLowAlert(userConfig.getHoleLowAlert());
                savedConfig.setMinimumHeightDetected(userConfig.getMinimumHeightDetected());
                savedConfig.setGridEnable(userConfig.getGridEnable());
                savedConfig.setActiveZoneEnable(userConfig.getActiveZoneEnable());

                savedConfig.setLidarIp(userConfig.getLidarIp());
                savedConfig.setLidarPort(userConfig.getLidarPort());

                savedConfig.setControllerComName(userConfig.getControllerComName());
                savedConfig.setControllerBaudRate(userConfig.getControllerBaudRate());
                savedConfig.setControllerParity(userConfig.getControllerParity());
                savedConfig.setSerialDataType(userConfig.getSerialDataType());

                savedConfig.setGPSComName(userConfig.getGPSComName());
                savedConfig.setGPSBaudRate(userConfig.getGPSBaudRate());
                savedConfig.setGPSParity(userConfig.getGPSParity());

                savedConfig.setServerIp(userConfig.getServerIp());
                savedConfig.setLidarAdapter(userConfig.getLidarAdapter());
                savedConfig.setInterntAdapter(userConfig.getInterntAdapter());
                savedConfig.save();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
