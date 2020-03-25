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
            frontAlertHigh.Value = userConfig.getSideHighAlert();
            frontAlertLow.Value = userConfig.getSideLowAlert();

            sideAlertHigh.Value = userConfig.getSideHighAlert();
            sideAlertLow.Value = userConfig.getSideLowAlert();

            heightAlertHigh.Value = userConfig.getHeightHighAlert();
            heightAlertHigh.Value = userConfig.getHeightLowAlert();
        }
        public override void SaveFormData() {
            userConfig.setFrontHighAlert(Convert.ToInt16(frontAlertHigh.Value));
            userConfig.setFrontLowAlert(Convert.ToInt16(frontAlertLow.Value));

            userConfig.setSideHighAlert(Convert.ToInt16(sideAlertHigh.Value));
            userConfig.setSideLowAlert(Convert.ToInt16(sideAlertLow.Value));

            userConfig.setHeightHighAlert(Convert.ToInt16(heightAlertHigh.Value));
            userConfig.setHeightLowAlert(Convert.ToInt16(heightAlertHigh.Value));
        }

        private void WindowSettings_Load(Object sender, EventArgs e) { LoadUserConfig(); }
    }
}
