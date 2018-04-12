namespace Dynago.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegisteredUsers = new System.Windows.Forms.Label();
            this.lblNewestVersion = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateAnAccount = new System.Windows.Forms.Button();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.lblJustinOOO = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.tabLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tabChangelog = new System.Windows.Forms.Panel();
            this.lblChangelog = new System.Windows.Forms.Label();
            this.pnlChangelog = new System.Windows.Forms.Panel();
            this.txtChangelog = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabChangelog.SuspendLayout();
            this.pnlChangelog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 100;
            this.label1.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRegisteredUsers);
            this.groupBox1.Controls.Add(this.lblNewestVersion);
            this.groupBox1.Controls.Add(this.lblCurrentVersion);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dynago Information";
            // 
            // lblRegisteredUsers
            // 
            this.lblRegisteredUsers.AutoSize = true;
            this.lblRegisteredUsers.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredUsers.ForeColor = System.Drawing.Color.White;
            this.lblRegisteredUsers.Location = new System.Drawing.Point(134, 65);
            this.lblRegisteredUsers.Name = "lblRegisteredUsers";
            this.lblRegisteredUsers.Size = new System.Drawing.Size(160, 18);
            this.lblRegisteredUsers.TabIndex = 3;
            this.lblRegisteredUsers.Text = "Registered Users: -";
            // 
            // lblNewestVersion
            // 
            this.lblNewestVersion.AutoSize = true;
            this.lblNewestVersion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewestVersion.ForeColor = System.Drawing.Color.White;
            this.lblNewestVersion.Location = new System.Drawing.Point(142, 42);
            this.lblNewestVersion.Name = "lblNewestVersion";
            this.lblNewestVersion.Size = new System.Drawing.Size(144, 18);
            this.lblNewestVersion.TabIndex = 2;
            this.lblNewestVersion.Text = "Newest Version: -";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVersion.ForeColor = System.Drawing.Color.White;
            this.lblCurrentVersion.Location = new System.Drawing.Point(138, 19);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(152, 18);
            this.lblCurrentVersion.TabIndex = 1;
            this.lblCurrentVersion.Text = "Current Version: -";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(148, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(148, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 100;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(65, 63);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(301, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login to Dynago";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAnAccount
            // 
            this.btnCreateAnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCreateAnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAnAccount.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateAnAccount.Location = new System.Drawing.Point(65, 105);
            this.btnCreateAnAccount.Name = "btnCreateAnAccount";
            this.btnCreateAnAccount.Size = new System.Drawing.Size(301, 22);
            this.btnCreateAnAccount.TabIndex = 3;
            this.btnCreateAnAccount.Text = "Need to Create an Account?";
            this.btnCreateAnAccount.UseVisualStyleBackColor = false;
            this.btnCreateAnAccount.Click += new System.EventHandler(this.btnCreateAnAccount_Click);
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoweredBy.ForeColor = System.Drawing.Color.White;
            this.lblPoweredBy.Location = new System.Drawing.Point(148, 278);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(67, 13);
            this.lblPoweredBy.TabIndex = 5;
            this.lblPoweredBy.Text = "Powered by";
            // 
            // lblJustinOOO
            // 
            this.lblJustinOOO.AutoSize = true;
            this.lblJustinOOO.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustinOOO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblJustinOOO.Location = new System.Drawing.Point(214, 278);
            this.lblJustinOOO.Name = "lblJustinOOO";
            this.lblJustinOOO.Size = new System.Drawing.Size(91, 13);
            this.lblJustinOOO.TabIndex = 4;
            this.lblJustinOOO.Text = "www.justin.ooo";
            this.lblJustinOOO.Click += new System.EventHandler(this.lblJustinOOO_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnCreateAnAccount);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(12, 145);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(429, 141);
            this.pnlLogin.TabIndex = 101;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabLogin.Controls.Add(this.lblLogin);
            this.tabLogin.Location = new System.Drawing.Point(12, 109);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Size = new System.Drawing.Size(211, 30);
            this.tabLogin.TabIndex = 111;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(78, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 19);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // tabChangelog
            // 
            this.tabChangelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabChangelog.Controls.Add(this.lblChangelog);
            this.tabChangelog.Location = new System.Drawing.Point(230, 109);
            this.tabChangelog.Name = "tabChangelog";
            this.tabChangelog.Size = new System.Drawing.Size(211, 30);
            this.tabChangelog.TabIndex = 112;
            // 
            // lblChangelog
            // 
            this.lblChangelog.AutoSize = true;
            this.lblChangelog.BackColor = System.Drawing.Color.Transparent;
            this.lblChangelog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangelog.ForeColor = System.Drawing.Color.White;
            this.lblChangelog.Location = new System.Drawing.Point(60, 5);
            this.lblChangelog.Name = "lblChangelog";
            this.lblChangelog.Size = new System.Drawing.Size(90, 19);
            this.lblChangelog.TabIndex = 0;
            this.lblChangelog.Text = "Changelog";
            // 
            // pnlChangelog
            // 
            this.pnlChangelog.Controls.Add(this.txtChangelog);
            this.pnlChangelog.Location = new System.Drawing.Point(12, 145);
            this.pnlChangelog.Name = "pnlChangelog";
            this.pnlChangelog.Size = new System.Drawing.Size(429, 270);
            this.pnlChangelog.TabIndex = 1;
            // 
            // txtChangelog
            // 
            this.txtChangelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtChangelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChangelog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangelog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtChangelog.Location = new System.Drawing.Point(0, 0);
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.ReadOnly = true;
            this.txtChangelog.Size = new System.Drawing.Size(429, 270);
            this.txtChangelog.TabIndex = 113;
            this.txtChangelog.Text = "";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(452, 298);
            this.Controls.Add(this.lblPoweredBy);
            this.Controls.Add(this.lblJustinOOO);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlChangelog);
            this.Controls.Add(this.tabChangelog);
            this.Controls.Add(this.tabLogin);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynago v[0.0] - Public Release";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabChangelog.ResumeLayout(false);
            this.tabChangelog.PerformLayout();
            this.pnlChangelog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblNewestVersion;
        private System.Windows.Forms.Label lblRegisteredUsers;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAnAccount;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.Label lblJustinOOO;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel tabLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel tabChangelog;
        private System.Windows.Forms.Label lblChangelog;
        private System.Windows.Forms.Panel pnlChangelog;
        private System.Windows.Forms.RichTextBox txtChangelog;
    }
}