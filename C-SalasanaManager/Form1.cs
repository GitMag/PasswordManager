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
using System.Globalization;
using System.Resources;

namespace C_SalasanaManager
{
    public partial class MainForm : Form
    {
        string Username; // Read username from file based on Selected site
        string Strings; //random string you can store stuff in
        string Password; //read password from this string
        string EncryptedPassword;
        string site;
        string FTPpass;
        string testDecrypt;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(GlobalVariables.AppConfigLoc); //create directory where profiles are saved         
                if (File.Exists(GlobalVariables.AppConfigLoc + "site.txt") == false) //check if this is first run
                {
                    using (FirstRun FirstRun = new FirstRun()) //open decrypt form to decrypt passwords with master key
                    {
                        FirstRun.ShowDialog(this);
                        loadtext();
                    }
                }
                else //if not first run
                {             
                    NeedKey();
                }                        
                LoadSettings();
                TestPass();      
        }
        void LoadSettings()
        {
            if (Properties.Settings.Default["PasswordPlainText"].ToString() == "False") //check if password should be displayed in plain text
            {
                TextBoxPassword.PasswordChar = '*';
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVariables.AllowExit == false)
            {
                if (Properties.Settings.Default["UploadFTP"].ToString() == "True")
                {
                    UploadFTP();
                 }
            }
        }
        void TestPass() //test if the password the user gave is correct
        {
            if (GlobalVariables.AllowExit == false) //only test password if we do not want to exit
            {
                try
                {
                    testDecrypt = File.ReadAllText(GlobalVariables.AppConfigLoc + "pswdTest.txt"); //This is used to test if key is correct
                    testDecrypt = StringCipher.Decrypt(testDecrypt, GlobalVariables.DecryptKey); //try to decrypt key
                }
                catch (Exception)
                {

                    NeedKey();
                }
            }
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
                if (Properties.Settings.Default["UploadFTP"].ToString() == "True") //chek if we should load files from ftp
                {
                    //load files from ftp
                    DownloadFTP();
                }
                else //Load files locally
                {
                    loadtext(); //load text from file to Site list
                    LoadUserDetails();
                }
                TestPass(); //test if password is correct
                LoadUserDetails();
            }
        }
        private void ListboxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
            LoadUserDetails();
        }
        void UpdateInfo()
        {
            if (TextBoxUsername.Text != "" && TextBoxPassword.Text != "")
            {       
                if (Username != TextBoxUsername.Text || Password != TextBoxPassword.Text)
                {
                    if (MessageBox.Show("Olet tehnyt muutoksia käyttäjänimeent/salasanaan, haluatko tallentaa? \n" + Username + "=" + TextBoxUsername.Text + "\n" + Password + "=" + TextBoxPassword.Text, "Tallenna muutokset?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Strings = File.ReadAllText(GlobalVariables.AppConfigLoc + "username.txt"); //replace username
                        Strings = Strings.Replace(Username, TextBoxUsername.Text);
                        File.WriteAllText(GlobalVariables.AppConfigLoc + "username.txt", Strings);

                        Strings = File.ReadAllText(GlobalVariables.AppConfigLoc + "password.txt");
                        Strings = Strings.Replace(EncryptedPassword, StringCipher.Encrypt(TextBoxPassword.Text, GlobalVariables.DecryptKey));
                        File.WriteAllText(GlobalVariables.AppConfigLoc + "password.txt", Strings);
                    }
                }
            }
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
                client.DownloadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/custominfo.txt", GlobalVariables.AppConfigLoc + "custominfo.txt");
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
          //  try
           // {
                FTPpass = File.ReadLines(GlobalVariables.AppConfigLoc + "FTPpass.txt").Skip(GlobalVariables.CurrentItem).Take(1).First(); //get encrypted ftp password from file
                FTPpass = StringCipher.Decrypt(FTPpass, GlobalVariables.DecryptKey); //try to decrypt password using key              
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(Properties.Settings.Default["FTPuser"].ToString(), FTPpass);
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/site.txt", GlobalVariables.AppConfigLoc + "site.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/username.txt", GlobalVariables.AppConfigLoc + "username.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/password.txt", GlobalVariables.AppConfigLoc + "password.txt");
                client.UploadFile(Properties.Settings.Default["FTPaddress"].ToString() + "/custominfo.txt", GlobalVariables.AppConfigLoc + "custominfo.txt");
            client.Dispose();
           // }
           // catch (Exception)
           // {
               // MessageBox.Show("Salasanojen synkronointi FTP-palvelimelle epäonnistui. Tarkista onko kaikki FTP tunnuksesi oikein. Jos haluat pitää tämän istunnon muutokset" +
                 //   "niin paina 'Käytä paikallista salasanavarastoa' ensi istunnon alussa ja korjaa FTP-tunnukset.");
          //  }
        }
        void LoadUserDetails() // Load Username an Password to Textbox
        {
            if (testDecrypt == "test")
            { // 
                try
            {
                GlobalVariables.CurrentItem = ListboxSite.SelectedIndex;
                Username = File.ReadLines(GlobalVariables.AppConfigLoc + "username.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
                EncryptedPassword = File.ReadLines(GlobalVariables.AppConfigLoc + "password.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
                Password = StringCipher.Decrypt(EncryptedPassword, GlobalVariables.DecryptKey);
                Console.WriteLine(Username);
                Console.WriteLine(Password);
                TextBoxUsername.Text = Username;
                TextBoxPassword.Text = Password;
                site = ListboxSite.SelectedItem.ToString();
                Console.WriteLine(site);
                    //change text to display username or email depending if username contains @ and .
                    if (Username.Contains("@") && Username.Contains("."))
                    {
                        label2.Text = "Sähköposti:";
                    }
                    else
                    {
                        label2.Text = "Käyttäjänimi:";
                    }

                    //settings test
                    if (Properties.Settings.Default["CopyClipboard"].ToString() == "True")
                    {
                        Clipboard.SetText(Password);
                    }
                }
            catch (Exception)
            {
                        
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
            var file3 = new List<string>(System.IO.File.ReadAllLines(GlobalVariables.AppConfigLoc + "custominfo.txt")); //remove site name from file
            file3.RemoveAt(GlobalVariables.CurrentItem);
            File.WriteAllLines(GlobalVariables.AppConfigLoc + "custominfo.txt", file3.ToArray());
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

        private void ButttonSearchItem_Click(object sender, EventArgs e)
        {
            using (SearchSite search = new SearchSite())
            {
                search.ShowDialog(this);
                int index = ListboxSite.FindString(GlobalVariables.SearchString);
                if (index != -1)
                {
                    ListboxSite.SetSelected(index, true);
                }
                else
                {
                    MessageBox.Show("Hakutuloksia ei löytynyt");
                }
            }            
        }

        private void ButtonEditItem_Click_1(object sender, EventArgs e)
        {
            try //try to open editform
            {
                using (EditItemForm EditItem = new EditItemForm())
                {
                    EditItem.ShowDialog(this);
                }
            }
            catch (Exception) //show error if nothing was selected
            {
                MessageBox.Show("Valittua salasanaa ei voida avata.");
            }
        }

        private void labelShowAdditionalInfo_Click(object sender, EventArgs e)
        {
            using (CustomInfo CustomInfo = new CustomInfo())
            {
                CustomInfo.ShowDialog(this);
            }
        }
    }
    public static class GlobalVariables //can be accesed from anywhere
    {
        public static string DecryptKey; //Key used to encrypt and decrypt passwords
        public static int CurrentItem; //Current slected listbox item
        public static string AppConfigLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PasswordManager\";
        public static bool AllowExit = false; //Variable that allows instant exit whitout uploading ftp
        public static string SearchString;
    }
}
