using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appointment
{
    class TreatDBO
    {
         
        SqlConnection conn = null;

        public TreatDBO()
        {
            conn = DBConnection.getConnection();
        }

        public void addTreat(Treat treat)
        {
            string doc_nic = treat.getdoc_nic();

            string patient_nic = treat.getpatient_nic();
            string treatment_date = treat.gettreatment_date();
            float treatment_fee = treat.gettreatment_fee();
            
            string treatment_code = treat.gettreatment_code();
            string treatment_details = treat.gettreatment_details();
            bool is_paid = treat.getis_paid();
             
             

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into treatments values ('" + doc_nic + "', '" + patient_nic + "','" + treatment_date + "','" + treatment_fee + "','" + treatment_code + "','" + treatment_details + "','" + is_paid + "')", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        
        

        public void deletetreat(string patient_nic)
        {


            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from treatments where patients_nic='" + patient_nic + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


         
 
        
        }
    }

 