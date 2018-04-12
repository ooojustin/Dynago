namespace Dynago.Forms
{
    partial class ChangeOffset
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
            this.rbHexadecimal = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDecimal = new System.Windows.Forms.RadioButton();
            this.btnChangeValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbHexadecimal
            // 
            this.rbHexadecimal.AutoSize = true;
            this.rbHexadecimal.BackColor = System.Drawing.Color.Transparent;
            this.rbHexadecimal.Checked = true;
            this.rbHexadecimal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHexadecimal.ForeColor = System.Drawing.Color.White;
            this.rbHexadecimal.Location = new System.Drawing.Point(132, 40);
            this.rbHexadecimal.Name = "rbHexadecimal";
            this.rbHexadecimal.Size = new System.Drawing.Size(91, 17);
            this.rbHexadecimal.TabIndex = 2;
            this.rbHexadecimal.TabStop = true;
            this.rbHexadecimal.Text = "Hexadecimal";
            this.rbHexadecimal.UseVisualStyleBackColor = false;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtValue.Location = new System.Drawing.Point(103, 14);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(226, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Value:";
            // 
            // rbDecimal
            // 
            this.rbDecimal.AutoSize = true;
            this.rbDecimal.BackColor = System.Drawing.Color.Transparent;
            this.rbDecimal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDecimal.ForeColor = System.Drawing.Color.White;
            this.rbDecimal.Location = new System.Drawing.Point(229, 40);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(67, 17);
            this.rbDecimal.TabIndex = 3;
            this.rbDecimal.Text = "Decimal";
            this.rbDecimal.UseVisualStyleBackColor = false;
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChangeValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnChangeValue.Location = new System.Drawing.Point(103, 63);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(226, 23);
            this.btnChangeValue.TabIndex = 4;
            this.btnChangeValue.Text = "Change Value";
            this.btnChangeValue.UseVisualStyleBackColor = false;
            this.btnChangeValue.Click += new System.EventHandler(this.btnChangeValue_Click);
            // 
            // ChangeOffset
            // 
            this.AcceptButton = this.btnChangeValue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(347, 99);
            this.Controls.Add(this.btnChangeValue);
            this.Controls.Add(this.rbDecimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.rbHexadecimal);
            this.Name = "ChangeOffset";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbHexadecimal;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDecimal;
        private System.Windows.Forms.Button btnChangeValue;
    }
}