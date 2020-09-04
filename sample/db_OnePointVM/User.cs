using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_OnePointVM
{
    class User
    {
        private string userName;
        private string password;
        private string userType;

        private string query = "";


        public User(string usrName, string passwd, string usrType)
        {
            this.userName = usrName;
            this.password = passwd;
            this.userType = usrType;
        }

        public void addUser()
        {
            try
            {
                query = "create user " + userName + " identified by " + password + " account unlock";
                OracleDBConnection.performDMLOperation(query);

                query = "insert into dbadmin.users values('" + userName + "', '" + userType + "') ";
                OracleDBConnection.performDMLOperation(query);

                grantPrivileges();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public void dropUser()
        {
            try
            {
                query = "drop user " + userName;
                OracleDBConnection.performDMLOperation(query);
                OracleDBConnection.callStoredProcedure("deleteUser", userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void updateUser()
        {
            try
            {
                query = "alter user " + userName + " identified by " + password;
                OracleDBConnection.performDMLOperation(query);

                MessageBox.Show("User Password updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void grantPrivileges()
        {
            query = "grant create session, unlimited tablespace, resource to " + userName;
            OracleDBConnection.performDMLOperation(query);

            string[] tables = { "EXPENSES", "TRANSACTION", "VEHICLE", "DRIVER", "MAINTENANCE", "USERS",
                                  "VUTRANSACTIONPENDING", "VUTRANSACTIONDONE", "VUDRIVERSLIST", "", "VUTRANSACTIONS", "VUVEHICLESLIST"  };

            foreach (string item in tables)
            {
                query = "grant select, insert, update on dbadmin." + item + " to " + userName;
                OracleDBConnection.performDMLOperation(query);
            }
        }
    }
}
