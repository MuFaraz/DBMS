namespace db_OnePointVM
{
    partial class frmSearchVehicle
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtSearchVehicle = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDrivenBy = new System.Windows.Forms.RadioButton();
            this.rdoVehicleID = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearchVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSearchText);
            this.groupBox3.Controls.Add(this.txtSearchText);
            this.groupBox3.Location = new System.Drawing.Point(224, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 52);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Value";
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(30, 22);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(87, 13);
            this.lblSearchText.TabIndex = 1;
            this.lblSearchText.Text = "Enter Vehicle ID:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(133, 19);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(167, 20);
            this.txtSearchText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtSearchVehicle);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 276);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // dtSearchVehicle
            // 
            this.dtSearchVehicle.AllowUserToAddRows = false;
            this.dtSearchVehicle.AllowUserToDeleteRows = false;
            this.dtSearchVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSearchVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSearchVehicle.Location = new System.Drawing.Point(22, 30);
            this.dtSearchVehicle.Name = "dtSearchVehicle";
            this.dtSearchVehicle.ReadOnly = true;
            this.dtSearchVehicle.Size = new System.Drawing.Size(610, 225);
            this.dtSearchVehicle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDrivenBy);
            this.groupBox1.Controls.Add(this.rdoVehicleID);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // rdoDrivenBy
            // 
            this.rdoDrivenBy.AutoSize = true;
            this.rdoDrivenBy.Location = new System.Drawing.Point(110, 22);
            this.rdoDrivenBy.Name = "rdoDrivenBy";
            this.rdoDrivenBy.Size = new System.Drawing.Size(70, 17);
            this.rdoDrivenBy.TabIndex = 1;
            this.rdoDrivenBy.Text = "Driven by";
            this.rdoDrivenBy.UseVisualStyleBackColor = true;
            this.rdoDrivenBy.CheckedChanged += new System.EventHandler(this.rdoDrivenBy_CheckedChanged);
            // 
            // rdoVehicleID
            // 
            this.rdoVehicleID.AutoSize = true;
            this.rdoVehicleID.Checked = true;
            this.rdoVehicleID.Location = new System.Drawing.Point(30, 22);
            this.rdoVehicleID.Name = "rdoVehicleID";
            this.rdoVehicleID.Size = new System.Drawing.Size(73, 17);
            this.rdoVehicleID.TabIndex = 3;
            this.rdoVehicleID.TabStop = true;
            this.rdoVehicleID.Text = "Unique ID";
            this.rdoVehicleID.UseVisualStyleBackColor = true;
            this.rdoVehicleID.CheckedChanged += new System.EventHandler(this.rdoVehicleID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "SEARCH VEHICLE";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 399);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(476, 399);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(587, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 440);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearchVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Vehicle";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSearchVehicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtSearchText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtSearchVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDrivenBy;
        private System.Windows.Forms.RadioButton rdoVehicleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSearchText;
    }
}