using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game._CatchIt._WF
{
    public partial class Form1 : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private Bitmap personTexture = Properties.Resources.person;
        private int score = 0, name = 0;
        bool isMove = false;
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

            // Visibility
            pbPlayer.Enabled = false;
            pbPlayer.Visible = false;
            lblCounter.Enabled = false;
            lblCounter.Visible = false;
            lblTimer.Enabled = false;
            lblTimer.Visible = false;

            // Optimize moves of player
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer
                        | ControlStyles.AllPaintingInWmPaint
                        | ControlStyles.UserPaint, true);
            this.UpdateStyles(); // Update them
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Turn on the timer
            if (!Time.Enabled)
            {
                Time.Enabled = true;
            }

            // Moves of keyboard
            if (e.KeyCode == Keys.A)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 30, pbPlayer.Location.Y);
            }
            if (e.KeyCode == Keys.W)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X, pbPlayer.Location.Y - 30);
            }
            if (e.KeyCode == Keys.D)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 30, pbPlayer.Location.Y);
            }
            if (e.KeyCode == Keys.S)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X, pbPlayer.Location.Y + 30);
            }
            this.Refresh(); // Invoke method 'Paint()'
        }
        private void RndPlaceCoins()
        {
            Random random = new Random();
            PictureBox picture = new PictureBox();

            picture.Name = "picture" + (char)name++;
            picture.Size = new Size(50, 50);
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            picture.BackColor = Color.Transparent;

            int count = random.Next(0, 2);
            if (count == 0)
            {
                picture.BackgroundImage = Image.FromFile("../../../Properties/Image/coffee.png");
            }
            else
            {
                picture.BackgroundImage = Image.FromFile("../../../Properties/Image/coffee_2.png");
            }
            picture.Location = new Point(random.Next(0, 1920), random.Next(0, 1080));
            pictureBoxes.Add(picture);
            Controls.Add(picture);
        }
        private void VisibilityFinish()
        {
            isMove = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;
            pbPlayer.Enabled = false;
            pbPlayer.Visible = false;
            lblCounter.Enabled = false;
            lblCounter.Visible = false;
            lblTimer.Enabled = false;
            lblTimer.Visible = false;
            Time.Enabled = false;
            Time.Interval = 1000;
            score = 0;
            lblCounter.Text = "Score : 0/60";
            lblTimer.Text = "Time : 0/60";
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            // Our timer

            // Finish by score
            if (score == 20)
            {
                VisibilityFinish();
                MessageBox.Show("You are the winner!\n You collect all points {score}/20!", $"The End!", MessageBoxButtons.OK);
            }

            // Finish by time
            if (Time.Interval == 60000)
            {
                VisibilityFinish();
                MessageBox.Show("You collect {score}/20 points.", $"The End!", MessageBoxButtons.OK);
            }
            lblTimer.Text = $"Time : {Time.Interval / 1000}/60";
            Time.Interval += 1000;
            RndPlaceCoins();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Show and hide different objects to start a game
            isMove = true;
            pbPlayer.Enabled = false;
            lblTimer.Enabled = true;
            pbPlayer.Visible = false;
            lblTimer.Visible = true;
            lblCounter.Enabled = true;
            lblCounter.Visible = true;

            btnStart.Enabled = false;
            btnStart.Visible = false;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isMove)
            {
                // Draw player moves
                Graphics graphics = e.Graphics;
                var playerRectangle = new Rectangle(pbPlayer.Location.X, pbPlayer.Location.Y, 100, 100);
                playerRectangle.Width = 72;
                playerRectangle.Height = 122;
                graphics.DrawImage(personTexture, playerRectangle);

                // Collect process of coins
                CollectCoins(playerRectangle);
            }
        }
        private void CollectCoins(Rectangle playerRectangle)
        {
            foreach (var item in pictureBoxes)
            {
                // Check the collision of label(our coins) and rectangle of player
                Rectangle rectangle = item.Bounds;
                if (playerRectangle.IntersectsWith(rectangle))
                {
                    // Remove need coin from 'Form1', 'List<PictureBox>' and plus our 'score'
                    Controls.Remove(item);
                    pictureBoxes.Remove(item);
                    lblCounter.Text = $"Score : {++score}";
                    break;
                }
            }
        }
    }
}
