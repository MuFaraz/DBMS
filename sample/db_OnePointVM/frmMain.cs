using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_OnePointVM
{
    public partial class frmMain : Form
    {
        frmLogin loginform = new frmLogin();
        private string query;

        public frmMain()
        {
            InitializeComponent();
            if(OracleDBConnection.userType == OracleDBConnection.UserType.USER.ToString())
            {
                adminPanelToolStripMenuItem.Enabled = false;
                ViewtoolStripMenuItem.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginform.Show();
        }

        private void btnFilterResults_Click(object sender, EventArgs e)
        {
            if(rdoOnDuty.Checked)
            {
                query = "select * from dbadmin.VUTransactionPending";
            }
            else
            {
                query = "select * from dbadmin.VUTransactionDone";
            }

            OracleDBConnection.fillDataGrieView(dtOnDuty, query);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rdoOnDuty.Checked = true;

            query = "select * from dbadmin.VUTransactionPending";
            OracleDBConnection.fillDataGrieView(dtOnDuty, query);
        }

        private void driversManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriver driverForm = new frmDriver();
            driverForm.Show();
        }

        private void vehicleManagemtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicle vehicleForm = new frmVehicle();
            vehicleForm.Show();
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpenses expenseForm = new frmExpenses();
            expenseForm.Show();
        }

        private void viewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpensesHistory expeneHistory = new frmExpensesHistory();
            expeneHistory.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchDriver driverSearch = new frmSearchDriver();
            driverSearch.Show();
        }

        private void vehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchVehicle vhcSearch = new frmSearchVehicle();
            vhcSearch.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs abtUs = new frmAboutUs();
            abtUs.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummary summ = new frmSummary();
            summ.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp hlpFrom = new frmHelp();
            hlpFrom.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaction transForm = new frmTransaction();
            transForm.Show();
        }

        private void rdoAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maintenanceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintenance mtcForm = new frmMaintenance();
            mtcForm.Show();
        }
    }
}
