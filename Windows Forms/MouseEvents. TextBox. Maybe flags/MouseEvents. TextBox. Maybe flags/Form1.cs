using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvents._TextBox._Maybe_flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int size = 10;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Location : {e.Location}, Buttons : {e.Button}";

            //Label lbl = new Label();
            //lbl.Size = new Size(size, size);
            //if (e.Button == MouseButtons.Left)
            //{
            //    lbl.BackColor = Color.Red;
            //    lbl.Location = e.Location;
            //}

            //this.Controls.Add(lbl);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Label lbl = new Label();
            lbl.Size = new Size(size, size);
            if (e.Button == MouseButtons.Left)
            {
                lbl.BackColor = Color.White;
                lbl.Location = e.Location;
            }

            this.Controls.Add(lbl);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = new Label();
            lbl.Size = new Size(size, size);
            if (e.Button == MouseButtons.Left)
            {
                lbl.BackColor = Color.Red;
                lbl.Location = e.Location;
            }

            panel1.Controls.Add(lbl);
        }
    }
}
