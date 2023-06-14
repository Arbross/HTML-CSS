using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // reflection
            var colors = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.Name).ToArray(); // type of result 'Color' 
            cbColor.Items.AddRange(colors);
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromName(cbColor.SelectedItem as string);
        }
    }
}
