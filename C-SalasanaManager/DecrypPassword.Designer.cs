namespace C_SalasanaManager
{
    partial class DecryptPassword
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
            this.TextBoxKey = new System.Windows.Forms.TextBox();
            this.ButtonDecrypt = new System.Windows.Forms.Button();
            this.ButtonUseLocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salasanavaraston salasana:";
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxKey.Location = new System.Drawing.Point(12, 39);
            this.TextBoxKey.MaxLength = 64;
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.PasswordChar = '*';
            this.TextBoxKey.Size = new System.Drawing.Size(260, 29);
            this.TextBoxKey.TabIndex = 4;
            this.TextBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKey_KeyDown);
            // 
            // ButtonDecrypt
            // 
            this.ButtonDecrypt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDecrypt.Location = new System.Drawing.Point(197, 74);
            this.ButtonDecrypt.Name = "ButtonDecrypt";
            this.ButtonDecrypt.Size = new System.Drawing.Size(75, 29);
            this.ButtonDecrypt.TabIndex = 5;
            this.ButtonDecrypt.Text = "Ok";
            this.ButtonDecrypt.UseVisualStyleBackColor = true;
            this.ButtonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // ButtonUseLocal
            // 
            this.ButtonUseLocal.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUseLocal.Location = new System.Drawing.Point(12, 74);
            this.ButtonUseLocal.Name = "ButtonUseLocal";
            this.ButtonUseLocal.Size = new System.Drawing.Size(179, 29);
            this.ButtonUseLocal.TabIndex = 6;
            this.ButtonUseLocal.Text = "Käytä paikallista salasanavarastoa";
            this.ButtonUseLocal.UseVisualStyleBackColor = true;
            this.ButtonUseLocal.Visible = false;
            this.ButtonUseLocal.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // DecryptPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.ButtonUseLocal);
            this.Controls.Add(this.ButtonDecrypt);
            this.Controls.Add(this.TextBoxKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DecryptPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salasana Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DecryptPassword_FormClosing);
            this.Load += new System.EventHandler(this.DecryptPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxKey;
        private System.Windows.Forms.Button ButtonDecrypt;
        private System.Windows.Forms.Button ButtonUseLocal;
    }
}