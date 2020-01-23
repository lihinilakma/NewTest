using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class Front
    {

        private string empid;
        private string fname;
        private string lname;

        private string addressl1;
        private string street;
        private string city;
        private string gender;

        private DateTime dob;



        public Front(string empid, string fname, string lname, string addressl1, string street, string city, string gender, DateTime dob)
        {
            this.empid = empid;

            this.fname = fname;
            this.lname = lname;
            this.addressl1 = addressl1;
            this.street = street;
            this.city = city;
            this.gender = gender;

            this.dob = dob;

        }
        public string getempid()
        {
            return this.empid;
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

        public string getgender()
        {
            return this.gender;
        }


        public DateTime getdob()
        {
            return this.dob;
        }


    }
} 