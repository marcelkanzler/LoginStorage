﻿using Login_storage.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_storage
{
    public partial class Storage_Form : Form
    {
        private LoginEncoder loginEncoder;
        private List<LoginFormular> loginList;
        private SearchManager searchManage;
        private List<LoginFormular> hiddenPwLoginList;

        public bool dataGridCanBeEdit = true;


        public Storage_Form()
        {
            InitializeComponent();
            searchManage = new SearchManager(this);
            this.clbox_SearchMode.SelectedIndex = 0;
        }

        #region Event methods

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (loginEncoder.Save(GetLoginList()))
            {
                this.btn_Save.Enabled = false;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Errors were detected while saving file! Do you wanna try it again?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    btn_Save_Click(null, null);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_AddLoginData activeAddLoginData = new Form_AddLoginData();
            activeAddLoginData.SetStorageForm(this);

            activeAddLoginData.Show();
        }



        private void dataGrid_Logins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the heading of a column is clicked, the method should be aborted.
            if (e.RowIndex < 0)
            {
                return;
            }

            LoginFormular lf_data = this.GetDataGridLoginList()[e.RowIndex];
            int listPosition = -1;

            List<LoginFormular> currentList;

            if (this.cb_ShowPassword.Checked)
            {
                currentList = this.GetLoginList();
            }
            else
            {
                currentList = this.GetHiddenPwLoginList();
            }
            //Search for an equal LoginFormular
            for (int i = 0; i < currentList.Count; i++)
            {
                LoginFormular lf = currentList[i];
                if (lf.Equals(lf_data))
                {
                    listPosition = i;
                    break;
                }
            }
            if (listPosition != -1)
            {
                new Form_EditData().Show(this, this.GetLoginList()[listPosition], listPosition, e.ColumnIndex);
            }
            else
            {
                MessageBox.Show("This cell cannot be edited.");
            }
        }

        private void cbox_SearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMatchingLoginFormulars();

            if (clbox_SearchMode.SelectedIndex == 4)
            {
                if (cb_ShowPassword.Checked == false)
                {
                    txtb_Search.UseSystemPasswordChar = true;
                }
                else
                {
                    txtb_Search.UseSystemPasswordChar = false;
                }
            }
            else
            {
                txtb_Search.UseSystemPasswordChar = false;
            }

        }
        private void txtb_Search_TextChanged(object sender, EventArgs e)
        {
            UpdateMatchingLoginFormulars();
        }

        private void Storage_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_Save.Enabled)
            {
                DialogResult dialogResult = MessageBox.Show("The login list has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    btn_Save_Click(null, null);
                    MessageBox.Show("File successfully  saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    btn_Save.Enabled = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void cb_ShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (clbox_SearchMode.SelectedIndex == 4)
            {
                txtb_Search.UseSystemPasswordChar = !cb_ShowPassword.Checked;
            }
            else
            {
                txtb_Search.UseSystemPasswordChar = false;
            }
            UpdateMatchingLoginFormulars();
        }

        private void dataGrid_Logins_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.cb_ShowPassword.Checked == false)
            {
                if (e.Control && (e.KeyCode == Keys.C))
                {
                    if (dataGrid_Logins.CurrentCell.ColumnIndex == 3)
                    {
                        Clipboard.SetText(this.GetLoginList()[dataGrid_Logins.CurrentCell.RowIndex].Password);
                    }
                }
            }
        }
        #endregion

        #region Other methods

        public void setLoginEncoder(string username, string password)
        {
            this.loginEncoder = new LoginEncoder(username, password);
        }

        public void SetDataGrid(List<LoginFormular> loginList)
        {
            if (this.loginList != null)
            {
                this.btn_Save.Enabled = true;
            }
            this.loginList = loginList;

            List<LoginFormular> hiddenPwLoginList = new List<LoginFormular>();
            foreach (LoginFormular lg in loginList)
            {
                LoginFormular newlg = (LoginFormular)lg.Clone();
                newlg.Password = new string('•', newlg.Password.Length);
                hiddenPwLoginList.Add(newlg);
            }
            this.hiddenPwLoginList = hiddenPwLoginList;

            if (this.txtb_Search.Text != "")
            {
                UpdateMatchingLoginFormulars();
            }
            else
            {
                if (cb_ShowPassword.Enabled)
                {
                    this.dataGrid_Logins.DataSource = hiddenPwLoginList;
                }
                else
                {
                    this.dataGrid_Logins.DataSource = loginList;
                }
            }
        }

        public List<LoginFormular> GetLoginList()
        {
            return this.loginList;
        }

        public List<LoginFormular> GetHiddenPwLoginList()
        {
            return this.hiddenPwLoginList;
        }

        public List<LoginFormular> GetDataGridLoginList()
        {
            return this.dataGrid_Logins.DataSource as List<LoginFormular>;
        }

        //Execute and display the new search results
        public void UpdateMatchingLoginFormulars()
        {
            this.dataGrid_Logins.DataSource = this.searchManage.GetMatchingLoginFormulars();
        }
        #endregion


    }
}
