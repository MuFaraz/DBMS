namespace db_OnePointVM
{
    partial class frmSummary
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
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtMaintenanceCharges = new System.Windows.Forms.TextBox();
            this.txtTransactionCharges = new System.Windows.Forms.TextBox();
            this.txtTransactions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMMARY";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtExpenses);
            this.groupBox1.Controls.Add(this.txtMaintenanceCharges);
            this.groupBox1.Controls.Add(this.txtTransactionCharges);
            this.groupBox1.Controls.Add(this.txtTransactions);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Summary";
            // 
            // txtExpenses
            // 
            this.txtExpenses.Location = new System.Drawing.Point(96, 146);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.ReadOnly = true;
            this.txtExpenses.Size = new System.Drawing.Size(227, 20);
            this.txtExpenses.TabIndex = 8;
            this.txtExpenses.TabStop = false;
            this.txtExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaintenanceCharges
            // 
            this.txtMaintenanceCharges.Location = new System.Drawing.Point(148, 118);
            this.txtMaintenanceCharges.Name = "txtMaintenanceCharges";
            this.txtMaintenanceCharges.ReadOnly = true;
            this.txtMaintenanceCharges.Size = new System.Drawing.Size(175, 20);
            this.txtMaintenanceCharges.TabIndex = 7;
            this.txtMaintenanceCharges.TabStop = false;
            this.txtMaintenanceCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransactionCharges
            // 
            this.txtTransactionCharges.Location = new System.Drawing.Point(148, 90);
            this.txtTransactionCharges.Name = "txtTransactionCharges";
            this.txtTransactionCharges.ReadOnly = true;
            this.txtTransactionCharges.Size = new System.Drawing.Size(175, 20);
            this.txtTransactionCharges.TabIndex = 6;
            this.txtTransactionCharges.TabStop = false;
            this.txtTransactionCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransactions
            // 
            this.txtTransactions.Location = new System.Drawing.Point(163, 30);
            this.txtTransactions.Name = "txtTransactions";
            this.txtTransactions.ReadOnly = true;
            this.txtTransactions.Size = new System.Drawing.Size(160, 20);
            this.txtTransactions.TabIndex = 5;
            this.txtTransactions.TabStop = false;
            this.txtTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Expenses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maintenance Charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transaction Charges:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Transactions:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(271, 310);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(113, 18);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(210, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Daily Savings:";
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 345);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSummary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransactions;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.TextBox txtMaintenanceCharges;
        private System.Windows.Forms.TextBox txtTransactionCharges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
    }
}