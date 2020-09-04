namespace db_OnePointVM
{
    partial class frmTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLateCharges = new System.Windows.Forms.MaskedTextBox();
            this.cboDrivers = new System.Windows.Forms.ComboBox();
            this.cboVehicles = new System.Windows.Forms.ComboBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.dtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.nmrLateDays = new System.Windows.Forms.NumericUpDown();
            this.rdoReturn = new System.Windows.Forms.RadioButton();
            this.rdoOneWay = new System.Windows.Forms.RadioButton();
            this.txtCharges = new System.Windows.Forms.MaskedTextBox();
            this.txtDistanceKM = new System.Windows.Forms.MaskedTextBox();
            this.txtCurrentLoc = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDesctination = new System.Windows.Forms.MaskedTextBox();
            this.txtSource = new System.Windows.Forms.MaskedTextBox();
            this.txtClientMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtClientCNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtClientName = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAllPending = new System.Windows.Forms.RadioButton();
            this.rdoAllToday = new System.Windows.Forms.RadioButton();
            this.dtGridTransactions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGetID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLateDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACTION FORM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtLateCharges);
            this.groupBox1.Controls.Add(this.cboDrivers);
            this.groupBox1.Controls.Add(this.cboVehicles);
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.dtTransactionDate);
            this.groupBox1.Controls.Add(this.nmrLateDays);
            this.groupBox1.Controls.Add(this.rdoReturn);
            this.groupBox1.Controls.Add(this.rdoOneWay);
            this.groupBox1.Controls.Add(this.txtCharges);
            this.groupBox1.Controls.Add(this.txtDistanceKM);
            this.groupBox1.Controls.Add(this.txtCurrentLoc);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDesctination);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.txtClientMobile);
            this.groupBox1.Controls.Add(this.txtClientCNIC);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTransID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Order";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(772, 134);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(58, 17);
            this.chkStatus.TabIndex = 43;
            this.chkStatus.Text = "Done?";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(726, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Status:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(290, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Late Charges:";
            // 
            // txtLateCharges
            // 
            this.txtLateCharges.Location = new System.Drawing.Point(369, 132);
            this.txtLateCharges.Name = "txtLateCharges";
            this.txtLateCharges.ReadOnly = true;
            this.txtLateCharges.Size = new System.Drawing.Size(138, 20);
            this.txtLateCharges.TabIndex = 40;
            // 
            // cboDrivers
            // 
            this.cboDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrivers.FormattingEnabled = true;
            this.cboDrivers.Items.AddRange(new object[] {
            "CAR",
            "TRUCK",
            "BUS",
            "WAGON",
            "JEEP",
            "MAZDA"});
            this.cboDrivers.Location = new System.Drawing.Point(531, 48);
            this.cboDrivers.Name = "cboDrivers";
            this.cboDrivers.Size = new System.Drawing.Size(130, 21);
            this.cboDrivers.TabIndex = 39;
            // 
            // cboVehicles
            // 
            this.cboVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicles.FormattingEnabled = true;
            this.cboVehicles.Items.AddRange(new object[] {
            "CAR",
            "TRUCK",
            "BUS",
            "WAGON",
            "JEEP",
            "MAZDA"});
            this.cboVehicles.Location = new System.Drawing.Point(325, 48);
            this.cboVehicles.Name = "cboVehicles";
            this.cboVehicles.Size = new System.Drawing.Size(142, 21);
            this.cboVehicles.TabIndex = 38;
            this.cboVehicles.SelectedIndexChanged += new System.EventHandler(this.cboVehicles_SelectedIndexChanged);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "BUS",
            "CAR",
            "JEEP",
            "MAZDA",
            "TRUCK",
            "WAGON"});
            this.cmbVehicleType.Location = new System.Drawing.Point(91, 48);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(154, 21);
            this.cmbVehicleType.Sorted = true;
            this.cmbVehicleType.TabIndex = 37;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // dtTransactionDate
            // 
            this.dtTransactionDate.Enabled = false;
            this.dtTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransactionDate.Location = new System.Drawing.Point(388, 18);
            this.dtTransactionDate.Name = "dtTransactionDate";
            this.dtTransactionDate.Size = new System.Drawing.Size(119, 20);
            this.dtTransactionDate.TabIndex = 36;
            this.dtTransactionDate.TabStop = false;
            // 
            // nmrLateDays
            // 
            this.nmrLateDays.Location = new System.Drawing.Point(600, 133);
            this.nmrLateDays.Name = "nmrLateDays";
            this.nmrLateDays.Size = new System.Drawing.Size(79, 20);
            this.nmrLateDays.TabIndex = 35;
            this.nmrLateDays.ValueChanged += new System.EventHandler(this.nmrLateDays_ValueChanged);
            // 
            // rdoReturn
            // 
            this.rdoReturn.AutoSize = true;
            this.rdoReturn.Location = new System.Drawing.Point(863, 49);
            this.rdoReturn.Name = "rdoReturn";
            this.rdoReturn.Size = new System.Drawing.Size(57, 17);
            this.rdoReturn.TabIndex = 34;
            this.rdoReturn.Text = "Return";
            this.rdoReturn.UseVisualStyleBackColor = true;
            // 
            // rdoOneWay
            // 
            this.rdoOneWay.AutoSize = true;
            this.rdoOneWay.Checked = true;
            this.rdoOneWay.Location = new System.Drawing.Point(787, 49);
            this.rdoOneWay.Name = "rdoOneWay";
            this.rdoOneWay.Size = new System.Drawing.Size(70, 17);
            this.rdoOneWay.TabIndex = 33;
            this.rdoOneWay.TabStop = true;
            this.rdoOneWay.Text = "One Way";
            this.rdoOneWay.UseVisualStyleBackColor = true;
            // 
            // txtCharges
            // 
            this.txtCharges.Location = new System.Drawing.Point(73, 132);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.ReadOnly = true;
            this.txtCharges.Size = new System.Drawing.Size(192, 20);
            this.txtCharges.TabIndex = 32;
            // 
            // txtDistanceKM
            // 
            this.txtDistanceKM.Location = new System.Drawing.Point(851, 104);
            this.txtDistanceKM.Mask = "0000";
            this.txtDistanceKM.Name = "txtDistanceKM";
            this.txtDistanceKM.Size = new System.Drawing.Size(70, 20);
            this.txtDistanceKM.TabIndex = 31;
            this.txtDistanceKM.Text = "0";
            this.txtDistanceKM.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDistanceKM_MaskInputRejected);
            this.txtDistanceKM.Leave += new System.EventHandler(this.txtDistanceKM_Leave);
            // 
            // txtCurrentLoc
            // 
            this.txtCurrentLoc.Location = new System.Drawing.Point(354, 104);
            this.txtCurrentLoc.Name = "txtCurrentLoc";
            this.txtCurrentLoc.Size = new System.Drawing.Size(153, 20);
            this.txtCurrentLoc.TabIndex = 30;
            this.txtCurrentLoc.Text = "None";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(260, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Current Location:";
            // 
            // txtDesctination
            // 
            this.txtDesctination.Location = new System.Drawing.Point(600, 104);
            this.txtDesctination.Name = "txtDesctination";
            this.txtDesctination.Size = new System.Drawing.Size(148, 20);
            this.txtDesctination.TabIndex = 28;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(68, 104);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(177, 20);
            this.txtSource.TabIndex = 27;
            // 
            // txtClientMobile
            // 
            this.txtClientMobile.Location = new System.Drawing.Point(607, 76);
            this.txtClientMobile.Mask = "(0000) 000-0000";
            this.txtClientMobile.Name = "txtClientMobile";
            this.txtClientMobile.Size = new System.Drawing.Size(160, 20);
            this.txtClientMobile.TabIndex = 26;
            // 
            // txtClientCNIC
            // 
            this.txtClientCNIC.Location = new System.Drawing.Point(360, 76);
            this.txtClientCNIC.Mask = "00000-0000000-0";
            this.txtClientCNIC.Name = "txtClientCNIC";
            this.txtClientCNIC.Size = new System.Drawing.Size(147, 20);
            this.txtClientCNIC.TabIndex = 25;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(91, 76);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(174, 20);
            this.txtClientName.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Vehicle Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(531, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Late Days:";
            // 
            // txtTransID
            // 
            this.txtTransID.Enabled = false;
            this.txtTransID.Location = new System.Drawing.Point(101, 18);
            this.txtTransID.Mask = "?????-000";
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(164, 20);
            this.txtTransID.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Charges:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(765, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Distance (KM) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Destination:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Source:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Trip Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Driver ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vehicle ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Client Mobile:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client CNIC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transaction Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transaction ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAllPending);
            this.groupBox2.Controls.Add(this.rdoAllToday);
            this.groupBox2.Controls.Add(this.dtGridTransactions);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 295);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions Detail";
            // 
            // rdoAllPending
            // 
            this.rdoAllPending.AutoSize = true;
            this.rdoAllPending.Location = new System.Drawing.Point(263, 19);
            this.rdoAllPending.Name = "rdoAllPending";
            this.rdoAllPending.Size = new System.Drawing.Size(89, 17);
            this.rdoAllPending.TabIndex = 2;
            this.rdoAllPending.Text = "All in Pending";
            this.rdoAllPending.UseVisualStyleBackColor = true;
            this.rdoAllPending.CheckedChanged += new System.EventHandler(this.rdoAllPending_CheckedChanged);
            // 
            // rdoAllToday
            // 
            this.rdoAllToday.AutoSize = true;
            this.rdoAllToday.Checked = true;
            this.rdoAllToday.Location = new System.Drawing.Point(136, 19);
            this.rdoAllToday.Name = "rdoAllToday";
            this.rdoAllToday.Size = new System.Drawing.Size(109, 17);
            this.rdoAllToday.TabIndex = 1;
            this.rdoAllToday.TabStop = true;
            this.rdoAllToday.Text = "Added Today (All)";
            this.rdoAllToday.UseVisualStyleBackColor = true;
            this.rdoAllToday.CheckedChanged += new System.EventHandler(this.rdoAllToday_CheckedChanged);
            // 
            // dtGridTransactions
            // 
            this.dtGridTransactions.AllowUserToAddRows = false;
            this.dtGridTransactions.AllowUserToDeleteRows = false;
            this.dtGridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTransactions.Location = new System.Drawing.Point(16, 42);
            this.dtGridTransactions.Name = "dtGridTransactions";
            this.dtGridTransactions.ReadOnly = true;
            this.dtGridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridTransactions.Size = new System.Drawing.Size(905, 234);
            this.dtGridTransactions.TabIndex = 0;
            this.dtGridTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridTransactions_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(498, 526);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(619, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Existing";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(758, 526);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(113, 23);
            this.btnClearFields.TabIndex = 5;
            this.btnClearFields.Text = "Clear All Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(877, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGetID
            // 
            this.lblGetID.AutoSize = true;
            this.lblGetID.Location = new System.Drawing.Point(17, 22);
            this.lblGetID.Name = "lblGetID";
            this.lblGetID.Size = new System.Drawing.Size(73, 13);
            this.lblGetID.TabIndex = 44;
            this.lblGetID.Text = "___________";
            this.lblGetID.TextChanged += new System.EventHandler(this.lblGetID_TextChanged);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.lblGetID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLateDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridTransactions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtTransID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtClientMobile;
        private System.Windows.Forms.MaskedTextBox txtClientCNIC;
        private System.Windows.Forms.MaskedTextBox txtClientName;
        private System.Windows.Forms.MaskedTextBox txtDesctination;
        private System.Windows.Forms.MaskedTextBox txtSource;
        private System.Windows.Forms.MaskedTextBox txtCurrentLoc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtDistanceKM;
        private System.Windows.Forms.MaskedTextBox txtCharges;
        private System.Windows.Forms.RadioButton rdoOneWay;
        private System.Windows.Forms.RadioButton rdoReturn;
        private System.Windows.Forms.NumericUpDown nmrLateDays;
        private System.Windows.Forms.DateTimePicker dtTransactionDate;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cboVehicles;
        private System.Windows.Forms.ComboBox cboDrivers;
        private System.Windows.Forms.RadioButton rdoAllToday;
        private System.Windows.Forms.RadioButton rdoAllPending;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtLateCharges;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label lblGetID;
    }
}