using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Button
{
    public partial class SkillsQuiz : Form
    {
        public SkillsQuiz()
        {
            InitializeComponent();
        }

        private void java_CheckStateChanged(object sender, EventArgs e)
        {
            if (java.CheckState == CheckState.Checked)
            {
                java.Text = $"Strong knowledge Java";
            }
            else if (java.CheckState == CheckState.Indeterminate) 
            {
                java.Text = $"Middle knowledge Java";    
            }
            else
            {
                java.Text = $"Poor knowledge Java";
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            string result = null;
            foreach (CheckBox check in gbSkills.Controls)
            {
                if (!check.ThreeState)
                {
                    result += $"{check.Text} {check.Checked}" + Environment.NewLine;
                }
                else
                {
                    result += $"{check.Text} {check.CheckState}" + Environment.NewLine;
                }
            }
            foreach (RadioButton radio in enSkills.Controls)
            {
                if (radio.Checked)
                {
                    result += $"{radio.Text}" + Environment.NewLine;
                }
            }
            tbInfo.Text = result;
        }

        private void enSkills_Enter(object sender, EventArgs e)
        {
            foreach (CheckBox item in gbSkills.Controls)
            {
                if (item.Checked)
                {
                    Update();
                }
            }
        }
        private void Beginner_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                Update();
            }
        }

        private void java_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                Update();
            }
        }
    }
}
