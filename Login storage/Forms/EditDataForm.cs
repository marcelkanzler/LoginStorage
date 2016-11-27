using Login_storage.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_storage
{
    public partial class Form_EditData : Form
    {

        private Storage_Form storage_Form;
        private LoginFormular login_formular;
        private int listPosition = 0;
        public Form_EditData()
        {
            InitializeComponent();
        }

        public void Show(Storage_Form storage_Form, LoginFormular lf_data, int listPosition, int columnIndex)
        {
            try
            {
                this.cb_ShowPassword.Checked = storage_Form.cb_ShowPassword.Checked;
                this.storage_Form = storage_Form;
                this.listPosition = listPosition;
                this.login_formular = lf_data;
                base.Show();

                //Select the right textbox by the clicked colonne
                foreach (Control c in this.Controls)
                {
                    if (c.TabIndex == columnIndex)
                    {
                        c.Select();
                    }
                }

            }
            catch
            {
                MessageBox.Show("This cell cannot edit.");
                this.Close();
            }

        }

        private void bnt_Okay_Click(object sender, EventArgs e)
        {
            this.login_formular.EMail = this.txtb_Email.Text;
            this.login_formular.FirstName = this.txtb_FirstName.Text;
            this.login_formular.LastName = this.txtb_LastName.Text;
            this.login_formular.Password = this.txtb_Password.Text;
            this.login_formular.Username = this.txtb_Username.Text;
            this.login_formular.Website = this.txtb_Website.Text;

            List<LoginFormular> newLoginList = this.storage_Form.GetLoginList();
            this.storage_Form.SetDataGrid(newLoginList);
            this.btn_Cancel_Click(null, null);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_EditData_Load(object sender, EventArgs e)
        {
            this.txtb_Email.Text = this.login_formular.EMail;
            this.txtb_FirstName.Text = this.login_formular.FirstName;
            this.txtb_LastName.Text = this.login_formular.LastName;
            this.txtb_Password.Text = this.login_formular.Password;
            this.txtb_Username.Text = this.login_formular.Username;
            this.txtb_Website.Text = this.login_formular.Website;
        }

        private void txtb_Website_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btn_Cancel_Click(null, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.bnt_Okay_Click(null, null);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this login data?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.storage_Form.GetLoginList().RemoveAt(this.listPosition);
                this.storage_Form.SetDataGrid(this.storage_Form.GetLoginList());
                this.btn_Cancel_Click(null, null);
            }
        }

        private void cb_ShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            txtb_Password.UseSystemPasswordChar = !cb_ShowPassword.Checked;
        }
    }
}
