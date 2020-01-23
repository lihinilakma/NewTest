using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 

namespace appointment
{
    class FrontDBO
    {

        SqlConnection conn = null;

        public FrontDBO()
        {
            conn = DBConnection.getConnection();
        }

        public void registerFront(Front front, ArrayList contactNos)
        {
            string empid = front.getempid();

            string first_name = front.getfname();
            string last_name = front.getlname();
            string addressl1 = front.getaddressl1();
            string street = front.getstreet();
            string city = front.getcity();
            string gender = front.getgender();

            DateTime dob = front.getdob();


            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into front_office_clerks values ('" + empid + "', '" + first_name + "','" + last_name + "','" + addressl1 + "','" + street + "','" + city + "','" + gender + "', '" + dob + "')", conn);

            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("insert into employee_contact_nos values('" + empid + "','" + contactNos[0] + "' )", conn);
            SqlCommand cmd2 = new SqlCommand("insert into employee_contact_nos values('" + empid + "','" + contactNos[1] + "')", conn);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            conn.Close();
        }
        public void deleteclerk(string empid)
        {


            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from front_office_clerks where empid='" + empid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
