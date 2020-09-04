namespace db_OnePointVM
{
    partial class frmSearchDriver
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
            this.btnSearchDriver = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoDriverID = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtSearchDriver = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoNotLike = new System.Windows.Forms.RadioButton();
            this.rdoContainig = new System.Windows.Forms.RadioButton();
            this.txtSearchText = new System.Windows.Forms.MaskedTextBox();
            this.rdoExact = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearchDriver)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH DRIVER";
            // 
            // btnSearchDriver
            // 
            this.btnSearchDriver.Location = new System.Drawing.Point(329, 404);
            this.btnSearchDriver.Name = "btnSearchDriver";
            this.btnSearchDriver.Size = new System.Drawing.Size(155, 35);
            this.btnSearchDriver.TabIndex = 1;
            this.btnSearchDriver.Text = "Search";
            this.btnSearchDriver.UseVisualStyleBackColor = true;
            this.btnSearchDriver.Click += new System.EventHandler(this.btnSearchDriver_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(490, 404);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSalary);
            this.groupBox1.Controls.Add(this.rdoName);
            this.groupBox1.Controls.Add(this.rdoDriverID);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.Location = new System.Drawing.Point(153, 22);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(54, 17);
            this.rdoSalary.TabIndex = 1;
            this.rdoSalary.Text = "Salary";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(97, 22);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(53, 17);
            this.rdoName.TabIndex = 2;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // rdoDriverID
            // 
            this.rdoDriverID.AutoSize = true;
            this.rdoDriverID.Checked = true;
            this.rdoDriverID.Location = new System.Drawing.Point(19, 22);
            this.rdoDriverID.Name = "rdoDriverID";
            this.rdoDriverID.Size = new System.Drawing.Size(73, 17);
            this.rdoDriverID.TabIndex = 3;
            this.rdoDriverID.TabStop = true;
            this.rdoDriverID.Text = "Unique ID";
            this.rdoDriverID.UseVisualStyleBackColor = true;
            this.rdoDriverID.CheckedChanged += new System.EventHandler(this.rdoDriverID_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtSearchDriver);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 276);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // dtSearchDriver
            // 
            this.dtSearchDriver.AllowUserToAddRows = false;
            this.dtSearchDriver.AllowUserToDeleteRows = false;
            this.dtSearchDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSearchDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSearchDriver.Location = new System.Drawing.Point(22, 30);
            this.dtSearchDriver.Name = "dtSearchDriver";
            this.dtSearchDriver.ReadOnly = true;
            this.dtSearchDriver.Size = new System.Drawing.Size(610, 225);
            this.dtSearchDriver.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoNotLike);
            this.groupBox3.Controls.Add(this.rdoContainig);
            this.groupBox3.Controls.Add(this.txtSearchText);
            this.groupBox3.Controls.Add(this.rdoExact);
            this.groupBox3.Location = new System.Drawing.Point(245, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Value";
            // 
            // rdoNotLike
            // 
            this.rdoNotLike.AutoSize = true;
            this.rdoNotLike.Location = new System.Drawing.Point(342, 22);
            this.rdoNotLike.Name = "rdoNotLike";
            this.rdoNotLike.Size = new System.Drawing.Size(65, 17);
            this.rdoNotLike.TabIndex = 4;
            this.rdoNotLike.Text = "Not Like";
            this.rdoNotLike.UseVisualStyleBackColor = true;
            // 
            // rdoContainig
            // 
            this.rdoContainig.AutoSize = true;
            this.rdoContainig.Location = new System.Drawing.Point(270, 22);
            this.rdoContainig.Name = "rdoContainig";
            this.rdoContainig.Size = new System.Drawing.Size(66, 17);
            this.rdoContainig.TabIndex = 5;
            this.rdoContainig.Text = "Contains";
            this.rdoContainig.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(35, 21);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(155, 20);
            this.txtSearchText.TabIndex = 0;
            // 
            // rdoExact
            // 
            this.rdoExact.AutoSize = true;
            this.rdoExact.Checked = true;
            this.rdoExact.Location = new System.Drawing.Point(212, 22);
            this.rdoExact.Name = "rdoExact";
            this.rdoExact.Size = new System.Drawing.Size(52, 17);
            this.rdoExact.TabIndex = 6;
            this.rdoExact.TabStop = true;
            this.rdoExact.Text = "Exact";
            this.rdoExact.UseVisualStyleBackColor = true;
            // 
            // frmSearchDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearchDriver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSearchDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Driver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSearchDriver)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchDriver;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtSearchDriver;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoDriverID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtSearchText;
        private System.Windows.Forms.RadioButton rdoNotLike;
        private System.Windows.Forms.RadioButton rdoContainig;
        private System.Windows.Forms.RadioButton rdoExact;
    }
}