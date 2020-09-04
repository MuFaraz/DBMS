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
    public partial class frmVehicle : Form
    {
        Vehicles vhcl;

        public frmVehicle()
        {
            InitializeComponent();
            disableButtons();
            this.ActiveControl = txtVehicleID;
            cmboMaker.SelectedIndex = 0;
            cmbVehicleType.SelectedIndex = 0;
        }

        public frmVehicle(string id)
        {
            InitializeComponent();
            enableButtons();
            cmboMaker.SelectedIndex = 0;
            cmbVehicleType.SelectedIndex = 0;
            txtVehicleID.ReadOnly = true;
            enterIDAndFill(id);
        }


        public void enterIDAndFill(string id)
        {
            if (txtVehicleID.Text != null)
            {
                txtVehicleID.Text = id;
                btnAddVehicle.Enabled = false;
                fillData();
            }
            else
            {
                clearFields();
                disableButtons();
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
                cmd.CommandText = "select * from dbadmin.vehicle where vehicleID = '" + txtVehicleID.Text + "'";

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string availability = "\0";

                    txtVehicleID.Text = reader.GetString(0);
                    cmboMaker.Text = reader.GetString(1);
                    txtModel.Text = reader.GetString(2);
                    cmbVehicleType.Text =reader.GetString(3);
                    dtMadeYear.Value = reader.GetDateTime(4);
                    txtEngine.Text = reader.GetString(5);
                    txtChasis.Text = reader.GetString(6);
                    txtPrice.Text = reader.GetInt32(7).ToString();
                    dtPurchaseDate.Value = reader.GetDateTime(8);
                    dtFitnessFrom.Value = reader.GetDateTime(9);
                    dtExpiry.Value = reader.GetDateTime(10);
                    availability = reader.GetString(11);

                    if (availability == "A") rdoVehicleAvailable.Checked = true;
                    else rdoVehicleUnavilable.Checked = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void disableButtons()
        {
            btnUpdateVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;
        }

        private void enableButtons()
        {
            btnUpdateVehicle.Enabled = true;
            btnDeleteVehicle.Enabled = true;
            btnAddVehicle.Enabled = false;
        }

        private void btnClearAllFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private bool isEmpty()
        {
            if (!txtVehicleID.MaskCompleted || cmboMaker.Text == null || txtModel.Text == null ||
                     !txtEngine.MaskCompleted || !txtChasis.MaskCompleted || txtPrice.Text == null)
            {
                MessageBox.Show("Some fields are empty! Fill that first and try again!", "Error");
                return true;
            }

            return false;
        }

        private void clearFields()
        {
            txtVehicleID.ReadOnly = false;
            txtVehicleID.Clear();
            cmboMaker.SelectedIndex = 0;
            txtModel.Clear();
            cmbVehicleType.SelectedIndex = 0;
            txtEngine.Clear();
            txtChasis.Clear();
            txtPrice.Clear();
            dtMadeYear.Value = DateTime.Now;
            dtExpiry.Value = DateTime.Now;
            dtFitnessFrom.Value = DateTime.Now;
            dtPurchaseDate.Value = DateTime.Now;
            txtVehicleID.Focus();
            disableButtons();
            btnAddVehicle.Enabled = true;
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if(!isEmpty())
            {
                vhcl = new Vehicles();
                initializeValues();

                vhcl.addVehicle();
                disableButtons();
                clearFields();
            }
        }

        private void initializeValues()
        {
            if(!isEmpty())
            {
                vhcl = new Vehicles();
                vhcl.vehicleID = txtVehicleID.Text.ToUpper();
                vhcl.maker = cmboMaker.Text;
                vhcl.model = txtModel.Text.ToUpper();
                vhcl.type = cmbVehicleType.Text;
                vhcl.engineNumber = txtEngine.Text.ToString();
                vhcl.chasisNumber = txtChasis.Text.ToString();
                vhcl.price = Convert.ToInt64(txtPrice.Text);
                vhcl.madeYear = dtMadeYear.Value;
                vhcl.fitnessExpiresOn = dtExpiry.Value;
                vhcl.fitnessStartsFrom = dtFitnessFrom.Value;
                vhcl.purchaseDate = dtPurchaseDate.Value;

                if (rdoVehicleAvailable.Checked) vhcl.availabilityStatus = "A";
                else vhcl.availabilityStatus = "N";
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if(!isEmpty())
            {
                vhcl = new Vehicles();

                vhcl.deleteVehicle(txtVehicleID.Text);
                clearFields();
            }
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if(!isEmpty())
            {
                vhcl = new Vehicles();
                initializeValues();
                vhcl.updateVehicle();
                clearFields();
            }
        }

        private void btnBrowseVehicle_Click(object sender, EventArgs e)
        {
            frmVehiclesList vhcList = new frmVehiclesList();
            this.Dispose();
            vhcList.Show();
        }
    }
}
