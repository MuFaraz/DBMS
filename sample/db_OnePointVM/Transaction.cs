using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_OnePointVM
{
    class Transaction
    {
        public string transactionID { get; set; }
        public string transactionDate { get; set; }
        public string   clientName { get; set; }
        public string clientCNIC { get; set; }
        public string clientContact { get; set; }
        public string vehicleID { get; set; }
        public string driverID { get; set; }
        public short tripType { get; set; }
        public string source { get; set; }
        public string currentLoc { get; set; }
        public string destination { get; set; }
        public int kilometers { get; set; }
        public long charges { get; set; }
        public int lateCharges { get; set; }
        public string Status { get; set; }

        private string query = "";

        public string generateNewTransID()
        {
            string oldID;
            string sub;
            int newNumber = 0;
            string newID = "";

            query = "select max(TransactionID) from dbadmin.Transaction";
            oldID = OracleDBConnection.selectStringValue(query);

            if (oldID == null)
            {
                newID = "TRANS-001";
            }
            else
            {
                sub = oldID.Substring(6, 3);
                newNumber = Int16.Parse(sub);
                newNumber = newNumber + 1;
                newID = oldID.Replace(sub, string.Format("{0:000}", newNumber));
            }

            return newID;
        }

        public long getChargesForTransaction(string vhcID)
        {
            long amount = 0;
            int perKMCharges = 0;

            string vhcType;
            vhcType = OracleDBConnection.selectStringValue("select type from dbadmin.vehicle where vehicleID = '" + vhcID + "'");

            if(vhcType == "BUS" || vhcType == "TRUCK" || vhcType == "MAZDA")
            {
                perKMCharges = 80;
            }
            else if(vhcType == "CAR" || vhcType == "WAGON" || vhcType == "JEEP")
            {
                perKMCharges = 20;
            }

            amount = kilometers * perKMCharges;
            return amount;
        }

        private void transactionDone()
        {
            query = "update dbadmin.Transaction set Status = 'DONE' where transactionID = '" + transactionID + "'";
            OracleDBConnection.performDMLOperation(query);

            setDriverAndVehicleAvailable();
        }

        public void AddTransaction()
        {
            query = "insert into dbadmin.Transaction values('" + transactionID + "', to_date('" + transactionDate + "', 'dd-mm-yyyy'), '"
                         + clientName + "', '" + clientCNIC + "', '" + clientContact + "', '" + vehicleID + "', '" + driverID + "', '" + tripType + "', '"
                         + source + "', '" + currentLoc + "', '" + destination + "', " + kilometers + ", " + charges + ", " + lateCharges + ", '" + Status + "')";
            OracleDBConnection.performDMLOperation(query);

            setDriverAndVehicleOnDuty();

            kilometers = 0;
            charges = 0;
        }

        public void updateTransaction()
        {
            query = "update dbadmin.Transaction set clientName = '" + clientName + "', clientCNIC = '" + clientCNIC 
                     + "', clientContact = '" +  clientCNIC + "', current_Loc = '" + currentLoc 
                     + "', LateCharges = " + lateCharges + ", Status = '" + Status + "' where TransactionID = '" + transactionID + "'";
            
            OracleDBConnection.performDMLOperation(query);
            updateCurrentLocation();

            kilometers = 0;
            charges = 0;
        }

        public void updateCurrentLocation()
        {
            if(tripType == 1 && currentLoc == destination)
            {
                transactionDone();
            } 
            else if(tripType == 2 && currentLoc == source)
            {
                transactionDone();
            }
        }

        public void setDriverAndVehicleOnDuty()
        {
            query = "update dbadmin.driver set Availability = 'O' where driverID = '" + driverID + "'";
            OracleDBConnection.performDMLOperation(query);

            query = "update dbadmin.vehicle set Status = 'O' where vehicleID  = '" + vehicleID + "'";
            OracleDBConnection.performDMLOperation(query);
        }

        public void setDriverAndVehicleAvailable()
        {
            query = "update dbadmin.driver set Availability = 'A' where driverID = '" + driverID + "'";
            OracleDBConnection.performDMLOperation(query);

            query = "update dbadmin.vehicle set Status = 'A' where vehicleID  = '" + vehicleID + "'";
            OracleDBConnection.performDMLOperation(query);
        }
    }
}
