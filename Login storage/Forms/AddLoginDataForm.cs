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
        private bool cancelClose = true;

        public Form_AddLoginData()
        {
            InitializeComponent();
        }


        public void SetStorageForm(Storage_Form storageForm)
        {
            this.storageForm = storageForm;
            this.cb_ShowPassword.Checked = storageForm.cb_ShowPassword.Checked;

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            bool hasChanged = false;
            //Stays false if nothing has written in all TextBoxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (tb.Text != "")
                    {
                        hasChanged = true;
                        break;
                    }
                }
            }
            if (hasChanged)
            {
                DialogResult dlr = MessageBox.Show("Do you wanna add the new login data to your storage?", "Add to storage?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    btn_Okay.PerformClick();
                }
                else if (dlr == DialogResult.No)
                {
                    ForceClose();
                }
            }
            else
            {
                ForceClose();
            }
        }

        private void Btn_Okay_Click(object sender, EventArgs e)
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
            LoginFormular loginFormular = new LoginFormular
            {
                Website = txtb_Website.Text,
                EMail = txtb_Email.Text,
                Username = txtb_Username.Text,
                Password = txtb_Password.Text,
                FirstName = txtb_FirstName.Text,
                LastName = txtb_LastName.Text
            };
            loginList.Add(loginFormular);

            this.storageForm.SetDataGrid(loginList);
            this.storageForm.UpdateMatchingLoginFormulars();
            ForceClose();
        }

        private void Txtb_Website_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Btn_Cancel_Click(null, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (this.txtb_Website.Text != "")
                {
                    this.btn_Okay.PerformClick();
                }
            }
        }

        private void Cb_ShowPassword_CheckStateChanged(object sender, EventArgs e)
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

        private void Pb_rnd_Click(object sender, EventArgs e)
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

        private void ForceClose()
        {
            cancelClose = false;
            this.Close();
        }

        private void Form_AddLoginData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelClose)
            {
                e.Cancel = false;
                btn_Cancel.PerformClick();
            }
            e.Cancel = cancelClose;
        }
    }
}
