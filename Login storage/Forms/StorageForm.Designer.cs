using System.Windows.Forms;
namespace Login_storage
{
    partial class Storage_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage_Form));
            this.dataGrid_Logins = new System.Windows.Forms.DataGridView();
            this.txtb_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.clbox_SearchMode = new System.Windows.Forms.ComboBox();
            this.cb_ShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Logins)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Logins
            // 
            this.dataGrid_Logins.AllowUserToAddRows = false;
            this.dataGrid_Logins.AllowUserToDeleteRows = false;
            this.dataGrid_Logins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid_Logins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Logins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Logins.Location = new System.Drawing.Point(25, 63);
            this.dataGrid_Logins.MultiSelect = false;
            this.dataGrid_Logins.Name = "dataGrid_Logins";
            this.dataGrid_Logins.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.NullValue = "-;-";
            this.dataGrid_Logins.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Logins.Size = new System.Drawing.Size(822, 426);
            this.dataGrid_Logins.TabIndex = 0;
            this.dataGrid_Logins.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Logins_CellDoubleClick);
            this.dataGrid_Logins.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGrid_Logins_KeyUp);
            // 
            // txtb_Search
            // 
            this.txtb_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtb_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtb_Search.Location = new System.Drawing.Point(25, 37);
            this.txtb_Search.Name = "txtb_Search";
            this.txtb_Search.Size = new System.Drawing.Size(338, 20);
            this.txtb_Search.TabIndex = 0;
            this.txtb_Search.UseSystemPasswordChar = true;
            this.txtb_Search.TextChanged += new System.EventHandler(this.txtb_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(826, 507);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(66, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(25, 507);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // clbox_SearchMode
            // 
            this.clbox_SearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clbox_SearchMode.Items.AddRange(new object[] {
            "Website",
            "E-Mail",
            "First name",
            "Last name",
            "Password",
            "Username"});
            this.clbox_SearchMode.Location = new System.Drawing.Point(403, 37);
            this.clbox_SearchMode.Name = "clbox_SearchMode";
            this.clbox_SearchMode.Size = new System.Drawing.Size(121, 21);
            this.clbox_SearchMode.TabIndex = 10;
            this.clbox_SearchMode.SelectedIndexChanged += new System.EventHandler(this.cbox_SearchMode_SelectedIndexChanged);
            // 
            // cb_ShowPassword
            // 
            this.cb_ShowPassword.AutoSize = true;
            this.cb_ShowPassword.Location = new System.Drawing.Point(565, 41);
            this.cb_ShowPassword.Name = "cb_ShowPassword";
            this.cb_ShowPassword.Size = new System.Drawing.Size(106, 17);
            this.cb_ShowPassword.TabIndex = 11;
            this.cb_ShowPassword.Text = "Show passwords";
            this.cb_ShowPassword.UseVisualStyleBackColor = true;
            this.cb_ShowPassword.CheckStateChanged += new System.EventHandler(this.cb_ShowPassword_CheckStateChanged);
            // 
            // Storage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(904, 542);
            this.Controls.Add(this.cb_ShowPassword);
            this.Controls.Add(this.clbox_SearchMode);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_Search);
            this.Controls.Add(this.dataGrid_Logins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Storage_Form";
            this.Text = "Storage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Storage_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Logins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        public DataGridView dataGrid_Logins;
        public ComboBox clbox_SearchMode;
        public TextBox txtb_Search;
        public CheckBox cb_ShowPassword;
    }
}