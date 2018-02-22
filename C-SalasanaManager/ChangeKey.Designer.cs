namespace C_SalasanaManager
{
    partial class ChangeKey
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
            this.TextBoxOldKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewKeyAgain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salasanavaraston salasana:";
            // 
            // TextBoxOldKey
            // 
            this.TextBoxOldKey.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOldKey.Location = new System.Drawing.Point(12, 35);
            this.TextBoxOldKey.MaxLength = 64;
            this.TextBoxOldKey.Name = "TextBoxOldKey";
            this.TextBoxOldKey.PasswordChar = '*';
            this.TextBoxOldKey.Size = new System.Drawing.Size(260, 29);
            this.TextBoxOldKey.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salasanavaraston uusi salasana:";
            // 
            // textBoxNewKey
            // 
            this.textBoxNewKey.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewKey.Location = new System.Drawing.Point(12, 93);
            this.textBoxNewKey.MaxLength = 64;
            this.textBoxNewKey.Name = "textBoxNewKey";
            this.textBoxNewKey.PasswordChar = '*';
            this.textBoxNewKey.Size = new System.Drawing.Size(260, 29);
            this.textBoxNewKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salasanavaraston uusi salasana uudelleen:";
            // 
            // textBoxNewKeyAgain
            // 
            this.textBoxNewKeyAgain.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewKeyAgain.Location = new System.Drawing.Point(12, 157);
            this.textBoxNewKeyAgain.MaxLength = 64;
            this.textBoxNewKeyAgain.Name = "textBoxNewKeyAgain";
            this.textBoxNewKeyAgain.PasswordChar = '*';
            this.textBoxNewKeyAgain.Size = new System.Drawing.Size(260, 29);
            this.textBoxNewKeyAgain.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Vaihda salasanaa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Peruuta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNewKeyAgain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxOldKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaihda pääsalasanaa:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxOldKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewKeyAgain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}