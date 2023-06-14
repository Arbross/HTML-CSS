using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MessageAnswer
    {
        public MessageAnswer() { }
        public MessageAnswer(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
