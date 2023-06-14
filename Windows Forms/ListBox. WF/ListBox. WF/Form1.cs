using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox._WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;

            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;

            foreach (SelectionMode item in Enum.GetValues(typeof(SelectionMode)))
            {
                cbSelMode.Items.Add(item);
            }
            cbSelMode.SelectedItem = SelectionMode.One;
            lbProducts.SelectionMode = SelectionMode.One;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameProd = mtbProduct.Text;
            if (!lbProducts.Items.Contains(nameProd))
            {
                lbProducts.Items.Add(nameProd);
            }
            mtbProduct.Clear();
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = string.Empty;
            if (lbProducts.SelectedItem != null)
            {
                //result = $"Selected product : {lbProducts.SelectedItem}\n" +
                //         $"Index : {lbProducts.SelectedIndex}";
                result = $"Selected products :\n" +
                    $"{String.Join(", ", lbProducts.SelectedItems.Cast<string>())}";
                result += $"\nSelected indecied :\n" +
                    $"{String.Join(", ", lbProducts.SelectedIndices.Cast<int>())}";
                lblSelected.Text = result;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (lbProducts.SelectedIndex != -1)
            {
                System.Diagnostics.Debug.WriteLine($"---remove--- {lbProducts.SelectedItems}");
                lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
            }
        }

        private void cbSelMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProducts.SelectionMode = SelectionMode.One;
        }
    }
}
