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
    public partial class frmUsers : Form
    {
        private string getUsers = "select * from users";
        private User newUser;

        public frmUsers()
        {
            InitializeComponent();
            OracleDBConnection.fillDataGrieView(dtGridUsers, getUsers);
            disableButtons();
            btnAddNewUser.Focus();
            rdoLocalUser.Checked = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPassword.Checked)
            {
                txtNewUserPass.PasswordChar = '●';
            }
            else
            {
                txtNewUserPass.PasswordChar = '\0';
                txtNewUserPass.Text = txtNewUserPass.Text;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "" || txtNewUserPass.Text == "")
            {
                MessageBox.Show("Field cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.Compare(txtNewUser.Text.ToString(), "USER", StringComparison.OrdinalIgnoreCase) == 0)
            {
                MessageBox.Show("Invalid USERNAME... Try a different name like \"user1\". ");
                txtNewUser.Focus();
            }
            else
            {
                if (rdoLocalUser.Checked)
                    newUser = new User(txtNewUser.Text, txtNewUserPass.Text, rdoLocalUser.Text);
                else
                    newUser = new User(txtNewUser.Text, txtNewUserPass.Text, rdoUserAdmin.Text);

                newUser.addUser();
                clearFields();
                txtNewUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            OracleDBConnection.fillDataGrieView(dtGridUsers, getUsers);
        }

        private void btnClearAllFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string user = txtNewUser.Text.ToString();
            if (user != null || user != "")
            {
                try
                {
                    User usrDrop = new User(txtNewUser.Text, "", "");
                    usrDrop.dropUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                txtNewUser.Focus();
            }

            enableRadioButtons();
            disableButtons();
            clearFields();
            OracleDBConnection.fillDataGrieView(dtGridUsers, getUsers);
        }

        private void dtGridUsers_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            txtNewUser.Enabled = false;
            chkShowPassword.Enabled = false;

            enableButtons();
            // SelectionMode is set to FullRowSelect for this operation...
            dtGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewRow dr = dtGridUsers.SelectedRows[0];
            txtNewUser.Text = dr.Cells[0].Value.ToString();
            txtNewUserPass.Text = "*********";

            if (dr.Cells[1].Value.ToString() == "USER")
                rdoLocalUser.Checked = true;
            else
                rdoUserAdmin.Checked = true;

            disableRadioButtons();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtNewUserPass.Text == "*********")
                MessageBox.Show("Type your New Password First...");
            else
            {
                try
                {
                    User usrUpdate = new User(txtNewUser.Text, txtNewUserPass.Text, null);
                    usrUpdate.updateUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            enableRadioButtons();
            disableButtons();
            clearFields();
            OracleDBConnection.fillDataGrieView(dtGridUsers, getUsers);
        }




        private void disableButtons()
        {
            btnDeleteUser.Enabled = false;
            btnUpdateUser.Enabled = false;
        }

        private void enableButtons()
        {
            btnUpdateUser.Enabled = true;
            btnDeleteUser.Enabled = true;
        }

        private void enableRadioButtons()
        {
            rdoLocalUser.Enabled = true;
            rdoUserAdmin.Enabled = true;
        }

        private void disableRadioButtons()
        {
            rdoLocalUser.Enabled = false;
            rdoUserAdmin.Enabled = false;
        }

        private void clearFields()
        {
            txtNewUser.Clear();
            txtNewUserPass.Clear();
            enableRadioButtons();
            txtNewUser.Enabled = true;
            chkShowPassword.Enabled = true;
            txtNewUser.Focus();
        }

    }
}
