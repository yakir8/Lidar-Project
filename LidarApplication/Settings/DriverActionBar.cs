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
    public partial class DriverActionBar : Form {
        private Configuration savedConfig;
        private Configuration userConfig;
        private Settings mainMenu;
        private BaseSubMenu subMenu;

        public DriverActionBar(Configuration savedConfig, Configuration userConfig, 
            Settings mainMenu,BaseSubMenu subMenu) {
            this.savedConfig = savedConfig;
            this.userConfig = userConfig;
            this.mainMenu = mainMenu;
            this.subMenu = subMenu;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            subMenu.SaveFormData();
            if (userConfig.getLidarAdapter() == "כבוי")
                MessageBox.Show("חובה לבחור מתאם רשת לחיישן.",
                    "נתונים לא תקינים", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else if (userConfig.getStopAngle() < userConfig.getStartAngle())
                MessageBox.Show(".זווית התחלה לא יכולה להיות גדולה מזווית סיום",
                    "נתונים לא תקינים", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else {
                saveConfiguration();
                OperatorMode operatorMode = new OperatorMode(OperatingMode.DRIVER);
                mainMenu.Hide();
                operatorMode.Closed += (s, args) => mainMenu.Show();
                operatorMode.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            userConfig.LoadConfiguration();
            subMenu.LoadUserConfig();
        } 
        private void btnSave_Click(object sender, EventArgs e) => saveConfiguration(); 

        private void saveConfiguration() {
            subMenu.SaveFormData();
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
            }
        }
    }
}
