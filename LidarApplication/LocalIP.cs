using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace LidarApplication {
    public enum LOCAL_IP_TYPE { INTERNET, LIDAR };

    class LocalIP {
        public static IPAddress GetLocalIP(LOCAL_IP_TYPE type) {
            string adapterName = "";
            if (type == LOCAL_IP_TYPE.INTERNET)
                adapterName = new Configuration().getInterntAdapter();
            if (type == LOCAL_IP_TYPE.LIDAR)
                adapterName = new Configuration().getLidarAdapter();
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces()) {
                if (ni.Name == adapterName)
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses) {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork) {
                            return new IPAddress(ip.Address.GetAddressBytes());
                        }
                    }
            }
            return null;
        }

        public static IPAddress GetLocalIP(string adapterName, LOCAL_IP_TYPE type) {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces()) {
                if (ni.Name == adapterName)
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses) {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork) {
                            return new IPAddress(ip.Address.GetAddressBytes());
                        }
                    }
            }
            return null;
        }

    }
}
