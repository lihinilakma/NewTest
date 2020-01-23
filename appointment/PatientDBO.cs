using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class PatientDBO
    {
        SqlConnection conn = null;

        public PatientDBO()
        {
            conn = DBConnection.getConnection();
        }

        public int count_doctor_appointments(string nic, string appoinment_date)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from patients where doctors_nic = '" + nic + "' and appoinment_date = '" + appoinment_date + "' group by doctors_nic", conn);
            Int32 count = (Int32)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }

        public void resgisterPatient(Patient patient)
        {

            string nic = patient.getnic();

            string fname = patient.getfname();
            string lname = patient.getlname();
            string addressl1 = patient.getaddressl1();
            string street = patient.getstreet();
            string city = patient.getcity();

            string front_office_clerksId = patient.getfront_office_clerksId();

            string doctors_nic = patient.getdoctors_nic();

            bool is_paid = patient.getis_paid();

            float reg_fee = patient.getreg_fee();

            string appoinment_date = patient.getappoinment_date();

            string dob = patient.getdob();
            string contact_no = patient.getcontact_no();

            //open the connection
            conn.Open();

            //Execute query
            SqlCommand cmd = new SqlCommand("insert into patients values ('" + nic + "', '" + fname + "','" + lname + "','" + addressl1 + "','" + street + "','" + city + "','" + front_office_clerksId + "', '" + doctors_nic + "', '" + is_paid + "', '" + reg_fee + "', '" + appoinment_date + "', '" + dob + "','" + contact_no + "')", conn);

            cmd.ExecuteNonQuery();

             
             //close the connection

            conn.Close();
        }

         

        public void deletepatient(string nic)
        {


            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from patients where nic='" + nic + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public Patient findPatient(string nic)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *  from patients where nic ='" + nic + "'", conn);


            
            SqlDataReader rd = cmd.ExecuteReader();

             

            Patient patient = null;
            while (rd.Read())
            {
                string nic_no = rd[0].ToString();
                string fname = rd[1].ToString();
                string lname = rd[2].ToString();
                string addressl1 = rd[3].ToString();
                string street = rd[4].ToString();
                string city = rd[5].ToString();
                string front_office_clerksId = rd[6].ToString();
                string doctors_nic = rd[7].ToString();
                 
                bool is_paid = bool.Parse(rd[8].ToString());
                float reg_fee = float.Parse(rd[9].ToString());
                string appointment_date = rd[10].ToString();
                string dob = rd[11].ToString();
                string contact_no = rd[12].ToString();
                 

                patient = new Patient(nic_no, fname, lname, addressl1, street, city, front_office_clerksId, doctors_nic, is_paid, reg_fee, appointment_date, dob,contact_no);


            }
            conn.Close();
            return patient;
        }

        public void updatepatient(Patient patient)
        {
            string nic = patient.getnic();
            string fname = patient.getfname();
            string lname = patient.getlname();
            string addressl1 = patient.getaddressl1();
            string street = patient.getstreet();
            string city = patient.getcity();

            string front_office_clerksId = patient.getfront_office_clerksId();
            string doctors_nic = patient.getdoctors_nic();
            bool is_paid = patient.getis_paid();

            float reg_fee = patient.getreg_fee();
            string appointment_date = patient.getappoinment_date();
            string dob = patient.getdob();
            string contact_no = patient.getcontact_no();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update patients set fname='" + fname + "',lname='" + lname + "',addressl1='" + addressl1 + "',street='" + street + "',city='" + city + "', front_office_clerksId='" + front_office_clerksId + "',doctors_nic='" + doctors_nic + "',is_paid='" + is_paid + "' ,reg_fee='" + reg_fee + "' ,appoinment_date='" + appointment_date + "',dob='" + dob + "',contact_no='" + contact_no + "' where nic ='" + nic + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        
        }
    
    }

