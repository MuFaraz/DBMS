namespace db_OnePointVM
{
    partial class frmVehiclesList
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
            this.txtSelectedID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridVehicles = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSelectedID
            // 
            this.txtSelectedID.Location = new System.Drawing.Point(186, 322);
            this.txtSelectedID.MaxLength = 10;
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.ReadOnly = true;
            this.txtSelectedID.Size = new System.Drawing.Size(142, 20);
            this.txtSelectedID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selected ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "VEHICLES LIST";
            // 
            // dtGridVehicles
            // 
            this.dtGridVehicles.AllowUserToAddRows = false;
            this.dtGridVehicles.AllowUserToDeleteRows = false;
            this.dtGridVehicles.AllowUserToOrderColumns = true;
            this.dtGridVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVehicles.Location = new System.Drawing.Point(27, 55);
            this.dtGridVehicles.Name = "dtGridVehicles";
            this.dtGridVehicles.ReadOnly = true;
            this.dtGridVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridVehicles.Size = new System.Drawing.Size(631, 248);
            this.dtGridVehicles.TabIndex = 8;
            this.dtGridVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVehicles_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(497, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect_Return
            // 
            this.btnSelect_Return.Location = new System.Drawing.Point(374, 320);
            this.btnSelect_Return.Name = "btnSelect_Return";
            this.btnSelect_Return.Size = new System.Drawing.Size(117, 23);
            this.btnSelect_Return.TabIndex = 6;
            this.btnSelect_Return.Text = "Select and Return";
            this.btnSelect_Return.UseVisualStyleBackColor = true;
            this.btnSelect_Return.Click += new System.EventHandler(this.btnSelect_Return_Click);
            // 
            // frmVehiclesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.txtSelectedID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridVehicles);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVehiclesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of All Vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectedID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridVehicles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect_Return;
    }
}