using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Full screen
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Button Start delete frame
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;

            // Button Stop delete frame
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
        }
        private void trafficTimer_Tick(object sender, EventArgs e)
        {
            if (trafficTimer.Enabled)
            {
                if (trafficTimer.Interval >= 1500 && trafficTimer.Interval <= 2000)
                {
                    Yellow.BackColor = Color.FromArgb(255, 255, 255);
                    Green.BackColor = Color.FromArgb(255, 255, 255);
                    Red.BackColor = Color.FromArgb(255, 0, 0);
                    state.Text = "Red. Stop";
                }
                else if (trafficTimer.Interval >= 500 && trafficTimer.Interval <= 1000)
                {
                    Green.BackColor = Color.FromArgb(255, 255, 255);
                    Red.BackColor = Color.FromArgb(255, 255, 255);
                    Yellow.BackColor = Color.FromArgb(255, 255, 0);
                    state.Text = "Yellow. Wait";
                }
                else if (trafficTimer.Interval >= 2500 && trafficTimer.Interval <= 3000)
                {
                    Green.BackColor = Color.FromArgb(255, 255, 255);
                    Red.BackColor = Color.FromArgb(255, 255, 255);
                    Yellow.BackColor = Color.FromArgb(255, 255, 0);
                    state.Text = "Yellow. Wait";
                }
                else if (trafficTimer.Interval >= 3500 && trafficTimer.Interval <= 4000)
                {
                    Red.BackColor = Color.FromArgb(255, 255, 255);
                    Yellow.BackColor = Color.FromArgb(255, 255, 255);
                    Green.BackColor = Color.FromArgb(0, 128, 0);
                    state.Text = "Green. Go";
                    trafficTimer.Interval = 500;
                }
                trafficTimer.Interval += 500;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            trafficTimer.Enabled = true;
            trafficTimer.Interval = 1500;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            if (trafficTimer.Enabled)
            {
                trafficTimer.Enabled = false;
                Red.BackColor = Color.FromArgb(255, 255, 255);
                Yellow.BackColor = Color.FromArgb(255, 255, 255);
                Green.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

    }
}
