using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Info_MouseEnter(object sender, EventArgs e)
        {
            //Info.Left += rnd.Next(-100, 100); // x
            //Info.Top += rnd.Next(-100, 100); // y

            Info.Left = rnd.Next(0, this.ClientSize.Width - Info.Width);
            Info.Top = rnd.Next(ClientSize.Height - Info.Height);
            Info.Size = new Size(rnd.Next(100, 200), rnd.Next(100, 200));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            // timer1.Enabled = true; // okay too
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            // timer1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }
        int step = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Info.Left > this.ClientSize.Width - Info.Width)
            {
                Info.Left = 0;
            }
            else
            {
                Info.Left += step;
            }
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (timer1.Interval > 100)
                {
                    timer1.Interval -= 50;
                }
                step += 10;
            }
        }
    }
}
