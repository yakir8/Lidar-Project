﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LidarApplication {
    public class Configuration {

        private Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"\configuration.csv";

        public Configuration() {
            LoadConfiguration();
        }

        #region Sensor Physical Information
        public int getSensorHeightSetup() { return data["Height Setup"]; }
        public void setSensorHeightSetup(int value) { data["Height Setup"] = value; }
        public int getAngleSetup() { return data["Angle Setup"]; }
        public void setAngleSetup(int value) { data["Angle Setup"] = value; }
        public int getVehicleWidth() { return data["Vehicle Width"]; }
        public void setVehicleWidth(int value) { data["Vehicle Width"] = value; }
        #endregion

        #region Sensor Scanning Information
        public int getStartAngle() { return data["Start Angle"]; }
        public void setStartAngle(int value) { data["Start Angle"] = value; }
        public int getStopAngle() { return data["Stop Angle"]; }
        public void setStopAngle(int value) { data["Stop Angle"] = value; }
        public float getResolution() { return data["Resolution"]; }
        public void setResolution(float value) { data["Resolution"] = value; }
        #endregion

        #region Alert Information
        public int getFrontHighAlert() { return data["Front High Alert"]; }
        public void setFrontHighAlert(int value) { data["Front High Alert"] = value; }
        public int getFrontLowAlert() { return data["Front Low Alert"]; }
        public void setFrontLowAlert(int value) { data["Front Low Alert"] = value; }

        public int getSideHighAlert() { return data["Side High Alert"]; }
        public void setSideHighAlert(int value) { data["Side High Alert"] = value; }
        public int getSideLowAlert() { return data["Side Low Alert"]; }
        public void setSideLowAlert(int value) { data["Side Low Alert"] = value; }

        public int getHeightHighAlert() { return data["Height High Alert"]; }
        public void setHeightHighAlert(int value) { data["Height High Alert"] = value; }
        public int getHeightLowAlert() { return data["Height Low Alert"]; }
        public void setHeightLowAlert(int value) { data["Height Low Alert"] = value; }
        #endregion

        #region Serial Ports Setting For Controller
        public string getControllerComName() { return data["Controller COM Name"]; }
        public void setControllerComName(string value) { data["Controller COM Name"] = value; }
        public int getControllerBaudRate() { return data["Controller Baud Rate"]; }
        public void setControllerBaudRate(int value) { data["Controller Baud Rate"] = value; }
        public string getControllerParity() { return data["Controller Parity"]; }
        public void setControllerParity(string value) { data["Controller Parity"] = value; }
        #endregion

        #region Serial Ports Setting For GPS
        public string getGPSComName() { return data["GPS COM Name"]; }
        public void setGPSComName(string value) { data["GPS COM Name"] = value; }
        public int getGPSBaudRate() { return data["GPS Baud Rate"]; }
        public void setGPSBaudRate(int value) { data["GPS Baud Rate"] = value; }
        public string getGPSParity() { return data["GPS Parity"]; }
        public void setGPSParity(string value) { data["GPS Parity"] = value; }
        #endregion

        #region Network Setting
        public string getLidarIp() { return data["Lidar IP"]; }
        public void setLidarIp(string value) { data["Lidar IP"] = value; }
        public string getLidarPort() { return data["Lidar Port"]; }
        public void setLidarPort(string value) { data["Lidar Port"] = value; }
        public string getServerIp() { return data["Server IP"]; }
        public void setServerIp(string value) { data["Server IP"] = value; }
        public string getLidarAdapter() { return data["Lidar Adapter"]; }
        public void setLidarAdapter(string value) { data["Lidar Adapter"] = value; }
        public string getInterntAdapter() { return data["Internt Adapter"]; }
        public void setInterntAdapter(string value) { data["Internt Adapter"] = value; }
        #endregion

        public void LoadConfiguration() {
            data.Clear();
            if (File.Exists(path)) {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream) {
                    var values = reader.ReadLine().Split(',');
                    switch (values[0]) {
                        #region Sensor Physical Information
                        case "Height Setup":
                            data.Add("Height Setup", int.Parse(values[1]));
                            break;
                        case "Angle Setup":
                            data.Add("Angle Setup", int.Parse(values[1]));
                            break;
                        case "Vehicle Width":
                            data.Add("Vehicle Width", int.Parse(values[1]));
                            break;
                        #endregion
                        #region Sensor Scanning Information
                        case "Start Angle":
                            data.Add("Start Angle", int.Parse(values[1]));
                            break;
                        case "Stop Angle":
                            data.Add("Stop Angle", int.Parse(values[1]));
                            break;
                        case "Resolution":
                            data.Add("Resolution", float.Parse(values[1]));
                            break;
                        #endregion
                        #region Alert Information
                        case "Front High Alert":
                            data.Add("Front High Alert", int.Parse(values[1]));
                            break;
                        case "Front Low Alert":
                            data.Add("Front Low Alert", int.Parse(values[1]));
                            break;
                        case "Side High Alert":
                            data.Add("Side High Alert", int.Parse(values[1]));
                            break;
                        case "Side Low Alert":
                            data.Add("Side Low Alert", int.Parse(values[1]));
                            break;
                        case "Height High Alert":
                            data.Add("Height High Alert", int.Parse(values[1]));
                            break;
                        case "Height Low Alert":
                            data.Add("Height Low Alert", int.Parse(values[1]));
                            break;
                        #endregion
                        #region Serial Ports Setting For Controller
                        case "Controller COM Name":
                            data.Add("Controller COM Name", values[1]);
                            break;
                        case "Controller Baud Rate":
                            data.Add("Controller Baud Rate", int.Parse(values[1]));
                            break;
                        case "Controller Parity":
                            data.Add("Controller Parity", values[1]);
                            break;
                        #endregion
                        #region Serial Ports Setting For GPS
                        case "GPS COM Name":
                            data.Add("GPS COM Name", values[1]);
                            break;
                        case "GPS Baud Rate":
                            data.Add("GPS Baud Rate", int.Parse(values[1]));
                            break;
                        case "GPS Parity":
                            data.Add("GPS Parity", values[1]);
                            break;
                        #endregion
                        #region Network Setting
                        case "Lidar IP":
                            data.Add("Lidar IP", values[1]);
                            break;
                        case "Lidar Port":
                            data.Add("Lidar Port", values[1]);
                            break;
                        case "Server IP":
                            data.Add("Server IP", values[1]);
                            break;
                        case "Lidar Adapter":
                            data.Add("Lidar Adapter", values[1]);
                            break;
                        case "Internt Adapter":
                            data.Add("Internt Adapter", values[1]);
                            break;
                            #endregion
                    }
                }
                reader.Close();
            }
            else {
                #region Sensor Physical Information
                data.Add("Height Setup", 100);
                data.Add("Angle Setup", 85);
                data.Add("Vehicle Width", 500);
                #endregion
                #region Sensor Scanning Information
                data.Add("Start Angle", 0);
                data.Add("Stop Angle", 180);
                data.Add("Resolution", 0.25f);
                #endregion
                #region Alert Information
                data.Add("Front High Alert", 100);
                data.Add("Front Low Alert", 150);

                data.Add("Side High Alert", 100);
                data.Add("Side Low Alert", 150);

                data.Add("Height High Alert", 30);
                data.Add("Height Low Alert", 50);
                #endregion
                #region Serial Ports Setting For Controller
                data.Add("Controller COM Name", "כבוי");
                data.Add("Controller Baud Rate", 115200);
                data.Add("Controller Parity", "ללא");
                #endregion
                #region Serial Ports Setting For GPS
                data.Add("GPS COM Name", "כבוי");
                data.Add("GPS Baud Rate", 115200);
                data.Add("GPS Parity", "ללא");
                #endregion
                #region Network Setting
                data.Add("Lidar IP", "192.168.0.1");
                data.Add("Lidar Port", "2111");
                data.Add("Lidar Adapter", "כבוי");
                data.Add("Internt Adapter", "כבוי");
                data.Add("Server IP", "");
                #endregion
            }
        }
        public bool save() {
            try {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\configuration.csv";
                var csv = new StringBuilder();
                foreach (KeyValuePair<string, dynamic> item in data) {
                    var newLine = string.Format("{0},{1}", item.Key, item.Value);
                    csv.AppendLine(newLine);
                }
                File.WriteAllText(path, csv.ToString(), Encoding.UTF8);
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
