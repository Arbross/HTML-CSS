using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgBox_SimpleForm._WF_Intro
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }
        private void Quiz_Load(object sender, EventArgs e)
        {
            // Full screen
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Button X delete frame
            X.FlatAppearance.BorderSize = 0;
            X.FlatStyle = FlatStyle.Flat;

            // Button Run delete frame
            Run.FlatAppearance.BorderSize = 0;
            Run.FlatStyle = FlatStyle.Flat;

            // Button First Clicker delete frame
            FirstClicker.FlatAppearance.BorderSize = 0;
            FirstClicker.FlatStyle = FlatStyle.Flat;

            // Button Second Clicker delete frame
            SecondClicker.FlatAppearance.BorderSize = 0;
            SecondClicker.FlatStyle = FlatStyle.Flat;

            // Button +1% Opacity delete frame
            PlusOne.FlatAppearance.BorderSize = 0;
            PlusOne.FlatStyle = FlatStyle.Flat;

            // Button -1% Opacity delete frame
            OneMinus.FlatAppearance.BorderSize = 0;
            OneMinus.FlatStyle = FlatStyle.Flat;

            // Button Rnd Image delete frame
            RndImage.FlatAppearance.BorderSize = 0;
            RndImage.FlatStyle = FlatStyle.Flat;
        }
        private void Quiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void Run_Click(object sender, EventArgs e)
        {
            TempQuiz quiz = new TempQuiz();
            quiz.AddQuestion("Is it WF?", DialogResult.Yes);
            quiz.AddQuestion("Is it true?", DialogResult.Yes);
            quiz.AddQuestion("Is your name Steve?", DialogResult.No);
            quiz.AddQuestion("Is this hw hard?", DialogResult.No);

            quiz.Run();
        }
        private void X_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private int firstCounter = 0;
        private int secondCounter = 0;
        private void SecondClicker_Click(object sender, EventArgs e)
        {
            ++secondCounter;
            Output.Text = $"First counter : {firstCounter}, second counter : {secondCounter}";
        }
        private void FirstClicker_Click(object sender, EventArgs e)
        {
            ++firstCounter;
            Output.Text = $"First counter : {firstCounter}, second counter : {secondCounter}";
        }

        private void PlusOne_Click(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
        }

        private void OneMinus_Click(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
        }

        private void RndImage_Click(object sender, EventArgs e)
        {
            List<string> images = new List<string>();
            images.Add("image.png");
            images.Add("image1.png");
            images.Add("image2.png");

            Random rnd = new Random();
            Pictures.ImageLocation = images[rnd.Next(0, images.Count)];
        }
    }
}
