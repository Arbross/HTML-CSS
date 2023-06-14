
namespace RadioButton
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
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.NIntermidiate = new System.Windows.Forms.RadioButton();
            this.Advance = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.Checked = true;
            this.Beginner.Location = new System.Drawing.Point(6, 22);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(72, 19);
            this.Beginner.TabIndex = 0;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            this.Beginner.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // NIntermidiate
            // 
            this.NIntermidiate.AutoSize = true;
            this.NIntermidiate.Location = new System.Drawing.Point(6, 47);
            this.NIntermidiate.Name = "NIntermidiate";
            this.NIntermidiate.Size = new System.Drawing.Size(89, 19);
            this.NIntermidiate.TabIndex = 1;
            this.NIntermidiate.Text = "Intermidiate";
            this.NIntermidiate.UseVisualStyleBackColor = true;
            this.NIntermidiate.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // Advance
            // 
            this.Advance.AutoSize = true;
            this.Advance.Location = new System.Drawing.Point(6, 72);
            this.Advance.Name = "Advance";
            this.Advance.Size = new System.Drawing.Size(71, 19);
            this.Advance.TabIndex = 2;
            this.Advance.Text = "Advance";
            this.Advance.UseVisualStyleBackColor = true;
            this.Advance.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Beginner);
            this.groupBox1.Controls.Add(this.Advance);
            this.groupBox1.Controls.Add(this.NIntermidiate);
            this.groupBox1.Location = new System.Drawing.Point(197, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your label";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(219, 310);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(219, 335);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 19);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.RadioButton NIntermidiate;
        private System.Windows.Forms.RadioButton Advance;
        private System.Windows.Forms.RadioButton Intermidiate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

