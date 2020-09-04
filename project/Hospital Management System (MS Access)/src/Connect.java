/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Raj
 */
import java.sql.*;
import javax.swing.*;
public class Connect {
//     Connection con=null;
   
        public static Connection ConnectDB(){
             String dataSourceName="HMS_DB";
//          String dbURL = "jdbc:odbc:" + dataSourceName;
        try{
             String db = "jdbc:ucanaccess://HMS_DB.accdb";
             String driver = "net.ucanaccess.jdbc.UcanaccessDriver";
            Class.forName(driver);
//            Connection con = DriverManager.getConnection(dbURL, "","");
            Connection con = DriverManager.getConnection(db);

            return con;
            
        }catch(Exception e){
            JOptionPane.showMessageDialog(null, e);
            return null;
    
    }      
}
}
