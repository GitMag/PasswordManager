using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C_SalasanaManager
{
    public partial class ChangeKey : Form
    {
        string _password; //current password when reading file
        List<string> PasswordCollection = new List<string>();
        public ChangeKey()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ChangePass() //change the main key
        {
            string[] passwords = File.ReadAllLines(GlobalVariables.AppConfigLoc + "password.txt");
            foreach (string password in passwords) //read all encrypted passwords from file
            {
                _password = StringCipher.Decrypt(password, GlobalVariables.DecryptKey); //decrypt password with old key
                _password = StringCipher.Encrypt(_password, textBoxNewKey.Text); //encrypt with new key
                PasswordCollection.Add(_password); //add new encypted password to string collection
            }
            File.WriteAllLines(GlobalVariables.AppConfigLoc + "password.txt", PasswordCollection); //write collection to file
            _password = File.ReadAllText(GlobalVariables.AppConfigLoc + "FTPpass.txt"); //read encrypted FTP pass
            _password = StringCipher.Decrypt(_password, GlobalVariables.DecryptKey); //decrypt using old key
            _password = StringCipher.Encrypt(_password, textBoxNewKey.Text); //encrypt using new kkey
            File.WriteAllText(GlobalVariables.AppConfigLoc + "FTPpass.txt", _password); //write encrypted FTP pass to file

            _password = File.ReadAllText(GlobalVariables.AppConfigLoc + "pswdtest.txt"); //read encrypted test text
            _password = StringCipher.Decrypt(_password, GlobalVariables.DecryptKey); //decrypt using old key
            _password = StringCipher.Encrypt(_password, textBoxNewKey.Text); //encrypt using new kkey
            File.WriteAllText(GlobalVariables.AppConfigLoc + "pswdtest.txt", _password); //write encrypted FTP pass to file
            GlobalVariables.DecryptKey = textBoxNewKey.Text; //update new key to config (so FTP can upload)
            MessageBox.Show("Pääsalasana vaihdettu!"); //display success message
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxOldKey.Text == GlobalVariables.DecryptKey) //test if typed key equals real key
            {
                if (textBoxNewKey.Text != "") //test if new key is empty
                {

                    if (textBoxNewKey.Text == textBoxNewKeyAgain.Text) //test if new key is typed correctly 2 times
                    {
                        if (MessageBox.Show("Oletko nyt avivan varma, tämä on viimeinen mahdollisuus peruuttaa tomintio. Ota huomioon että jos tuot varmuuskopioita FTP-palvelimelta niin saattaa nissä olla vielä vanha Pääsalasana!", "Vaihda pääsalasana?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ChangePass();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Salasanat eivät täsmää!");
                    }
                }
                else
                {
                    MessageBox.Show("Uusi salasana ei voi olla tyhjä!");
                }
            }
            else
            {
                MessageBox.Show("Väärä salasana!");
            }
        }
    }
}
