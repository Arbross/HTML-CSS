using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgBox_SimpleForm._WF_Intro
{
    public class TempQuiz
    {
        private List<Question> questions;
        public List<Question> Questions
        {
            get => questions;
            set => questions = value;
        }
        public TempQuiz()
        {
            questions = new List<Question>();
        }
        public void AddQuestion(string question, DialogResult answer)
        {
            questions.Add(new Question(question, answer));
        }
        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }
        public void Run()
        {
            int counter = 0;
            foreach (var list in questions)
            {
                DialogResult result = MessageBox.Show(list.PQuestion, "Quiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    break;
                }
                if (list.Answer == result)
                {
                    ++counter;
                }
            }
            MessageBox.Show($"Result : {counter}/{questions.Count}", "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
