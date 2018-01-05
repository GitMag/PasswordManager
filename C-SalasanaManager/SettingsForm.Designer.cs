namespace C_SalasanaManager
{
    partial class SettingsForm
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
            this.textBoxFTPpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxAskPassword = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxFTPuser = new System.Windows.Forms.TextBox();
            this.textBoxFTPaddress = new System.Windows.Forms.TextBox();
            this.checkBoxUseFTP = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFTPpass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFTPuser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFTPaddress);
            this.groupBox1.Controls.Add(this.checkBoxUseFTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(315, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internet";
            // 
            // textBoxFTPpass
            // 
            this.textBoxFTPpass.Location = new System.Drawing.Point(9, 184);
            this.textBoxFTPpass.Name = "textBoxFTPpass";
            this.textBoxFTPpass.PasswordChar = '*';
            this.textBoxFTPpass.Size = new System.Drawing.Size(252, 26);
            this.textBoxFTPpass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "FTP salasana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "FTP käyttäjänimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FTP palvelimen osoite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAskPassword);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yleiset";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(293, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Tarkista päivitykset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(513, 424);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 31);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Tallenna";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salasanojen varmuuskopiointi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tuo FTP palvelimelta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vie FTP palvelimelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(315, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 149);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salasanojen hallinta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Vaihda pääsalasana";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxAskPassword
            // 
            this.checkBoxAskPassword.AutoSize = true;
            this.checkBoxAskPassword.Checked = global::C_SalasanaManager.Properties.Settings.Default.AskIfPasswordIsGood;
            this.checkBoxAskPassword.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::C_SalasanaManager.Properties.Settings.Default, "AskIfPasswordIsGood", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAskPassword.Location = new System.Drawing.Point(7, 97);
            this.checkBoxAskPassword.Name = "checkBoxAskPassword";
            this.checkBoxAskPassword.Size = new System.Drawing.Size(248, 44);
            this.checkBoxAskPassword.TabIndex = 3;
            this.checkBoxAskPassword.Text = "Salasanaa luotaessa kysy onko luotu\r\n salasan tyydyttävä";
            this.checkBoxAskPassword.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::C_SalasanaManager.Properties.Settings.Default.PasswordPlainText;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::C_SalasanaManager.Properties.Settings.Default, "PasswordPlainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(9, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(232, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Näytä salasana tavallisena tekstinä";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::C_SalasanaManager.Properties.Settings.Default.CopyClipboard;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::C_SalasanaManager.Properties.Settings.Default, "CopyClipboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(9, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(217, 44);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Kopioi valitun sivuston salasana\r\nleikepöydälle automaattisesti";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxFTPuser
            // 
            this.textBoxFTPuser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::C_SalasanaManager.Properties.Settings.Default, "FTPuser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFTPuser.Location = new System.Drawing.Point(9, 132);
            this.textBoxFTPuser.Name = "textBoxFTPuser";
            this.textBoxFTPuser.Size = new System.Drawing.Size(252, 26);
            this.textBoxFTPuser.TabIndex = 5;
            this.textBoxFTPuser.Text = global::C_SalasanaManager.Properties.Settings.Default.FTPuser;
            // 
            // textBoxFTPaddress
            // 
            this.textBoxFTPaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::C_SalasanaManager.Properties.Settings.Default, "FTPaddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFTPaddress.Location = new System.Drawing.Point(9, 80);
            this.textBoxFTPaddress.Name = "textBoxFTPaddress";
            this.textBoxFTPaddress.Size = new System.Drawing.Size(252, 26);
            this.textBoxFTPaddress.TabIndex = 2;
            this.textBoxFTPaddress.Text = global::C_SalasanaManager.Properties.Settings.Default.FTPaddress;
            // 
            // checkBoxUseFTP
            // 
            this.checkBoxUseFTP.AutoSize = true;
            this.checkBoxUseFTP.Checked = global::C_SalasanaManager.Properties.Settings.Default.UploadFTP;
            this.checkBoxUseFTP.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::C_SalasanaManager.Properties.Settings.Default, "UploadFTP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseFTP.Location = new System.Drawing.Point(9, 26);
            this.checkBoxUseFTP.Name = "checkBoxUseFTP";
            this.checkBoxUseFTP.Size = new System.Drawing.Size(252, 24);
            this.checkBoxUseFTP.TabIndex = 1;
            this.checkBoxUseFTP.Text = "Lataa salasanavarasto ftp palvelimelle";
            this.checkBoxUseFTP.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "Salasanaluojan asetukset";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Asetukset:";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFTPpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFTPuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFTPaddress;
        private System.Windows.Forms.CheckBox checkBoxUseFTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBoxAskPassword;
        private System.Windows.Forms.Button button5;
    }
}