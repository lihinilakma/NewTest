using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class DoctorDBO
    {

        SqlConnection conn = null;

        public DoctorDBO()
        {
            conn = DBConnection.getConnection();
        }

        public void resgisterDoctor(Doctor doctor, ArrayList contactNos)
        {
            string nic = doctor.getnic();

            string fname = doctor.getfname();
            string lname = doctor.getlname();
            string addressl1 = doctor.getaddressl1();
            string street = doctor.getstreet();
            string city = doctor.getcity();
             

            DateTime dob = doctor.getdob();
            int experience = doctor.getexperience();
            string speciality = doctor.getspeciality();
            string managerid = doctor.getmanagerid();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into doctors values ('" + nic + "', '" + fname + "','" + lname + "','" + addressl1 + "','" + street + "','" + city + "',  '" + dob + "',  '" + experience + "',  '" + speciality + "',  '" + managerid + "')", conn);

            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("insert into doctors_contact_nos values('" + nic+ "','" + contactNos[0] + "' )", conn);
            SqlCommand cmd2 = new SqlCommand("insert into doctors_contact_nos   values('" + nic + "','" + contactNos[1] + "')", conn);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

             

            conn.Close();
        }
        public void deletedoctor(string nic)
        {


            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from doctors where nic='" + nic + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
