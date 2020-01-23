using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class Patient
    {
        

            private string nic;
            private string fname;
            private string lname;

            private string addressl1;
            private string street;
            private string city;


            private string front_office_clerksId;
            private string doctors_nic;
            private bool is_paid;
            private float reg_fee;
            private string appoinment_date;
            private string dob;
            private string contact_no;
            



            public Patient(string nic, string fname, string lname, string addressl1, string street, string city, string front_office_clerksId, string doctors_nic, bool is_paid, float reg_fee, string appoinment_date, string dob, string contact_no)
            {
                this.nic = nic;

                this.fname = fname;
                this.lname = lname;
                this.addressl1 = addressl1;
                this.street = street;
                this.city = city;
                this.front_office_clerksId = front_office_clerksId;
                this.doctors_nic = doctors_nic;
                this.is_paid = is_paid;
                this.reg_fee = reg_fee;
                this.appoinment_date = appoinment_date;
                this.dob = dob;
                this.contact_no = contact_no;
                 

            }
            public string getnic()
            {
                return this.nic;
            }



            public string getfname()
            {
                return this.fname;
            }

            public string getlname()
            {
                return this.lname;
            }

            public string getaddressl1()
            {
                return this.addressl1;
            }
            public string getstreet()
            {
                return this.street;
            }

            public string getcity()
            {
                return this.city;
            }


            public string getfront_office_clerksId()
            {
                return this.front_office_clerksId;
            }

            public string getdoctors_nic()
            {
                return this.doctors_nic;
            }
            public bool getis_paid()
            {
                return this.is_paid;
            }
            public float getreg_fee()
            {
                return this.reg_fee;
            }
            public string getappoinment_date()
            {
                return this.appoinment_date;
            }
            public string getdob()
            {
                return this.dob;
            }
            public string getcontact_no()
            {
                return this.contact_no;
            }
             
        }
    }
 