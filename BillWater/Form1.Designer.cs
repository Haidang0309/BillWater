namespace BillWater
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
            lbUserName = new Label();
            lbPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btLogin = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(103, 88);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(75, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(103, 158);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(206, 81);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(169, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(206, 151);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(169, 27);
            tbPassword.TabIndex = 3;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(236, 230);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 4;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 321);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Label lbPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btLogin;
    }
}