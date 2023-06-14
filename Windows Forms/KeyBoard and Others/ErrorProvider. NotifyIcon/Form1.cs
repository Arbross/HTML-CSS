using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider._NotifyIcon
{
    public partial class Form1 : Form
    {
        int compNumber;
        public Form1()
        {
            InitializeComponent();
            compNumber = new Random().Next(1, 11);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userNumber = int.Parse(textBox1.Text);
            if (userNumber == compNumber)
            {
                errorProvider2.SetError(textBox1, "You have guessed number!");
                errorProvider1.SetError(textBox1, String.Empty);
            }
            else if (compNumber > userNumber)
            {
                errorProvider1.SetError(textBox1, ":/ My number is greater than yours");
            }
            else
            {
                errorProvider1.SetError(textBox1, ":/ My number is greater than yours");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            fastNotifty.Visible = true;
            fastNotifty.ShowBalloonTip(500);
            this.Hide();
        }

        private void fastNotifty_DoubleClick(object sender, EventArgs e)
        {
            fastNotifty.Visible = true;
            this.Show();
        }
    }
}
