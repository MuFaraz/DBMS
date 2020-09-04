namespace db_OnePointVM
{
    partial class frmMaintenance
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridMaintenance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoDaily = new System.Windows.Forms.RadioButton();
            this.rdoLastWeek = new System.Windows.Forms.RadioButton();
            this.rdoMaintenanceID = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMtcID = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNewID = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboVehicles = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMaintenance)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridMaintenance);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance History";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.cboVehicles);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNewID);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtParts);
            this.groupBox2.Controls.Add(this.dtMaintenanceDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 94);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Entry";
            // 
            // dtGridMaintenance
            // 
            this.dtGridMaintenance.AllowUserToAddRows = false;
            this.dtGridMaintenance.AllowUserToDeleteRows = false;
            this.dtGridMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMaintenance.Location = new System.Drawing.Point(20, 24);
            this.dtGridMaintenance.Name = "dtGridMaintenance";
            this.dtGridMaintenance.ReadOnly = true;
            this.dtGridMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridMaintenance.Size = new System.Drawing.Size(721, 262);
            this.dtGridMaintenance.TabIndex = 0;
            this.dtGridMaintenance.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAINTENANCE FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maintenance ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amount:";
            // 
            // dtMaintenanceDate
            // 
            this.dtMaintenanceDate.Enabled = false;
            this.dtMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMaintenanceDate.Location = new System.Drawing.Point(224, 32);
            this.dtMaintenanceDate.Name = "dtMaintenanceDate";
            this.dtMaintenanceDate.Size = new System.Drawing.Size(102, 20);
            this.dtMaintenanceDate.TabIndex = 6;
            this.dtMaintenanceDate.TabStop = false;
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(570, 32);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(156, 20);
            this.txtParts.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 58);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(498, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMtcID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rdoMaintenanceID);
            this.groupBox3.Controls.Add(this.rdoLastWeek);
            this.groupBox3.Controls.Add(this.rdoDaily);
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History Criteria";
            // 
            // rdoDaily
            // 
            this.rdoDaily.AutoSize = true;
            this.rdoDaily.Checked = true;
            this.rdoDaily.Location = new System.Drawing.Point(148, 19);
            this.rdoDaily.Name = "rdoDaily";
            this.rdoDaily.Size = new System.Drawing.Size(48, 17);
            this.rdoDaily.TabIndex = 3;
            this.rdoDaily.TabStop = true;
            this.rdoDaily.Text = "Daily";
            this.rdoDaily.UseVisualStyleBackColor = true;
            this.rdoDaily.CheckedChanged += new System.EventHandler(this.rdoDaily_CheckedChanged);
            // 
            // rdoLastWeek
            // 
            this.rdoLastWeek.AutoSize = true;
            this.rdoLastWeek.Location = new System.Drawing.Point(240, 19);
            this.rdoLastWeek.Name = "rdoLastWeek";
            this.rdoLastWeek.Size = new System.Drawing.Size(77, 17);
            this.rdoLastWeek.TabIndex = 4;
            this.rdoLastWeek.Text = "Last Week";
            this.rdoLastWeek.UseVisualStyleBackColor = true;
            this.rdoLastWeek.CheckedChanged += new System.EventHandler(this.rdoLastWeek_CheckedChanged);
            // 
            // rdoMaintenanceID
            // 
            this.rdoMaintenanceID.AutoSize = true;
            this.rdoMaintenanceID.Location = new System.Drawing.Point(355, 19);
            this.rdoMaintenanceID.Name = "rdoMaintenanceID";
            this.rdoMaintenanceID.Size = new System.Drawing.Size(51, 17);
            this.rdoMaintenanceID.TabIndex = 5;
            this.rdoMaintenanceID.Text = "By ID";
            this.rdoMaintenanceID.UseVisualStyleBackColor = true;
            this.rdoMaintenanceID.CheckedChanged += new System.EventHandler(this.rdoMaintenanceID_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter ID:";
            // 
            // txtMtcID
            // 
            this.txtMtcID.Location = new System.Drawing.Point(513, 18);
            this.txtMtcID.Mask = "?-000";
            this.txtMtcID.Name = "txtMtcID";
            this.txtMtcID.Size = new System.Drawing.Size(73, 20);
            this.txtMtcID.TabIndex = 7;
            this.txtMtcID.Leave += new System.EventHandler(this.txtMtcID_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(458, 515);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(572, 515);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(101, 34);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(679, 515);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewID
            // 
            this.txtNewID.Location = new System.Drawing.Point(109, 32);
            this.txtNewID.Mask = "?-000";
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.ReadOnly = true;
            this.txtNewID.Size = new System.Drawing.Size(57, 20);
            this.txtNewID.TabIndex = 8;
            this.txtNewID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vehicle ID:";
            // 
            // cboVehicles
            // 
            this.cboVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicles.FormattingEnabled = true;
            this.cboVehicles.Items.AddRange(new object[] {
            "BUS",
            "CAR",
            "JEEP",
            "MAZDA",
            "TRUCK",
            "WAGON"});
            this.cboVehicles.Location = new System.Drawing.Point(412, 31);
            this.cboVehicles.Name = "cboVehicles";
            this.cboVehicles.Size = new System.Drawing.Size(99, 21);
            this.cboVehicles.Sorted = true;
            this.cboVehicles.TabIndex = 39;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(667, 58);
            this.txtAmount.Mask = "00000";
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(59, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMaintenance)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtMaintenanceDate;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoDaily;
        private System.Windows.Forms.RadioButton rdoLastWeek;
        private System.Windows.Forms.RadioButton rdoMaintenanceID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtMtcID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtNewID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboVehicles;
        private System.Windows.Forms.MaskedTextBox txtAmount;
    }
}