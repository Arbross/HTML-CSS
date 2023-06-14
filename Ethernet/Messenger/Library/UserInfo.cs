using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class UserInfo
    {
        public UserInfo() { }
        public UserInfo(string name, string roomPassword, string ipPort, string message, IPEndPoint endPoint)
        {
            Name = name;
            RoomPassword = roomPassword;
            IP = ipPort;
            Port = ipPort;
            Message = message;
            EndPoint = endPoint;
        }
        public UserInfo(string ipPort)
        {
            IP = ipPort;
            Port = ipPort;
        }
        private string ip { get; set; }
        private string port { get; set; }


        public IPEndPoint EndPoint { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string RoomPassword { get; set; }
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
    }
}
