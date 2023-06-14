using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
        static int port = 7777;
        static void Main(string[] args)
        {
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, port);
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);

            UdpClient server = new UdpClient(localEndPoint);

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\tWaiting for screen...");

                    byte[] data = server.Receive(ref clientEndPoint);
                    string fileName = Encoding.Unicode.GetString(data);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Got a file: " + fileName);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Saving...");

                    byte[] fileData = server.Receive(ref clientEndPoint);
                    using (Bitmap fs = new Bitmap(new MemoryStream(fileData)))
                    {
                        fs.Save(fileName);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Saved!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ResetColor();
                }
            }
        }
    }
}
