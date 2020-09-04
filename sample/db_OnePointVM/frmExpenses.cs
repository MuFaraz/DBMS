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
    public partial class frmExpenses : Form
    {
        private string query = "";
        private string dateToday;

        public frmExpenses()
        {
            InitializeComponent();
            dateToday = dtExpenses.Value.ToString("dd-MM-yyyy");
            txtExpsesAmount.Focus();
        }

        private void btnClearAllFields_Click(object sender, EventArgs e)
        {
        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                query = "insert into dbadmin.expenses values(to_date('" + dateToday + "', 'dd-mm-yyyy'), '" +
                          txtExpensesDescription.Text + "', " + txtExpsesAmount.Text + ")";

                OracleDBConnection.performDMLOperation(query);
                clearFields();
            }

        }

        private bool isEmpty()
        {
            if (txtExpsesAmount.Text == "" || txtExpensesDescription.Text == "")
            {
                MessageBox.Show("No field can be empty!");
                return false;
            }

            return true;
        }

        public void clearFields()
        {
            txtExpsesAmount.Clear();
            txtExpensesDescription.Clear();
            txtExpsesAmount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
