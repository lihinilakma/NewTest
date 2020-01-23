using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class Treat
    {
        private string doc_nic;
        private string patient_nic;
        private string treatment_date; 
        private float treatment_fee;
        
        private string treatment_code;
        private string treatment_details;
        private bool is_paid;




        public Treat(string doc_nic, string patient_nic, string treatment_date, float treatment_fee, string treatment_code,  string treatment_details, bool is_paid)
        {
            this.doc_nic = doc_nic;

            this.patient_nic = patient_nic;
            this.treatment_date = treatment_date;
            this.treatment_fee = treatment_fee;
            
            this.treatment_code = treatment_code;
            this.treatment_details = treatment_details;
            this.is_paid = is_paid;
            
             
        }
        public string getdoc_nic()
        {
            return this.doc_nic;
        }



        public string getpatient_nic()
        {
            return this.patient_nic;
        }

        public string gettreatment_date()
        {
            return this.treatment_date;
        }
        public float gettreatment_fee()
        {
            return this. treatment_fee;
        }

        public string gettreatment_code()
        {
            return this.treatment_code;
        }
        public string gettreatment_details()
        {
            return this.treatment_details;
        }

        
        public bool getis_paid()
        {
            return this.is_paid;
        }

        
    }
}
