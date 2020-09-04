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
    public partial class frmSearchDriver : Form
    {
        private string query;
        public frmSearchDriver()
        {
            InitializeComponent();
            disableRadioButtons();
            this.ActiveControl = txtSearchText;
            txtSearchText.Mask = "???-000";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            query = "select driverID \"ID\", DriverSince \"Join Date\", Name, Experience, Salary from dbadmin.driver";
            OracleDBConnection.fillDataGrieView(dtSearchDriver, query);
            rdoDriverID.Checked = true;
            disableRadioButtons();
        }

        private void rdoDriverID_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.Clear();
            txtSearchText.Mask = "???-000";
            disableRadioButtons();
        }

        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.Clear();
            txtSearchText.Mask = null;
            enableRadrioButtons();
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchText.Clear();
            txtSearchText.Mask = "00000";
            disableRadioButtons();
        }


        private void disableRadioButtons()
        {
            rdoContainig.Enabled = false;
            rdoExact.Enabled = false;
            rdoNotLike.Enabled = false;
        }

        private void enableRadrioButtons()
        {
            rdoContainig.Enabled = true;
            rdoExact.Enabled = true;
            rdoNotLike.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearchDriver_Click(object sender, EventArgs e)
        {
            if(rdoDriverID.Checked)
            {
                query = "select driverID \"ID\", DriverSince \"Join Date\", Name, Experience, Salary from dbadmin.driver where driverID = '" + txtSearchText.Text.ToUpper() + "'";
            } 
            else if (rdoSalary.Checked)
            {
                query = "select driverID \"ID\", DriverSince \"Join Date\", Name, Experience, Salary from dbadmin.driver where salary = " + txtSearchText.Text ;
            } else
            {
                if(rdoExact.Checked)
                {
                    query = "select driverID \"ID\", DriverSince \"Join Date\", Name, Experience, Salary from dbadmin.driver where name = '" + txtSearchText.Text.ToUpper() + "'";
                } else if (rdoContainig.Checked)
                {
                    query = "select driverID \"ID\", DriverSince \"Join Date\", Name, Experience, Salary from dbadmin.driver where name like '%" + txtSearchText.Text.ToUpper() + "%'" ;
                } else
                {
                    query = "select driverID \"ID\", DriverSince \"Join Date\", Name, Experience, Salary from dbadmin.driver where name not like '%" + txtSearchText.Text.ToUpper() + "%'" ;
                }
            }

            OracleDBConnection.fillDataGrieView(dtSearchDriver, query);
        }
    }
}
