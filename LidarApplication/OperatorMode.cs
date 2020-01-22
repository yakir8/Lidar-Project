using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace LidarApplication
{
    public partial class OperatorMode : Form
    {
        enum IP_TYPE { INTERNET, LIDAR };

        Lidar lidar;
        SocketSync serverSocket;
        Configuration configuration = new Configuration();

        public OperatorMode()
        {
            string lidarIP = configuration.getLidarIp().Split(':')[0];
            string lidarPort = configuration.getLidarIp().Split(':')[1];
            InitializeComponent();
            lidar = new Lidar(lidarIP, int.Parse(lidarPort));
            lidar.initialization();
           // configServerConnection();
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

        private bool configServerConnection()
        {
            try
            {
                IPAddress server = IPAddress.Parse(configuration.getServerIp());
                IPAddress my = getInernalIpByAdapter(configuration.getInterntAdapter(), IP_TYPE.INTERNET);
                if (my == null || server == null) throw new ProtocolViolationException();
                serverSocket = new SocketSync(my, server, 80);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("לא ניתן להתחבר לשרת.", "שגיאת התחברות", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1, 
                    MessageBoxOptions.RightAlign);
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
