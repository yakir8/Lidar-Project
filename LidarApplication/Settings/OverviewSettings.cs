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
    public partial class OverviewSettings : BaseSubMenu {
        Configuration userConfig;
        public OverviewSettings(Configuration userConfig) {
            InitializeComponent();
            this.userConfig = userConfig;
        }

        public override void LoadUserConfig() {
            heightSetup.Text = userConfig.getSensorHeightSetup().ToString();
            angleSetup.Text = userConfig.getAngleSetup().ToString();
            vehicleWidth.Text = userConfig.getVehicleWidth().ToString();
            startAngle.Text = userConfig.getStartAngle().ToString();
            stopAngle.Text = userConfig.getStopAngle().ToString();
            resolution.Text = userConfig.getResolution().ToString();

            frontAlertLow.Text = userConfig.getFrontLowAlert().ToString();
            frontAlertHigh.Text = userConfig.getFrontHighAlert().ToString();

            sideAlertLow.Text = userConfig.getSideLowAlert().ToString();
            sideAlertHigh.Text = userConfig.getSideHighAlert().ToString();

            heightAlertLow.Text = userConfig.getHoleLowAlert().ToString();
            heightAlertHigh.Text = userConfig.getHoleHighAlert().ToString();

            detectionResolution.Text = userConfig.getMinimumHeightDetected().ToString();

            gridEnable.Text = userConfig.getGridEnable() ? "כן" : "לא";
            activeZoneEnable.Text = userConfig.getActiveZoneEnable() ? "כן" : "לא";

            sensorIp.Text = userConfig.getLidarIp().ToString() + ":" + userConfig.getLidarPort().ToString();
            sensorAdapter.Text = userConfig.getLidarAdapter().ToString();
            serverIp.Text = userConfig.getServerIp().ToString();
            serverAdapter.Text = userConfig.getInterntAdapter().ToString();

            controllerCom.Text = userConfig.getControllerComName().ToString();
            controllerBaudRate.Text = userConfig.getControllerBaudRate().ToString();
            controllerParity.Text = userConfig.getControllerParity().ToString();
            controllerDataType.Text = userConfig.getSerialDataType();

            gpsCom.Text = userConfig.getGPSComName().ToString();
            gpsBaudRate.Text = userConfig.getGPSBaudRate().ToString();
            gpsParity.Text = userConfig.getGPSParity().ToString();

            sensorAdapter.ForeColor = sensorAdapter.Text == "כבוי" ? Color.Red : Color.Black;
            serverAdapter.ForeColor = serverAdapter.Text == "כבוי" ? Color.Red : Color.Black;

            controllerCom.ForeColor = controllerCom.Text == "כבוי" ? Color.Red : Color.Black;
            gpsCom.ForeColor = gpsCom.Text == "כבוי" ? Color.Red : Color.Black;
        }

        public override void SaveFormData() {}

        private void OverviewSettings_Load(Object sender, EventArgs e) { LoadUserConfig(); }
    }
}
