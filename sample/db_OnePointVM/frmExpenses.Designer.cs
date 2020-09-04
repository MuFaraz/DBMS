namespace db_OnePointVM
{
    partial class frmExpenses
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
            this.dtExpenses = new System.Windows.Forms.DateTimePicker();
            this.txtExpsesAmount = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddExpenses = new System.Windows.Forms.Button();
            this.btnClearAllFields = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtExpensesDescription = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAILY EXPENSES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExpensesDescription);
            this.groupBox1.Controls.Add(this.dtExpenses);
            this.groupBox1.Controls.Add(this.txtExpsesAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expenses";
            // 
            // dtExpenses
            // 
            this.dtExpenses.Enabled = false;
            this.dtExpenses.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpenses.Location = new System.Drawing.Point(63, 45);
            this.dtExpenses.Name = "dtExpenses";
            this.dtExpenses.Size = new System.Drawing.Size(142, 20);
            this.dtExpenses.TabIndex = 4;
            // 
            // txtExpsesAmount
            // 
            this.txtExpsesAmount.Location = new System.Drawing.Point(317, 46);
            this.txtExpsesAmount.Mask = "00000";
            this.txtExpsesAmount.Name = "txtExpsesAmount";
            this.txtExpsesAmount.Size = new System.Drawing.Size(79, 20);
            this.txtExpsesAmount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // btnAddExpenses
            // 
            this.btnAddExpenses.Location = new System.Drawing.Point(138, 207);
            this.btnAddExpenses.Name = "btnAddExpenses";
            this.btnAddExpenses.Size = new System.Drawing.Size(94, 27);
            this.btnAddExpenses.TabIndex = 4;
            this.btnAddExpenses.Text = "Add Entry";
            this.btnAddExpenses.UseVisualStyleBackColor = true;
            this.btnAddExpenses.Click += new System.EventHandler(this.btnAddExpenses_Click);
            // 
            // btnClearAllFields
            // 
            this.btnClearAllFields.Location = new System.Drawing.Point(238, 207);
            this.btnClearAllFields.Name = "btnClearAllFields";
            this.btnClearAllFields.Size = new System.Drawing.Size(108, 27);
            this.btnClearAllFields.TabIndex = 5;
            this.btnClearAllFields.Text = "Clear All Fields";
            this.btnClearAllFields.UseVisualStyleBackColor = true;
            this.btnClearAllFields.Click += new System.EventHandler(this.btnClearAllFields_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtExpensesDescription
            // 
            this.txtExpensesDescription.Location = new System.Drawing.Point(93, 75);
            this.txtExpensesDescription.MaxLength = 50;
            this.txtExpensesDescription.Name = "txtExpensesDescription";
            this.txtExpensesDescription.Size = new System.Drawing.Size(303, 20);
            this.txtExpensesDescription.TabIndex = 5;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAllFields);
            this.Controls.Add(this.btnAddExpenses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtExpsesAmount;
        private System.Windows.Forms.Button btnAddExpenses;
        private System.Windows.Forms.DateTimePicker dtExpenses;
        private System.Windows.Forms.Button btnClearAllFields;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtExpensesDescription;
    }
}