using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace db_OnePointVM
{
    public partial class frmDriver : Form
    {
        Drivers drv = new Drivers();
        public string driverID = "";


        // Custom Constructor to set old DriverID and make updtaion or deletion over it.
        public frmDriver(string id)
        {
            InitializeComponent();
            this.ActiveControl = txtDriverSelectionID;
            enterIDAndFill(id);
            txtSalary.ReadOnly = false;
        }

        public frmDriver()
        {
            InitializeComponent();
            this.ActiveControl = txtDriverName;
            txtDriverID.Text = drv.newDriverID();
            disableButtons();
        }

        public void enterIDAndFill(string id)
        {
            if (txtDriverSelectionID.Text != null)
            {
                txtDriverSelectionID.Text = id;
                btnAddDriver.Enabled = false;
                fillData();
            }
            else
            {
                txtDriverID.Text = drv.newDriverID();
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
                cmd.CommandText = "select * from dbadmin.driver where driverID = '" + txtDriverSelectionID.Text + "'";

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string availability = "\0";

                    txtDriverID.Text = reader.GetString(0);
                    dtToday.Value = reader.GetDateTime(1);
                    txtDriverName.Text = reader.GetString(2);
                    txtFatherName.Text = reader.GetString(3);
                    txtAge.Text = reader.GetInt16(4).ToString();
                    txtCNIC.Text = reader.GetString(5);
                    txtMobile.Text = reader.GetString(6);
                    txtExperience.Text = reader.GetInt16(7).ToString();
                    txtAccidents.Text = reader.GetInt16(8).ToString();
                    txtSalary.Text = reader.GetInt32(9).ToString();
                    availability = reader.GetString(10);

                    if (availability == "Y") rdoDriverAvailable.Checked = true;
                    else rdoDriverNotAvailable.Checked = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBrowseDrivers_Click(object sender, EventArgs e)
        {
            frmDriversList allDrivers = new frmDriversList();
            allDrivers.Show();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int validateRequiredAge()
        {
            int expectedAgeDifference = 0;
            int enteredAge = Convert.ToInt16(txtAge.Text);

            expectedAgeDifference = enteredAge - 21;

            if(expectedAgeDifference < 0)
            {
                txtExperience.Focus();
                return 0;
            }

            return enteredAge;
        }

        private int validateDrivingExperience()
        {
            int expectedDifference = 0;
            int enteredAge = Convert.ToInt16(txtAge.Text);
            int enteredExperience = Convert.ToInt16(txtExperience.Text);

            expectedDifference = enteredAge - enteredExperience;

            if(expectedDifference < 18)
            {
                MessageBox.Show("Wrong Driving Experience Entered.");
                txtExperience.Focus();
                return 0;
            }

            return enteredExperience;
        }

        public void getAllValues()
        {
            drv.driverID = txtDriverID.Text;
            drv.driverSince = dtToday.Value.ToString("dd-MM-yyyy");
            drv.name = txtDriverName.Text.ToUpper();
            drv.fatherName = txtFatherName.Text.ToUpper();
            drv.age = Convert.ToInt16(txtAge.Text);
            drv.CNIC = txtCNIC.Text.ToString();
            drv.mobile = txtMobile.Text.ToString();
            drv.experience = Convert.ToInt16(txtExperience.Text);
            drv.accidents = Convert.ToInt16(txtAccidents.Text);
            drv.salary = Convert.ToInt16(txtSalary.Text);

            if (rdoDriverAvailable.Checked) drv.availabile = 'Y';
            else
                drv.availabile = 'N';
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            getAllValues();

            if(!isEmpty())
            {
                if (isCompatible())
                {
                    drv.addDriver();
                    clearFields();
                    txtDriverID.Text = drv.newDriverID();
                }
                else
                {
                    MessageBox.Show("Entered Age and Experience are Suspicious!");
                }
            }
        }

        public bool isCompatible()
        {
            if(validateRequiredAge() > 0 && validateDrivingExperience() > 0)
            {
                return true;
            }
            return false;
        }

        private bool isEmpty()
        {
            if( txtDriverName.Text == null || txtFatherName.Text == null ||
                !txtCNIC.MaskCompleted || !txtMobile.MaskCompleted || txtExperience.Text == null ||
                txtAccidents.Text == null || txtSalary.Text == null )
            {
                MessageBox.Show("All Fields my be filled...");
                return true;
            }

            return false;
        }


        private void disableButtons()
        {
            btnUpdateDriver.Enabled = false;
            btnDeleteDriver.Enabled = false;
        }

        private void enableButtons()
        {
            btnUpdateDriver.Enabled = true;
            btnDeleteDriver.Enabled = true;
        }

        private void clearFields()
        {
            txtDriverName.Text = null;
            txtFatherName.Text = null;
            txtCNIC.Text = null;
            txtMobile.Text = null;
            txtAge.Text = null;
            txtExperience.Text = null;
            txtAccidents.Text = null;
            txtSalary.Text = null;
            txtDriverSelectionID.Text = null;

            txtDriverName.Focus();
            txtSalary.ReadOnly = true;
            btnAddDriver.Enabled = true;
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            drv = new Drivers();
            getAllValues();

            drv.updateDriver(txtDriverSelectionID.Text);
            clearFields();
            disableButtons();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            drv = new Drivers();
            drv.deleteDriver(txtDriverSelectionID.Text.ToString());
            txtDriverSelectionID.Text = null;
            txtDriverID.Text = drv.newDriverID();
            disableButtons();
            clearFields();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearFields();
            disableButtons();
        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            txtDriverName.Focus();
        }
    }
}
