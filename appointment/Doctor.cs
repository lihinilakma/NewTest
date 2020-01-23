using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class Doctor
    {

        private string nic;
        private string fname;
        private string lname;

        private string addressl1;
        private string street;
        private string city;
        

        private DateTime dob;

        private int experience;
        private string speciality;
        private string managerid;

        public Doctor(string nic, string fname, string lname, string addressl1, string street, string city, DateTime dob,int experience,string speciality,string managerid )
        {
            this.nic = nic;

            this.fname = fname;
            this.lname = lname;
            this.addressl1 = addressl1;
            this.street = street;
            this.city = city;
            this.dob = dob;
            this.experience = experience;
            this.speciality = speciality;
            this.managerid = managerid;

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

       
        public DateTime getdob()
        {
            return this.dob;
        }

        public int getexperience()
        {
            return this.experience;
        }
        public string getspeciality()
        {
            return this.speciality;
        }
        public string getmanagerid()
        {
            return this.managerid;
        }
    }
}