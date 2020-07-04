using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace LidarApplication
{
    class ServerSocket
    {

        private int port;
        private IPAddress ipAddress;
        private TcpListener listener;
        private Thread listenerThread;
        private Action<string> ReceiveHandler;

        private const int BUFFER_SIZE = 10240;

        public ServerSocket(IPAddress ip, int port, Action<string> ReceiveHandler){
            this.ipAddress = ip;
            this.port = port;
            this.ReceiveHandler = ReceiveHandler;
            this.listener = new TcpListener(ip, port);
        }

        public void StartListening(){
            try{
                listener.Start();
                Console.WriteLine("Server started.");
                listenerThread = new Thread(() => {
                    string msg = null;
                    while (true){
                        Console.WriteLine("waiting for client");
                        TcpClient client = listener.AcceptTcpClient();
                        do {
                            msg = Receive(client);
                            if (msg != null && msg != "") ReceiveHandler(msg);
                        } while (msg != null);
                    }
                });
                listenerThread.Start();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        private string Receive(TcpClient client) {
            try {
                byte[] recevedBuffer = new byte[BUFFER_SIZE];
                NetworkStream stream = client.GetStream();
                stream.Read(recevedBuffer, 0, recevedBuffer.Length);
                StringBuilder msg = new StringBuilder();
                foreach (byte b in recevedBuffer) {
                    if (b.Equals(00)) break;
                    else msg.Append(Convert.ToChar(b).ToString());
                }
                return msg.ToString();
            }
            catch {
                return null;
            }
        }

        public void StopListening() {
            listener.Stop();
            if (listenerThread != null) listenerThread.Abort();
        }
    }
}
