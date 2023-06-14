using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum CommandType
    {
        WAIT,    // очікування (опонента)
        START,   // початок гри
        RESTART, // перезапуск гри
        MOVE,    // хід
        CLOSE,   // закриття сесії на сервері
        EXIT,    // закриття гри
    }

    public class ServerCommand
    {
        public CommandType Type { get; set; }
        public MessageAnswer messageAnswer { get; set; }

        public ServerCommand(CommandType type)
        {
            this.Type = type;
            messageAnswer = new MessageAnswer();
        }

        public ServerCommand(CommandType type, string question, string answer)
        {
            this.Type = type;
            messageAnswer = new MessageAnswer(question, answer);
        }
    }
}
