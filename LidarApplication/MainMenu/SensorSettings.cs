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
    public partial class SensorSettings : BaseSubMenu {
        Configuration userConfig;

        public SensorSettings(Configuration userConfig) {
            InitializeComponent();
            this.userConfig = userConfig;
            resolutionComboBox.Items.AddRange(new string[] { "0.25", "0.5" });
        }

        private void SensorSettings_FormClosing(Object sender, FormClosingEventArgs e) =>
            SaveFormData();

        override public void LoadUserConfig() {
            height.Value = userConfig.getSensorHeightSetup();
            angle.Value = userConfig.getAngleSetup();
            startAngle.Value = userConfig.getStartAngle();
            stopAngle.Value = userConfig.getStopAngle();
            vehicleWidth.Value = userConfig.getVehicleWidth();
            resolutionComboBox.SelectedItem = userConfig.getResolution().ToString();
        }

        public override void SaveFormData() {
            userConfig.setSensorHeightSetup(Convert.ToInt16(height.Value));
            userConfig.setAngleSetup(Convert.ToInt16(angle.Value));
            userConfig.setStartAngle(Convert.ToInt16(startAngle.Value));
            userConfig.setStopAngle(Convert.ToInt16(stopAngle.Value));
            userConfig.setVehicleWidth(Convert.ToInt16(vehicleWidth.Value));
            if (resolutionComboBox.SelectedItem != null)
                userConfig.setResolution(float.Parse(resolutionComboBox.SelectedItem.ToString()));
        }

        private void SensorSettings_Load(Object sender, EventArgs e) { LoadUserConfig(); }
    }
}
