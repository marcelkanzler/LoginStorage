using Login_storage.DataManager;
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

namespace Login_storage
{
    public partial class LoginForm : Form
    {

        private FileManager latestLogin = new FileManager(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LoginStorage\\LatesLogin.txt");
        private bool rememberMe = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Pb_Remember_Click(object sender, EventArgs e)
        {
            if (rememberMe)
            {
                this.pB_Remember.Image = LoginStorage.Properties.Resources.checkbox_off;
            }
            else
            {
                this.pB_Remember.Image = LoginStorage.Properties.Resources.checkbox_on;
            }
            rememberMe = !rememberMe;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox_Username.Text = latestLogin.ReadFile();
            if (textBox_Username.Text != "")
            {
                textBox_Password.Select();
                rememberMe = true;
                this.pB_Remember.Image = LoginStorage.Properties.Resources.checkbox_on;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void CheckPassword()
        {
            string username = this.textBox_Username.Text;
            string password = this.textBox_Password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Username or password is empty!", "Login warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rememberMe)
            {
                this.latestLogin.WriteFile(username);
            }
            else
            {
                this.latestLogin.WriteFile("");
            }
            LoginDecoder loginDecoder = new LoginDecoder(username, password);
            if (loginDecoder.IsCorrectPassword())
            {
                Storage_Form storage_From = new Storage_Form();
                storage_From.SetLoginEncoder(username, password);
                List<LoginFormular> loginList = loginDecoder.GetLoginList();
                if (loginDecoder.GetLoginList() != null)
                {
                    storage_From.SetDataGrid(loginList);
                    storage_From.Show();
                }
                else
                {
                    storage_From.SetDataGrid(new List<LoginFormular>());
                    storage_From.Show();
                }
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password.Text = "";
            }
        }

        private void TextBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckPassword();
            }
        }

        private void TextBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textbText = e.KeyChar.ToString();
            if (textbText.Contains("\\") || textbText.Contains("/") || textbText.Contains("?") || textbText.Contains(":") || textbText.Contains(" ")
                || textbText.Contains("*") || textbText.Contains("<") || textbText.Contains(">") || textbText.Contains("|") || textbText.Contains("\""))
            {

                tt_Warning.Show("The Username cannot contain the following characters: \n\\/?:*< >|\"", textBox_Username, 5000);
                e.KeyChar = new char();
            }
        }

    }
}
