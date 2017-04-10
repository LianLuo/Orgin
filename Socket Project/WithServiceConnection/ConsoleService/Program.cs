using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace ConsoleService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceManager service = new ServiceManager();
            service.StartConnection();
            string inputInfo = string.Empty;
            while ((inputInfo = Console.ReadLine()) != "QUIT")
            {
                service.SendMsg(inputInfo);
            }
        }
    }

    class ServiceManager
    {
        Socket socketWatch;
        Thread threadWatch;
        Socket socketClient;

        public ServiceManager()
        {
            IPAddress address = IPAddress.Parse("192.168.1.104");
            IPEndPoint endPoint = new IPEndPoint(address, 5000);
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch.Bind(endPoint);
            Console.WriteLine("Service has start.");
        }

        public void StartConnection()
        {
            socketWatch.Listen(10);
            socketClient = socketWatch.Accept();
            threadWatch = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        byte[] rec = new byte[1024 * 1024];
                        int index = socketClient.Receive(rec);
                        if (index > 0)
                        {
                            string msg = Encoding.UTF8.GetString(rec, 0, index);
                            Console.WriteLine("Rec from client Info:{0}", msg);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Rec from client Exception:{0}", e.Message);
                }
            });
            threadWatch.IsBackground = true;
            threadWatch.Start();
        }

        public void SendMsg(string msg)
        {
            try
            {
                byte[] sendmsg = Encoding.UTF8.GetBytes(msg);
                if (socketClient != null)
                {
                    socketClient.Send(sendmsg);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine("send to client Exception:", e.Message);
            }
        }
    }
}
