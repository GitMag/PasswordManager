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
    public partial class CustomInfo : Form
    {
        string Info;
        string Encrypted;
        string oldtext;
        string Strings;
        public CustomInfo()
        {
            InitializeComponent();
        }

        private void CustomInfo_Load(object sender, EventArgs e)
        {
            try
            {
                Encrypted = File.ReadLines(GlobalVariables.AppConfigLoc + "custominfo.txt").Skip(GlobalVariables.CurrentItem).Take(1).First();
                Info = StringCipher.Decrypt(Encrypted, GlobalVariables.DecryptKey);
                RichTextBoxCustomInfo.Text = Info;
                oldtext = Info;
            }
            catch (Exception)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RichTextBoxCustomInfo.Text == "")
            {
                RichTextBoxCustomInfo.Text = "Voit kirjoittaa tänne lisätietoja salasanasa..";
            }
            if (oldtext != RichTextBoxCustomInfo.Text)
            {
                if (MessageBox.Show("Olet tehnyt muutoksia tekstiin, haluatko tallentaa?", "Tallenna muutokset?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Info = StringCipher.Encrypt(RichTextBoxCustomInfo.Text, GlobalVariables.DecryptKey);
                    Strings = File.ReadAllText(GlobalVariables.AppConfigLoc + "custominfo.txt"); //replace username
                    Strings = Strings.Replace(Encrypted, Info);
                    File.WriteAllText(GlobalVariables.AppConfigLoc + "custominfo.txt", Strings);
                }
            }
            this.Close();
        }
    }
}

