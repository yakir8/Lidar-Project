using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {

    class Lidar {

        //Default IP and Port for the Lidar Sensor
        public static int PORT = 2111;
        public static IPAddress IP = new IPAddress(new byte[] { 192, 168, 0, 1 });

        private List<float> Radius = new List<float>();

        public Lidar() { }

        public Lidar(string newIP, int port) {
            IP = IPAddress.Parse(newIP);
            PORT = port;
        }

        public bool initialization(int startAngle, int stopAngle, double resolution) {
            startAngle *= 10000;
            stopAngle *= 10000;
            resolution *= 10000;
            LidarTelegram.StartAngle = startAngle > 0 ? "+" + startAngle.ToString() : startAngle.ToString();
            LidarTelegram.StopAngle = stopAngle > 0 ? "+" + stopAngle.ToString() : stopAngle.ToString();
            LidarTelegram.Resolution = resolution.ToString();
            LidarTelegram.Update();
            bool Succeeded = false;
            ProgressBarDialog form =
                new ProgressBarDialog("טוען את המערכת", "מבצע איתחול לחיישן Lidar...");
            Thread thread = new Thread(() => {
                Configuration configuration = new Configuration();
                IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.LIDAR);
                SocketSync socket = new SocketSync(my, IP, PORT);
                //  1 Log in: sMN SetAccessMode (see 4.1, page 12)
                Succeeded = socket.SendData(LidarTelegram.LOG_IN);
                form.updateProgressBar(15);

                //  2 Set frequency and resolution: sMN mLMPsetscancfg (see 4.2.1, page 14)
                if (Succeeded) {
                    Succeeded = socket.SendData(LidarTelegram.SET_FREQUENCY_AND_RESOLUTION);
                    form.updateProgressBar(15);
                }
                //  3 Configure scandata content: sWN LMDscandatacfg (see 4.3.1, page 56)
                if (Succeeded) {
                    Succeeded = socket.SendData(LidarTelegram.SCANNING_CONFIG_CONTENT);
                    form.updateProgressBar(15);
                }
                //  4 Configure scandata output: sWN LMPoutputRange (see 4.3.2 page 60)
                if (Succeeded) {
                    Succeeded = socket.SendData(LidarTelegram.SCANNING_CONFIG_OUTPUT);
                    form.updateProgressBar(15);
                }
                //  5 Store parameters: sMN mEEwriteall (see 4.2.20, page 53)
                if (Succeeded) {
                    Succeeded = socket.SendData(LidarTelegram.STORE_PARAMETERS);
                    form.updateProgressBar(15);
                }
                //  6 Log out: sMN Run (see 4.2.21, page 54)
                if (Succeeded) {
                    Succeeded = socket.SendData(LidarTelegram.RUN);
                    form.updateProgressBar(15);
                }
                //  7 Request scan:
                if (Succeeded) {
                    //Succeeded = CreateDistanceList(socket.SendAndReceiveData(LidarTelegram.GET_LAST_SCAN, 1024));

                    form.updateProgressBar(10);
                }
                form.Invoke(new Action(() => form.Close()));
            });
            thread.IsBackground = true;
            thread.Start();
            form.ShowDialog();
            return Succeeded;
        }

        public bool CreateDistanceList(string data) {
            Configuration configuration = new Configuration();
            double point = (configuration.getStopAngle() - configuration.getStartAngle()) / configuration.getResolution();
            List<float> newDist = new List<float>();
            if (data != null && !data.Equals("")) {
                int start = 0, end = 0;
                // Remove char STX & ETX
                data = data.Remove(0, 1);
                data = data.Remove(data.Length - 1, 1);
                List<string> telegramList = data.Split(' ').ToList();
                if (telegramList.Count < 2) return false;
                if (telegramList[0] != "sRA" && telegramList[1] != "LMDscandata") return false;
                start = telegramList.FindIndex(x => x == "DIST1") + 1;
                end = telegramList.FindIndex(x => x == "DIST2");
                start += 4;
                if (start == end) return false;
                for (int i = start; i < end; i++) newDist.Add(convertDistance(telegramList[i]));
                if (newDist.Count != point) return false;
                Radius = newDist;
                return true;
            }
            return false;
        }

        public void StartScan() {
            Configuration configuration = new Configuration();
            IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.LIDAR);
            SocketSync socket = new SocketSync(my, IP, PORT);
            socket.SendData(LidarTelegram.START_RECEIVE_DATA);
        }

        public void StopScan() {
            Configuration configuration = new Configuration();
            IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.LIDAR);
            SocketSync socket = new SocketSync(my, IP, PORT);
            socket.SendData(LidarTelegram.STOP_RECEIVE_DATA);
        }

        // Convert from ASSCI to number unit millimeters
        private float convertDistance(string dist) {
            /*
            |\              c - lidar distance
            |β\             b - Real distance
            |  \                     
            |   \  c        sin(β)= b/c => b = c * sin(β)
          a |    \                 
            |     \
            |      \
            |_____(α\
                b
            */
            Configuration configuration = new Configuration();
            int beta = configuration.getAngle();
            double radians = beta * (Math.PI / 180);
            int c = Convert.ToInt32(dist, 16); 
            float a = (float) (c * Math.Sin(radians));
            return a;
        }

        public List<Obstacle> GetScanResult() {
            Configuration configuration = new Configuration();
            int startAngle = configuration.getStartAngle();
            List<Obstacle> obstacles = new List<Obstacle>();
            for (int i = 0; i < Radius.Count(); i++) {
                float angle = startAngle + i * configuration.getResolution();
                obstacles.Add(new Obstacle(angle, Radius[i]));
            }
            return obstacles;
        }
        public static float GetMaxDistance() {
            /*
              |\
              |β\           c - lidar Maximum distance
              |  \          b - Real Maximum distance
              |   \ 
            a |    \ c      tan(α) = a/b => b = a/tan(α)
              |     \
              |      \
              |_____(α\
                 b
              */
            Configuration configuration = new Configuration();
            int a = configuration.getHeight() * 10; // convert cm to millimeters
            // α = 180 - 90 - β
            // β = lidar setup angle
            int alpha = 90 - configuration.getAngle(); 
            double radians = alpha * (Math.PI / 180);
            float b = (float)(a / Math.Tan(radians));
            return b > 40000 ? 40000 : b; // Maximum range for lidar is 40 meter (40000 millimeters)
        }
    }

    class LidarTelegram {

        const char stx = (char)2;
        const char etx = (char)3;

        public static string Resolution = "+2500";
        public static string StartAngle = "0";
        public static string StopAngle = "+1800000";

        /* See 4.1, page 12
         * <STX> - Start Text
         * Command type = sMN
         * Command = SetAccessMode
         * User Level = 3
         * Password = F4724744
         * <ETX> - End Text
        */
        public static readonly string LOG_IN = stx + "sMN SetAccessMode 03 F4724744" + etx;

        /* See 4.2.1, page 14
         * <STX> - Start Text
         * Command type = sMN
         * Command = mLMPsetscancfg
         * Scan frequency = 25Hz
         * Number of active sectors = 1
         * Same value for each sector required = 0.25°
         * Start angle = 0°
         * Stop angle = 180°
         * <ETX> - End Text
         */
        public static string SET_FREQUENCY_AND_RESOLUTION =
            stx + "sMN mLMPsetscancfg +2500 +1 " + Resolution + " " + StartAngle + " " + StopAngle + " " + etx;

        /* See 4.3.1, page 56
         * <STX> - Start Text
         * Command type = sWN
         * Command = LMDscandatacfg
         * Data Channel = 01 00
         * Remission = 0
         * Resolution = 1 (16 bit)
         * Unit = 0
         * Encoder = 0
         * Position = 0
         * Device Name = 0
         * Comment = 0
         * Time = 0
         * Output Rate = +1
         * <ETX> - End Text
        */
        public static readonly string SCANNING_CONFIG_CONTENT = stx + "sWN LMDscandatacfg 01 00 0 1 0 00 00 0 0 0 0 +1" + etx;

        /* See 4.3.2 page 60
         * <STX> - Start Text
         * Command type = sWN
         * Command = LMPoutputRange
         * Status Code = 1
         * Angular Resolution = 0.25°
         * Start Angle = 0°
         * Stop angle = 180°
         * <ETX> - End Text
        */
        public static string SCANNING_CONFIG_OUTPUT =
            stx + "sWN LMPoutputRange 1 " + Resolution + " " + StartAngle + " " + StopAngle + " " + etx;

        /* See 4.2.20, page 53
         * <STX> - Start Text
         * Command type = sMN
         * Command = mEEwriteall
         * <ETX> - End Text
         */
        public static readonly string STORE_PARAMETERS = stx + "sMN mEEwriteall" + etx;

        /* See 4.2.21, page 54
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * <ETX> - End Text
         */
        public static readonly string RUN = stx + "sMN Run" + etx;

        /* See 4.2.21, page 64
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * <ETX> - End Text
         */
        public static readonly string GET_LAST_SCAN = stx + "sRN LMDscandata" + etx;

        /* See 4.2.21, page 65
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * Measurement = 1
         * <ETX> - End Text
         */
        public static readonly string START_RECEIVE_DATA = stx + "sEN LMDscandata 1" + etx;

        /* See 4.2.21, page 65
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * Measurement = 0
         * <ETX> - End Text
         */
        public static readonly string STOP_RECEIVE_DATA = stx + "sEN LMDscandata 0" + etx;

        public static void Update() {
            SET_FREQUENCY_AND_RESOLUTION =
            stx + "sMN mLMPsetscancfg +2500 +1 " + Resolution + " " + StartAngle + " " + StopAngle + " " + etx;
            SCANNING_CONFIG_OUTPUT =
            stx + "sWN LMPoutputRange 1 " + Resolution + " " + StartAngle + " " + StopAngle + " " + etx;
        }
    }
}
