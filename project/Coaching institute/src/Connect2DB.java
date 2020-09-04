
import java.sql.Connection;
import java.sql.DriverManager;
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Muhammad Faraz
 */
public class Connect2DB {
    public static void main(String[] args) {
        try{
            Class.forName("oracle.jdbc.OracleDriver");
            Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","system","hussain");
//            return con;
        }catch(Exception e){
            JOptionPane.showMessageDialog(null, e);
        }
//        return null;
    }
    
}
