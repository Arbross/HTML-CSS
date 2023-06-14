using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox._WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> accounts;
        private void Form1_Load(object sender, EventArgs e)
        {
            accounts = new Dictionary<string, string>()
            {
                ["user"] = "1",
                ["admin"] = "admin",
                ["ulia"] = "1",
                ["root"] = "root"
            };
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;
            if (accounts.ContainsKey(login))
            {
                if (accounts[login] == password)
                {
                    MessageBox.Show("OK authorization");
                    TVEditor.Enabled = true;
                    Login.Enabled = false;
                    Password.Enabled = false;
                    return;
                }
                MessageBox.Show("User not found");
                Login.Focus();
                Login.Clear();
            }
        }

        private void TVEditor_TextChanged(object sender, EventArgs e)
        {
            Info.Text = $"Total symbols : {TVEditor.Text.Length}\n" + 
                        $"Total lines : {TVEditor.Lines.Length}";
        }

        private void TVEditor_MouseCaptureChanged(object sender, EventArgs e)
        {
            Selected.Text = $"Selection start : {TVEditor.SelectionStart},\n {TVEditor.SelectionLength},\n {TVEditor.SelectedText}";
        }

        private void TVEditor_KeyDown(object sender, KeyEventArgs e)
        {
            TVEditor_MouseCaptureChanged(sender, null);
        }
    }
}
