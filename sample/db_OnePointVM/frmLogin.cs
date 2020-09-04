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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.ToString();
            string passwd = txtUserPswd.Text.ToString();

            if(OracleDBConnection.connect(userID, passwd))
            {
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.Show();

            } else
            {
                txtUserID.Text = "";
                txtUserID.BackColor = Color.Yellow;

                txtUserPswd.Text = "";
                txtUserPswd.BackColor = Color.Yellow;

                txtUserID.Focus();
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            txtUserID.BackColor = Color.White;
        }

        private void txtUserPswd_TextChanged(object sender, EventArgs e)
        {
            txtUserPswd.BackColor = Color.White;
        }
    }
}
