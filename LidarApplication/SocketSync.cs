using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;


namespace LidarApplication
{
    class SocketSync
    {
        private IPAddress srcAddress;
        private IPAddress destAddress;
        private int port;

        public SocketSync(IPAddress srcAddress, IPAddress destAddress, int port)
        {
            this.srcAddress = srcAddress;
            this.destAddress = destAddress;
            this.port = port;
        }

        public string SendAndReceiveData(string data, int bufferSize)
        {
            try
            {
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                EndPoint srcEP = new IPEndPoint(srcAddress, 0);
                clientSock.Bind(srcEP);
                EndPoint destEP = new IPEndPoint(destAddress, port);
                clientSock.Connect(destEP);
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                clientSock.Send(bytes);
                byte[] recevedBuffer = new byte[bufferSize];
                clientSock.Receive(recevedBuffer);
                StringBuilder msg = new StringBuilder();
                foreach (byte b in recevedBuffer)
                {
                    if (b.Equals(00)) break;
                    else msg.Append(Convert.ToChar(b).ToString());
                }
                Console.WriteLine(msg);
                clientSock.Close();
                return msg.ToString();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            return "Connection Error";
        }

        public void SendData(string data)
        {
            try
            {
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                EndPoint srcEP = new IPEndPoint(srcAddress, 0);
                clientSock.Bind(srcEP);
                EndPoint destEP = new IPEndPoint(destAddress, port);
                clientSock.Connect(destEP);
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                clientSock.Send(bytes);
                clientSock.Close();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
        }
    }
}
