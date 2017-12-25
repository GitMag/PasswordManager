using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SalasanaManager
{
    public partial class MainForm : Form
    {
        int CurrentItemSiteName; //current selected item from site selector
        string Username; // Read username from file based on Selected site
        string Password;
        string site;
        string Key;
        public MainForm()
        {
            InitializeComponent();
            loadtext(); //load text from file to Site list
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (DecryptPassword form = new DecryptPassword()) //open decrypt form to decrypt passwords with master key
            {
                form.ShowDialog(this);
              //  Key = DecryptPassword.TextBoxKey.Text;
            }
            // string encryptedstring = StringCipher.Encrypt("es", "juu");
        }
        void loadtext()
        {
            ListboxSite.DataSource = File.ReadAllLines(@"d:\c-salasanamanager\site.txt");
        }

        private void ListboxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserDetails();
        }
        void LoadUserDetails() // Load Username an Password to Textbox
        {
            try
            {
                CurrentItemSiteName = ListboxSite.SelectedIndex;
                Username = File.ReadLines(@"d:\c-salasanamanager\username.txt").Skip(CurrentItemSiteName).Take(1).First();
                Password = File.ReadLines(@"d:\c-salasanamanager\password.txt").Skip(CurrentItemSiteName).Take(1).First();
                Console.WriteLine(Username);
                Console.WriteLine(Password);
                TextBoxUsername.Text = Username;
                TextBoxPassword.Text = Password;
                site = ListboxSite.SelectedItem.ToString();
                Console.WriteLine(site);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
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
            var file0 = new List<string>(System.IO.File.ReadAllLines(@"d:\c-salasanamanager\site.txt")); //remove site name from file
            file0.RemoveAt(CurrentItemSiteName);
            File.WriteAllLines(@"d:\c-salasanamanager\site.txt", file0.ToArray());
            var file1 = new List<string>(System.IO.File.ReadAllLines(@"d:\c-salasanamanager\username.txt")); //remove username from file
            file1.RemoveAt(CurrentItemSiteName);
            File.WriteAllLines(@"d:\c-salasanamanager\username.txt", file1.ToArray());
            var file2 = new List<string>(System.IO.File.ReadAllLines(@"d:\c-salasanamanager\password.txt")); //remove password from file
            file2.RemoveAt(CurrentItemSiteName);
            File.WriteAllLines(@"d:\c-salasanamanager\password.txt", file2.ToArray());
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
    }
}
