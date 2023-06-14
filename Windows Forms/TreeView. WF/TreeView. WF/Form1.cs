using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView._WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = new TreeNode(textBox1.Text);
            treeNode.SelectedImageIndex = 5;
            if (treeView1.Nodes == null)
            {
                treeView1.Nodes.Add(treeNode);
            }
            else
            {
                treeView1.SelectedNode.Nodes.Add(treeNode);
                treeView1.SelectedNode.Expand();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes == null)
            {
                return;
            }
            treeView1.SelectedNode.Nodes.Remove(treeView1.SelectedNode);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            statusStrip1.Text = $"{e.Node}, Checked : {e.Node.Checked}, {e.Node.FullPath}, {e.Action}";
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Add("Noname");
        }
    }
}
