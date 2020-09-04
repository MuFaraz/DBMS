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
    public partial class frmDriversList : Form
    {
        private string query = "select driverID as \"DRIVER ID\", Name \"DRIVER NAME\", Mobile from dbadmin.driver";
        public frmDriversList()
        {
            InitializeComponent();
            OracleDBConnection.fillDataGrieView(dtDriversList, query);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmDriver driverForm = new frmDriver();
            this.Dispose();
            driverForm.Show();
        }


        private void btnSelect_Return_Click(object sender, EventArgs e)
        {
            if (txtSelectedID.Text != null)
            {
                frmDriver driverForm = new frmDriver(txtSelectedID.Text);
                this.Dispose();
                driverForm.Show();
            }
            else
            {
                MessageBox.Show("No ID Selected!");
            }
        }

        private void dtDriversList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtDriversList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewRow dr = dtDriversList.SelectedRows[0];
            txtSelectedID.Text = dr.Cells[0].Value.ToString();
        }

    }
}
