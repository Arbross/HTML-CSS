
namespace MsgBox_SimpleForm._WF_Intro
{
    partial class Quiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.Run = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.FirstClicker = new System.Windows.Forms.Button();
            this.SecondClicker = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.PlusOne = new System.Windows.Forms.Button();
            this.OneMinus = new System.Windows.Forms.Button();
            this.RndImage = new System.Windows.Forms.Button();
            this.Pictures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.AutoSize = true;
            this.Run.BackColor = System.Drawing.Color.Transparent;
            this.Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Run.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Run.ForeColor = System.Drawing.Color.White;
            this.Run.Location = new System.Drawing.Point(12, 203);
            this.Run.Margin = new System.Windows.Forms.Padding(0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(287, 79);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run Quiz";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X.ForeColor = System.Drawing.SystemColors.Window;
            this.X.Location = new System.Drawing.Point(1698, 55);
            this.X.Margin = new System.Windows.Forms.Padding(0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(161, 60);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // FirstClicker
            // 
            this.FirstClicker.BackColor = System.Drawing.Color.Transparent;
            this.FirstClicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FirstClicker.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstClicker.ForeColor = System.Drawing.SystemColors.Window;
            this.FirstClicker.Location = new System.Drawing.Point(12, 296);
            this.FirstClicker.Name = "FirstClicker";
            this.FirstClicker.Size = new System.Drawing.Size(287, 76);
            this.FirstClicker.TabIndex = 2;
            this.FirstClicker.Text = "First Clicker";
            this.FirstClicker.UseVisualStyleBackColor = false;
            this.FirstClicker.Click += new System.EventHandler(this.FirstClicker_Click);
            // 
            // SecondClicker
            // 
            this.SecondClicker.BackColor = System.Drawing.Color.Transparent;
            this.SecondClicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SecondClicker.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondClicker.ForeColor = System.Drawing.Color.White;
            this.SecondClicker.Location = new System.Drawing.Point(12, 378);
            this.SecondClicker.Name = "SecondClicker";
            this.SecondClicker.Size = new System.Drawing.Size(287, 76);
            this.SecondClicker.TabIndex = 3;
            this.SecondClicker.Text = "Second Clicker";
            this.SecondClicker.UseVisualStyleBackColor = false;
            this.SecondClicker.Click += new System.EventHandler(this.SecondClicker_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Transparent;
            this.Output.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Output.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(12, 457);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(287, 105);
            this.Output.TabIndex = 4;
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusOne
            // 
            this.PlusOne.BackColor = System.Drawing.Color.Transparent;
            this.PlusOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusOne.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusOne.ForeColor = System.Drawing.Color.Transparent;
            this.PlusOne.Location = new System.Drawing.Point(12, 565);
            this.PlusOne.Name = "PlusOne";
            this.PlusOne.Size = new System.Drawing.Size(287, 76);
            this.PlusOne.TabIndex = 5;
            this.PlusOne.Text = "+1% Opacity";
            this.PlusOne.UseVisualStyleBackColor = false;
            this.PlusOne.Click += new System.EventHandler(this.PlusOne_Click);
            // 
            // OneMinus
            // 
            this.OneMinus.BackColor = System.Drawing.Color.Transparent;
            this.OneMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OneMinus.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OneMinus.ForeColor = System.Drawing.Color.White;
            this.OneMinus.Location = new System.Drawing.Point(12, 647);
            this.OneMinus.Name = "OneMinus";
            this.OneMinus.Size = new System.Drawing.Size(287, 76);
            this.OneMinus.TabIndex = 6;
            this.OneMinus.Text = "-1% Opacity";
            this.OneMinus.UseVisualStyleBackColor = false;
            this.OneMinus.Click += new System.EventHandler(this.OneMinus_Click);
            // 
            // RndImage
            // 
            this.RndImage.BackColor = System.Drawing.Color.Transparent;
            this.RndImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RndImage.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RndImage.ForeColor = System.Drawing.SystemColors.Window;
            this.RndImage.Location = new System.Drawing.Point(12, 751);
            this.RndImage.Name = "RndImage";
            this.RndImage.Size = new System.Drawing.Size(287, 76);
            this.RndImage.TabIndex = 7;
            this.RndImage.Text = "Random Image";
            this.RndImage.UseVisualStyleBackColor = false;
            this.RndImage.Click += new System.EventHandler(this.RndImage_Click);
            // 
            // Pictures
            // 
            this.Pictures.BackColor = System.Drawing.Color.Transparent;
            this.Pictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pictures.Location = new System.Drawing.Point(12, 833);
            this.Pictures.Name = "Pictures";
            this.Pictures.Size = new System.Drawing.Size(287, 196);
            this.Pictures.TabIndex = 8;
            this.Pictures.TabStop = false;
            // 
            // Quiz
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Pictures);
            this.Controls.Add(this.RndImage);
            this.Controls.Add(this.OneMinus);
            this.Controls.Add(this.PlusOne);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.SecondClicker);
            this.Controls.Add(this.FirstClicker);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Run);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quiz_FormClosing);
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button FirstClicker;
        private System.Windows.Forms.Button SecondClicker;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button PlusOne;
        private System.Windows.Forms.Button OneMinus;
        private System.Windows.Forms.Button RndImage;
        private System.Windows.Forms.PictureBox Pictures;
    }
}

