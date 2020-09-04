namespace db_OnePointVM
{
    partial class frmUsers
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
            this.dtGridUsers = new System.Windows.Forms.DataGridView();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoLocalUser = new System.Windows.Forms.RadioButton();
            this.rdoUserAdmin = new System.Windows.Forms.RadioButton();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtNewUserPass = new System.Windows.Forms.TextBox();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnClearAllFields = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.pictUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsers)).BeginInit();
            this.grpUsers.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridUsers
            // 
            this.dtGridUsers.AllowUserToAddRows = false;
            this.dtGridUsers.AllowUserToDeleteRows = false;
            this.dtGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsers.Location = new System.Drawing.Point(19, 27);
            this.dtGridUsers.Name = "dtGridUsers";
            this.dtGridUsers.ReadOnly = true;
            this.dtGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridUsers.Size = new System.Drawing.Size(288, 369);
            this.dtGridUsers.TabIndex = 0;
            this.dtGridUsers.TabStop = false;
            this.dtGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUsers_SelectionChanged);
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.dtGridUsers);
            this.grpUsers.Location = new System.Drawing.Point(295, 12);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(327, 417);
            this.grpUsers.TabIndex = 10;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Users";
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.label3);
            this.grpUserInfo.Controls.Add(this.rdoLocalUser);
            this.grpUserInfo.Controls.Add(this.rdoUserAdmin);
            this.grpUserInfo.Controls.Add(this.chkShowPassword);
            this.grpUserInfo.Controls.Add(this.txtNewUserPass);
            this.grpUserInfo.Controls.Add(this.txtNewUser);
            this.grpUserInfo.Controls.Add(this.label2);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Location = new System.Drawing.Point(12, 249);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(265, 114);
            this.grpUserInfo.TabIndex = 3;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Type:";
            // 
            // rdoLocalUser
            // 
            this.rdoLocalUser.AutoSize = true;
            this.rdoLocalUser.Location = new System.Drawing.Point(149, 91);
            this.rdoLocalUser.Name = "rdoLocalUser";
            this.rdoLocalUser.Size = new System.Drawing.Size(55, 17);
            this.rdoLocalUser.TabIndex = 13;
            this.rdoLocalUser.Text = "USER";
            this.rdoLocalUser.UseVisualStyleBackColor = true;
            // 
            // rdoUserAdmin
            // 
            this.rdoUserAdmin.AutoSize = true;
            this.rdoUserAdmin.Enabled = false;
            this.rdoUserAdmin.Location = new System.Drawing.Point(83, 91);
            this.rdoUserAdmin.Name = "rdoUserAdmin";
            this.rdoUserAdmin.Size = new System.Drawing.Size(60, 17);
            this.rdoUserAdmin.TabIndex = 12;
            this.rdoUserAdmin.TabStop = true;
            this.rdoUserAdmin.Text = "ADMIN";
            this.rdoUserAdmin.UseVisualStyleBackColor = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(143, 19);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 11;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtNewUserPass
            // 
            this.txtNewUserPass.Location = new System.Drawing.Point(80, 68);
            this.txtNewUserPass.MaxLength = 16;
            this.txtNewUserPass.Name = "txtNewUserPass";
            this.txtNewUserPass.PasswordChar = '●';
            this.txtNewUserPass.Size = new System.Drawing.Size(165, 20);
            this.txtNewUserPass.TabIndex = 1;
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(93, 42);
            this.txtNewUser.MaxLength = 16;
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(152, 20);
            this.txtNewUser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "New User ID:";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(12, 369);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(89, 23);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.Text = "Add";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(202, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(202, 369);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(107, 369);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateUser.TabIndex = 12;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnClearAllFields
            // 
            this.btnClearAllFields.Location = new System.Drawing.Point(107, 398);
            this.btnClearAllFields.Name = "btnClearAllFields";
            this.btnClearAllFields.Size = new System.Drawing.Size(89, 23);
            this.btnClearAllFields.TabIndex = 13;
            this.btnClearAllFields.Text = "Clear All";
            this.btnClearAllFields.UseVisualStyleBackColor = true;
            this.btnClearAllFields.Click += new System.EventHandler(this.btnClearAllFields_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.Location = new System.Drawing.Point(12, 398);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(89, 23);
            this.btnRefreshUsers.TabIndex = 14;
            this.btnRefreshUsers.Text = "Refresh";
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // pictUser
            // 
            this.pictUser.Image = global::db_OnePointVM.Properties.Resources.user_account1;
            this.pictUser.Location = new System.Drawing.Point(46, 31);
            this.pictUser.Name = "pictUser";
            this.pictUser.Size = new System.Drawing.Size(200, 200);
            this.pictUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictUser.TabIndex = 2;
            this.pictUser.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.btnClearAllFields);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.grpUserInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictUser);
            this.Controls.Add(this.grpUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsers)).EndInit();
            this.grpUsers.ResumeLayout(false);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridUsers;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.PictureBox pictUser;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtNewUserPass;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnClearAllFields;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.RadioButton rdoLocalUser;
        private System.Windows.Forms.RadioButton rdoUserAdmin;
        private System.Windows.Forms.Label label3;
    }
}