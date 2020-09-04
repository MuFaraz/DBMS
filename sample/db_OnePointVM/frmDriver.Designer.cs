namespace db_OnePointVM
{
    partial class frmDriver
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccidents = new System.Windows.Forms.MaskedTextBox();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.txtExperience = new System.Windows.Forms.MaskedTextBox();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtAge = new System.Windows.Forms.MaskedTextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.dtToday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.rdoDriverNotAvailable = new System.Windows.Forms.RadioButton();
            this.rdoDriverAvailable = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictDriver = new System.Windows.Forms.PictureBox();
            this.grpBoxDriver = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDriverSelectionID = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowseDrivers = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictDriver)).BeginInit();
            this.grpBoxDriver.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccidents);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtExperience);
            this.groupBox1.Controls.Add(this.txtCNIC);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtFatherName);
            this.groupBox1.Controls.Add(this.txtDriverName);
            this.groupBox1.Controls.Add(this.dtToday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDriverID);
            this.groupBox1.Controls.Add(this.rdoDriverNotAvailable);
            this.groupBox1.Controls.Add(this.rdoDriverAvailable);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictDriver);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver\'s Information";
            // 
            // txtAccidents
            // 
            this.txtAccidents.HideSelection = false;
            this.txtAccidents.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtAccidents.Location = new System.Drawing.Point(292, 218);
            this.txtAccidents.Mask = "00";
            this.txtAccidents.Name = "txtAccidents";
            this.txtAccidents.Size = new System.Drawing.Size(48, 20);
            this.txtAccidents.TabIndex = 6;
            this.txtAccidents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(57, 218);
            this.txtSalary.Mask = "00000";
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(54, 20);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.TabStop = false;
            this.txtSalary.Text = "15000";
            // 
            // txtExperience
            // 
            this.txtExperience.HideSelection = false;
            this.txtExperience.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtExperience.Location = new System.Drawing.Point(312, 186);
            this.txtExperience.Mask = "00";
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(28, 20);
            this.txtExperience.TabIndex = 5;
            this.txtExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(57, 186);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(104, 20);
            this.txtCNIC.TabIndex = 4;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(135, 155);
            this.txtMobile.Mask = "(9999) 000-0000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(91, 20);
            this.txtMobile.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.HideSelection = false;
            this.txtAge.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtAge.Location = new System.Drawing.Point(51, 155);
            this.txtAge.Mask = "00";
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(34, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(62, 124);
            this.txtFatherName.MaxLength = 20;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(164, 20);
            this.txtFatherName.TabIndex = 1;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(60, 93);
            this.txtDriverName.MaxLength = 20;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(166, 20);
            this.txtDriverName.TabIndex = 0;
            // 
            // dtToday
            // 
            this.dtToday.Enabled = false;
            this.dtToday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToday.Location = new System.Drawing.Point(90, 62);
            this.dtToday.Name = "dtToday";
            this.dtToday.Size = new System.Drawing.Size(136, 20);
            this.dtToday.TabIndex = 9;
            this.dtToday.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Driver Since:";
            // 
            // txtDriverID
            // 
            this.txtDriverID.Location = new System.Drawing.Point(118, 31);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.ReadOnly = true;
            this.txtDriverID.Size = new System.Drawing.Size(108, 20);
            this.txtDriverID.TabIndex = 4;
            this.txtDriverID.TabStop = false;
            // 
            // rdoDriverNotAvailable
            // 
            this.rdoDriverNotAvailable.AutoSize = true;
            this.rdoDriverNotAvailable.Location = new System.Drawing.Point(188, 251);
            this.rdoDriverNotAvailable.Name = "rdoDriverNotAvailable";
            this.rdoDriverNotAvailable.Size = new System.Drawing.Size(67, 17);
            this.rdoDriverNotAvailable.TabIndex = 8;
            this.rdoDriverNotAvailable.Text = "Not Now";
            this.rdoDriverNotAvailable.UseVisualStyleBackColor = true;
            // 
            // rdoDriverAvailable
            // 
            this.rdoDriverAvailable.AutoSize = true;
            this.rdoDriverAvailable.Checked = true;
            this.rdoDriverAvailable.Location = new System.Drawing.Point(118, 251);
            this.rdoDriverAvailable.Name = "rdoDriverAvailable";
            this.rdoDriverAvailable.Size = new System.Drawing.Size(43, 17);
            this.rdoDriverAvailable.TabIndex = 7;
            this.rdoDriverAvailable.TabStop = true;
            this.rdoDriverAvailable.Text = "Yes";
            this.rdoDriverAvailable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Is Availabile?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Number of Accidents (in History):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Salary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Driving Experience (Years):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mobile:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CNIC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Father:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver ID (Unique):";
            // 
            // pictDriver
            // 
            this.pictDriver.Image = global::db_OnePointVM.Properties.Resources.driver;
            this.pictDriver.Location = new System.Drawing.Point(240, 53);
            this.pictDriver.Name = "pictDriver";
            this.pictDriver.Size = new System.Drawing.Size(100, 100);
            this.pictDriver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictDriver.TabIndex = 0;
            this.pictDriver.TabStop = false;
            // 
            // grpBoxDriver
            // 
            this.grpBoxDriver.Controls.Add(this.btnExit);
            this.grpBoxDriver.Controls.Add(this.btnClearAll);
            this.grpBoxDriver.Controls.Add(this.btnDeleteDriver);
            this.grpBoxDriver.Controls.Add(this.btnUpdateDriver);
            this.grpBoxDriver.Controls.Add(this.btnAddDriver);
            this.grpBoxDriver.Location = new System.Drawing.Point(12, 391);
            this.grpBoxDriver.Name = "grpBoxDriver";
            this.grpBoxDriver.Size = new System.Drawing.Size(355, 90);
            this.grpBoxDriver.TabIndex = 0;
            this.grpBoxDriver.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 49);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(19, 49);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(163, 23);
            this.btnClearAll.TabIndex = 12;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteDriver.Location = new System.Drawing.Point(237, 22);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteDriver.TabIndex = 11;
            this.btnDeleteDriver.Text = "Delete";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.Location = new System.Drawing.Point(135, 22);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(96, 23);
            this.btnUpdateDriver.TabIndex = 10;
            this.btnUpdateDriver.Text = "Update";
            this.btnUpdateDriver.UseVisualStyleBackColor = true;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(19, 22);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(110, 23);
            this.btnAddDriver.TabIndex = 9;
            this.btnAddDriver.Text = "Add New Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDriverSelectionID);
            this.groupBox2.Controls.Add(this.btnBrowseDrivers);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification Section";
            // 
            // txtDriverSelectionID
            // 
            this.txtDriverSelectionID.HideSelection = false;
            this.txtDriverSelectionID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtDriverSelectionID.Location = new System.Drawing.Point(102, 28);
            this.txtDriverSelectionID.Mask = "???-000";
            this.txtDriverSelectionID.Name = "txtDriverSelectionID";
            this.txtDriverSelectionID.ReadOnly = true;
            this.txtDriverSelectionID.Size = new System.Drawing.Size(86, 20);
            this.txtDriverSelectionID.TabIndex = 18;
            this.txtDriverSelectionID.TabStop = false;
            // 
            // btnBrowseDrivers
            // 
            this.btnBrowseDrivers.Location = new System.Drawing.Point(210, 26);
            this.btnBrowseDrivers.Name = "btnBrowseDrivers";
            this.btnBrowseDrivers.Size = new System.Drawing.Size(114, 23);
            this.btnBrowseDrivers.TabIndex = 2;
            this.btnBrowseDrivers.TabStop = false;
            this.btnBrowseDrivers.Text = "Browse List";
            this.btnBrowseDrivers.UseVisualStyleBackColor = true;
            this.btnBrowseDrivers.Click += new System.EventHandler(this.btnBrowseDrivers_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Driver ID:";
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxDriver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.frmDriver_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictDriver)).EndInit();
            this.grpBoxDriver.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxDriver;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.PictureBox pictDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.DateTimePicker dtToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBrowseDrivers;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.MaskedTextBox txtAge;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private System.Windows.Forms.MaskedTextBox txtExperience;
        private System.Windows.Forms.MaskedTextBox txtSalary;
        private System.Windows.Forms.MaskedTextBox txtAccidents;
        private System.Windows.Forms.MaskedTextBox txtDriverSelectionID;
        private System.Windows.Forms.RadioButton rdoDriverNotAvailable;
        private System.Windows.Forms.RadioButton rdoDriverAvailable;
    }
}