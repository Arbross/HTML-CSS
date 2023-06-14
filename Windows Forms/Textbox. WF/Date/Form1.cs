using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbInfo.Text = Convert.ToString($"Date : {dateTimePicker1.Value}");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays((int)numericUpDown1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            ranDate.Text = $"Start : {e.Start, 20}, End : {e.End, 20}";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime birth = dateTimePicker1.Value;
            Person p = new Person { Name = name, Birth = birth };
            lb.Items.Add(p);
        }
    }
}
