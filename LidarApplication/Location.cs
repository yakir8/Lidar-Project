using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LidarApplication {
    public class Location {
        public double Latitude;
        public double Longitude;

        public Location (double latitude, double longitude) {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        override public string ToString() {
            return Latitude + " " + Longitude;
        }
    }
}
