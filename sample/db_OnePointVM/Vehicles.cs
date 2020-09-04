using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_OnePointVM
{
    class Vehicles
    {
        public string vehicleID { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public DateTime madeYear { get; set; }
        public string engineNumber { get; set; }
        public string chasisNumber { get; set; }
        public long price { get; set; }
        public DateTime purchaseDate { get; set; }
        public DateTime fitnessStartsFrom { get; set; }
        public DateTime fitnessExpiresOn { get; set; }
        public string availabilityStatus { get; set; }

        private string query = "";


        public void addVehicle()
        {
            query = "insert into dbadmin.vehicle values('" + vehicleID + "', '" + maker + "', '" + model + "', '" + type
                     + "', to_date('" + madeYear.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy'), '" + engineNumber + "', '" + chasisNumber
                     + "', " + price + ", to_date('" + purchaseDate.ToString("dd-MM-yyyy") 
                     + "', 'dd-mm-yyyy'), to_date('" + fitnessStartsFrom.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy')"
                     + ", to_date('" + fitnessExpiresOn.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy'), '" + availabilityStatus + "')";

            OracleDBConnection.performDMLOperation(query);
        }

        public void updateVehicle()
        {
            query = "update dbadmin.vehicle set MAKER = '" + maker + "',  MODEL = '" + model + "', TYPE = '" + type
                     + "', MADE = to_date('" + madeYear.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy'), ENGINE = '" + engineNumber + "', CHASIS ='" + chasisNumber
                     + "', PRICE = " + price + ", PURCHASEDATE = to_date('" + purchaseDate.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy')"
                     + ", FITNESSVALID = to_date('" + fitnessStartsFrom.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy')"
                     + ", FITNESSEXPIRY = to_date('" + fitnessExpiresOn.ToString("dd-MM-yyyy") + "', 'dd-mm-yyyy'), STATUS = '" + availabilityStatus + 
                     "' where vehicleID = '" + vehicleID + "'";
            OracleDBConnection.performDMLOperation(query);
        }  

        public void deleteVehicle(string vehclID)
        {
            query = "delete from dbadmin.vehicle where vehicleID = '" + vehclID + "'";
            OracleDBConnection.performDMLOperation(query);
        }
    }
}
