using Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        private static List<UserInfo> userInfo = new List<UserInfo>();
        private static List<string> messages = new List<string>();

        private static IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
        private static int port = 7777;

        private static string RoomPassword;
        static void Main(string[] args)
        {
            Console.Write("Enter room password : "); RoomPassword = Console.ReadLine();
            Console.Write("Enter ip : "); iPAddress = IPAddress.Parse(Console.ReadLine());
            try
            {
                Console.Write("Enter port : "); port = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                throw;
            }
            
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, port);

            TcpListener server = new TcpListener(localEndPoint);
            server.Start(10);

            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();

                    BinaryFormatter serializer = new BinaryFormatter();
                    UserInfo info = (UserInfo)serializer.Deserialize(client.GetStream());

                    if (info.RoomPassword != RoomPassword)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception($"[ERROR][{DateTime.UtcNow.TimeOfDay}] User : {info.Name} from {client.Client.RemoteEndPoint}. Can't enter true password.");
                    }

                    foreach (UserInfo item in userInfo)
                    {
                        if (Convert.ToString(item.EndPoint) == Convert.ToString(info.EndPoint))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"[INFO][{DateTime.UtcNow.TimeOfDay}] User {info.Name} from {client.Client.RemoteEndPoint} has been connected.");

                            if (info.Message != null && info.Message != string.Empty)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"[INFO][{DateTime.UtcNow.TimeOfDay}] Message has been got by {info.Name}, {client.Client.RemoteEndPoint}.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new Exception($"[ERROR][{DateTime.UtcNow.TimeOfDay}] User : {info.Name} from {client.Client.RemoteEndPoint}. Message is equeal null or it is empty.");
                            }

                            foreach (UserInfo user in userInfo)
                            {
                                if (user.EndPoint != info.EndPoint)
                                {
                                    BinaryFormatter binary = new BinaryFormatter();

                                    NetworkStream stream = client.GetStream();
                                    serializer.Serialize(stream, info);
                                }
                            }
                        }
                    }

                    if (userInfo.Exists(x => x.Name == info.Name) == false)
                    {
                        userInfo.Add(info);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"[INFO][{DateTime.UtcNow.TimeOfDay}] User {info.Name} from {client.Client.RemoteEndPoint} has been registered.");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[ERROR][{DateTime.UtcNow.TimeOfDay}] {ex.Message}");
                }
                finally
                {
                    Console.ResetColor();
                }
            }
        }
    }
}
