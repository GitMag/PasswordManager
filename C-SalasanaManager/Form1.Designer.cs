namespace C_SalasanaManager
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListboxSite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButttonSearchItem = new System.Windows.Forms.Button();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.ButtonDeleteItem = new System.Windows.Forms.Button();
            this.ButtonEditItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(264, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiedot";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(12, 121);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(186, 29);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salasana:";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(12, 49);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(186, 29);
            this.TextBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Käyttäjänimi:";
            // 
            // ListboxSite
            // 
            this.ListboxSite.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxSite.FormattingEnabled = true;
            this.ListboxSite.ItemHeight = 23;
            this.ListboxSite.Items.AddRange(new object[] {
            "youtube.com",
            "gmail.com",
            "pelikone.fi"});
            this.ListboxSite.Location = new System.Drawing.Point(13, 37);
            this.ListboxSite.Name = "ListboxSite";
            this.ListboxSite.Size = new System.Drawing.Size(236, 349);
            this.ListboxSite.TabIndex = 1;
            this.ListboxSite.SelectedIndexChanged += new System.EventHandler(this.ListboxSite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sivusto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButttonSearchItem);
            this.groupBox2.Controls.Add(this.ButtonAddItem);
            this.groupBox2.Controls.Add(this.ButtonDeleteItem);
            this.groupBox2.Controls.Add(this.ButtonEditItem);
            this.groupBox2.Location = new System.Drawing.Point(264, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Työkalut";
            // 
            // ButttonSearchItem
            // 
            this.ButttonSearchItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButttonSearchItem.Location = new System.Drawing.Point(12, 142);
            this.ButttonSearchItem.Name = "ButttonSearchItem";
            this.ButttonSearchItem.Size = new System.Drawing.Size(197, 35);
            this.ButttonSearchItem.TabIndex = 3;
            this.ButttonSearchItem.Text = "Hae";
            this.ButttonSearchItem.UseVisualStyleBackColor = true;
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddItem.Location = new System.Drawing.Point(12, 101);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(197, 35);
            this.ButtonAddItem.TabIndex = 2;
            this.ButtonAddItem.Text = "Lisää uusi";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // ButtonDeleteItem
            // 
            this.ButtonDeleteItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteItem.Location = new System.Drawing.Point(12, 60);
            this.ButtonDeleteItem.Name = "ButtonDeleteItem";
            this.ButtonDeleteItem.Size = new System.Drawing.Size(197, 35);
            this.ButtonDeleteItem.TabIndex = 1;
            this.ButtonDeleteItem.Text = "Poista Valittu";
            this.ButtonDeleteItem.UseVisualStyleBackColor = true;
            this.ButtonDeleteItem.Click += new System.EventHandler(this.ButtonDeleteItem_Click);
            // 
            // ButtonEditItem
            // 
            this.ButtonEditItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditItem.Location = new System.Drawing.Point(12, 19);
            this.ButtonEditItem.Name = "ButtonEditItem";
            this.ButtonEditItem.Size = new System.Drawing.Size(197, 35);
            this.ButtonEditItem.TabIndex = 0;
            this.ButtonEditItem.Text = "Muokkaa valittua";
            this.ButtonEditItem.UseVisualStyleBackColor = true;
            this.ButtonEditItem.Click += new System.EventHandler(this.ButtonEditItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListboxSite);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salasana Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListboxSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.Button ButtonDeleteItem;
        private System.Windows.Forms.Button ButtonEditItem;
        private System.Windows.Forms.Button ButttonSearchItem;
    }
}

