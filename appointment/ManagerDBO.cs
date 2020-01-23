using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace appointment
{
    class ManagerDBO
    {
        
        SqlConnection conn = null;

        public ManagerDBO()
        {
            conn = DBConnection.getConnection();
        }

        public void registerManager(Manager manager, ArrayList contactNos)
        {
            string empid = manager.getempid();

            string fname = manager.getfname();
            string lname = manager.getlname();
            string addressl1 = manager.getaddressl1();
            string street = manager.getstreet();
            string city = manager.getcity();
            string gender = manager.getgender();

            string dob = manager.getdob();
             

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into managers values ('" + empid + "', '" + fname + "','" + lname + "','" + addressl1 + "','" + street + "','" + city + "','" + gender + "', '" + dob + "')", conn);

            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("insert into employee_contact_nos values('" + empid + "','" + contactNos[0] + "' )", conn);
            SqlCommand cmd2 = new SqlCommand("insert into employee_contact_nos values('" + empid + "','" + contactNos[1] + "')", conn);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();


            conn.Close();
        }
        public void deletemanager(string empid)
        {


            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from managers where empid='" + empid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
         


    }
}
