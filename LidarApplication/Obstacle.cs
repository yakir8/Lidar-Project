using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LidarApplication {
    public class Obstacle {
        /*
         Z - Distance the obstacle from the Lidar

                                          |***|
                                          |***|   ______
                                         /              |
                                        /               |
                                       /                |
                                      /                 |
                                     /                  |
                                  R /                   | Y
                                   /                    |    
                                  /                     |
                                 /                      |
                              __/α)__              _____|
            _________________|_______|__________________________
             ///////////////////////////////////////////////
                                      |___|
                                        X
         */

        private Location location;
        private List<float> Angle = new List<float>();
        private List<float> Radius = new List<float>();
        private Configuration config;

        public Obstacle(Configuration config, float Angle, float Radius) {
            this.config = config;
            this.Angle.Add(Angle);
            this.Radius.Add(Radius);
        }

        /// <summary>
        /// Add a new sample for the Obstacle
        /// </summary>
        /// <param name="angle">take float number for the angle of the sample</param>
        /// <param name="radius">take float number for the distance of the sample</param>
        public void AddPoint(float angle,float radius) {
           AddAngle(angle);
           AddRadius(radius);
        }
        /// <summary>
        /// Add new Angle for Obstacle
        /// </summary>
        /// <param name="value">take float number for the angle of the sample</param>
        public void AddAngle(float value) { Angle.Add(value); }
        /// <summary>
        /// Add new distance for Obstacle
        /// </summary>
        /// <param name="value">take float number for the distance of the sample</param>
        public void AddRadius(float value) { Radius.Add(value); }
        /// <summary>
        /// return all the angles in the Obstacle
        /// </summary>
        /// <returns>List<float> of all the angles in the Obstacle</returns>
        public List<float> GetAngles() { return Angle; }
        /// <summary>
        /// return all the distance in the Obstacle
        /// </summary>
        /// <returns>List<float> of all the distance  in the Obstacle</returns>
        public List<float> GetRadius() { return Radius; }
        /// <summary>
        /// Returns the angle to the nearest part of the Obstacle
        /// </summary>
        /// <returns>string in format xx.xx° right/left in Hebrew</returns>
        public string GetAngle() {
            float minAngle = float.MaxValue;
            minAngle = GetAlfha();
            if (minAngle == 90) return "90°";
            else if (minAngle < 90) return minAngle.ToString("0.00") + "° " + "מימין";
            return (180 - minAngle).ToString("0.00") + "° " + "משמאל";
        }
        /// <summary>
        /// Returns the minimum side distance (in axis X) from the Obstacle
        /// </summary>
        /// <returns>string in format xx.xx m right/left in Hebrew</returns>
        public string GetSideDistance() {
            if (!Angle.Any()) return "לא ידוע";
            float VehicleWidth = config.getVehicleWidth() / 2;
            float x = GetMinX();
            //if (Math.Abs(x) < VehicleWidth) return (GetH() / 1000).ToString("0.00") + " מטרים מלפנים";
            if (x > 0) return ((x - VehicleWidth) / 1000).ToString("0.00") + " מ' מימין";
            if (x < 0) return ((Math.Abs(x) - VehicleWidth) / 1000).ToString("0.00") + " מ' משמאל";
            return "לא ידוע";
        }
        /// <summary>
        /// Returns the minimum front distance (in axis Y) from the Obstacle
        /// </summary>
        /// <returns>string in format xx.xx m in Hebrew</returns>
        public string GetFrontDistance() {
            if (!Radius.Any()) return "לא ידוע";
            return (GetMinY() / 1000).ToString("0.00") + " מ'";
        }
        /// <summary>
        /// Returns the aleat level
        /// </summary>
        /// <returns>
        /// Var type is string 
        /// "Low" for Obstacle in green zone
        /// "High" for Obstacle in red zone
        /// *Hebrew Language
        /// </returns>
        public string GetAleatLevel() {
            if (GetAleatState() == 2)
                return "גבוהה";
            if (GetAleatState() == 1)
                return "נמוכה";
            return "לא ידוע";
        }
        /// <summary> Calculate the aleat level</summary>
        /// <returns>
        /// Var type is int 
        /// 1 for obstacle in green zone
        /// 2 for obstacle in red zone
        /// -1 for obstacle outside alert zone
        /// </returns>
        public int GetAleatState() {
            double vehicleWidth = config.getVehicleWidth() / 2;
            double x = (Math.Abs(GetMinX()) - vehicleWidth * 10);
            // In Red Zone
            if (GetMinY() <= config.getFrontHighAlert() * 10 && x <= config.getSideHighAlert() * 10)
                return 2;
            // In Green Zone
            if (GetMinY() <= config.getFrontHighAlert() * 10 && x <= config.getSideLowAlert() * 10)
                return 1;
            if (GetMinY() <= config.getFrontLowAlert() * 10 && x <= config.getSideHighAlert() * 10)
                return 1;
            if (GetMinY() <= config.getFrontLowAlert() * 10 && x <= config.getSideLowAlert() * 10)
                return 1;
            return -1;
        }
        /// <summary>
        /// return delta between obstacle to the sensor
        /// </summary>
        /// <returns>string in format xx.xx m in Hebrew</returns>
        public string GetHeight() {
            if (!Radius.Any()) return "לא ידוע";
            return (GetMinZ() / 1000).ToString("0.00") + " מ'";
        }
        /// <summary>
        /// Calculate the angle of the nearest part of the obstacle
        /// </summary>
        /// <returns>float in degrees unit</returns>
        public float GetAlfha() {
            float min = float.MaxValue;
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            for (int i = 0; i < Radius.Count(); i++) {
                Obstacle o = new Obstacle(config, Angle[i], Radius[i]);
                float x = o.GetX(0);
                float y = o.GetY(0);
                if (o.InActiveZone())
                    if (x < minX && y < minY) {
                        minX = x;
                        minY = y;
                        min = Angle[i];
                    }
            }
            return min;
        }
        /// <summary>
        /// Calculate the delta between obstacle to the sensor 
        /// located in the array angle and radius on position 'index'
        /// </summary>
        /// <returns>float in mm unit</returns>        
        public float GetZ(int index) {
            return GetZ(Angle[index], Radius[index]);
        }
        /// <summary>
        /// Calculate the delta between obstacle to the sensor 
        /// located on given angle and radius from the vehicle
        /// </summary>
        /// <returns>float in mm unit</returns>        
        private float GetZ(float angle, float radius) {
            double radians = (90 - angle) * (Math.PI / 180);
            float temp = (float)(radius * Math.Cos(radians));
            int alpha = 90 - config.getAngleSetup();
            radians = alpha * (Math.PI / 180);
            return (float)(temp * Math.Sin(radians));
        }
        /// <summary>
        /// Calculate the delta between obstacle to the sensor 
        /// of the nearest part of the obstacle
        /// </summary>
        /// <returns>float in mm unit</returns>
        public float GetMinZ() {
            float angle = GetAlfha();
            float radius = 0;
            if (angle == float.MaxValue) return float.NaN;
            for (int i = 0; i < Radius.Count; i++)
                if (angle == Angle[i]) radius = Radius[i];
            return GetZ(angle, radius);
        }
        /// <summary>
        /// Calculate the front distance from the vehicle
        /// located in the array angle and radius on position 'index'
        /// </summary>
        /// <returns>float in mm unit</returns>        
        public float GetY(int index) {
            return GetY(Angle[index],Radius[index]);
        }
        /// <summary>
        /// Calculate the front distance from the vehicle
        /// located on given angle and radius from the vehicle
        /// </summary>
        /// <returns>float in mm unit</returns>  
        private float GetY(float angle, float radius) {
            double radians = (90 - angle) * (Math.PI / 180);
            float temp = (float)(radius * Math.Cos(radians));
            radians = config.getAngleSetup() * (Math.PI / 180);
            return (float)(temp * Math.Sin(radians));
        }
        /// <summary>
        /// Calculate the front distance from the vehicle
        /// of the nearest part of the obstacle
        /// </summary>
        /// <returns>float in mm unit</returns>
        public float GetMinY() {
            float angle = GetAlfha();
            float radius = 0;
            if (angle == float.MaxValue) return float.NaN;
            for (int i = 0; i < Radius.Count; i++)
                if (angle == Angle[i]) radius = Radius[i];
            return GetY(angle, radius);
        }
        /// <summary>
        /// Calculate the side distance from the vehicle
        /// located in the array angle and radius on position 'index'
        /// </summary>
        /// <returns>float in mm unit</returns>   
        public float GetX(int index) {
            return GetX(Angle[index], Radius[index]);
        }
        /// <summary>
        /// Calculate the side distance from the vehicle
        /// located on given angle and radius from the vehicle
        /// </summary>
        /// <returns>float in mm unit</returns>  
        private float GetX(float angle, float radius) {
            double radians = (90 - angle) * (Math.PI / 180);
            return (float)(radius * Math.Sin(radians));
        }
        /// <summary>
        /// Calculate the side distance from the vehicle
        /// of the nearest part of the obstacle
        /// </summary>
        /// <returns>float in mm unit</returns>
        public float GetMinX() {
            float angle = GetAlfha();
            float radius = 0;
            if (angle == float.MaxValue) return float.NaN;
            for (int i = 0; i < Radius.Count; i++)
                if (angle == Angle[i]) radius = Radius[i];
            return GetX(angle, radius);
        }
        /// <summary>
        /// Check if the obstacle in the acitve zone
        /// </summary>
        public bool InActiveZone() {
            int hole = config.getHoleHighAlert() * 10;
            int res = config.getMinimumHeightDetected() * 10;
            int minoricAlertSide = config.getSideLowAlert() * 10;
            int minoricAlertFront = config.getFrontLowAlert() * 10;
            int minoricAlertHeight = config.getHoleLowAlert() * 10;
            return YInActiveZone() && XInActiveZone();
        }
        /// <summary>
        /// Check if the obstacle in the acitve zone on the X axis
        /// </summary>
        private bool XInActiveZone() {
            int minoricAlertSide = config.getSideLowAlert() * 10;
            for (int i = 0; i < Radius.Count; i++)
                if (Math.Abs(GetX(Angle[i],Radius[i])) <= minoricAlertSide) return true;
            return false;
        }
        /// <summary>
        ///  Check if the obstacle in the acitve zone on the Y axis
        /// </summary>
        private bool YInActiveZone() {
            int minoricAlertFront = config.getFrontLowAlert() * 10;
            for (int i = 0; i < Radius.Count; i++)
                if (GetY(Angle[i], Radius[i]) <= minoricAlertFront) return true;
            return false;
        }
        /// <summary>
        /// Check if the obstacle need to be detected
        /// </summary>
        public bool isDetectable() {
            int hole = config.getHoleLowAlert() * 10;
            int res = config.getMinimumHeightDetected() * 10;
            float z = GetZ(0);
            return z < config.getSensorHeightSetup() * 10 - res ||
                z > config.getSensorHeightSetup() * 10 + hole;
        }
        /// <summary>
        /// Check if is the same obstacle. Threshold of 250mm
        /// </summary>
        /// <param name="o">obstacle to comparer</param>
        public bool isEqule(Obstacle o) {
            if (this.GetMinX() - 250 > o.GetMinX() && this.GetMinX() + 250 < o.GetMinX()) return false;
            if (this.GetMinY() - 250 > o.GetMinY() && this.GetMinY() + 250 < o.GetMinY()) return false;
            if (this.GetAleatState() != o.GetAleatState()) return false;
            return true;
        }
        /// <summary>
        /// Computer waypoints of the obstacle
        /// </summary>
        /// <returns>string in format lat,long</returns>
        public string GetLocation(GPS gps) {
            if (gps == null) return "מיקום לא ידוע";
            else location = gps.CalculateObjectLocation(this);
            if (location == null) return "מיקום לא ידוע";
            else return location.Latitude + " רוחב " + location.Longitude + " אורך ";
        }
    }
}
