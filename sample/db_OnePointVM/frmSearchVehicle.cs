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
    public partial class frmSearchVehicle : Form
    {
        private string query = null;

        public frmSearchVehicle()
        {
            InitializeComponent();
            this.ActiveControl = txtSearchText;
            txtSearchText.Text = null;
            txtSearchText.Mask = "???-0000";
        }

        private void rdoVehicleID_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.Text = null;
            txtSearchText.Mask = "???-0000";
            lblSearchText.Text = "Enter Vehicle ID:";
        }

        private void rdoDrivenBy_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.Text = null;
            txtSearchText.Mask = null;
            lblSearchText.Text = "Enter Driver Name:";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rdoVehicleID.Checked)
            {
                query = "select * from dbadmin.vuVehiclesList where \"UNIQUE ID\" = '" + txtSearchText.Text.ToUpper() + "'";
            } 
            else if (rdoDrivenBy.Checked)
            {
                query = "select ID, driver, \"Vehicle Number\" from dbadmin.vuTransactions where \"Driver\" = '" + txtSearchText.Text.ToUpper() + "'";
            }
            OracleDBConnection.fillDataGrieView(dtSearchVehicle, query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            query = "select * from dbadmin.VUVEHICLESLIST";
            OracleDBConnection.fillDataGrieView(dtSearchVehicle, query);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
