using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        private static DALModel model = new DALModel();

        private static int Port = 8080;
        private static string IP = "127.0.0.1";
        static void Main(string[] args)
        {
            IPAddress iPAddress = IPAddress.Parse(IP);
            IPEndPoint ipPoint = new IPEndPoint(iPAddress, Port);

            EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                listenSocket.Bind(ipPoint);

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Server started! Waiting for request...");

                    int bytes = 0;
                    byte[] data = new byte[1024];
                    bytes = listenSocket.ReceiveFrom(data, ref remoteEndPoint);

                    string msg = Encoding.Unicode.GetString(data, 0, bytes);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"[INFO][{DateTime.Now.ToLocalTime()}] {msg} from {remoteEndPoint}");

                    string tmp = msg.ToLower();
                    string message = null;
                    if (tmp.Contains("hello"))
                    {
                        Random rnd = new Random();

                        List<Message> list = model.Messages.Where(x => x.Categoria.UseCategoria.ToLower() == "hello").ToList();
                        List<int> indecies = new List<int>();
                        foreach (var item in list)
                        {
                            indecies.Add(item.Id);
                        }
                        message = list.Where(x => x.Id == rnd.Next(1, indecies.Count)).First().UseMessage;
                    }
                    
                    data = Encoding.Unicode.GetBytes(message);
                    listenSocket.SendTo(data, remoteEndPoint);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Message was send!");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR][{DateTime.Now.ToLocalTime()}] {ex.Message}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
