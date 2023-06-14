using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrackBar._WF
{
    public partial class Form1 : Form
    {
        // List for votes(trackBars)
        private List<Vote> votes;
        private int currentIndexOfVote;
        public Form1()
        {
            InitializeComponent();
            votes = new List<Vote>();
            if (!File.Exists("test.dat"))
            {
                votes.Add(new Vote(new Bitmap(Image.FromFile(@"../../../Images/mars_seasons.jpg")), 0, 0, @"../../../Images/mars_seasons.jpg", "Seasons"));
                votes.Add(new Vote(new Bitmap(Image.FromFile(@"../../../Images/mars_colony.jpg")), 0, 0, @"../../../Images/mars_colony.jpg", "Colony"));
            }
            if (File.Exists("test.dat"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Vote>));
                using (TextReader tr = new StreamReader("test.dat"))
                {
                    votes = (List<Vote>)xs.Deserialize(tr);
                    foreach (var item in votes)
                    {
                        item.Load();
                    }
                }
            }

        }
        // btnYes
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (pbImages.Image != null)
            {
                votes[currentIndexOfVote].YesVotes++;
                tbYes.Maximum++;
                tbNo.Maximum++;
                tbYes.Value++;
                lblCounterYes.Text = $"{tbYes.Value}/{tbYes.Maximum}";
                lblCounterNo.Text = $"{tbNo.Value}/{tbNo.Maximum}";
            }
            else
            {
                MessageBox.Show("Select the image.", "Info", MessageBoxButtons.OK);
            }
        }
        // btnNo
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (pbImages.Image != null)
            {
                votes[currentIndexOfVote].NoVotes++;
                tbNo.Maximum++;
                tbYes.Maximum++;
                tbNo.Value++;
                lblCounterYes.Text = $"{tbYes.Value}/{tbYes.Maximum}";
                lblCounterNo.Text = $"{tbNo.Value}/{tbNo.Maximum}";
            }
            else
            {
                MessageBox.Show("Select the image.", "Info", MessageBoxButtons.OK);
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndexOfVote = 0;
            niMax.Icon = new Icon(@"../../../Images/robot.ico");
            niMax.Text = votes[currentIndexOfVote].Name;
            pbImages.Image = votes[currentIndexOfVote].Image;
            tbYes.Value = votes[currentIndexOfVote].YesVotes;
            tbNo.Value = votes[currentIndexOfVote].NoVotes;
            tbNo.Maximum = tbYes.Value + tbNo.Value;
            tbYes.Maximum = tbYes.Value + tbNo.Value;
            lblCounterYes.Text = $"{tbYes.Value}/{tbYes.Maximum}";
            lblCounterNo.Text = $"{tbNo.Value}/{tbNo.Maximum}";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndexOfVote = votes.Count - 1;
            niMax.Icon = new Icon(@"../../../Images/robot.ico");
            niMax.Text = votes[currentIndexOfVote].Name;
            pbImages.Image = votes[currentIndexOfVote].Image;
            tbYes.Value = votes[currentIndexOfVote].YesVotes;
            tbNo.Value = votes[currentIndexOfVote].NoVotes;
            tbNo.Maximum = tbYes.Value + tbNo.Value;
            tbYes.Maximum = tbYes.Value + tbNo.Value;
            lblCounterYes.Text = $"{tbYes.Value}/{tbYes.Maximum}";
            lblCounterNo.Text = $"{tbNo.Value}/{tbNo.Maximum}";
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndexOfVote != votes.Count - 1)
            {
                currentIndexOfVote++;
                niMax.Icon = new Icon(@"../../../Images/robot.ico");
                niMax.Text = votes[currentIndexOfVote].Name;
                pbImages.Image = votes[currentIndexOfVote].Image;
                tbYes.Value = votes[currentIndexOfVote].YesVotes;
                tbNo.Value = votes[currentIndexOfVote].NoVotes;
                tbNo.Maximum = tbYes.Value + tbNo.Value;
                tbYes.Maximum = tbYes.Value + tbNo.Value;
                lblCounterYes.Text = $"{tbYes.Value}/{tbYes.Maximum}";
                lblCounterNo.Text = $"{tbNo.Value}/{tbNo.Maximum}";
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndexOfVote != 0)
            {
                currentIndexOfVote--;
                niMax.Icon = new Icon(@"../../../Images/robot.ico");
                niMax.Text = votes[currentIndexOfVote].Name;
                pbImages.Image = votes[currentIndexOfVote].Image;
                tbYes.Value = votes[currentIndexOfVote].YesVotes;
                tbNo.Value = votes[currentIndexOfVote].NoVotes;
                tbNo.Maximum = tbYes.Value + tbNo.Value;
                tbYes.Maximum = tbYes.Value + tbNo.Value;
                lblCounterYes.Text = $"{tbYes.Value}/{tbYes.Maximum}";
                lblCounterNo.Text = $"{tbNo.Value}/{tbNo.Maximum}";
            }
        }
        private Size size;
        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            size = this.Size;
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Size.Width > size.Width && this.Size.Height > size.Height)
            {
                niMax.ShowBalloonTip(50, niMax.BalloonTipTitle, niMax.BalloonTipText, ToolTipIcon.Info);
            }
            else
            {
                this.Hide();
                niMax.ShowBalloonTip(50, niMax.BalloonTipTitle, "You're minimise this form. Also the program puts in a tray.", ToolTipIcon.Info);
                this.Show();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Vote>));
            using (TextWriter tw = new StreamWriter("test.dat"))
            {
                xs.Serialize(tw, votes);
            }
        }
    }
}
