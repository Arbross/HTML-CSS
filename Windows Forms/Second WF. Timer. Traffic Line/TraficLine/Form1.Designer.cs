
namespace TraficLine
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
            this.trafficTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundTraffic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.Label();
            this.Yellow = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trafficTimer
            // 
            this.trafficTimer.Interval = 500;
            this.trafficTimer.Tick += new System.EventHandler(this.trafficTimer_Tick);
            // 
            // backgroundTraffic
            // 
            this.backgroundTraffic.BackColor = System.Drawing.Color.DimGray;
            this.backgroundTraffic.Location = new System.Drawing.Point(860, 9);
            this.backgroundTraffic.Name = "backgroundTraffic";
            this.backgroundTraffic.Size = new System.Drawing.Size(244, 551);
            this.backgroundTraffic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(955, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 502);
            this.label1.TabIndex = 1;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.White;
            this.Red.Location = new System.Drawing.Point(899, 24);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(168, 157);
            this.Red.TabIndex = 3;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.White;
            this.Yellow.Location = new System.Drawing.Point(899, 203);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(168, 157);
            this.Yellow.TabIndex = 4;
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.White;
            this.Green.Location = new System.Drawing.Point(899, 378);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(168, 157);
            this.Green.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(1182, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 119);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(1182, 203);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(186, 119);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.state.Location = new System.Drawing.Point(501, 12);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(327, 169);
            this.state.TabIndex = 8;
            this.state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.state);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroundTraffic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer trafficTimer;
        private System.Windows.Forms.Label backgroundTraffic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Yellow;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label state;
    }
}

