using System;

namespace LidarApplication {
    static class Geodesy
    {
        public static double[] GeodeticToGeocentric(double wgsPhi, double wgsLam, double wgsHeight = 0)
        {
            // input in Decimal Degrees

            // wgs84
            double a = 6378137; // large sami axis of earth
            double f = 1 / 298.257223563;

            wgsPhi *= (Math.PI) / 180;
            wgsLam *= (Math.PI) / 180;

            double ee = 2 * f - (f * f);
            double sinPhi = Math.Sin(wgsPhi);
            double cosPhi = Math.Cos(wgsPhi);
            double N = a / Math.Sqrt(1 - ee * sinPhi * sinPhi);

            double X = (N + wgsHeight) * cosPhi * Math.Cos(wgsLam);
            double Y = (N + wgsHeight) * cosPhi * Math.Sin(wgsLam);
            double Z = (N * (1 - ee) + wgsHeight) * sinPhi;

            return new double[3] { X, Y, Z};
        }

        public static double[] GeodeticToGeocentricGrs80(double wgsPhi, double wgsLam, double wgsHeight = 0)
        {
            // input in Decimal Degrees

            // grs80
            double a = 6378137; // large sami axis of earth
            double f = 1 / 298.257222101;

            wgsPhi *= (Math.PI) / 180;
            wgsLam *= (Math.PI) / 180;

            double ee = 2 * f - (f * f);
            double sinPhi = Math.Sin(wgsPhi);
            double cosPhi = Math.Cos(wgsPhi);
            double N = a / Math.Sqrt(1 - ee * sinPhi * sinPhi);

            double X = (N + wgsHeight) * cosPhi * Math.Cos(wgsLam);
            double Y = (N + wgsHeight) * cosPhi * Math.Sin(wgsLam);
            double Z = (N * (1 - ee) + wgsHeight) * sinPhi;

            return new double[3] { X, Y, Z };
        }

        public static double[] Geocentric_Wgs84ToGrs80(double wgsX, double wgsY, double wgsZ)
        // 7 param transform, ITM
        {
            double dx = -24.0024; 
            double dy = -17.1032; 
            double dz = -17.8444; 
            double sCl = 1.0000054248; 
            double rx = -0.33009; 
            double ry = -1.85269; 
            double rz = 1.66969; 

            rx = (rx / 3600) * (Math.PI / 180);
            ry = (ry / 3600) * (Math.PI / 180);
            rz = (rz / 3600) * (Math.PI / 180);


            double grsX = dx + sCl * (wgsX + rz * wgsY - ry * wgsZ);
            double grsY = dy + sCl * (-rz * wgsX + wgsY + rx * wgsZ);
            double grsZ = dz + sCl * (ry * wgsX - rx * wgsY + wgsZ);

            return new double[3] { grsX, grsY, grsZ };
        }

        public static double[] Geocentric_Grs80ToWgs84(double grsX, double grsY, double grsZ)
        // 7 param transform, ITM
        {
            double dx = 24.0024;
            double dy = 17.1032;
            double dz = 17.8444;
            double sCl = 1.0 / 1.0000054248;
            double rx = 0.33009;
            double ry = 1.85269;
            double rz = -1.66969;

            rx = (rx / 3600) * (Math.PI / 180);
            ry = (ry / 3600) * (Math.PI / 180);
            rz = (rz / 3600) * (Math.PI / 180);


            double tmpX = (grsX + dx) * sCl;
            double tmpY = (grsY + dy) * sCl;
            double tmpZ = (grsZ + dz) * sCl;

            double wgsX = tmpX + rz * tmpY - ry * tmpZ;
            double wgsY = -rz * tmpX + tmpY + rx * tmpZ;
            double wgsZ = ry * tmpX - rx * tmpY + tmpZ;

            return new double[3] { wgsX, wgsY, wgsZ };
        }

        public static double[] Geocentric_05_Wgs84ToGrs80(double wgsX, double wgsY, double wgsZ)
        {
            double dx = -23.8085;
            double dy = -17.5937;
            double dz = -17.801;
            double sCl = 1.0000054374;
            double rx = -0.3306;
            double ry = -1.85706;
            double rz = 1.64828;

            rx = (rx / 3600) * (Math.PI / 180);
            ry = (ry / 3600) * (Math.PI / 180);
            rz = (rz / 3600) * (Math.PI / 180);


            double grsX = dx + sCl * (wgsX + rz * wgsY - ry * wgsZ);
            double grsY = dy + sCl * (-rz * wgsX + wgsY + rx * wgsZ);
            double grsZ = dz + sCl * (ry * wgsX - rx * wgsY + wgsZ);

            return new double[3] { grsX, grsY, grsZ };
        }

