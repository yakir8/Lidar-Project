using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;


namespace LidarApplication {
    class SocketSync {
        private IPAddress srcAddress;
        private IPAddress destAddress;
        private Action<bool> TimeOut;
        private int port;

        public SocketSync(IPAddress srcAddress, IPAddress destAddress, int port) {
            this.srcAddress = srcAddress;
            this.destAddress = destAddress;
            this.port = port;
        }

        public SocketSync(IPAddress srcAddress, IPAddress destAddress, int port, Action<bool> TimeOut) {
            this.TimeOut = TimeOut;
            this.srcAddress = srcAddress;
            this.destAddress = destAddress;
            this.port = port;
        }

        public string SendAndReceiveData(string data, int bufferSize, int timeout = 250) {
            try {
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSock.SendTimeout = timeout;           // Set timeout of 250 milliseconds for send data
                clientSock.ReceiveTimeout = timeout;        // Set timeout of 250 milliseconds for receive data
                EndPoint srcEP = new IPEndPoint(srcAddress, 0);
                clientSock.Bind(srcEP);
                EndPoint destEP = new IPEndPoint(destAddress, port);
                clientSock.Connect(destEP);
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                clientSock.Send(bytes);
                byte[] recevedBuffer = new byte[bufferSize];
                clientSock.Receive(recevedBuffer);
                StringBuilder msg = new StringBuilder();
                foreach (byte b in recevedBuffer) {
                    if (b.Equals(00)) break;
                    else msg.Append(Convert.ToChar(b).ToString());
                }
                Console.WriteLine(msg);
                clientSock.Close();
                return msg.ToString();
            } catch (ArgumentNullException ane) {
                Console.WriteLine("ArgumentNullException: ", ane.ToString());
                return null;
            } catch (SocketException se) {
                Console.WriteLine("SocketException: ", se.ToString());
                return null;
            } catch (Exception e) {
                Console.WriteLine("Unexpected exception: ", e.ToString());
                return null;
            }
        }

        public bool SendData(string data, int timeout = 250) {
            try {
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSock.SendTimeout = timeout;           // Set timeout of 250 milliseconds for send data
                clientSock.ReceiveTimeout = timeout;        // Set timeout of 250 milliseconds for receive data
                EndPoint srcEP = new IPEndPoint(srcAddress, 0);
                clientSock.Bind(srcEP);
                EndPoint destEP = new IPEndPoint(destAddress, port);
                clientSock.Connect(destEP);
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                clientSock.Send(bytes);
                clientSock.Close();
                if (TimeOut != null) TimeOut(false);
            } catch (ArgumentNullException ane) {
                Console.WriteLine("ArgumentNullException: ", ane.ToString());
                return false;
            } catch (SocketException se) {
                if (se.SocketErrorCode == SocketError.TimedOut && TimeOut != null) TimeOut(true);
                else Console.WriteLine("SocketException: ", se.ToString());
                return false;
            } catch (Exception e) {
                Console.WriteLine("Unexpected exception: ", e.ToString());
                return false;
            }
            return true;
        }
    }
}
