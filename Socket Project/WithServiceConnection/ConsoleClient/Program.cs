using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientManager client = new ClientManager();
            client.StartThread();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "QUIT")
            {
                client.SendMsg(input);
            }
        }
    }

    class ClientManager
    {
        Socket socketClient;
        Thread threadClient;
        public ClientManager()
        {
            try
            {
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress address = IPAddress.Parse("127.0.0.1");
                IPEndPoint endPoint = new IPEndPoint(address, 5000);
                // connection service address:port
                socketClient.Connect(endPoint);
                Console.WriteLine("connection service success.");
            }
            catch (Exception e)
            {
                Console.WriteLine("conntion service exception:", e.Message);
            }
        }

        /// <summary>
        /// start thread to listen information from service
        /// </summary>
        public void StartThread()
        {
            threadClient = new Thread(WatchMsg);
            threadClient.IsBackground = true;
            threadClient.Start();
        }

        private void WatchMsg()
        {
            while (true)
            {
                try
                {
                    // assign 2M space to receive data
                    byte[] rec = new byte[1024 * 1024 * 2];
                    int index = socketClient.Receive(rec);
                    if (index > 0)
                    {
                        string msg = Encoding.UTF8.GetString(rec, 0, index);
                        Console.WriteLine("service say:{0}", msg);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("rec service exception:", e.Message);
                }                
            }
        }

        /// <summary>
        /// client send msg to service
        /// </summary>
        /// <param name="msg"></param>
        public void SendMsg(string msg)
        {
            try
            {
                byte[] send = Encoding.UTF8.GetBytes(msg);
                socketClient.Send(send);
            }
            catch (Exception e)
            {
                Console.WriteLine("send to service exception:", e.Message);
            }
        }
    }
}