        public static double[] GeocentricToGeodetic(double grsX, double grsY, double grsZ)
        {
            double lam, r0, phi0, phi1, h0, h1, N, a, f, ee;

            // grs80
            a = 6378137; // large sami axis of earth
            f = 1 / 1 / 298.257222101;


            ee = 2 * f - f * f;
            lam = Math.Atan2(grsY, grsX);

            r0 = Math.Sqrt(grsX * grsX + grsY * grsY);
            phi0 = Math.Atan2(grsZ, (r0 * (1 - ee)));
            h0 = 0;
            h1 = 1;
            phi1 = 1;


            while (Math.Abs(h1 - h0) > 1e-5 || Math.Abs(phi1 - phi0) > 1e-10)
            {
                h1 = h0;
                phi1 = phi0;
                double sinPhi0 =   Math.Sin(phi0);
                N = a / Math.Sqrt(1 - ee *sinPhi0*sinPhi0);
                h0 = r0 / Math.Cos(phi0) - N;
                phi0 = Math.Atan2(grsZ, r0 * (1 - ee * N / (N + h0)));
            }

            return new double[3] {phi0,lam,h0};
        }

        public static double[] GeocentricToGeodeticWgs84(double grsX, double grsY, double grsZ)
        {
            double lam, r0, phi0, phi1, h0, h1, N, a, f, ee;

            // wgs84
            a = 6378137; // large sami axis of earth
            f = 1 / 1 / 298.257223563;


            ee = 2 * f - f * f;
            lam = Math.Atan2(grsY, grsX);

            r0 = Math.Sqrt(grsX * grsX + grsY * grsY);
            phi0 = Math.Atan2(grsZ, (r0 * (1 - ee)));
            h0 = 0;
            h1 = 1;
            phi1 = 1;


            while (Math.Abs(h1 - h0) > 1e-5 || Math.Abs(phi1 - phi0) > 1e-10)
            {
                h1 = h0;
                phi1 = phi0;
                double sinPhi0 = Math.Sin(phi0);
                N = a / Math.Sqrt(1 - ee * sinPhi0 * sinPhi0);
                h0 = r0 / Math.Cos(phi0) - N;
                phi0 = Math.Atan2(grsZ, r0 * (1 - ee * N / (N + h0)));
            }

            return new double[3] { phi0, lam, h0 };
        }

        public static double[] ITM(double grsPhi, double grsLam, double grsH)
        {
            //grs80
            double a = 6378137;
            double f = 1 / 298.257222101;

            double Lat0 = 31 + 44.0 / 60 + 3.817 / 3600; // deg
            double Long0 = 35 + 12.0 / 60 + 16.261 / 3600; //deg

            // convert to rad
            Lat0 *= Math.PI / 180;
            Long0 *= Math.PI / 180;

            double east0 = 219529.584;
            double north0 = 626907.39;

            double ee, M0, Sm0, N, J, t, Ni, D2, D3, C2,
                   C3, Ca, Cb, Cc, Cd, Sm;

            double sinPhi = Math.Sin(grsPhi);
            double cosPhi = Math.Cos(grsPhi);

            ee = 2 * f - f * f;
            M0 = 1.0000067;

            Sm0 = 3512424.339;

            N = (M0 * a) / (Math.Sqrt(1 - ee * sinPhi * sinPhi));
            J = (grsLam - Long0) * Math.Cos(grsPhi);
            t = Math.Tan(grsPhi);
            Ni = (ee * cosPhi * cosPhi) / (1 - ee);

            double JJ = J * J;
            double tt = t * t;
            double NiNi = Ni * Ni;

            D2 = JJ * (1 - tt + Ni) / 6;
            D3 = (JJ * JJ) * (5 - 18 * tt + 14 * Ni + (tt * tt) - 58 * tt * Ni) / 120;
            C2 = JJ * (5 - tt + 9 * Ni + 4 * NiNi) / 12;
            C3 = (JJ * JJ) * (61 - 58 * tt + 270 * Ni + (tt * tt) - 330 * tt * Ni) / 360;

            Ca = 1 + (3.0 / 4) * ee + (45.0 / 64) * (ee * ee) + (175.0 / 256) * (ee * ee * ee);
            Cb = (1.0 / 2) * ((3.0 / 4) * ee + (15.0 / 16 )* (ee * ee) + (525.0 / 512) * (ee * ee * ee));
            Cc = (1.0 / 4) * ((15.0 / 64) * (ee * ee) + (105.0 / 256) * (ee * ee * ee));
            Cd = (1.0/ 6) * ((35.0 / 512) * (ee * ee * ee));

            Sm = M0 * a * (1 - ee) * (Ca * grsPhi - Cb * Math.Sin(2 * grsPhi) + Cc * Math.Sin(4 * grsPhi) - Cd * Math.Sin(6 * grsPhi));

            double itmEast = east0 + N * J * (1 + D2 + D3);
            double itmNorth = north0 + (Sm - Sm0) + N * JJ * t * (1 + C2 + C3) / 2;
            double itmHeight = grsH;

            return new double[3] { itmEast, itmNorth, itmHeight };
        }

