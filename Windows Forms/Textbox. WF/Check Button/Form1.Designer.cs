
namespace Check_Button
{
    partial class SkillsQuiz
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
            this.cpp = new System.Windows.Forms.CheckBox();
            this.cs = new System.Windows.Forms.CheckBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.gbSkills = new System.Windows.Forms.GroupBox();
            this.Advanced = new System.Windows.Forms.RadioButton();
            this.Intermidiate = new System.Windows.Forms.RadioButton();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.enSkills = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbSkills.SuspendLayout();
            this.enSkills.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpp
            // 
            this.cpp.AutoSize = true;
            this.cpp.Location = new System.Drawing.Point(6, 22);
            this.cpp.Name = "cpp";
            this.cpp.Size = new System.Drawing.Size(50, 19);
            this.cpp.TabIndex = 0;
            this.cpp.Text = "C++";
            this.cpp.ThreeState = true;
            this.cpp.UseVisualStyleBackColor = true;
            this.cpp.CheckedChanged += new System.EventHandler(this.java_CheckedChanged);
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Location = new System.Drawing.Point(6, 47);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(64, 19);
            this.cs.TabIndex = 1;
            this.cs.Text = "CSharp";
            this.cs.UseVisualStyleBackColor = true;
            this.cs.CheckedChanged += new System.EventHandler(this.java_CheckedChanged);
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(6, 72);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(48, 19);
            this.java.TabIndex = 2;
            this.java.Text = "Java";
            this.java.ThreeState = true;
            this.java.UseVisualStyleBackColor = true;
            this.java.CheckedChanged += new System.EventHandler(this.java_CheckedChanged);
            this.java.CheckStateChanged += new System.EventHandler(this.java_CheckStateChanged);
            // 
            // gbSkills
            // 
            this.gbSkills.Controls.Add(this.cpp);
            this.gbSkills.Controls.Add(this.java);
            this.gbSkills.Controls.Add(this.cs);
            this.gbSkills.Location = new System.Drawing.Point(214, 22);
            this.gbSkills.Name = "gbSkills";
            this.gbSkills.Size = new System.Drawing.Size(200, 195);
            this.gbSkills.TabIndex = 3;
            this.gbSkills.TabStop = false;
            this.gbSkills.Text = "Skills";
            // 
            // Advanced
            // 
            this.Advanced.AutoSize = true;
            this.Advanced.Location = new System.Drawing.Point(6, 73);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(78, 19);
            this.Advanced.TabIndex = 5;
            this.Advanced.TabStop = true;
            this.Advanced.Text = "Advanced";
            this.Advanced.UseVisualStyleBackColor = true;
            this.Advanced.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // Intermidiate
            // 
            this.Intermidiate.AutoSize = true;
            this.Intermidiate.Location = new System.Drawing.Point(6, 47);
            this.Intermidiate.Name = "Intermidiate";
            this.Intermidiate.Size = new System.Drawing.Size(89, 19);
            this.Intermidiate.TabIndex = 4;
            this.Intermidiate.TabStop = true;
            this.Intermidiate.Text = "Intermidiate";
            this.Intermidiate.UseVisualStyleBackColor = true;
            this.Intermidiate.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.Location = new System.Drawing.Point(6, 22);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(72, 19);
            this.Beginner.TabIndex = 3;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            this.Beginner.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(645, 31);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 53);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Location = new System.Drawing.Point(307, 313);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(200, 89);
            this.tbInfo.TabIndex = 5;
            // 
            // enSkills
            // 
            this.enSkills.Controls.Add(this.Advanced);
            this.enSkills.Controls.Add(this.Intermidiate);
            this.enSkills.Controls.Add(this.Beginner);
            this.enSkills.Location = new System.Drawing.Point(6, 22);
            this.enSkills.Name = "enSkills";
            this.enSkills.Size = new System.Drawing.Size(200, 195);
            this.enSkills.TabIndex = 6;
            this.enSkills.TabStop = false;
            this.enSkills.Text = "Skills";
            this.enSkills.Enter += new System.EventHandler(this.enSkills_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enSkills);
            this.groupBox1.Controls.Add(this.gbSkills);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1041, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(785, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // SkillsQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 719);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnSubmit);
            this.Name = "SkillsQuiz";
            this.Text = "Form1";
            this.gbSkills.ResumeLayout(false);
            this.gbSkills.PerformLayout();
            this.enSkills.ResumeLayout(false);
            this.enSkills.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cpp;
        private System.Windows.Forms.CheckBox cs;
        private System.Windows.Forms.CheckBox java;
        private System.Windows.Forms.GroupBox gbSkills;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.RadioButton Advanced;
        private System.Windows.Forms.RadioButton Intermidiate;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.GroupBox enSkills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

