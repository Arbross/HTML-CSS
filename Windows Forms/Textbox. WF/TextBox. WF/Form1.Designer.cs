
namespace TextBox._WF
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.TVEditor = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.Selected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoCompleteCustomSource.AddRange(new string[] {
            "ulia",
            "long"});
            this.Login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Login.Location = new System.Drawing.Point(72, 60);
            this.Login.Name = "Login";
            this.Login.PlaceholderText = "Enter login";
            this.Login.Size = new System.Drawing.Size(222, 23);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(72, 89);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderText = "Enter password";
            this.Password.Size = new System.Drawing.Size(222, 23);
            this.Password.TabIndex = 1;
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // TVEditor
            // 
            this.TVEditor.Enabled = false;
            this.TVEditor.Location = new System.Drawing.Point(72, 118);
            this.TVEditor.Multiline = true;
            this.TVEditor.Name = "TVEditor";
            this.TVEditor.PlaceholderText = "Enter text";
            this.TVEditor.Size = new System.Drawing.Size(222, 217);
            this.TVEditor.TabIndex = 2;
            this.TVEditor.TextChanged += new System.EventHandler(this.TVEditor_TextChanged);
            this.TVEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TVEditor_KeyDown);
            this.TVEditor.MouseCaptureChanged += new System.EventHandler(this.TVEditor_MouseCaptureChanged);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(320, 118);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(28, 15);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            // 
            // Selected
            // 
            this.Selected.AutoSize = true;
            this.Selected.Location = new System.Drawing.Point(320, 169);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(75, 15);
            this.Selected.TabIndex = 4;
            this.Selected.Text = "Selected info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.TVEditor);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Enter login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.TVEditor_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox TVEditor;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Selected;
    }
}

