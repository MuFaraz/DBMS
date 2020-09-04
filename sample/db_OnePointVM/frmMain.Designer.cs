namespace db_OnePointVM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleManagemtnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtOnDuty = new System.Windows.Forms.DataGridView();
            this.grpBoxStatus = new System.Windows.Forms.GroupBox();
            this.rdoAvailable = new System.Windows.Forms.RadioButton();
            this.rdoOnDuty = new System.Windows.Forms.RadioButton();
            this.btnFilterResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOnDuty)).BeginInit();
            this.grpBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminPanelToolStripMenuItem,
            this.expenseSheetToolStripMenuItem,
            this.maintenanceFormToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.ViewtoolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1136, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.vehicleManagemtnToolStripMenuItem,
            this.driversManagementToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.adminPanelToolStripMenuItem.Text = "Admin Panel";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.userManagementToolStripMenuItem.Text = "Users";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // vehicleManagemtnToolStripMenuItem
            // 
            this.vehicleManagemtnToolStripMenuItem.Name = "vehicleManagemtnToolStripMenuItem";
            this.vehicleManagemtnToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vehicleManagemtnToolStripMenuItem.Text = "Vehicles";
            this.vehicleManagemtnToolStripMenuItem.Click += new System.EventHandler(this.vehicleManagemtnToolStripMenuItem_Click);
            // 
            // driversManagementToolStripMenuItem
            // 
            this.driversManagementToolStripMenuItem.Name = "driversManagementToolStripMenuItem";
            this.driversManagementToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.driversManagementToolStripMenuItem.Text = "Drivers";
            this.driversManagementToolStripMenuItem.Click += new System.EventHandler(this.driversManagementToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // expenseSheetToolStripMenuItem
            // 
            this.expenseSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.viewExpensesToolStripMenuItem});
            this.expenseSheetToolStripMenuItem.Name = "expenseSheetToolStripMenuItem";
            this.expenseSheetToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.expenseSheetToolStripMenuItem.Text = "Expense Sheet";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newEntryToolStripMenuItem.Text = "New Entry";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // viewExpensesToolStripMenuItem
            // 
            this.viewExpensesToolStripMenuItem.Name = "viewExpensesToolStripMenuItem";
            this.viewExpensesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewExpensesToolStripMenuItem.Text = "View Expenses";
            this.viewExpensesToolStripMenuItem.Click += new System.EventHandler(this.viewExpensesToolStripMenuItem_Click);
            // 
            // maintenanceFormToolStripMenuItem
            // 
            this.maintenanceFormToolStripMenuItem.Name = "maintenanceFormToolStripMenuItem";
            this.maintenanceFormToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.maintenanceFormToolStripMenuItem.Text = "Maintenance Form";
            this.maintenanceFormToolStripMenuItem.Click += new System.EventHandler(this.maintenanceFormToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transactionsToolStripMenuItem.Text = "Order Form";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem,
            this.vehicleToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.driversToolStripMenuItem.Text = "Driver";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem1
            // 
            this.vehicleToolStripMenuItem1.Name = "vehicleToolStripMenuItem1";
            this.vehicleToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.vehicleToolStripMenuItem1.Text = "Vehicle";
            this.vehicleToolStripMenuItem1.Click += new System.EventHandler(this.vehicleToolStripMenuItem1_Click);
            // 
            // ViewtoolStripMenuItem
            // 
            this.ViewtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.ViewtoolStripMenuItem.Name = "ViewtoolStripMenuItem";
            this.ViewtoolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewtoolStripMenuItem.Text = "View";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About Us";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dtOnDuty
            // 
            this.dtOnDuty.AllowUserToAddRows = false;
            this.dtOnDuty.AllowUserToDeleteRows = false;
            this.dtOnDuty.AllowUserToOrderColumns = true;
            this.dtOnDuty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtOnDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOnDuty.Location = new System.Drawing.Point(20, 33);
            this.dtOnDuty.Name = "dtOnDuty";
            this.dtOnDuty.ReadOnly = true;
            this.dtOnDuty.Size = new System.Drawing.Size(1070, 461);
            this.dtOnDuty.TabIndex = 5;
            // 
            // grpBoxStatus
            // 
            this.grpBoxStatus.Controls.Add(this.dtOnDuty);
            this.grpBoxStatus.Location = new System.Drawing.Point(12, 118);
            this.grpBoxStatus.Name = "grpBoxStatus";
            this.grpBoxStatus.Size = new System.Drawing.Size(1112, 514);
            this.grpBoxStatus.TabIndex = 6;
            this.grpBoxStatus.TabStop = false;
            this.grpBoxStatus.Text = "Transactions Information";
            // 
            // rdoAvailable
            // 
            this.rdoAvailable.AutoSize = true;
            this.rdoAvailable.Location = new System.Drawing.Point(139, 648);
            this.rdoAvailable.Name = "rdoAvailable";
            this.rdoAvailable.Size = new System.Drawing.Size(84, 17);
            this.rdoAvailable.TabIndex = 7;
            this.rdoAvailable.TabStop = true;
            this.rdoAvailable.Text = "Done Today";
            this.rdoAvailable.UseVisualStyleBackColor = true;
            this.rdoAvailable.CheckedChanged += new System.EventHandler(this.rdoAvailable_CheckedChanged);
            // 
            // rdoOnDuty
            // 
            this.rdoOnDuty.AutoSize = true;
            this.rdoOnDuty.Location = new System.Drawing.Point(242, 648);
            this.rdoOnDuty.Name = "rdoOnDuty";
            this.rdoOnDuty.Size = new System.Drawing.Size(64, 17);
            this.rdoOnDuty.TabIndex = 8;
            this.rdoOnDuty.TabStop = true;
            this.rdoOnDuty.Text = "Pending";
            this.rdoOnDuty.UseVisualStyleBackColor = true;
            // 
            // btnFilterResults
            // 
            this.btnFilterResults.Location = new System.Drawing.Point(362, 645);
            this.btnFilterResults.Name = "btnFilterResults";
            this.btnFilterResults.Size = new System.Drawing.Size(114, 23);
            this.btnFilterResults.TabIndex = 9;
            this.btnFilterResults.Text = "Filter Result";
            this.btnFilterResults.UseVisualStyleBackColor = true;
            this.btnFilterResults.Click += new System.EventHandler(this.btnFilterResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter Result by Status:";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::db_OnePointVM.Properties.Resources.mono_logout;
            this.btnLogout.Location = new System.Drawing.Point(1074, 44);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 2;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1136, 85);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 681);
            this.Controls.Add(this.btnFilterResults);
            this.Controls.Add(this.rdoOnDuty);
            this.Controls.Add(this.rdoAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxStatus);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOnDuty)).EndInit();
            this.grpBoxStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleManagemtnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtOnDuty;
        private System.Windows.Forms.GroupBox grpBoxStatus;
        private System.Windows.Forms.RadioButton rdoAvailable;
        private System.Windows.Forms.RadioButton rdoOnDuty;
        private System.Windows.Forms.Button btnFilterResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ViewtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceFormToolStripMenuItem;
    }
}