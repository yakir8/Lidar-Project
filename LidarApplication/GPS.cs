using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LidarApplication {
    class GPS {

        private SerialPort serialPort;
        private Location location;
        private string signal = "כבוי";
        public bool isFix = false;
        private Thread listener;
        private double azimuth = 0;

        private double old_longitude = 0;
        private double old_latitude = 0;

        const double earth = 6378.137;  //radius of the earth in kilometer
        const double pi = Math.PI;

        public GPS() {
            Configuration configuration = new Configuration();
            signal = "אין אות";
            List<string> parityList = new string[]{ "ללא", "אי-זוגי" , "זוגי", "סימון", "רווח"}.ToList();
            Parity parity = (Parity) parityList.IndexOf(configuration.getGPSParity());
            serialPort = new SerialPort(configuration.getGPSComName(),
                configuration.getGPSBaudRate(), parity, 8, StopBits.One);
        }

        public GPS(Location location, double azimuth) {
            Configuration configuration = new Configuration();
            signal = "אין אות";
            this.location = location;
            this.azimuth = azimuth;
        }

        public void StartListening(Action StatusUpdate) {
            serialPort.Open();
            listener = new Thread(() => {
                while (true) {
                    string line = "$GPGGA,131812.00,3301.5911,N,03506.5975,E,2,08,1.0,27.1,M,19.2,M,1.8,0000*44";
                    //string line = serialPort.ReadLine();
                    if (line.Contains("$GPGGA")) {
                        string[] data =  line.Split(',');
                        if (data.Count() >= 7) {
                            if (data[6] == "0") {
                                isFix = false;
                                signal = "אין אות";
                            }
                            else if (data[6] == "1" || data[6] == "2") {
                                isFix = true;
                                signal = data[7];
                                location = ConvertDMToDD(double.Parse(data[2]), double.Parse(data[4]));
                                CalculateAzimuth();
                            }
                        }
                        StatusUpdate();
                    }
                }
            });
            listener.Start();

        }

        private Location ConvertDMToDD(double latitude, double longitude) {
            latitude /= 100;
            longitude /= 100;
            latitude = ((int)latitude) + (latitude % 1) * 100 / 60;
            longitude = ((int)longitude) + (longitude % 1) * 100 / 60;
            return new Location(latitude, longitude);
        }

        public void StopListening() {
            new Thread(() => {
                if (listener != null) listener.Abort();
                Thread.Sleep(250);
                if (serialPort != null) serialPort.Close();
            }).Start();
        }

        private void CalculateAzimuth() {
            if (old_latitude != 0 && old_longitude != 0) {
                double dx = location.Latitude - old_latitude;
                double dy = location.Longitude - old_longitude;
                double rad = (dy / dx) * (Math.PI / 180);
                azimuth = Math.Atan(Math.Abs(rad));
                // north azimuth is 0°, east azimut is 90°
                if (dx >= 0 && dy >= 0) azimuth = 90 - azimuth; 
                else if (dx >= 0 && dy <= 0) azimuth += 90;
                else if (dx <= 0 && dy <= 0) azimuth += 180;
                else if (dx <= 0 && dy >= 0) azimuth += 270;
            }
            old_latitude = location.Latitude;
            old_longitude = location.Longitude;
        }

        public Location CalculateObjectLocation(Obstacle obj) {
            Location obj_location = null;
            double m = (1 / ((2 * pi / 360) * earth)) / 1000;  //1 meter in degree
            double mm = m / 1000;                              //1 millimeter in degree
            // driving to the N or NE
            if (azimuth >= 0 && azimuth < 90) {
                double new_latitude = location.Latitude + (obj.GetX() * mm);
                double new_longitude = location.Longitude + 
                    (obj.GetY() * mm) / Math.Cos(location.Latitude * (pi / 180));
                obj_location = new Location(new_latitude, new_longitude);
            }
            // driving to the E or SE: x -> -longitude & y-> latitude
            else if (azimuth >= 90 && azimuth < 180) {
                double new_latitude = location.Latitude + (-obj.GetX() * mm);
                double new_longitude = location.Longitude + (obj.GetY() * mm) / Math.Cos(location.Latitude * (pi / 180));
                obj_location = new Location(new_latitude, new_longitude);
            }
            // driving to the S or SW: x -> -latitude & y-> -longitude
            else if (azimuth >= 180 && azimuth < 270) {
                double new_latitude = location.Latitude + (-obj.GetX() * mm);
                double new_longitude = location.Longitude + (-obj.GetY() * mm) / Math.Cos(location.Latitude * (pi / 180));
                obj_location = new Location(new_latitude, new_longitude);
            }
            // driving to the W or NW: x -> longitude & y-> -latitude
            else if (azimuth >= 270 && azimuth < 360) {
                double new_latitude = location.Latitude + (obj.GetX() * mm);
                double new_longitude = location.Longitude + (-obj.GetY() * mm) / Math.Cos(location.Latitude * (pi / 180));
                obj_location = new Location(new_latitude, new_longitude);
            }
            return obj_location;
        }

        public string getStatus() { return signal; }

        public Location getLocation() { return location; }

        public double getAzimuth() { return azimuth; }
    }
}
