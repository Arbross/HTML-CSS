using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Sockets.Class_Work
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int Port = 8080;
        private static string IP = "127.0.0.1";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbIP.Text == String.Empty)
                {
                    IP = "127.0.0.1";
                }
                else
                {
                    IP = tbIP.Text;
                }

                if (tbPort.Text == String.Empty)
                {
                    Port = 8080;
                }
                else
                {
                    Port = int.Parse(tbPort.Text);
                }

                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(IP), Port);
                EndPoint remoteIpPoint = new IPEndPoint(IPAddress.Any, 0);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                byte[] data = Encoding.Unicode.GetBytes(tbMessage.Text);
                socket.SendTo(data, ipPoint);

                int bytes = 0;
                string response = "";
                data = new byte[1024];
                do
                {
                    bytes = socket.ReceiveFrom(data, ref remoteIpPoint);
                    response += Encoding.Unicode.GetString(data, 0, bytes);
                } while (socket.Available > 0);

                lbDialog.Items.Add(response);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
