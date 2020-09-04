namespace db_OnePointVM
{
    partial class frmExpensesHistory
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalExpenses = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtExpensHistory = new System.Windows.Forms.DataGridView();
            this.btnViewExpenses = new System.Windows.Forms.Button();
            this.rdoDailyExpenses = new System.Windows.Forms.RadioButton();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtHistoryFrom = new System.Windows.Forms.DateTimePicker();
            this.dtHistoryTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpensHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Range Total:";
            // 
            // txtTotalExpenses
            // 
            this.txtTotalExpenses.Location = new System.Drawing.Point(132, 497);
            this.txtTotalExpenses.MaxLength = 15;
            this.txtTotalExpenses.Name = "txtTotalExpenses";
            this.txtTotalExpenses.ReadOnly = true;
            this.txtTotalExpenses.Size = new System.Drawing.Size(180, 20);
            this.txtTotalExpenses.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtHistoryTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtHistoryFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rdoWeekly);
            this.groupBox1.Controls.Add(this.rdoDailyExpenses);
            this.groupBox1.Controls.Add(this.btnViewExpenses);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtExpensHistory);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 326);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // dtExpensHistory
            // 
            this.dtExpensHistory.AllowUserToAddRows = false;
            this.dtExpensHistory.AllowUserToDeleteRows = false;
            this.dtExpensHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtExpensHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtExpensHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExpensHistory.Location = new System.Drawing.Point(16, 34);
            this.dtExpensHistory.MultiSelect = false;
            this.dtExpensHistory.Name = "dtExpensHistory";
            this.dtExpensHistory.ReadOnly = true;
            this.dtExpensHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtExpensHistory.Size = new System.Drawing.Size(450, 272);
            this.dtExpensHistory.TabIndex = 0;
            // 
            // btnViewExpenses
            // 
            this.btnViewExpenses.Location = new System.Drawing.Point(378, 15);
            this.btnViewExpenses.Name = "btnViewExpenses";
            this.btnViewExpenses.Size = new System.Drawing.Size(97, 58);
            this.btnViewExpenses.TabIndex = 6;
            this.btnViewExpenses.Text = "View";
            this.btnViewExpenses.UseVisualStyleBackColor = true;
            this.btnViewExpenses.Click += new System.EventHandler(this.btnViewExpenses_Click);
            // 
            // rdoDailyExpenses
            // 
            this.rdoDailyExpenses.AutoSize = true;
            this.rdoDailyExpenses.Checked = true;
            this.rdoDailyExpenses.Location = new System.Drawing.Point(16, 19);
            this.rdoDailyExpenses.Name = "rdoDailyExpenses";
            this.rdoDailyExpenses.Size = new System.Drawing.Size(87, 17);
            this.rdoDailyExpenses.TabIndex = 7;
            this.rdoDailyExpenses.TabStop = true;
            this.rdoDailyExpenses.Text = "Daily (Today)";
            this.rdoDailyExpenses.UseVisualStyleBackColor = true;
            this.rdoDailyExpenses.CheckedChanged += new System.EventHandler(this.rdoDailyExpenses_CheckedChanged);
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Location = new System.Drawing.Point(109, 19);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(79, 17);
            this.rdoWeekly.TabIndex = 8;
            this.rdoWeekly.Text = "Last 7 days";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(194, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Custom";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From:";
            // 
            // dtHistoryFrom
            // 
            this.dtHistoryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHistoryFrom.Location = new System.Drawing.Point(52, 45);
            this.dtHistoryFrom.Name = "dtHistoryFrom";
            this.dtHistoryFrom.Size = new System.Drawing.Size(106, 20);
            this.dtHistoryFrom.TabIndex = 11;
            // 
            // dtHistoryTo
            // 
            this.dtHistoryTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHistoryTo.Location = new System.Drawing.Point(213, 45);
            this.dtHistoryTo.Name = "dtHistoryTo";
            this.dtHistoryTo.Size = new System.Drawing.Size(106, 20);
            this.dtHistoryTo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To:";
            // 
            // frmExpensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTotalExpenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExpensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Expense History";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtExpensHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalExpenses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtExpensHistory;
        private System.Windows.Forms.Button btnViewExpenses;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdoWeekly;
        private System.Windows.Forms.RadioButton rdoDailyExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtHistoryFrom;
        private System.Windows.Forms.DateTimePicker dtHistoryTo;
        private System.Windows.Forms.Label label4;
    }
}