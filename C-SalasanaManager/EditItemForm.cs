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
    public partial class EditItemForm : Form
    {
        string Strings;
        string OldUsername;
        string OldSite;
        string OldencryptedPass;
        public EditItemForm()
        {
            InitializeComponent();
        }

       public void EditItemForm_Load(object sender, EventArgs e)
        {
            OldSite= File.ReadLines(GlobalVariables.AppConfigLoc + "site.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
            OldUsername = File.ReadLines(GlobalVariables.AppConfigLoc + "username.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
            OldencryptedPass = File.ReadLines(GlobalVariables.AppConfigLoc + "password.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();

            TextBoxSite.Text = OldSite;
            TextBoxUsername.Text = OldUsername;
            TextBoxPassword.Text = StringCipher.Decrypt(OldencryptedPass, GlobalVariables.DecryptKey);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //update site name
            Strings = File.ReadAllText(GlobalVariables.AppConfigLoc + "site.txt");
            Strings = Strings.Replace(OldSite, TextBoxSite.Text);
            File.WriteAllText(GlobalVariables.AppConfigLoc + "site.txt", Strings);
            //update username
            Strings = File.ReadAllText(GlobalVariables.AppConfigLoc + "username.txt");
            Strings = Strings.Replace(OldUsername, TextBoxUsername.Text);
            File.WriteAllText(GlobalVariables.AppConfigLoc + "username.txt", Strings);
            //update password
            Strings = File.ReadAllText(GlobalVariables.AppConfigLoc + "password.txt");
            Strings = Strings.Replace(OldencryptedPass, StringCipher.Encrypt(TextBoxPassword.Text, GlobalVariables.DecryptKey));
            File.WriteAllText(GlobalVariables.AppConfigLoc + "password.txt", Strings);
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
