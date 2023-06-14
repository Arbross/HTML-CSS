using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class PlayerInfo
    {
        private string ip { get; set; }
        private string port { get; set; }

        public PlayerInfo(string name, string roomPassword, string ipPort)
        {
            Name = name;
            RoomPassword = roomPassword;
            IP = ipPort;
            Port = ipPort;
        }

        public string Name { get; set; }
        public string IP
        {
            get => ip;
            set
            {
                ip = string.Empty;
                foreach (char item in value)
                {
                    if (item == ':')
                    {
                        break;
                    }
                    ip += item;
                }
            }
        }
        public string Port
        {
            get => port;
            set
            {
                port = string.Empty;
                foreach (char item in value.Reverse())
                {
                    if (item == ':')
                    {
                        break;
                    }
                    port += item;
                }

                string tmp = string.Empty;
                foreach (char item in port.Reverse())
                {
                    tmp += item;
                }
                port = tmp;
            }
        }
        public string RoomPassword { get; set; }

        // метод для відправки об'єкту команди
        private void Send()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // formatter.Serialize(TcpClient.GetStream(), this);
        }

        //public void SendCloseCommand()
        //{
        //    SendCommand(new ServerCommand(CommandType.CLOSE));
        //}
        //public void SendWaitCommand()
        //{
        //    SendCommand(new ServerCommand(CommandType.WAIT));
        //}
        //public void SendStartCommand(string opponentName)
        //{
        //    ServerCommand command = new ServerCommand(CommandType.START);
        //    SendCommand(command);
        //}
        // метод отримання команди від сервера
        //public ClientCommand ReceiveCommand()
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    return (ClientCommand)formatter.Deserialize(TcpClient.GetStream());
        //}
    }
}
