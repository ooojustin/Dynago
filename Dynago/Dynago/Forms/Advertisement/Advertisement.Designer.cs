namespace Dynago.Forms {
    partial class Advertisement {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.adChecker = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblPreEarned = new System.Windows.Forms.Label();
            this.lblEarned = new System.Windows.Forms.Label();
            this.lblRemoveAds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Advertisement Required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(75, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "This process takes under 10 seconds.";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOpen.Enabled = false;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnOpen.Location = new System.Drawing.Point(139, 82);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 29);
            this.btnOpen.TabIndex = 103;
            this.btnOpen.Text = "Open URL";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.OpenAdvertisement);
            // 
            // adChecker
            // 
            this.adChecker.Tick += new System.EventHandler(this.adCheck_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(47, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Cheat will automatically open once completed.";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(34, 148);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(304, 23);
            this.pb.TabIndex = 105;
            this.pb.Visible = false;
            // 
            // lblPreEarned
            // 
            this.lblPreEarned.AutoSize = true;
            this.lblPreEarned.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreEarned.ForeColor = System.Drawing.Color.Aqua;
            this.lblPreEarned.Location = new System.Drawing.Point(129, 58);
            this.lblPreEarned.Name = "lblPreEarned";
            this.lblPreEarned.Size = new System.Drawing.Size(115, 13);
            this.lblPreEarned.TabIndex = 106;
            this.lblPreEarned.Text = "Raised this month:";
            // 
            // lblEarned
            // 
            this.lblEarned.AutoSize = true;
            this.lblEarned.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEarned.Location = new System.Drawing.Point(273, 58);
            this.lblEarned.Name = "lblEarned";
            this.lblEarned.Size = new System.Drawing.Size(25, 13);
            this.lblEarned.TabIndex = 107;
            this.lblEarned.Text = "[$]";
            // 
            // lblRemoveAds
            // 
            this.lblRemoveAds.AutoSize = true;
            this.lblRemoveAds.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRemoveAds.Location = new System.Drawing.Point(247, 182);
            this.lblRemoveAds.Name = "lblRemoveAds";
            this.lblRemoveAds.Size = new System.Drawing.Size(79, 13);
            this.lblRemoveAds.TabIndex = 108;
            this.lblRemoveAds.Text = "[CLICK HERE]";
            this.lblRemoveAds.Click += new System.EventHandler(this.lblRemoveAds_CLICK);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Want to remove advertisements?\r\n";
            // 
            // Advertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(373, 147);
            this.Controls.Add(this.lblRemoveAds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEarned);
            this.Controls.Add(this.lblPreEarned);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Advertisement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynago v[0.0] - Login Completion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Advertisement_FormClosing);
            this.Load += new System.EventHandler(this.Advertisement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer adChecker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblPreEarned;
        private System.Windows.Forms.Label lblEarned;
        private System.Windows.Forms.Label lblRemoveAds;
        private System.Windows.Forms.Label label4;
    }
}