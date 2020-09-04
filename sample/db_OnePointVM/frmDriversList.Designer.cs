namespace db_OnePointVM
{
    partial class frmDriversList
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
            this.btnSelect_Return = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtDriversList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDriversList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect_Return
            // 
            this.btnSelect_Return.Location = new System.Drawing.Point(272, 307);
            this.btnSelect_Return.Name = "btnSelect_Return";
            this.btnSelect_Return.Size = new System.Drawing.Size(117, 23);
            this.btnSelect_Return.TabIndex = 0;
            this.btnSelect_Return.Text = "Select and Return";
            this.btnSelect_Return.UseVisualStyleBackColor = true;
            this.btnSelect_Return.Click += new System.EventHandler(this.btnSelect_Return_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtDriversList
            // 
            this.dtDriversList.AllowUserToAddRows = false;
            this.dtDriversList.AllowUserToDeleteRows = false;
            this.dtDriversList.AllowUserToOrderColumns = true;
            this.dtDriversList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDriversList.Location = new System.Drawing.Point(12, 69);
            this.dtDriversList.Name = "dtDriversList";
            this.dtDriversList.ReadOnly = true;
            this.dtDriversList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDriversList.Size = new System.Drawing.Size(455, 230);
            this.dtDriversList.TabIndex = 2;
            this.dtDriversList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDriversList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "DRIVERS\' LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected ID:";
            // 
            // txtSelectedID
            // 
            this.txtSelectedID.Location = new System.Drawing.Point(84, 309);
            this.txtSelectedID.MaxLength = 10;
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.ReadOnly = true;
            this.txtSelectedID.Size = new System.Drawing.Size(142, 20);
            this.txtSelectedID.TabIndex = 5;
            // 
            // frmDriversList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 340);
            this.Controls.Add(this.txtSelectedID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDriversList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDriversList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers List";
            ((System.ComponentModel.ISupportInitialize)(this.dtDriversList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect_Return;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtDriversList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectedID;
    }
}