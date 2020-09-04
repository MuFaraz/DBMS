using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace db_OnePointVM
{
    public partial class frmTransaction : Form
    {
        private Transaction trans;
        private string query = "";

        public frmTransaction()
        {
            InitializeComponent();
            trans = new Transaction();
            txtTransID.Text = trans.generateNewTransID();
            clearComboBox();
            nmrLateDays.Enabled = false;
            disableButtons();
            txtCurrentLoc.Enabled = false;
            cmbVehicleType.SelectedIndex = 0;

            lblGetID.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure? you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.Yes)
            {
                setValues();
                trans.updateTransaction();
                clearAllFields();
                refreshDataGrid();
            }
        }

        public void refreshDataGrid()
        {
            query = "select * from dbadmin.VuTransactions where Status = 'PENDING'";
            OracleDBConnection.fillDataGrieView(dtGridTransactions, query);
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearComboBox();

            query = "select vehicleID from dbadmin.vehicle where type = '" + cmbVehicleType.Text + "' and status = 'A'";
            OracleDBConnection.fillComboBox(cboVehicles, query, "dbadmin.vehicle", "vehicleID");


            query = "select driverID from dbadmin.driver where Availability = 'A'";
            OracleDBConnection.fillComboBox(cboDrivers, query, "dbadmin.driver", "driverID");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearAllFields();
            disableButtons();
        }

        private void clearComboBox()
        {
            // cboVehicles.Items.Clear();    // Throws Exception if ComboBox is already empty.

            cboDrivers.DataSource = null;
            cboVehicles.DataSource = null;
        }


        private bool isEmpty()
        {
            if (txtClientName.Text == "")
            {
                MessageBox.Show("Name is Empty!");
                return true;
            } else if(!txtClientCNIC.MaskCompleted)
            {
                MessageBox.Show("Enter CNIC in Correct Format");
                return true;
            } 
            else if(!txtClientMobile.MaskCompleted)
            {
                MessageBox.Show("Enter Mobile Number in Correct Format");
                return true;
            }
            else if (txtSource.Text == "")
            {
                MessageBox.Show("Source field is Empty!");
                return true;
            } 
            else if(txtDesctination.Text == "")
            {
                MessageBox.Show("Destination is Empty!");
                return true;
            }
            else if (txtCharges.Text == "")
            {
                MessageBox.Show("Charges can't be 0!");
                return true;
            }

            return false;
        }

        private void setValues()
        {
            trans = new Transaction();

            if(!isEmpty())
            {
                trans.transactionID = txtTransID.Text;
                trans.transactionDate = dtTransactionDate.Value.ToString("dd-MM-yyyy");
                trans.clientName = txtClientName.Text.ToUpper();
                trans.clientCNIC = txtClientCNIC.Text;
                trans.clientContact = txtClientMobile.Text;
                trans.vehicleID = cboVehicles.Text;
                trans.driverID = cboDrivers.Text;

                if (rdoOneWay.Checked) trans.tripType = 1;
                else trans.tripType = 2;

                trans.source = txtSource.Text.ToUpper();
                trans.currentLoc = txtCurrentLoc.Text.ToUpper();
                trans.destination = txtDesctination.Text.ToUpper();
                trans.kilometers = Convert.ToInt16(txtDistanceKM.Text);
                trans.charges = Convert.ToInt32(txtCharges.Text);
                trans.lateCharges = 0;
                if (chkStatus.Checked) trans.Status = "DONE";
                else trans.Status = "PENDING";
            }
        }

        private void txtDistanceKM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDistanceKM_Leave(object sender, EventArgs e)
        {
            trans.kilometers = Convert.ToInt16(txtDistanceKM.Text);
            txtCharges.Text = trans.getChargesForTransaction(cboVehicles.Text).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!isEmpty())
            {
                setValues();
                trans.AddTransaction();

                string thisID = txtTransID.Text;
                string trs = trans.generateNewTransID();

                if (thisID != trs)
                {
                    clearAllFields();
                    txtTransID.Text = trans.generateNewTransID();
                }
            }
        }

        private void clearAllFields()
        {
            txtClientCNIC.Text = null;
            txtClientMobile.Text = null;
            txtClientName.Text = null;
            txtSource.Text = null;
            txtCurrentLoc.Text = null;
            txtDesctination.Text = null;
            txtDistanceKM.Text = null;
            txtCharges.Text = null;
            dtTransactionDate.Value = DateTime.Now;
            clearComboBox();
            txtTransID.Text = trans.generateNewTransID();
        }

        private void disableButtons()
        {
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void enableButtons()
        {
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void disableRadioButtons()
        {
            rdoOneWay.Enabled = false;
            rdoReturn.Enabled = false;
        }

        private void enableRadioButtons()
        {
            rdoOneWay.Enabled = true;
            rdoReturn.Enabled = true;
        }

        private void disableComboBox()
        {
            cboDrivers.Enabled = false;
            cboVehicles.Enabled = false;
            cmbVehicleType.Enabled = false;
        }

        private void enableComboBox()
        {
            cboDrivers.Enabled = true;
            cboVehicles.Enabled = true;
            cmbVehicleType.Enabled = true;
        }


        private void cboVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtDistanceKM.Text != null)
            {
                txtCharges.Text = trans.getChargesForTransaction(cboVehicles.Text).ToString();
            }
        }

        private void rdoAllToday_CheckedChanged(object sender, EventArgs e)
        {
            clearAllFields();
            query = "select * from dbadmin.VuTransactions where \"Date\" = trunc(sysdate)";
            OracleDBConnection.fillDataGrieView(dtGridTransactions, query);
        }

        private void rdoAllPending_CheckedChanged(object sender, EventArgs e)
        {
            clearAllFields();
            query = "select * from dbadmin.VuTransactions where Status = 'PENDING'";
            OracleDBConnection.fillDataGrieView(dtGridTransactions, query);
        }

        private void dtGridTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtGridTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewRow dr = dtGridTransactions.SelectedRows[0];
            lblGetID.Text = dr.Cells[0].Value.ToString();

            if (dtGridTransactions.Rows.Count > 0)
            {
                enableButtons();
                disableComboBox();
                txtDistanceKM.Enabled = false;
                txtCurrentLoc.Enabled = true;
                disableRadioButtons();
                nmrLateDays.Enabled = true;

            }
        }

        private void fillData()
        {
            string userID = OracleDBConnection.returnUserID();
            string passwd = OracleDBConnection.returnPassword();

            try
            {
                string conString = "User Id = " + userID + "; Password = " + passwd + "; Data Source = localhost:1521/orcl; Pooling = false;";
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from Transaction where TransactionID = '" + lblGetID.Text + "'";
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtTransID.Text = reader.GetString(0);
                    dtTransactionDate.Value = reader.GetDateTime(1);
                    txtClientName.Text = reader.GetString(2);
                    txtClientCNIC.Text = reader.GetString(3);
                    txtClientMobile.Text = reader.GetString(4);
                    cboVehicles.Text = reader.GetString(5);
                    cboDrivers.Text = reader.GetString(6);

                    string trpType = reader.GetString(7);
                    if (trpType == "1") rdoOneWay.Checked = true;
                    else rdoReturn.Checked = true;

                    txtSource.Text = reader.GetString(8);
                    txtCurrentLoc.Text = reader.GetString(9);
                    txtDesctination.Text = reader.GetString(10);
                    txtDistanceKM.Text = reader.GetInt32(11).ToString();
                    txtCharges.Text = reader.GetInt32(12).ToString();
                    txtLateCharges.Text = reader.GetInt32(13).ToString();

                    string status = reader.GetString(14);
                    if (status == "PENDING") chkStatus.Checked = false;
                    else  chkStatus.Checked = true;
                }
                con.Close();
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message.ToString());
            }

        }

        private void nmrLateDays_ValueChanged(object sender, EventArgs e)
        {
            int perDayLateCharges = 500;
            int total = 0;
            total = Convert.ToInt16(nmrLateDays.Value) * perDayLateCharges;

            txtLateCharges.Text = total.ToString();
        }

        private void lblGetID_TextChanged(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
