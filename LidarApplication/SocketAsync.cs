﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace LidarApplication
{
    // State object for reading client data asynchronously  
    public class StateObject
    {
        // Client  socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 1024;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }


    class SocketAsync
    {
        // Thread signal.  
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        private int port;
        private string ip;
        private Func<string, string> ReceiveMethod;
        private Func<string, string> SendMethod;


        public SocketAsync(string ip, int port, Func<string, string> ReceiveMethod, Func<string, string> SendMethod)
        {
            this.ip = ip;
            this.port = port;
            this.ReceiveMethod = ReceiveMethod;
            this.SendMethod = SendMethod;
        }

        public void StartListening()
        {
            IPAddress ipAddress = IPAddress.Parse(ip);
            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);
                // Create a TCP/IP socket.  
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // Bind the socket to the local endpoint and listen for incoming connections.  
                listener.Bind(localEndPoint);
                listener.Listen(100);
                Thread listenerThread = new Thread(() =>
                {
                    while (true)
                    {
                        // Set the event to nonsignaled state.  
                        allDone.Reset();
                        // Start an asynchronous socket to listen for connections.  
                        Console.WriteLine("Waiting for a connection...");
                        listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                        // Wait until a connection is made before continuing.  
                        allDone.WaitOne();
                    }
                });
                listenerThread.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.   
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read   
                // more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the   
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    // Echo the data back to the client.  
                    Send(handler, content);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private void Send(Socket handler, string data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}