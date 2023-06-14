using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoard_and_Others
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            icon = new PictureBox();
            icon.Size = new Size(3, 3);
            icon.BackgroundImageLayout = ImageLayout.Stretch;
            icon.Image = Image.FromFile(@"../../../Images/robot.ico");
            icon.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lblInfo.Text += $"KeyDown : {e.KeyCode}\tAlt : {e.Alt}\tShift : {e.Shift}\tCtrl : {e.Control}\n";
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                MessageBox.Show("!!!");
                e.Handled = true;
            }
            
            if (e.KeyCode == Keys.Home)
            {
                icon.Location = new Point(0, 0);
            }
            else if (e.KeyCode == Keys.End)
            {
                icon.Location = new Point(this.ClientSize.Width, 0);
            }

            if (e.KeyCode == Keys.Add)
            {
                // icon.Image.Size = new Size(icon.Size.Height + 1, icon.Size.Width + 1);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                icon.Size = new Size(icon.Size.Height - 1, icon.Size.Width - 1);
            }
                if (e.KeyCode == Keys.A && e.Alt)
                {
                    icon.Location = new Point(icon.Location.X - 20, icon.Location.Y);
                }
                else if (e.KeyCode == Keys.W && e.Alt)
                {
                    icon.Location = new Point(icon.Location.X, icon.Location.Y - 20);
                }
                else if (e.KeyCode == Keys.D && e.Alt)
                {
                    icon.Location = new Point(icon.Location.X + 20, icon.Location.Y);
                }
                else if (e.KeyCode == Keys.S && e.Alt)
                {
                    icon.Location = new Point(icon.Location.X, icon.Location.Y + 20);
                }
                if (e.KeyCode == Keys.A)
                {
                    icon.Location = new Point(icon.Location.X - 5, icon.Location.Y);
                }
                else if (e.KeyCode == Keys.W)
                {
                    icon.Location = new Point(icon.Location.X, icon.Location.Y - 5);
                }
                else if (e.KeyCode == Keys.D)
                {
                    icon.Location = new Point(icon.Location.X + 5, icon.Location.Y);
                }
                else if (e.KeyCode == Keys.S)
                {
                    icon.Location = new Point(icon.Location.X, icon.Location.Y + 5);
                }
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblInfo.Text += $"KeyPress Char : {e.KeyChar} code of char{(int)e.KeyChar}\n";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            lblInfo.Text += $"KeyUp : {e.KeyCode}\tAlt : {e.Alt}\tShift : {e.Shift}\tCtrl : {e.Control}\n";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // no access list of numbers()
            }
        }
        private PictureBox icon;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(icon.Image, icon.Location.X, icon.Location.Y);
        }
    }
}
