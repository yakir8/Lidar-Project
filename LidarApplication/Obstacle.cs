using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LidarApplication {
    class Obstacle {
        /*
         Y - Obstacle height from the floor

                                          |***|
                                          |***|   ______
                                         /              |
                                        /               |
                                       /                |
                                      /                 |
                                     /                  |
                                  R /                   | H
                                   /                    |    
                                  /                     |
                                 /                      |
                              __/α)__              _____|
            _________________|_______|__________________________
             ///////////////////////////////////////////////
                                      |___|
                                        X
         */

        private List<float> Angle = new List<float>();
        private List<float> Radius = new List<float>();
        private Location location;

        public Obstacle(float Angle, float Radius) {
            this.Angle.Add(Angle);
            this.Radius.Add(Radius);
        }
        public string GetSideDistance() {
            if (!Angle.Any()) return "לא ידוע";
            Configuration configuration = new Configuration();
            float VehicleWidth = configuration.getVehicleWidth() / 2;
            float x = GetX();
            if (Math.Abs(x) < VehicleWidth) return (GetH() / 1000).ToString("0.00") + " מטרים מלפנים";
            if (x > 0) return ((x - VehicleWidth) / 1000).ToString("0.00") + " מטרים מימין";
            if (x < 0) return ((Math.Abs(x) - VehicleWidth) / 1000).ToString("0.00") + " מטרים משמאל";
            return "לא ידוע";
        }
        public List<float> GetAngles() { return Angle; }
        public void AddAngle(float value) { Angle.Add(value); }
        public void AddDistance(float value) { Radius.Add(value); }
        public string GetAverageAngle() {
            float avg = 0;
            Angle.ForEach(x => avg += x);
            if (!Angle.Any()) return "לא ידוע";
            return (avg / Angle.Count).ToString("0.00") + "°";
        }
        public string GetFrontDistance() {
            if (!Radius.Any()) return "לא ידוע";
            return (GetH() / 1000).ToString("0.00") + " מטרים";
        }
        public string GetAleatLevel() {
            if (GetAleatState() == 2)
                return "גבוהה";
            if (GetAleatState() == 1)
                return "נמוכה";
            return "לא ידוע";
        }
        public int GetAleatState() {
            Configuration config = new Configuration();
            double vehicleWidth = config.getVehicleWidth() / 2;
            if (GetH() <= config.getFrontHighAlert() * 10) return 2;
            if (GetH() <= config.getFrontLowAlert() * 10) return 1;
            if ((Math.Abs(GetX()) - vehicleWidth * 10)  <= config.getSideHighAlert() * 10) return 2;
            if ((Math.Abs(GetX()) - vehicleWidth * 10) <= config.getSideLowAlert() * 10) return 2;
            if (GetY() <= config.getHeightHighAlert() * 10) return 2;
            if (GetY() <= config.getHeightLowAlert() * 10) return 1;
            return -1;
        }
        public string GetHeight() {
            if (!Radius.Any()) return "לא ידוע";
            return (GetY() / 1000).ToString("0.00") + " מטרים מעל הקרקע";
        }
        //Convert from R unit to Y
        public float GetY() {
            /*
                  |\              c - lidar distance
                  |β\             b - Real distance
                  |  \                     
                  |   \  c         tan(α) = a / b => a = b * tan(α)
                a |    \                 
                  |     \
                  |      \
                  |_____(α\
                      b
            */
            Configuration configuration = new Configuration();
            // α = 180 - 90 - β
            // β = lidar setup angle
            int alpha = 90 - configuration.getAngleSetup();
            double radians = alpha * (Math.PI / 180);
            float a = float.MaxValue;
            for (int i = 0; i < Radius.Count; i++) {
                float temp = (float)(Radius[i] * Math.Tan(radians));
                if (temp < a) a = temp;
            }
            
            return configuration.getSensorHeightSetup() * 10 - a;
        }
        //Convert from R unit to H
        public float GetH() {
            float min = float.MaxValue;
            for (int i = 0; i < Radius.Count(); i++) {
                double radians = Angle[i] * (Math.PI / 180);
                float temp = (float)(Radius[i] * Math.Sin(radians));
                if (temp < min) min = temp;
            }
            return min;
        }
        //Convert from R unit to X
        public float GetX() {
            float min = float.MaxValue;
            for (int i = 0; i < Radius.Count(); i++) {
                double radians = Angle[i] * (Math.PI / 180);
                float temp = (float)(Radius[i] * Math.Cos(radians));
                if (temp < min) min = temp;
            }
            return min;
        }
        public bool InActiveZone() {
            Configuration configuration = new Configuration();
            int minoricAlert = configuration.getSideLowAlert() * 10;
            return GetH() <= minoricAlert && Math.Abs(GetX()) <= minoricAlert;
        }
        public bool isEqule(Obstacle o) {
            if (this.GetX() - 250 > o.GetX() && this.GetX() + 250 < o.GetX()) return false;
            if (this.GetH() -250 > o.GetH() && this.GetH() + 250 < o.GetH()) return false;
            if (this.GetAleatState() == o.GetAleatState()) return false;
            return true;
        }
        public string GetLocation(GPS gps) {
            if (gps == null) return "מיקום לא ידוע";
            else location = gps.CalculateObjectLocation(this);
            if (location == null) return "מיקום לא ידוע";
            else return location.Latitude + " צפון " + location.Longitude + " מערב ";
        }
    }
}
