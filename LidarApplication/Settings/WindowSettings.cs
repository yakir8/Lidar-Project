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
    public partial class WindowSettings : BaseSubMenu {
        Configuration userConfig;
        public WindowSettings(Configuration userConfig) {
            InitializeComponent();
            this.userConfig = userConfig;
        }
        private void WindowSettings_FormClosing(Object sender, FormClosingEventArgs e) =>
            SaveFormData();

        override public void LoadUserConfig() {
            frontAlertHigh.Value = userConfig.getFrontHighAlert();
            frontAlertLow.Value = userConfig.getFrontLowAlert();

            sideAlertHigh.Value = userConfig.getSideHighAlert();
            sideAlertLow.Value = userConfig.getSideLowAlert();

            holeAlertHigh.Value = userConfig.getHoleHighAlert();
            holeAlertLow.Value = userConfig.getHoleLowAlert();

            resolution.Value = userConfig.getMinimumHeightDetected();

            gridEnable.Checked = userConfig.getGridEnable();
            activeZoneEnable.Checked = userConfig.getActiveZoneEnable();

        }
        public override void SaveFormData() {
            userConfig.setFrontHighAlert(Convert.ToInt32(frontAlertHigh.Value));
            userConfig.setFrontLowAlert(Convert.ToInt32(frontAlertLow.Value));

            userConfig.setSideHighAlert(Convert.ToInt32(sideAlertHigh.Value));
            userConfig.setSideLowAlert(Convert.ToInt32(sideAlertLow.Value));

            userConfig.setHoleHighAlert(Convert.ToInt32(holeAlertHigh.Value));
            userConfig.setHoleLowAlert(Convert.ToInt32(holeAlertLow.Value));

            userConfig.setMinimumHeightDetected(Convert.ToInt32(resolution.Value));

            userConfig.setGridEnable(gridEnable.Checked);
            userConfig.setActiveZoneEnable(activeZoneEnable.Checked);

        }

        private void WindowSettings_Load(Object sender, EventArgs e) { LoadUserConfig(); }
    }
}
