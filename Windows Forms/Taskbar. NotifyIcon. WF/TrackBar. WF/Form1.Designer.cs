
namespace TrackBar._WF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbYes = new System.Windows.Forms.TrackBar();
            this.tbNo = new System.Windows.Forms.TrackBar();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblCounterYes = new System.Windows.Forms.Label();
            this.lblCounterNo = new System.Windows.Forms.Label();
            this.niMax = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImages
            // 
            this.pbImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImages.Location = new System.Drawing.Point(12, 12);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(511, 296);
            this.pbImages.TabIndex = 0;
            this.pbImages.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(530, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(529, 102);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(529, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(530, 285);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tbYes
            // 
            this.tbYes.Enabled = false;
            this.tbYes.Location = new System.Drawing.Point(12, 315);
            this.tbYes.Maximum = 100000;
            this.tbYes.Name = "tbYes";
            this.tbYes.Size = new System.Drawing.Size(444, 45);
            this.tbYes.TabIndex = 5;
            this.tbYes.Value = 100000;
            // 
            // tbNo
            // 
            this.tbNo.Enabled = false;
            this.tbNo.Location = new System.Drawing.Point(12, 366);
            this.tbNo.Maximum = 100000;
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(444, 45);
            this.tbNo.TabIndex = 6;
            this.tbNo.Value = 100000;
            // 
            // btnNo
            // 
            this.btnNo.BackgroundImage = global::TrackBar._WF.Images.YesNo.no;
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNo.Location = new System.Drawing.Point(462, 366);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(61, 45);
            this.btnNo.TabIndex = 7;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackgroundImage = global::TrackBar._WF.Images.YesNo.yes;
            this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.Location = new System.Drawing.Point(462, 314);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(61, 46);
            this.btnYes.TabIndex = 8;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblCounterYes
            // 
            this.lblCounterYes.AutoSize = true;
            this.lblCounterYes.Location = new System.Drawing.Point(530, 326);
            this.lblCounterYes.Name = "lblCounterYes";
            this.lblCounterYes.Size = new System.Drawing.Size(24, 15);
            this.lblCounterYes.TabIndex = 9;
            this.lblCounterYes.Text = "0/0";
            // 
            // lblCounterNo
            // 
            this.lblCounterNo.AutoSize = true;
            this.lblCounterNo.Location = new System.Drawing.Point(530, 381);
            this.lblCounterNo.Name = "lblCounterNo";
            this.lblCounterNo.Size = new System.Drawing.Size(24, 15);
            this.lblCounterNo.TabIndex = 10;
            this.lblCounterNo.Text = "0/0";
            // 
            // niMax
            // 
            this.niMax.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMax.BalloonTipText = "You\'re maximize this form.";
            this.niMax.BalloonTipTitle = "Maximize";
            this.niMax.Icon = ((System.Drawing.Icon)(resources.GetObject("niMax.Icon")));
            this.niMax.Text = "noonononon";
            this.niMax.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 422);
            this.Controls.Add(this.lblCounterNo);
            this.Controls.Add(this.lblCounterYes);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.tbYes);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pbImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Poll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TrackBar tbYes;
        private System.Windows.Forms.TrackBar tbNo;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblCounterYes;
        private System.Windows.Forms.Label lblCounterNo;
        private System.Windows.Forms.NotifyIcon niMax;
    }
}

