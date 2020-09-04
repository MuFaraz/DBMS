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
    public partial class frmMaintenance : Form
    {
        private string query;

        public frmMaintenance()
        {
            InitializeComponent();
            txtMtcID.Enabled = false;
            txtNewID.Enabled = false;
            generateNewID();

            query = "select vehicleID from dbadmin.vehicle";
            OracleDBConnection.fillComboBox(cboVehicles, query, "dbadmin.vehicle", "vehicleID");
        }

        private void rdoDaily_CheckedChanged(object sender, EventArgs e)
        {
            txtMtcID.Enabled = false;

            query = "select * from maintenance where maintenanceDate = trunc(sysdate)";
            OracleDBConnection.fillDataGrieView(dtGridMaintenance, query);
        }

        private void rdoLastWeek_CheckedChanged(object sender, EventArgs e)
        {
            txtMtcID.Enabled = false;

            query = "select * from maintenance where maintenanceDate between trunc(sysdate - 7) and trunc(sysdate)";
            OracleDBConnection.fillDataGrieView(dtGridMaintenance, query);
        }

        private void rdoMaintenanceID_CheckedChanged(object sender, EventArgs e)
        {
            txtMtcID.Enabled = true;
            txtMtcID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!isEmpty())
            {
                query = "insert into dbadmin.maintenance values('" + txtNewID.Text + "', to_date('" + dtMaintenanceDate.Value.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy'), "
                    + "' " + txtParts.Text.ToUpper() + "',  '" + cboVehicles.Text + "', '" + txtDescription.Text.ToUpper() + "',  " + Convert.ToInt16(txtAmount.Text) + ")";

                OracleDBConnection.performDMLOperation(query);
                clearAllFields();
            }
        }

        private bool isEmpty()
        {
            int amount = Convert.ToUInt16(txtAmount.Text);

            if (!txtNewID.MaskCompleted || txtParts.Text == null || txtDescription.Text == null || amount <= 0)
            {
                MessageBox.Show("Enter Complete Informatin");
                return true;
            }

            return false;
        }

        private void clearAllFields()
        {
            generateNewID();
            txtParts.Clear();
            txtDescription.Clear();
            txtAmount.Clear();
            txtParts.Focus();
        }


        private void generateNewID()
        {

            string oldID;
            string sub;
            int newNumber = 0;
            string newID = "";

            query = "select max(maintenanceID) from dbadmin.maintenance";
            oldID = OracleDBConnection.selectStringValue(query);
            if (oldID == null)
            {
                newID = "M-001";
            }
            else
            {
                sub = oldID.Substring(2, 3);
                newNumber = Int16.Parse(sub);
                newNumber = newNumber + 1;
                newID = oldID.Replace(sub, string.Format("{0:000}", newNumber));
            }

            txtNewID.Text = newID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void txtMtcID_Leave(object sender, EventArgs e)
        {
            if (txtMtcID.MaskCompleted)
            {
                query = "select * from maintenance where maintenanceId = '" + txtMtcID.Text + "'";
                OracleDBConnection.fillDataGrieView(dtGridMaintenance, query);
            }
            else
            {
                MessageBox.Show("Enter Valid Maintenance ID first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}