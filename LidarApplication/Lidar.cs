using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LidarApplication
{

    class Lidar
    {
        enum IP_TYPE { INTERNET, LIDAR };

        public static int PORT = 2111;
        public static IPAddress IP = new IPAddress(new byte[] { 192, 168, 0, 1 });
        private List<double> dist = new List<double>();
        private double startAngular = 0;
        private double resolution = 0;

        public Lidar(string newIP, int port)
        {
            IP = IPAddress.Parse("10.100.102.12");
            PORT = port;
        }

        public void initialization()
        {
           
            Configuration configuration = new Configuration();
            IPAddress my = getInernalIpByAdapter(configuration.getLidarAdapter(), IP_TYPE.LIDAR);
            SocketSync socket = new SocketSync(my, IP, PORT);
            //  1 Log in: sMN SetAccessMode (see 4.1, page 12)
            socket.SendData(LidarTelegram.LOG_IN);
            //  2 Set frequency and resolution: sMN mLMPsetscancfg (see 4.2.1, page 14)
            socket.SendData(LidarTelegram.SET_FREQUENCY_AND_RESOLUTION);
            //  3 Configure scandata content: sWN LMDscandatacfg (see 4.3.1, page 56)
            socket.SendData(LidarTelegram.SCANNING_CONFIG_CONTENT);
            //  4 Configure scandata output: sWN LMPoutputRange (see 4.3.2 page 60)
            socket.SendData(LidarTelegram.SCANNING_CONFIG_OUTPUT);
            //  5 Store parameters: sMN mEEwriteall (see 4.2.20, page 53)
            socket.SendData(LidarTelegram.STORE_PARAMETERS);
            //  6 Log out: sMN Run (see 4.2.21, page 54)
            socket.SendData(LidarTelegram.RUN);
            //  7 Request scan:
            CreateDistanceList(socket.SendAndReceiveData(LidarTelegram.GET_LAST_SCAN, 1024));
        }

        private IPAddress getInernalIpByAdapter(string adapterName, IP_TYPE ipType)
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.Name == adapterName)
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            Console.WriteLine("The Ip Address For Adapter " + ni.Name + " Is " + ip.Address.ToString());
                            return new IPAddress(ip.Address.GetAddressBytes());
                        }
                    }
            }
            return null;
        }

        public bool CreateDistanceList(string data)
        {
            int start = 0, end = 0;
            // Remove char STX & ETX
            data = data.Remove(0, 1);
            data = data.Remove(data.Length -1, 1);
            List<string> telegramList = data.Split(' ').ToList();
            if (telegramList.Count < 2) return false;
            if (telegramList[0] != "sRA" && telegramList[1] != "LMDscandata") return false;
            start = telegramList.FindIndex(x => x == "DIST1") + 1;
            end = telegramList.FindIndex(x => x == "DIST2") - 1;
            if (start == end) return false;
            startAngular = Convert.ToInt32(telegramList[start + 2], 16) / 10000;
            start += 3;
            resolution = ((double) Convert.ToInt64(telegramList[start],16)) / 10000;
            start++;
            for (int i = start; i < end; i++) dist.Add(convertDistance(telegramList[i]));
            return true;
        }

        private double convertDistance(string dist)
        {
            // Convert from ASSCI to number unit cm
            return ((double) Convert.ToInt32(dist,16)) / 1000;
        }
    }

    class LidarTelegram
    {

        const char stx = (char)2;
        const char etx = (char)3;

        /* See 4.1, page 12
         * <STX> - Start Text
         * Command type = sMN
         * Command = SetAccessMode
         * User Level = 3
         * Password = F4724744
         * <ETX> - End Text
        */
        public static string LOG_IN = stx + "sMN SetAccessMode 03 F4724744" + etx;

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
        public static string SET_FREQUENCY_AND_RESOLUTION = stx + "sMN mLMPsetscancfg +2500 +1 +2500 0 +1800000" + etx;

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
        public static string SCANNING_CONFIG_CONTENT = stx + "sWN LMDscandatacfg 01 00 0 1 0 00 00 0 0 0 0 +1" + etx;

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
        public static string SCANNING_CONFIG_OUTPUT = stx + "sWN LMPoutputRange 1 +2500 0 +1850000" + etx;

        /* See 4.2.20, page 53
         * <STX> - Start Text
         * Command type = sMN
         * Command = mEEwriteall
         * <ETX> - End Text
         */
        public static string STORE_PARAMETERS = stx + "sMN mEEwriteall" + etx;

        /* See 4.2.21, page 54
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * <ETX> - End Text
         */
        public static string RUN = stx + "sMN Run" + etx;

        /* See 4.2.21, page 64
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * <ETX> - End Text
         */
        public static string GET_LAST_SCAN  = stx + "sRN LMDscandata" + etx;

        /* See 4.2.21, page 65
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * Measurement = 1
         * <ETX> - End Text
         */
        public static string START_RECEIVE_DATA = stx + "sEN LMDscandata 1" + etx;

        /* See 4.2.21, page 65
         * <STX> - Start Text
         * Command type = sMN
         * Command = Run
         * Measurement = 0
         * <ETX> - End Text
         */
        public static string STOP_RECEIVE_DATA = stx + "sEN LMDscandata 0" + etx;
    }
}
