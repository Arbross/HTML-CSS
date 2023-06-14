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
using System.Windows;
using System.Windows.Controls;

namespace Messenger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserInfo info = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private static void GetMessages(IPEndPoint endPoint, ref ListBox listBox)
        {
            TcpListener server = new TcpListener(endPoint);
            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                BinaryFormatter serializer = new BinaryFormatter();
                UserInfo info = (UserInfo)serializer.Deserialize(client.GetStream());

                listBox.Items.Add(info);
            }
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            UserInfo user = new UserInfo(tbIPPort.Text);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(user.IP), int.Parse(user.Port));
            info = new UserInfo(tbUser.Text, tbPassword.Text, tbIPPort.Text, tbMessage.Text, endPoint);
            TcpClient client = new TcpClient();

            Task.Run(() => GetMessages(endPoint, ref lbMessageHistory));

            try
            {
                client.Connect(endPoint);

                BinaryFormatter serializer = new BinaryFormatter();
                using (NetworkStream stream = client.GetStream())
                {
                    serializer.Serialize(stream, info);
                }

                WinConnect.Visibility = Visibility.Hidden;
                WinConnect.IsEnabled = false;

                WinMessanger.Visibility = Visibility.Visible;
                WinMessanger.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            info.Message = tbMessage.Text;
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(info.EndPoint);

                BinaryFormatter serializer = new BinaryFormatter();
                using (NetworkStream stream = client.GetStream())
                {
                    serializer.Serialize(stream, info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }
    }
}
