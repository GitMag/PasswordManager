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
          password = CreatePassword(Convert.ToInt32(NumericUDlenght.Value)); //create and get password to string. lenght accoring to selection
            File.AppendAllText(@"D:\c-salasanamanager\password.txt", password + Environment.NewLine); //add password to password text file
            File.AppendAllText(@"D:\c-salasanamanager\username.txt", TextBoxUsername.Text + Environment.NewLine); //add Username to text file
            File.AppendAllText(@"D:\c-salasanamanager\site.txt", TextBoxSiteName.Text + Environment.NewLine); //add site name to text file
            this.Close();
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
            ProgressbarPWstrenght.Value = Convert.ToInt32(NumericUDlenght.Value);
        }
    }
}
