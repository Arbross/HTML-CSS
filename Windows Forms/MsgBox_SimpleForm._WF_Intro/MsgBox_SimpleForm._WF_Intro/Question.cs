using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgBox_SimpleForm._WF_Intro
{
    public class Question
    {
        private string question;
        private DialogResult answer;
        public Question(string question, DialogResult answer)
        {
            PQuestion = question;
            Answer = answer;
        }
        public Question() : this("No question", default(DialogResult)) { }
        public string PQuestion
        {
            get => question;
            set => question = value;
        }
        public DialogResult Answer
        {
            get => answer;
            set => answer = value;
        }
    }
}
