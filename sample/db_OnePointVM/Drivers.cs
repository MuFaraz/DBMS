using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_OnePointVM
{
    class Drivers
    {
        public string driverID { get; set; }
        public  string driverSince { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public int age { get; set; }
        public string CNIC { get; set; }
        public string  mobile { get; set; }
        public int experience { get; set; }
        public int accidents { get; set; }
        public int salary { get; set; }
        public char availabile { get; set; }

        private string query = "";


        public void addDriver()
        {
            driverID = newDriverID();
            query = "insert into dbadmin.driver values('" + driverID + "', to_date('" + driverSince + "', 'dd-mm-yyyy'), '" + name + "', '"
                + fatherName + "', " + age + ", '" + CNIC + "', '" + mobile + "', " + experience + ", " + accidents + ", " + salary + ", '" + availabile + "')";
            OracleDBConnection.performDMLOperation(query);
        }

        public void updateDriver(string drvrID)
        {
            driverID = drvrID;
            query = "update dbadmin.driver set name = '" + name + "', fathername = '" + fatherName + "', age = " + age + ", cnic = '" + CNIC
                 + "', mobile = '" + mobile + "', experience = " + experience + ", accidents = " + accidents 
                 + ", salary = " + salary + ", availability = '" + availabile + "' where driverID = '" + driverID + "'";
            OracleDBConnection.performDMLOperation(query);
        }

        public void deleteDriver(string driverID)
        {
            query = "delete from dbadmin.driver where driverID = '" + driverID +"'";
            OracleDBConnection.performDMLOperation(query);
        }

        public string newDriverID()
        {
            string oldID;
            string sub;
            int newNumber = 0;
            string newID = "";

            query = "select max(driverID) from dbadmin.driver";
            oldID = OracleDBConnection.selectStringValue(query);
            if (oldID == null)
            {
                newID = "DRV-001";
            }
            else
            {
                sub = oldID.Substring(4, 3);
                newNumber = Int16.Parse(sub);
                newNumber = newNumber + 1;
                newID = oldID.Replace(sub, string.Format("{0:000}", newNumber));
            } 

            return newID;
        }
    }
}
