using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RndListBoxGenerate._WF
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

            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nmMin.Value > nmMax.Value)
            {
                MessageBox.Show("Error value, min is bigger than max value.");
                return;
            }
            Random rnd = new Random();
            for (int i = 0; i < nmCount.Value; i++)
            {
                lbNumbers.Items.Add(rnd.Next((int)nmMin.Value, (int)nmMax.Value));
            }
            GetResults();
        }
        private void GetResults()
        {
            double average = 0, product = 1, sum = 0;
                if ((string)cbTypes.SelectedItem == "Sum")
                {
                    foreach (var s in lbNumbers.SelectedItems)
                    {
                        sum += (int)s;
                    }
                    lblResult.Text = $"Result :\n" +
                             $"Sum : {sum}";
                }
                else if ((string)cbTypes.SelectedItem == "Product")
                {
                    foreach (var s in lbNumbers.SelectedItems)
                    {
                        product *= (int)s;
                    }
                    lblResult.Text = $"Result :\n" +
                             $"Product : {product}";
                }
                else if ((string)cbTypes.SelectedItem == "Average")
                {
                    foreach (var s in lbNumbers.SelectedItems)
                    {
                        average += (int)s;
                    }
                    average = average / lbNumbers.SelectedItems.Count;
                    lblResult.Text = $"Result :\n" +
                             $"Average : {average}";
                }
        }

        private void lbNumbers_SelectedValueChanged(object sender, EventArgs e)
        {
            GetResults();
        }
    }
}
