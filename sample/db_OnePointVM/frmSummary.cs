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
    public partial class frmSummary : Form
    {
        private string query = "";
        public frmSummary()
        {
            InitializeComponent();
            this.ActiveControl = btnOK;
            getDataAndFillTextBoxes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void getDataAndFillTextBoxes()
        {
            int total = 0;


            query = "select count(*) from dbadmin.Transaction where TransactionDate = trunc(sysdate)";
            txtTransactions.Text = OracleDBConnection.selectIntegerValue(query).ToString();

            query = "select sum(charges + lateCharges) from dbadmin.Transaction where TransactionDate = trunc(sysdate)";
            txtTransactionCharges.Text = OracleDBConnection.selectIntegerValue(query).ToString();
            total += Convert.ToInt32(txtTransactionCharges.Text);


            query = "select sum(partPrice) from dbadmin.maintenance where maintenanceDate = trunc(sysdate)";
            txtMaintenanceCharges.Text = OracleDBConnection.selectIntegerValue(query).ToString();
            total -= Convert.ToInt32(txtMaintenanceCharges.Text);


            query = "select sum(amount) from dbadmin.expenses where expenseDate = trunc(sysdate)";
            txtExpenses.Text = OracleDBConnection.selectIntegerValue(query).ToString();
            total -= Convert.ToInt32(txtExpenses.Text);


            txtTotal.Text = total.ToString();
        }
    }
}