        public static double[] ITMToGeodetic(double itmEast, double itmNorth, double itmH)
        {
            //grs80
            double a = 6378137;
            double f = 1 / 298.257222101;

            double Lat0 = 31 + 44.0 / 60 + 3.817 / 3600; // deg
            double Long0 = 35 + 12.0 / 60 + 16.261 / 3600; //deg

            // convert to rad
            Lat0 *= Math.PI / 180;
            Long0 *= Math.PI / 180;

            double east0 = 219529.584;
            double north0 = 626907.39;

            double k0 = 1.0000067;

            double ee = 2 * f - f * f;
            double ee_tag = ee / (1 - ee);
            double e1 = (1 - Math.Sqrt(1 - ee)) / (1 + Math.Sqrt(1 - ee));

            double M0 = a * ((1 - ee / 4 - 3 * ee * ee / 64 - 5 * ee * ee * ee / 256) *
                             Lat0 - (3 * ee / 8 + 3 * ee * ee / 32 + 45 * ee * ee * ee / 1024) * Math.Sin(2 * Lat0) +
                             (15 * ee * ee / 256 + 45 * ee * ee * ee / 1024) * Math.Sin(4 * Lat0) - 
                             (35 * ee * ee * ee / 3072) * Math.Sin(6 * Lat0));

            double M = M0 + (itmNorth - north0) / k0;
            double mu = M / (a * (1 - ee / 4 - 3 * ee * ee / 64 - 5 * ee * ee * ee / 256));

            double lat1 = mu + (3 * e1 / 2 - 27 * e1 * e1 * e1 / 32) * Math.Sin(2 * mu) +
                         (21 * e1 * e1 / 16 - 55 * e1 * e1 * e1 * e1 / 32) * Math.Sin(4 * mu) + 
                         (151 * e1 * e1 * e1 / 96) * Math.Sin(6 * mu) + 
                         (1097 * e1 * e1 * e1 * e1 / 512) * Math.Sin(8 * mu);

            double C1 = ee_tag * Math.Cos(lat1) * Math.Cos(lat1);
            double T1 = Math.Tan(lat1) * Math.Tan(lat1);
            double N1 = a / Math.Sqrt(1 - ee * Math.Sin(lat1) * Math.Sin(lat1));
            double R1 = a * (1 - ee) / (Math.Pow(1 - ee * Math.Sin(lat1) * Math.Sin(lat1), 1.5));
            double D = (itmEast - east0) / (N1 * k0);

            double lat, lon;

            double temp = D * D / 2 - (5 + 3 * T1 + 10 * C1 - 4 * C1 * C1 - 9 * ee_tag) * D * D * D * D / 24 +
                         (61 + 90 * T1 + 298 * C1 + 45 * T1 * T1 - 252 * ee_tag - 3 * C1 * C1) * D * D * D * D * D * D / 720;
            lat = lat1 - (N1 * Math.Tan(lat1) / R1) * (temp);
            
            temp = D - (1 + 2 * T1 + C1) * D * D * D / 6 +
                  (5 - 2 * C1 + 28 * T1 - 3 * C1 * C1 + 8 * ee_tag + 24 * T1 * T1) * D * D * D * D * D / 120;
            lon = Long0 + temp / Math.Cos(lat1);


            return new double[3] { lat , lon , itmH };
        }

        public static double[] NmeaToItm(double wgsPhi, double wgsLam, double wgsHeight)
        {
            double[] wgsGeocentric = GeodeticToGeocentric(wgsPhi, wgsLam, wgsHeight);
            double[] grsGeocentric = Geocentric_Wgs84ToGrs80(wgsX: wgsGeocentric[0], wgsY: wgsGeocentric[1], wgsZ: wgsGeocentric[2]);
            double[] grsGeodetic = GeocentricToGeodetic(grsX: grsGeocentric[0], grsY: grsGeocentric[1], grsZ: grsGeocentric[2]);
            double[] Itm = ITM(grsGeodetic[0], grsGeodetic[1], grsGeodetic[2]);

            return Itm;
        }

        public static double[] NmeaToItm05(double wgsPhi, double wgsLam, double wgsHeight)
        {
            double[] wgsGeocentric = GeodeticToGeocentric(wgsPhi, wgsLam, wgsHeight);
            double[] grsGeocentric = Geocentric_05_Wgs84ToGrs80(wgsX: wgsGeocentric[0], wgsY: wgsGeocentric[1], wgsZ: wgsGeocentric[2]);
            double[] grsGeodetic = GeocentricToGeodetic(grsX: grsGeocentric[0], grsY: grsGeocentric[1], grsZ: grsGeocentric[2]);
            double[] Itm = ITM(grsGeodetic[0], grsGeodetic[1], grsGeodetic[2]);

            return Itm;
        }

        public static double[] ItmToWgs84(double itmEast, double itmNorth, double geoH )
        {
            double[] grsGeodetic = ITMToGeodetic(itmEast, itmNorth, geoH);
            double[] grsGeocentric = GeodeticToGeocentricGrs80(grsGeodetic[0] * 180 / Math.PI, grsGeodetic[1] * 180 / Math.PI, grsGeodetic[2]);
            double[] wgsGeocentric = Geocentric_Grs80ToWgs84(grsGeocentric[0], grsGeocentric[1], grsGeocentric[2]);
            double[] wgsGeodetic = GeocentricToGeodeticWgs84(wgsGeocentric[0], wgsGeocentric[1], wgsGeocentric[2]);

            return wgsGeodetic;
        }
    }
}