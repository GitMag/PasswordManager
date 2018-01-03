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
    public partial class FirstRun : Form
    {
        public FirstRun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPswd.Text == textBoxPswdAgain.Text) //check if passwords match
            {
                Properties.Settings.Default.Save(); //save settings
                using (File.Create(GlobalVariables.AppConfigLoc + "site.txt"))
                File.WriteAllText(GlobalVariables.AppConfigLoc + "pswdTest.txt", StringCipher.Encrypt("test", textBoxPswd.Text));
                Application.Restart();          
            }
            else
            {
                MessageBox.Show("Salasanat eivät täsmää!");
            }
        }
    }
}
