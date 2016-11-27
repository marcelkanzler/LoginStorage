using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_storage.DataManager;
using System.Net.Mail;

namespace Login_storage
{
    public partial class Form_AddLoginData : Form
    {
        private Storage_Form storageForm;
        public Form_AddLoginData()
        {
            InitializeComponent();
        }


        public void SetStorageForm(Storage_Form storageForm)
        {
            this.storageForm = storageForm;
            this.cb_ShowPassword.Checked = storageForm.cb_ShowPassword.Checked;
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_Okay_Click(object sender, EventArgs e)
        {
            List<LoginFormular> loginList = this.storageForm.GetLoginList();
            if (loginList == null)
            {
                loginList = new List<LoginFormular>();
            }
            if (this.txtb_Website.Text == "")
            {
                MessageBox.Show("A website must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginFormular loginFormular = new LoginFormular();
            loginFormular.Website = txtb_Website.Text;
            loginFormular.EMail = txtb_Email.Text;
            loginFormular.Username = txtb_Username.Text;
            loginFormular.Password = txtb_Password.Text;
            loginFormular.FirstName = txtb_FirstName.Text;
            loginFormular.LastName = txtb_LastName.Text;
            loginList.Add(loginFormular);

            this.storageForm.SetDataGrid(loginList);
            this.storageForm.UpdateMatchingLoginFormulars();
            this.Close();
        }

        private void txtb_Website_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btn_Cancel_Click(null, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (this.txtb_Website.Text != "")
                {
                    this.bnt_Okay_Click(null, null);
                }
            }
        }

        private void cb_ShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (!this.cb_ShowPassword.Checked == true)
            {
                this.txtb_Password.UseSystemPasswordChar = true;
            }
            else
            {
                this.txtb_Password.UseSystemPasswordChar = false;
            }
        }

        private void pb_rnd_Click(object sender, EventArgs e)
        {
            String sRnd = "";
            String usingChars = "";
            Random rnd = new Random();
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                usingChars = usingChars + c;
                c++;
            }
            usingChars = usingChars + "0123456789?!*_+-";
            for (int i = 0; i < 12; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    sRnd = sRnd + Char.ToLower(usingChars[rnd.Next(usingChars.Length)]);
                }
                else
                {
                    sRnd = sRnd + Char.ToUpper(usingChars[rnd.Next(usingChars.Length)]);
                }
            }
            this.txtb_Password.Text = sRnd;
        }
    }
}
