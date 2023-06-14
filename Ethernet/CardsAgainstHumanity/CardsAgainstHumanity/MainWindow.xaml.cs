using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CardsAgainstHumanity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JoinGame_Click(object sender, RoutedEventArgs e)
        {
            WinMain.Visibility = Visibility.Hidden;
            WinJoinGame.Visibility = Visibility.Visible;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            TcpClient client = new TcpClient();
            PlayerInfo playerInfo = new PlayerInfo(tbName.Text, tbPasswordRoom.Text, tbIPPort.Text, client);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(playerInfo.IP), int.Parse(playerInfo.Port));

            try
            {
                client.Connect(endPoint);

                BinaryFormatter serializer = new BinaryFormatter();
                using (NetworkStream stream = client.GetStream())
                {
                    serializer.Serialize(stream, playerInfo);
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
