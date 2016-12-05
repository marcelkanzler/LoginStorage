namespace Login_storage
{
    partial class Form_EditData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditData));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.txtb_LastName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txtb_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txtb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Website = new System.Windows.Forms.Label();
            this.txtb_Website = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(324, 243);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_Okay
            // 
            this.btn_Okay.BackColor = System.Drawing.Color.Lime;
            this.btn_Okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Okay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Okay.Location = new System.Drawing.Point(405, 243);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(75, 23);
            this.btn_Okay.TabIndex = 7;
            this.btn_Okay.Text = "OK";
            this.btn_Okay.UseVisualStyleBackColor = false;
            this.btn_Okay.Click += new System.EventHandler(this.Btn_Okay_Click);
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(9, 209);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(70, 16);
            this.lbl_LastName.TabIndex = 25;
            this.lbl_LastName.Text = "Last name";
            // 
            // txtb_LastName
            // 
            this.txtb_LastName.Location = new System.Drawing.Point(85, 208);
            this.txtb_LastName.Name = "txtb_LastName";
            this.txtb_LastName.Size = new System.Drawing.Size(373, 20);
            this.txtb_LastName.TabIndex = 5;
            this.txtb_LastName.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(9, 171);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(70, 16);
            this.lbl_FirstName.TabIndex = 23;
            this.lbl_FirstName.Text = "First name";
            // 
            // txtb_FirstName
            // 
            this.txtb_FirstName.Location = new System.Drawing.Point(85, 170);
            this.txtb_FirstName.Name = "txtb_FirstName";
            this.txtb_FirstName.Size = new System.Drawing.Size(373, 20);
            this.txtb_FirstName.TabIndex = 4;
            this.txtb_FirstName.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_FirstName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(11, 133);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(68, 16);
            this.lbl_Password.TabIndex = 21;
            this.lbl_Password.Text = "Password";
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(85, 132);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.Size = new System.Drawing.Size(373, 20);
            this.txtb_Password.TabIndex = 3;
            this.txtb_Password.UseSystemPasswordChar = true;
            this.txtb_Password.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(8, 95);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(71, 16);
            this.lbl_Username.TabIndex = 19;
            this.lbl_Username.Text = "Username";
            // 
            // txtb_Username
            // 
            this.txtb_Username.Location = new System.Drawing.Point(85, 94);
            this.txtb_Username.Name = "txtb_Username";
            this.txtb_Username.Size = new System.Drawing.Size(373, 20);
            this.txtb_Username.TabIndex = 2;
            this.txtb_Username.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_Username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(37, 57);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 16);
            this.lbl_Email.TabIndex = 17;
            this.lbl_Email.Text = "Email";
            // 
            // txtb_Email
            // 
            this.txtb_Email.Location = new System.Drawing.Point(85, 56);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.Size = new System.Drawing.Size(373, 20);
            this.txtb_Email.TabIndex = 1;
            this.txtb_Email.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // lbl_Website
            // 
            this.lbl_Website.AutoSize = true;
            this.lbl_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Website.Location = new System.Drawing.Point(21, 19);
            this.lbl_Website.Name = "lbl_Website";
            this.lbl_Website.Size = new System.Drawing.Size(58, 16);
            this.lbl_Website.TabIndex = 15;
            this.lbl_Website.Text = "Website";
            // 
            // txtb_Website
            // 
            this.txtb_Website.Location = new System.Drawing.Point(85, 18);
            this.txtb_Website.Name = "txtb_Website";
            this.txtb_Website.Size = new System.Drawing.Size(373, 20);
            this.txtb_Website.TabIndex = 0;
            this.txtb_Website.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            this.txtb_Website.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(11, 243);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // cb_ShowPassword
            // 
            this.cb_ShowPassword.AutoSize = true;
            this.cb_ShowPassword.Location = new System.Drawing.Point(174, 247);
            this.cb_ShowPassword.Name = "cb_ShowPassword";
            this.cb_ShowPassword.Size = new System.Drawing.Size(101, 17);
            this.cb_ShowPassword.TabIndex = 27;
            this.cb_ShowPassword.Text = "Show password";
            this.cb_ShowPassword.UseVisualStyleBackColor = true;
            this.cb_ShowPassword.CheckStateChanged += new System.EventHandler(this.Cb_ShowPassword_CheckStateChanged);
            this.cb_ShowPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtb_Website_KeyUp);
            // 
            // Form_EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(490, 270);
            this.Controls.Add(this.cb_ShowPassword);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.txtb_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txtb_FirstName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtb_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txtb_Username);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txtb_Email);
            this.Controls.Add(this.lbl_Website);
            this.Controls.Add(this.txtb_Website);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_EditData";
            this.Text = "Edit data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditData_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Okay;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txtb_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txtb_FirstName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txtb_Username;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtb_Email;
        private System.Windows.Forms.Label lbl_Website;
        private System.Windows.Forms.TextBox txtb_Website;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.CheckBox cb_ShowPassword;
    }
}