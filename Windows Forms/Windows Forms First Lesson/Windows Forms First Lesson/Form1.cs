using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_First_Lesson
{
    public partial class MoinCruft : Form
    {
        public MoinCruft()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            while (true)
            {
                DialogResult dr = MessageBox.Show("Would you like to color form?", "Event click", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                MessageBox.Show($"You choose : {DialogResult}", "Info", MessageBoxButtons.OK);
                if (dr == DialogResult.Abort)
                {
                    // this.BackColor = Color.LightBlue;
                    Random rnd = new Random();
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    BackColor = randomColor;
                    break;
                }
            }
            Start.Visible = true;
            lblInfo.Update();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Full screen
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form close", "Event FormClosed");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure?", "Closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        private void lblClick_Click(object sender, EventArgs e)
        {
            lblInfo.Text = $"Was clicked : {++counter}";
        }
    }
}
