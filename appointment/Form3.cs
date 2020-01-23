using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace appointment
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorDBO adbo = new DoctorDBO();

            string nic = txtnic.Text.Trim();

            string fname = txtfname.Text.Trim();
            string lname = txtlname.Text.Trim();
            string addressl1 = txtaddressl1.Text.Trim();
            string street = txtstreet.Text.Trim();
            string city = txtcity.Text.Trim();
             

            DateTime dob = dateTimePicker1.Value;
            int experience = int.Parse(txtexperience.Text.Trim());
            string speciality = txtspeciality.Text.Trim();
            string managerid = txtmanagerid.Text.Trim();

            Doctor doctor = new Doctor(nic, fname, lname, addressl1, street, city, dob, experience, speciality, managerid);


            ArrayList list = new ArrayList();
            list.Add(txthome.Text.Trim());
            list.Add(txtmobile.Text.Trim());

             
            adbo.resgisterDoctor(doctor,list);
            
             
            MessageBox.Show("Doctor registration succesfully!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nic = txtnic.Text.Trim();
            DoctorDBO sdbo = new DoctorDBO ();
            sdbo.deletedoctor(nic);

            MessageBox.Show("doctor delete succesfully!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form20 Form20 = new Form20();
            Form20.Show();
            this.Hide();
        }
    }
}
