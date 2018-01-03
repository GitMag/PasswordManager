using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SalasanaManager
{
    public partial class DecryptPassword : Form
    {
        public DecryptPassword()
        {
            InitializeComponent();
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            GlobalVariables.DecryptKey = TextBoxKey.Text;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["UploadFTP"] = false;
            GlobalVariables.AllowExit = true;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void DecryptPassword_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["UploadFTP"].ToString() == "True")
            {
                ButtonUseLocal.Visible = true;
            }
        }
    }
}
