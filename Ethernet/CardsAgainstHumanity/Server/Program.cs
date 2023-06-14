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
        private static int Port;
        private static IPAddress Address;
        private static string RoomPassword;

        static void Main(string[] args)
        {
            EnterData(ref Port, ref Address, ref RoomPassword);
            Server(Port, Address);
        }

        private static void EnterData(ref int port, ref IPAddress address, ref string roomPassword)
        {
            Console.Write($"Enter port : "); port = int.Parse(Console.ReadLine());
            Console.Write($"Enter address : "); address = IPAddress.Parse(Console.ReadLine());
            Console.Write($"Enter room password : "); roomPassword = Console.ReadLine();
        }

        private static void Server(int port, IPAddress address)
        {
            TcpListener server = new TcpListener(address, port);
            server.Start();

            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();

                    BinaryFormatter formatter = new BinaryFormatter();
                    PlayerInfo info = formatter.Deserialize(client.GetStream()) as PlayerInfo;

                    if (info != null)
                    {
                        if (info.RoomPassword != RoomPassword)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            File.WriteAllText($"error-log-{DateTime.UtcNow.TimeOfDay}.txt", $"[ERROR][{DateTime.UtcNow.TimeOfDay}] {info.Name} room password doesn't equeal server password.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"[ERROR][{DateTime.UtcNow.TimeOfDay}] {info.Name} room password doesn't equeal server password.");
                        }

                        Console.WriteLine("Weeeee");
                    }
                    else
                    {
                        File.WriteAllText($"error-log-{DateTime.UtcNow.TimeOfDay}.txt", $"[ERROR][{DateTime.UtcNow.TimeOfDay}] Error loading file.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"[ERROR][{DateTime.UtcNow.TimeOfDay}] Working server error loading file by error.");
                    }
                }
                catch (Exception ex)
                {
                    File.WriteAllText($"error-log-{DateTime.UtcNow.TimeOfDay}.txt", $"[ERROR][{DateTime.UtcNow.TimeOfDay}] {ex}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Server stops working by error.");
                }

                server.Stop();
            }
        }
    }
}
