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
    public partial class frmVehiclesList : Form
    {

        private frmVehicle vhc;
        private string query = "";

        public frmVehiclesList()
        {
            InitializeComponent();
            fillGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            vhc = new frmVehicle();
            this.Dispose();
            vhc.Show();
        }

        private void btnSelect_Return_Click(object sender, EventArgs e)
        {
            if (txtSelectedID.Text != null)
            {
                vhc = new frmVehicle(txtSelectedID.Text);
            }
            else
            {
                vhc = new frmVehicle();
            }

            this.Dispose();
            vhc.Show();
        }


        public void fillGridView()
        {
            query = "select * from dbadmin.VUVEHICLESLST";
            OracleDBConnection.fillDataGrieView(dtGridVehicles, query);
        }

        private void dtGridVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtGridVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewRow dr = dtGridVehicles.SelectedRows[0];
            txtSelectedID.Text = dr.Cells[0].Value.ToString();
        }

    }
}
