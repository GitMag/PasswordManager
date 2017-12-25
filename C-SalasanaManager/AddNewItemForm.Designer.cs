namespace C_SalasanaManager
{
    partial class AddNewItemForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSiteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUDlenght = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgressbarPWstrenght = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDlenght)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sivuston nimi:";
            // 
            // TextBoxSiteName
            // 
            this.TextBoxSiteName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSiteName.Location = new System.Drawing.Point(12, 37);
            this.TextBoxSiteName.Name = "TextBoxSiteName";
            this.TextBoxSiteName.Size = new System.Drawing.Size(260, 29);
            this.TextBoxSiteName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Käyttäjänim/sähköposti:";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(12, 97);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(260, 29);
            this.TextBoxUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salasana:";
            // 
            // NumericUDlenght
            // 
            this.NumericUDlenght.Location = new System.Drawing.Point(100, 134);
            this.NumericUDlenght.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NumericUDlenght.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUDlenght.Name = "NumericUDlenght";
            this.NumericUDlenght.Size = new System.Drawing.Size(43, 20);
            this.NumericUDlenght.TabIndex = 6;
            this.NumericUDlenght.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUDlenght.ValueChanged += new System.EventHandler(this.NumericUDlenght_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "merikkiä";
            // 
            // ProgressbarPWstrenght
            // 
            this.ProgressbarPWstrenght.Location = new System.Drawing.Point(100, 157);
            this.ProgressbarPWstrenght.Maximum = 32;
            this.ProgressbarPWstrenght.Name = "ProgressbarPWstrenght";
            this.ProgressbarPWstrenght.Size = new System.Drawing.Size(172, 23);
            this.ProgressbarPWstrenght.TabIndex = 8;
            this.ProgressbarPWstrenght.Value = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vahvuus:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lisää";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProgressbarPWstrenght);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericUDlenght);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSiteName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDlenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSiteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericUDlenght;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar ProgressbarPWstrenght;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}