using System;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace db_OnePointVM
{
    static class OracleDBConnection
    {
        private static string userID;
        private static string passwd;
        public static string userType;

        private static OracleConnection con;
        private static OracleCommand cmd;
        private static OracleDataReader reader;

        public enum UserType
        {
            USER,
            ADMIN
        };

        public static string returnUserID()
        {
            return userID;
        }

        public static string returnPassword()
        {
            return passwd;
        }


        public static string conString { get; set; }


        public static bool connect(string usrID, string password)
        {
            userID = usrID;
            passwd = password;

            int returnVal = 0;

            try
            {
                conString = "User Id = " + userID + "; Password = " + passwd + "; Data Source = localhost:1521/orcl; Pooling = false;";
                con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandText = "select type from dbadmin.users where userID = '" + userID + "'";

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userType = reader.GetString(0);
                    returnVal++;  // to check how many rows are returned by the query...
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + " Wrong UserID or Password...");
            }

            if (returnVal == 1)
            {
                return true;
            }

            return false;
        }

        public static string selectStringValue(string query)
        {
            string returnVal = null;
            int countRows = 0;

            try
            {
                con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    returnVal = reader.GetString(0);
                    countRows++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "No Record Found!" );
            }

            if (countRows == 1)
            {
                return returnVal;
            }
            else
                returnVal = null;

            return returnVal;
        }

        public static int selectIntegerValue(string query)
        {
            int returnVal = 0;
            int countRows = 0;

            try
            {
                con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    returnVal = reader.GetInt32(0);
                    countRows++;
                }
            }
            catch (Exception )
            {
                // MessageBox.Show(ex.Message);
                return 0;
            }

            if (countRows == 1)
            {
                return returnVal;
            }

            return returnVal;
        }

        public static long getValueFromFunction(string query)
        {
            long returnVal = 0;







            return returnVal;
        }


        public static void performDMLOperation(string query)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();

            OracleCommand cmd = con.CreateCommand();
            // To commit data to Oracle Database...
            OracleTransaction trans = con.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                trans.Commit();
                con.Close();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
        }


        public static void fillComboBox(ComboBox cbBox, string query, string tableName, string displayID)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(conString))
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    conn.Open();

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, tableName);

                    cbBox.DataSource = ds.Tables[tableName];
                    cbBox.DisplayMember = displayID;
                }
            }
            catch (Exception)
            {
                cbBox.Items.Add("Not available");
            }
        }

        public static void fillDataGrieView(DataGridView dtGridView, string query)
        {
            try
            {
                using (OracleConnection connEz = new OracleConnection(conString))
                using (OracleCommand cmdEz = new OracleCommand(query, connEz))
                {
                    connEz.Open();
                    using (OracleDataReader reader = cmdEz.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dtGridView.DataSource = dataTable;

                        if(dtGridView.Rows.Count == 0)
                        {
                            if (query.Contains("VUTransactionPending"))
                            {
                                MessageBox.Show("No Transactions Pending for Today!", "Relax", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void callStoredProcedure(string procedureName, string id)
        {
            try
            {
                OracleConnection con = new OracleConnection(conString);
                con.Open();
                OracleCommand cmd = new OracleCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter inval = new OracleParameter("inval", OracleDbType.Varchar2);
                inval.Direction = ParameterDirection.Input;
                inval.Value = id;
                cmd.Parameters.Add(inval);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
