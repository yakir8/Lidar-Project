using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace LidarApplication {
    class SocketSync {

        Socket socket;
        Thread listener;
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

        public void StartListening(Action<string> ReceiveHandler) {
            listener = new Thread(() => {
                while (true) {
                    try {
                        string data = Receive();
                        if (data != null) {
                            ReceiveHandler(data);
                            TimeOut?.Invoke(false);
                        }
                        else TimeOut?.Invoke(true);
                    } catch {
                        TimeOut?.Invoke(true);
                    }
                }
            });
            listener.IsBackground = true;
            listener.Start();
        }
        public void StopListening() {
#pragma warning disable CS0618 // Type or member is obsolete
            if (listener != null) listener.Suspend();
#pragma warning restore CS0618 // Type or member is obsolete
            listener = null;
        }
        public void setTimeOut(Action<bool> TimeOut) { this.TimeOut = TimeOut; }
        public bool Send(string data, bool junk = true) {
            try {
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                socket.Send(bytes);
                if (junk) socket.Receive(new byte[10000]);
                TimeOut?.Invoke(false);
            } catch (ArgumentNullException ane) {
                Console.WriteLine("ArgumentNullException: ", ane.ToString());
                return false;
            } catch (SocketException se) {
                TimeOut?.Invoke(true);
                Console.WriteLine("SocketException: ", se.ToString());
                return false;
            } catch (Exception e) {
                Console.WriteLine("Unexpected exception: ", e.ToString());
                return false;
            }
            return true;
        }
        public bool SendWithAck(string data, string ack) {
            try {
                StringBuilder msg = new StringBuilder();
                byte[] recevedBuffer = new byte[10000];
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                socket.Send(bytes);
                socket.Receive(recevedBuffer);
                foreach (byte b in recevedBuffer) {
                    if (b.Equals(00)) break;
                    else msg.Append(Convert.ToChar(b).ToString());
                }
                return msg.ToString().Equals(ack);
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
        }
        public string Receive() {
            StringBuilder msg = new StringBuilder();
            try {
                byte[] recevedBuffer = new byte[100000];
                socket.Receive(recevedBuffer);
                foreach (byte b in recevedBuffer) {
                    if (b.Equals(00)) break;
                    else msg.Append(Convert.ToChar(b).ToString());
                }
                return msg.ToString();
            } catch (ArgumentNullException ane) {
                Console.WriteLine("ArgumentNullException: ", ane.ToString());
                return null;
            } catch (SocketException se) {
                if (se.SocketErrorCode == SocketError.TimedOut && TimeOut != null) TimeOut(true);
                else Console.WriteLine("SocketException: ", se.ToString());
                return null;
            } catch (Exception e) {
                Console.WriteLine("Unexpected exception: ", e.ToString());
                return null;
            }
        }
        public bool IsConnected() { return socket.Connected; }
        public bool Connect() {
            try {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.SendTimeout = 250;           // Set timeout of 250 milliseconds for send data
                socket.ReceiveTimeout = 4000;        // Set timeout of 250 milliseconds for receive data
                EndPoint srcEP = new IPEndPoint(srcAddress, 0);
                socket.Bind(srcEP);
                EndPoint destEP = new IPEndPoint(destAddress, port);
                //socket.Connect(destEP);

                IAsyncResult result = socket.BeginConnect(destAddress, port, null, null);
                WaitHandle timeoutHandler = result.AsyncWaitHandle;
                try {
                    if (!result.AsyncWaitHandle.WaitOne(250, false)) {
                        socket.Close();
                        return false;
                    }

                    socket.EndConnect(result);
                } catch (Exception) {
                    return false;
                } finally {
                    timeoutHandler.Close();
                }

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
        public void Disconnect() => socket.Close();
    }
}
