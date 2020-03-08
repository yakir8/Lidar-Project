using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LidarApplication {
    class Configuration {

        private Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

        public Configuration() {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\configuration.csv";
            if (File.Exists(path)) {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    switch (values[0]) {
                        case "Height":
                            data.Add("Height", int.Parse(values[1]));
                            break;
                        case "Angle":
                            data.Add("Angle", int.Parse(values[1]));
                            break;
                        case "Start Angle":
                            data.Add("Start Angle", int.Parse(values[1]));
                            break;
                        case "Stop Angle":
                            data.Add("Stop Angle", int.Parse(values[1]));
                            break;
                        case "Vehicle Width":
                            data.Add("Vehicle Width", int.Parse(values[1]));
                            break;
                        case "Resolution":
                            data.Add("Resolution", float.Parse(values[1]));
                            break;
                        case "High Alert":
                            data.Add("High Alert", int.Parse(values[1]));
                            break;
                        case "Low Alert":
                            data.Add("Low Alert", int.Parse(values[1]));
                            break;
                        case "COM Name":
                            data.Add("COM Name", values[1]);
                            break;
                        case "Baud Rate":
                            data.Add("Baud Rate", int.Parse(values[1]));
                            break;
                        case "Parity":
                            data.Add("Parity", values[1]);
                            break;
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
                    }
                }
                reader.Close();
            }
            else {
                data.Add("Height", 100);
                data.Add("Angle", 85);
                data.Add("Start Angle", 0);
                data.Add("Stop Angle", 180);
                data.Add("Vehicle Width", 500);
                data.Add("Resolution", 0.25);
                data.Add("High Alert", 100);
                data.Add("Low Alert", 150);
                data.Add("COM Name", "");
                data.Add("Baud Rate", 115200);
                data.Add("Parity", "ללא");
                data.Add("Lidar IP", "192.168.0.1");
                data.Add("Lidar Port", "2111");
                data.Add("Lidar Adapter", "");
                data.Add("Internt Adapter", "");
                data.Add("Server IP", "");
            }
        }

        public int getHeight() { return data["Height"]; }
        public void setHeight(int value) { data["Height"] = value; }
        public int getAngle() { return data["Angle"]; }
        public void setAngle(int value) { data["Angle"] = value; }
        public int getStartAngle() { return data["Start Angle"]; }
        public void setStartAngle(int value) { data["Start Angle"] = value; }
        public int getStopAngle() { return data["Stop Angle"]; }
        public void setStopAngle(int value) { data["Stop Angle"] = value; }
        public int getVehicleWidth() { return data["Vehicle Width"]; }
        public void setVehicleWidth(int value) { data["Vehicle Width"] = value; }
        public float getResolution() { return data["Resolution"]; }
        public void setResolution(double value) { data["Resolution"] = value; }
        public int getHighAlert() { return data["High Alert"]; }
        public void setHighAlert(int value) { data["High Alert"] = value; }
        public int getLowAlert() { return data["Low Alert"]; }
        public void setLowAlert(int value) { data["Low Alert"] = value; }
        public string getComName() { return data["COM Name"]; }
        public void setComName(string value) { data["COM Name"] = value; }
        public int getBaudRate() { return data["Baud Rate"]; }
        public void setBaudRate(int value) { data["Baud Rate"] = value; }
        public string getParity() { return data["Parity"]; }
        public void setParity(string value) { data["Parity"] = value; }
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
        public bool save() {
            try {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\configuration.csv";
                var csv = new StringBuilder();
                foreach (KeyValuePair<string, dynamic> item in data) {
                    var newLine = string.Format("{0},{1}", item.Key, item.Value);
                    csv.AppendLine(newLine);
                }
                File.WriteAllText(path, csv.ToString(),Encoding.UTF8);
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
