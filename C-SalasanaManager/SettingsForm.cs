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
using System.Net;
using System.IO;

namespace C_SalasanaManager
{
    public partial class SettingsForm : Form
    {
        string FTPpass;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save(); // Saves settings in config file
                File.WriteAllText(GlobalVariables.AppConfigLoc + "FTPpass.txt", StringCipher.Encrypt(textBoxFTPpass.Text, GlobalVariables.DecryptKey));                   
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //test ftp
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try //Try to read FTPpass with key
            {
                textBoxFTPpass.Text = StringCipher.Decrypt(File.ReadAllText(GlobalVariables.AppConfigLoc + "FTPpass.txt"), GlobalVariables.DecryptKey);
            }
            catch (Exception)
            {
                //don't do anything because this can be normal behaviour if FTP is not enabled
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try //Backup stuff with BACKUP(orgininal name).txt
            {
                FTPpass = File.ReadLines(GlobalVariables.AppConfigLoc + "FTPpass.txt").Skip(GlobalVariables.CurrentItem).Take(1).First(); //get encrypted ftp password from file
                FTPpass = StringCipher.Decrypt(FTPpass, GlobalVariables.DecryptKey); //try to decrypt password using key
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(Properties.Settings.Default["FTPuser"].ToString(), FTPpass);
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPsite.txt", GlobalVariables.AppConfigLoc + "site.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPusername.txt", GlobalVariables.AppConfigLoc + "username.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPpassword.txt", GlobalVariables.AppConfigLoc + "password.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPpswdTest.txt", GlobalVariables.AppConfigLoc + "pswdTest.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPFTPpass.txt", GlobalVariables.AppConfigLoc + "FTPpass.txt");
                MessageBox.Show("Varmuuskopiointi onnistui!");
                client.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Virhe tapahtui.Tarkista että FTP-tunnukset ovat oikein.");
            }           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oletko varma että haluat tuoda varmuuskopiot? Nykyinen salasanavarasto korvataan nillä?", "Tuo varmuuskopiot?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
             
            
            try //Load Backups from ftp server
            {
                FTPpass = File.ReadLines(GlobalVariables.AppConfigLoc + "FTPpass.txt").Skip(GlobalVariables.CurrentItem).Take(1).First(); //get encrypted ftp password from file
                FTPpass = StringCipher.Decrypt(FTPpass, GlobalVariables.DecryptKey); //try to decrypt password using key
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(Properties.Settings.Default["FTPuser"].ToString(), FTPpass);
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPsite.txt", GlobalVariables.AppConfigLoc + "site.txt");
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPusername.txt", GlobalVariables.AppConfigLoc + "username.txt");
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPpassword.txt", GlobalVariables.AppConfigLoc + "password.txt");
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPpswdTest.txt", GlobalVariables.AppConfigLoc + "pswdTest.txt");
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/BACKUPFTPpass.txt", GlobalVariables.AppConfigLoc + "FTPpass.txt");
                MessageBox.Show("Tuonti onnistui! Ohjelma uudlellenkäynnistyy jotta salasanavarasto voidaan päivittää.");
                Application.Restart();
                client.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tapahtui.Tarkista että FTP-tunnukset ovat oikein. Tarkemmat tiedot:\n" + ex.ToString());
            }
        }
      }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oletko varma että haluat vaihtaa pääsalasanan, sinun vanha salasanasi ei sen jälkeen enää toimi?", "Tuo varmuuskopiot?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ChangeKey ChangeKey = new ChangeKey())
                {
                    ChangeKey.ShowDialog(this);                 
                }
                }
            }

        private void button4_Click(object sender, EventArgs e)
        {

            }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sourcePath = GlobalVariables.AppConfigLoc;
            string targetPath = Environment.SpecialFolder.Desktop + @"\PasswordManagerBACKUP";
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            foreach (var srcPath in Directory.GetFiles(sourcePath))
            {
                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path
                File.Copy(srcPath, srcPath.Replace(sourcePath, targetPath), true);
            }
            MessageBox.Show("Tiedostot kopioitu kohteeseen: " + targetPath);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            using (PasswordCreatorSettings GeneratorSettings = new PasswordCreatorSettings())
            {
                GeneratorSettings.ShowDialog(this);
            }
        }
    }
}
