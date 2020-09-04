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
    public partial class frmExpensesHistory : Form
    {

        private string query = "select expenseDate \"DATE\", Description, Amount from dbadmin.expenses where expenseDate = trunc(sysdate)";
        private string totalAmountQuery;

        public frmExpensesHistory()
        {
            InitializeComponent();
            OracleDBConnection.fillDataGrieView(dtExpensHistory, query);
            disableDatePick();
        }

        private void btnViewExpenses_Click(object sender, EventArgs e)
        {
            if(rdoDailyExpenses.Checked)
            {
                query = "select expenseDate \"DATE\", Description, Amount from dbadmin.expenses where expenseDate = trunc(sysdate)";
                OracleDBConnection.fillDataGrieView(dtExpensHistory, query);


                totalAmountQuery = "select sum(amount) from dbadmin.expenses where expenseDate = trunc(sysdate)";
                txtTotalExpenses.Text = OracleDBConnection.selectIntegerValue(totalAmountQuery).ToString();
            } 
            else if(rdoWeekly.Checked)
            {
                query = "select expenseDate \"DATE\", Description, Amount from dbadmin.expenses where expenseDate between trunc(sysdate  - 7) and trunc(sysdate)";
                OracleDBConnection.fillDataGrieView(dtExpensHistory, query);

                totalAmountQuery = "select sum(amount) from dbadmin.expenses where expenseDate between trunc(sysdate - 7) and trunc(sysdate)";
                txtTotalExpenses.Text = OracleDBConnection.selectIntegerValue(totalAmountQuery).ToString();

            } 
            else
            {
                query = "select expenseDate \"DATE\", Description, Amount from dbadmin.expenses where expenseDate between to_date('" 
                    + dtHistoryFrom.Value.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy') and to_date('" +  dtHistoryTo.Value.ToString("dd-MM-yyyy")  + "', 'dd-mm-yyyy')";
                OracleDBConnection.fillDataGrieView(dtExpensHistory, query);


                totalAmountQuery = "select sum(amount) from dbadmin.expenses where expenseDate between to_date('"
                    + dtHistoryFrom.Value.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy') and to_date('" + dtHistoryTo.Value.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy')";
                txtTotalExpenses.Text = OracleDBConnection.selectIntegerValue(totalAmountQuery).ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rdoDailyExpenses_CheckedChanged(object sender, EventArgs e)
        {
            disableDatePick();
        }


        private void rdoWeekly_CheckedChanged(object sender, EventArgs e)
        {
            disableDatePick();
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            enableDatePick();
        }


        private void disableDatePick()
        {
            dtHistoryFrom.Enabled = false;
            dtHistoryTo.Enabled = false;
        }

        private void enableDatePick()
        {
            dtHistoryFrom.Enabled = true;
            dtHistoryTo.Enabled = true;
        }

    }
}
