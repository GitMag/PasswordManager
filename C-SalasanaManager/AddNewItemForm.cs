using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace C_SalasanaManager
{
    public partial class AddNewItemForm : Form
    {
        public string password;
        public AddNewItemForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreatePassword();
            Properties.Settings.Default.Save(); //save password lenght
        }
        void CreatePassword()
        {
            bool writepass = true;
            if (textBoxOldPass.Text == "") //test if user wants to user existring password
            {
                password = CreatePassword(Convert.ToInt32(NumericUDlenght.Value)); //create password
                System.Threading.Thread.Sleep(10);
                if (password.Contains("@") && password.Contains("%") && password.Contains("#")) //check if password is secure enough 
                {
                    if (Properties.Settings.Default["AskIfPasswordIsGood"].ToString() == "True") //see if we should ask user about password?
                    {
                        if (MessageBox.Show("Salasana luotu: " + password + "\n Haluatko luoda uuden salasanan?", "Salasana luotu!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        writepass = false;
                        CreatePassword();
                        }
                    }
                }
                else
                {
                    writepass = false; //don't allow to save password
                    CreatePassword(); //try to create a more secure password
                }

            }
            else
            {
                password = textBoxOldPass.Text; //Use existing password from textbox
            }
            if (writepass == true) //check if we should save changes
            {          
            File.AppendAllText(GlobalVariables.AppConfigLoc + "password.txt", StringCipher.Encrypt(password, GlobalVariables.DecryptKey) + Environment.NewLine); //add password to password text file
            File.AppendAllText(GlobalVariables.AppConfigLoc + "username.txt", TextBoxUsername.Text + Environment.NewLine); //add Username to text file
            File.AppendAllText(GlobalVariables.AppConfigLoc + "site.txt", TextBoxSiteName.Text + Environment.NewLine); //add site name to text file
            this.Close();
            }
        }
            public string CreatePassword(int length) 
         {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@#%";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }         
            return res.ToString();        
         }

        private void NumericUDlenght_ValueChanged(object sender, EventArgs e)
        {
            ProgressbarPWstrenght.Value = Convert.ToInt32(NumericUDlenght.Value); //Update password strenght
        }
    }
}
