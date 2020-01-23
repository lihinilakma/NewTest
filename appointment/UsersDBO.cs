using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appointment
{
    class UsersDBO
    {

        SqlConnection conn = null;

        public UsersDBO()
        {
            conn = DBConnection.getConnection();
        }

        public void addUser(Users users)
        {
            string username = users.getusername();

            string password = users.getpassword();
            string category = users.getcategory();


            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into users values ('" + username + "', '" + password + "','" + category + "')", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}