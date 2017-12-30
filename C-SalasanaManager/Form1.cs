using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SalasanaManager
{
    public partial class MainForm : Form
    {
        string Username; // Read username from file based on Selected site
        string Password;
        string site;
        string useFTP = Properties.Settings.Default["UploadFTP"].ToString();
        string FTPpass;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(GlobalVariables.AppConfigLoc); //create directory where profiles are saved
            NeedKey();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UploadFTP();
        }
              
        void loadtext()
        {
            ListboxSite.DataSource = File.ReadAllLines(GlobalVariables.AppConfigLoc + "site.txt");
        }
        void NeedKey()
        {
            using (DecryptPassword form = new DecryptPassword()) //open decrypt form to decrypt passwords with master key
            {
                form.ShowDialog(this);
                if (useFTP == "True") //chek if we should load files from ftp
                {
                    //load files from ftp
                    DownloadFTP();
                }
                else //Load files locally
                {
                    loadtext(); //load text from file to Site list
                    LoadUserDetails();
                }
                 
            }
        }
        private void ListboxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserDetails();
        }
        void DownloadFTP() //Download files from ftp server
        {
            try
            {
              
                FTPpass = File.ReadLines(GlobalVariables.AppConfigLoc + "FTPpass.txt").Skip(GlobalVariables.CurrentItem).Take(1).First(); //get encrypted ftp password from file
                FTPpass = StringCipher.Decrypt(FTPpass, GlobalVariables.DecryptKey); //try to decrypt password using key
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(Properties.Settings.Default["FTPuser"].ToString(), FTPpass);
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/site.txt", GlobalVariables.AppConfigLoc + "site.txt");
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/username.txt", GlobalVariables.AppConfigLoc + "username.txt");
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/password.txt", GlobalVariables.AppConfigLoc + "password.txt");
                client.Dispose();
                loadtext(); //load text from file to Site list
                LoadUserDetails();
            }
            catch (Exception)
            {
                NeedKey();
            }
           
        }
        void UploadFTP() //Upload files to server
        {
            try
            {
                if (FTPpass == "")
                {
                    FTPpass = File.ReadLines(GlobalVariables.AppConfigLoc + "FTPpass.txt").Skip(GlobalVariables.CurrentItem).Take(1).First(); //get encrypted ftp password from file
                    FTPpass = StringCipher.Decrypt(FTPpass, GlobalVariables.DecryptKey); //try to decrypt password using key
                }
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(Properties.Settings.Default["FTPuser"].ToString(), FTPpass);
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/site.txt", GlobalVariables.AppConfigLoc + "site.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/username.txt", GlobalVariables.AppConfigLoc + "username.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/password.txt", GlobalVariables.AppConfigLoc + "password.txt");
                client.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Salasanojen synkronointi FTP-palvelimelle epäonnistui. Tarkista onko kaikki FTP tunnuksesi oikein. Jos haluat pitää tämän istunnon muutokset" +
                    "niin paina 'Käytä paikallista salasanavarastoa' ensi istunnon alussa ja korjaa FTP-tunnukset.");
            }
        }
        void LoadUserDetails() // Load Username an Password to Textbox
        {
            if (GlobalVariables.DecryptKey != "")
            {
            try
            {
                GlobalVariables.CurrentItem = ListboxSite.SelectedIndex;
                Username = File.ReadLines(GlobalVariables.AppConfigLoc + "username.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
                Password = File.ReadLines(GlobalVariables.AppConfigLoc + "password.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
                Password = StringCipher.Decrypt(Password, GlobalVariables.DecryptKey);
                Console.WriteLine(Username);
                Console.WriteLine(Password);
                TextBoxUsername.Text = Username;
                TextBoxPassword.Text = Password;
                site = ListboxSite.SelectedItem.ToString();
                Console.WriteLine(site);
                    //settings test
                    if (Properties.Settings.Default["CopyClipboard"].ToString() == "True")
                    {
                        Clipboard.SetText(Password);
                    }
            }
            catch (Exception)
            {
                    if(ListboxSite.Items.Count != 0)
                    {
                        NeedKey();
                    }
            }
        }
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            using (AddNewItemForm f2 = new AddNewItemForm())
            {
                f2.ShowDialog(this);
                loadtext();
            }
        }
        void DeleteItem()
        {
            var file0 = new List<string>(System.IO.File.ReadAllLines(GlobalVariables.AppConfigLoc + "site.txt")); //remove site name from file
            file0.RemoveAt(GlobalVariables.CurrentItem);
            File.WriteAllLines(GlobalVariables.AppConfigLoc + "site.txt", file0.ToArray());
            var file1 = new List<string>(System.IO.File.ReadAllLines(GlobalVariables.AppConfigLoc + "username.txt")); //remove username from file
            file1.RemoveAt(GlobalVariables.CurrentItem);
            File.WriteAllLines(GlobalVariables.AppConfigLoc + "username.txt", file1.ToArray());
            var file2 = new List<string>(System.IO.File.ReadAllLines(GlobalVariables.AppConfigLoc + "password.txt")); //remove password from file
            file2.RemoveAt(GlobalVariables.CurrentItem);
            File.WriteAllLines(GlobalVariables.AppConfigLoc + "password.txt", file2.ToArray());
            loadtext();
        }

        private void ButtonDeleteItem_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Oletko varma että haluat poistaa tämän salasanan ohjelmasta? Sitä ei voida enää sen jälkeen palauttaa.", "Poista Salasana?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteItem(); //remove Selected Item(password and username) completely
            }
        }

        private void ButtonEditItem_Click(object sender, EventArgs e)
        {
            using (EditItemForm f3 = new EditItemForm())
            {
                f3.ShowDialog(this);
                loadtext();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                settings.ShowDialog(this);
            }
        }
    }
    public static class GlobalVariables //can be accesed from anywhere
    {
        public static string DecryptKey; //Key used to encrypt and decrypt passwords
        public static int CurrentItem; //Current slected listbox item
        public static string AppConfigLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PasswordManager\";
    }
}
