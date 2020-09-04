namespace db_OnePointVM
{
    partial class frmVehicle
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
            this.cmboMaker = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.dtMadeYear = new System.Windows.Forms.DateTimePicker();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtFitnessFrom = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtChasis = new System.Windows.Forms.MaskedTextBox();
            this.txtEngine = new System.Windows.Forms.MaskedTextBox();
            this.txtModel = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowseVehicle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.MaskedTextBox();
            this.rdoVehicleUnavilable = new System.Windows.Forms.RadioButton();
            this.rdoVehicleAvailable = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnClearAllFields = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboMaker);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.dtMadeYear);
            this.groupBox1.Controls.Add(this.dtPurchaseDate);
            this.groupBox1.Controls.Add(this.dtExpiry);
            this.groupBox1.Controls.Add(this.dtFitnessFrom);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtChasis);
            this.groupBox1.Controls.Add(this.txtEngine);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.btnBrowseVehicle);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtVehicleID);
            this.groupBox1.Controls.Add(this.rdoVehicleUnavilable);
            this.groupBox1.Controls.Add(this.rdoVehicleAvailable);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Info";
            // 
            // cmboMaker
            // 
            this.cmboMaker.FormattingEnabled = true;
            this.cmboMaker.Items.AddRange(new object[] {
            "HONDA",
            "TOYOTA",
            "FORD",
            "MAZDA",
            "NISSAN",
            "BMW",
            "HYUNDAI"});
            this.cmboMaker.Location = new System.Drawing.Point(61, 61);
            this.cmboMaker.Name = "cmboMaker";
            this.cmboMaker.Size = new System.Drawing.Size(195, 21);
            this.cmboMaker.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Fitness Certificate:";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "CAR",
            "TRUCK",
            "BUS",
            "WAGON",
            "JEEP",
            "MAZDA"});
            this.cmbVehicleType.Location = new System.Drawing.Point(68, 95);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(188, 21);
            this.cmbVehicleType.TabIndex = 3;
            // 
            // dtMadeYear
            // 
            this.dtMadeYear.CustomFormat = "";
            this.dtMadeYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMadeYear.Location = new System.Drawing.Point(349, 95);
            this.dtMadeYear.Name = "dtMadeYear";
            this.dtMadeYear.Size = new System.Drawing.Size(153, 20);
            this.dtMadeYear.TabIndex = 4;
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.CustomFormat = "";
            this.dtPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPurchaseDate.Location = new System.Drawing.Point(348, 163);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(153, 20);
            this.dtPurchaseDate.TabIndex = 8;
            // 
            // dtExpiry
            // 
            this.dtExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpiry.Location = new System.Drawing.Point(305, 218);
            this.dtExpiry.Name = "dtExpiry";
            this.dtExpiry.Size = new System.Drawing.Size(196, 20);
            this.dtExpiry.TabIndex = 10;
            // 
            // dtFitnessFrom
            // 
            this.dtFitnessFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFitnessFrom.Location = new System.Drawing.Point(61, 218);
            this.dtFitnessFrom.Name = "dtFitnessFrom";
            this.dtFitnessFrom.Size = new System.Drawing.Size(195, 20);
            this.dtFitnessFrom.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 163);
            this.txtPrice.Mask = "0000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0000000";
            // 
            // txtChasis
            // 
            this.txtChasis.Location = new System.Drawing.Point(349, 129);
            this.txtChasis.Mask = "000-0000";
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(152, 20);
            this.txtChasis.TabIndex = 6;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(111, 129);
            this.txtEngine.Mask = "000-0000";
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(145, 20);
            this.txtEngine.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(307, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(194, 20);
            this.txtModel.TabIndex = 2;
            // 
            // btnBrowseVehicle
            // 
            this.btnBrowseVehicle.Location = new System.Drawing.Point(245, 27);
            this.btnBrowseVehicle.Name = "btnBrowseVehicle";
            this.btnBrowseVehicle.Size = new System.Drawing.Size(107, 20);
            this.btnBrowseVehicle.TabIndex = 0;
            this.btnBrowseVehicle.Text = "Browse List";
            this.btnBrowseVehicle.UseVisualStyleBackColor = true;
            this.btnBrowseVehicle.Click += new System.EventHandler(this.btnBrowseVehicle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "OR";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(115, 27);
            this.txtVehicleID.Mask = "???-0000";
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(95, 20);
            this.txtVehicleID.TabIndex = 0;
            // 
            // rdoVehicleUnavilable
            // 
            this.rdoVehicleUnavilable.AutoSize = true;
            this.rdoVehicleUnavilable.Location = new System.Drawing.Point(216, 254);
            this.rdoVehicleUnavilable.Name = "rdoVehicleUnavilable";
            this.rdoVehicleUnavilable.Size = new System.Drawing.Size(168, 17);
            this.rdoVehicleUnavilable.TabIndex = 12;
            this.rdoVehicleUnavilable.Text = "Unavailable / To be Delivered";
            this.rdoVehicleUnavilable.UseVisualStyleBackColor = true;
            // 
            // rdoVehicleAvailable
            // 
            this.rdoVehicleAvailable.AutoSize = true;
            this.rdoVehicleAvailable.Checked = true;
            this.rdoVehicleAvailable.Location = new System.Drawing.Point(132, 254);
            this.rdoVehicleAvailable.Name = "rdoVehicleAvailable";
            this.rdoVehicleAvailable.Size = new System.Drawing.Size(68, 17);
            this.rdoVehicleAvailable.TabIndex = 11;
            this.rdoVehicleAvailable.TabStop = true;
            this.rdoVehicleAvailable.Text = "Available";
            this.rdoVehicleAvailable.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Availability Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Expiry:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Purchase Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Purchasing (Amount):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chasis Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Engine Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Made In (Year):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maker:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Vehicle ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "VEHICLE FORM";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(12, 371);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(105, 35);
            this.btnAddVehicle.TabIndex = 13;
            this.btnAddVehicle.Text = "Add New";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(123, 371);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(99, 35);
            this.btnUpdateVehicle.TabIndex = 14;
            this.btnUpdateVehicle.Text = "Update";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(228, 371);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(103, 35);
            this.btnDeleteVehicle.TabIndex = 15;
            this.btnDeleteVehicle.Text = "Delete";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnClearAllFields
            // 
            this.btnClearAllFields.Location = new System.Drawing.Point(337, 371);
            this.btnClearAllFields.Name = "btnClearAllFields";
            this.btnClearAllFields.Size = new System.Drawing.Size(107, 35);
            this.btnClearAllFields.TabIndex = 16;
            this.btnClearAllFields.Text = "Clear All";
            this.btnClearAllFields.UseVisualStyleBackColor = true;
            this.btnClearAllFields.Click += new System.EventHandler(this.btnClearAllFields_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(450, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 35);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAllFields);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoVehicleUnavilable;
        private System.Windows.Forms.RadioButton rdoVehicleAvailable;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnClearAllFields;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox txtVehicleID;
        private System.Windows.Forms.Button btnBrowseVehicle;
        private System.Windows.Forms.MaskedTextBox txtModel;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtChasis;
        private System.Windows.Forms.MaskedTextBox txtEngine;
        private System.Windows.Forms.DateTimePicker dtMadeYear;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtExpiry;
        private System.Windows.Forms.DateTimePicker dtFitnessFrom;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmboMaker;
    }
}