using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {

    public class Lidar {

        //Default IP and Port for the Lidar Sensor
        public static int PORT = 2111;
        public static IPAddress IP = new IPAddress(new byte[] { 192, 168, 0, 1 });
        private static bool isRestarting = false;

        private SocketSync socket;
        private List<float> Radius = new List<float>();
        private Configuration config;

        public Lidar(Configuration config) { this.config = config; }

        public Lidar(Configuration config, string newIP, int port) {
            PORT = port;
            this.config = config;
            IP = IPAddress.Parse(newIP);
            IPAddress my = LocalIP.GetLocalIP(LOCAL_IP_TYPE.LIDAR);
            socket = new SocketSync(my, IP, PORT);
        }
        public void SetIp(string ip) {
            IP = IPAddress.Parse(ip);
        }
        public void SetPort(int port) {
            PORT = port;
        }

        #region Lidar configuration
        public bool initialization(int startAngle, int stopAngle, double resolution) {
            socket.Connect();
            startAngle *= 10000;
            stopAngle *= 10000;
            resolution *= 10000;
            LidarTelegram.StartAngle = startAngle > 0 ? "+" + startAngle.ToString() : startAngle.ToString();
            LidarTelegram.StopAngle = stopAngle > 0 ? "+" + stopAngle.ToString() : stopAngle.ToString();
            LidarTelegram.Resolution = "+" + resolution.ToString();
            LidarTelegram.Update();
            bool Succeeded = false;
            Succeeded = LoadLidarConfigFromFile();
            return Succeeded;
        }
        public bool LoadLidarConfigFromFile() {
            bool Succeeded = false;
            List<string> sendData = new List<string>();
            List<string> ackData = new List<string>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Lidar\LidarConfig.txt";
            ProgressBarDialog form =
                new ProgressBarDialog("טוען את המערכת", "מבצע איתחול לחיישן Lidar...");
            Thread thread = new Thread(() => {
                if (File.Exists(path)) {
                    var reader = new StreamReader(path);
                    while (!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        if (line.Contains("SEND")) {
                            var lst = line.Split('\t');
                            string send = lst.Last().Replace("<STX>", ((char)2).ToString())
                                    .Replace("<ETX>", ((char)3).ToString())
                                    .Replace("{resolution}", LidarTelegram.Resolution)
                                    .Replace("{start angle}", LidarTelegram.StartAngle)
                                    .Replace("{stop angle}", LidarTelegram.StopAngle);
                            line = reader.ReadLine();
                            lst = line.Split('\t');
                            string received = lst.Last().Replace("<STX>", ((char)2).ToString())
                                    .Replace("<ETX>", ((char)3).ToString())
                                    .Replace("{resolution}", LidarTelegram.Resolution)
                                    .Replace("{start angle}", LidarTelegram.StartAngle)
                                    .Replace("{stop angle}", LidarTelegram.StopAngle);
                            sendData.Add(send);
                            ackData.Add(received);
                        }
                    }
                    for (int i = 0; i < sendData.Count; i++) {
                        //Succeeded = socket.SendWithAck(sendData[i], ackData[i]);
                        Succeeded = socket.Send(sendData[i]);
                        if (!Succeeded) break;
                        form.updateProgressBar(100 / sendData.Count);
                    }
                    form.Invoke(new Action(() => form.Close()));
                }
                else Console.WriteLine("File not Exists");
            });
            thread.IsBackground = true;
            thread.Start();
            form.ShowDialog();
            return Succeeded;
        }
        #endregion

        #region Lidar Result Handle
        public bool CreateDistanceList(string data) {
            double point = (config.getStopAngle() - config.getStartAngle()) / config.getResolution() + 1;
            List<float> newDist = new List<float>();
            if (data != null && !data.Equals("")) {
                int start = 0;
                // Remove char STX & ETX
                data = data.Remove(0, 1);
                data = data.Remove(data.Length - 1, 1);
                List<string> telegramList = data.Split(' ').ToList();
                if (telegramList.Count < 2) return false;
                //if (telegramList[0] != "sSN" && telegramList[1] != "LMDscandata") return false;
                start = telegramList.FindIndex(x => x == "DIST1") + 1;
                start += 5;
                if (start + point > telegramList.Count - start) return false;
                for (int i = start; i < start + point; i++) newDist.Add(convertDistance(telegramList[i]));
                Radius = newDist;
                return true;
            }
            return false;
        }
        // Convert from ASSCI to number unit millimeters
        private float convertDistance(string dist) {
            return Convert.ToInt32(dist, 16);
        }
        public List<Obstacle> GetScanResult() {
            int startAngle = config.getStartAngle();
            List<Obstacle> obstacles = new List<Obstacle>();
            for (int i = 0; i < Radius.Count(); i++) {
                float angle = startAngle + i * config.getResolution();
                obstacles.Add(new Obstacle(config, angle, Radius[i]));
            }
            return obstacles;
        }
        #endregion

        #region Scan State Handle
        public void StartScan(Action<string> ReceiveHandler, Action<bool> TimeOut) {
            socket.Send(LidarTelegram.START_RECEIVE_DATA);
            socket.setTimeOut(TimeOut);
            socket.StartListening(ReceiveHandler);
        }
        public void StopScan() {
            new Thread(() => {
                StopListening();
                socket.Send(LidarTelegram.STOP_RECEIVE_DATA);
                Disconnect();
            }).Start();
        }
        public void PauseScan() {
            new Thread(() => {
                socket.Send(LidarTelegram.STOP_RECEIVE_DATA);
            }).Start();
        }
        public void ResumeScan() {
            new Thread(() => {
                socket.Send(LidarTelegram.START_RECEIVE_DATA);
            }).Start();
        }

        #endregion

        #region TCP Compunction
        public bool Send(string data) { return socket.Send(data); }
        public bool Connect() {
            if (socket != null) return socket.Connect();
            return false;
        }
        public void Restart(Action<string> ReceiveHandler, Action<bool> TimeOut) {
            if (!isRestarting) {
                isRestarting = true;
                Connect();
                Send(LidarTelegram.START_RECEIVE_DATA);
            }
            isRestarting = false;
        }
        public void StopListening() { socket.StopListening(); }
        public void Disconnect() {
            if (socket != null)
                socket.Disconnect();
        }
        #endregion

        public static float GetMaxDistance(Configuration configuration) {
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
            int a = configuration.getSensorHeightSetup() * 10; // convert cm to millimeters
            // α = 180 - 90 - β
            // β = lidar setup angle

            int alpha = 90 - configuration.getAngleSetup();
            double radians = alpha * (Math.PI / 180);
            //float b = (float)(a * Math.Tan(radians));
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

        /* See 4.2.1, page 15
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
