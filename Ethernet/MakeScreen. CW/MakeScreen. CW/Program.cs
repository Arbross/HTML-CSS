using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Drawing;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Drawing.Imaging;

namespace MakeScreen.CW
{
    class Program
    {
        private static void MakeScreen(string path)
        {
            double screenLeft = SystemParameters.VirtualScreenLeft / 3;
            double screenTop = SystemParameters.VirtualScreenTop / 3;
            double screenWidth = SystemParameters.VirtualScreenWidth / 3;
            double screenHeight = SystemParameters.VirtualScreenHeight / 3;

            using (Bitmap bmp = new Bitmap((int)screenWidth, (int)screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";
                    g.CopyFromScreen((int)screenLeft, (int)screenTop, 0, 0, bmp.Size);
                    bmp.Save(filename);
                    //CompresImage(filename);
                    path = filename;
                }
            }
            // File.Delete(path);

            SendToTheServer(/*Path.GetFileName(path) + ".jpg"*/path);
        }

        private static void SendToTheServer(string path)
        {
            if (path == null) return;
            string FileName = System.IO.Path.GetFileName(path);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse("7777"));

            UdpClient client = new UdpClient();

            try
            {
                client.Connect(endPoint);

                byte[] data = Encoding.Unicode.GetBytes(FileName);
                client.Send(data, data.Length);

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    byte[] fileData = new byte[fs.Length];
                    fs.Read(fileData, 0, fileData.Length);

                    client.Send(fileData, fileData.Length);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Screen successfuly sended!");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        static void CompresImage(string path)
        {
            Image img = Image.FromFile(path);
            img.Save(Path.GetFileName(path) + ".jpg", ImageFormat.Jpeg);
        }

        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                string path = null;
                MakeScreen(path);
                ++i;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i} done.");
                Thread.Sleep(3000);
            }
        }
    }
}
