using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView._WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Category[] categs = (Category[])Enum.GetValues(typeof(Category));
            cbGroup.DataSource = categs;

            listView1.Groups.Add(new ListViewGroup("Middle"));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            decimal price = nudPrice.Value;
            decimal quantity = nudQuantity.Value;

            ListViewItem li = new ListViewItem(name);
            li.SubItems.AddRange(new string[] { price.ToString(), quantity.ToString() });
            li.ImageIndex = 0;
            li.Group = listView1.Groups[cbGroup.SelectedIndex];
            listView1.Items.Add(li);            
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new CmpProducts(e.Column);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            decimal price = nudPrice.Value;
            decimal quantity = nudQuantity.Value;

            listView1.Items[listView1.SelectedIndices[0]].Text = name;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text = price.ToString();
            listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = quantity.ToString();
        }
    }
}
