using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public partial class SerialSettings : BaseSubMenu {
        Configuration userConfig;
        public SerialSettings(Configuration userConfig) {
            InitializeComponent();
            this.userConfig = userConfig;
            comboBoxInit();
        }

        private void comboBoxInit() {
            string[] parity = { "זוגי", "סימון", "ללא", "אי-זוגי", "רווח" };
            string[] baudRate = { "9600", "14400", "19200", "38400", "57600", "115200", "128000" };

            controllerParityComboBox.Items.AddRange(parity);
            controllerBaudRateComboBox.Items.AddRange(baudRate);
            controllerComComboBox.Items.Add("כבוי");
            controllerComComboBox.Items.AddRange(SerialPort.GetPortNames());
            controllerComComboBox.SelectedItem = controllerComComboBox.Items[0];
            controllerParityComboBox.SelectedItem = controllerParityComboBox.Items[2];
            controllerBaudRateComboBox.SelectedItem = controllerBaudRateComboBox.Items[2];

            gpsParityComboBox.Items.AddRange(parity);
            gpsBaudRateComboBox.Items.AddRange(baudRate);
            gpsComComboBox.Items.Add("כבוי");
            gpsComComboBox.Items.AddRange(SerialPort.GetPortNames());
            gpsComComboBox.SelectedItem = controllerComComboBox.Items[0];
            gpsParityComboBox.SelectedItem = controllerParityComboBox.Items[2];
            gpsBaudRateComboBox.SelectedItem = controllerBaudRateComboBox.Items[2];
        }

        private void SerialSettings_FormClosing(Object sender, FormClosingEventArgs e) =>
            SaveFormData();

        override public void LoadUserConfig() {
            controllerBaudRateComboBox.SelectedItem = userConfig.getControllerBaudRate().ToString();
            controllerParityComboBox.SelectedItem = userConfig.getControllerParity();
            if (controllerComComboBox.Items.Contains(userConfig.getControllerComName()))
                controllerComComboBox.SelectedItem = userConfig.getControllerComName();
            else if (controllerComComboBox.Items.Count != 0)
                controllerComComboBox.SelectedItem = controllerComComboBox.Items[0];

            gpsBaudRateComboBox.SelectedItem = userConfig.getGPSBaudRate().ToString();
            gpsParityComboBox.SelectedItem = userConfig.getGPSParity();
            if (gpsComComboBox.Items.Contains(userConfig.getGPSComName()))
                gpsComComboBox.SelectedItem = userConfig.getGPSComName();
            else if (gpsComComboBox.Items.Count != 0)
                gpsComComboBox.SelectedItem = gpsComComboBox.Items[0];
        }

        public override void SaveFormData() {
            userConfig.setControllerBaudRate(Convert.ToInt32(controllerBaudRateComboBox.SelectedItem));
            userConfig.setControllerParity(controllerParityComboBox.SelectedItem.ToString());
            userConfig.setControllerComName(controllerComComboBox.SelectedItem.ToString());

            userConfig.setGPSBaudRate(Convert.ToInt32(gpsBaudRateComboBox.SelectedItem));
            userConfig.setGPSParity(gpsParityComboBox.SelectedItem.ToString());
            userConfig.setGPSComName(gpsComComboBox.SelectedItem.ToString());
        }

        private void SerialSettings_Load(Object sender, EventArgs e) { LoadUserConfig(); }
    }

}
