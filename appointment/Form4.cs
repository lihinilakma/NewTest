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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtnic.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtclerkid.Text == "")
            {
                MessageBox.Show("Please enter values for each textbox...");
            }
            else
            {

                PatientDBO adbo = new PatientDBO();

                string nic = txtnic.Text.Trim();

                string fname = txtfname.Text.Trim();
                string lname = txtlname.Text.Trim();
                string addressl1 = txtaddressl1.Text.Trim();
                string street = txtstreet.Text.Trim();
                string city = txtcity.Text.Trim();
                string front_office_clerksId = txtclerkid.Text.Trim();
                string doctors_nic = txtid.Text.Trim();
                bool is_paid = checkBox1.Checked;
                float reg_fee = float.Parse(txtreg_fee.Text.Trim());
                string appoinment_date = dateTimePicker2.Text.Trim(); ;
                string dob = dateTimePicker1.Text.Trim();

                string contact_no = txtcontact.Text.Trim();

                Patient patient = new Patient(nic, fname, lname, addressl1, street, city, front_office_clerksId, doctors_nic, is_paid, reg_fee, appoinment_date, dob, contact_no);
                
                
                int count = adbo.count_doctor_appointments(doctors_nic, appoinment_date);
                clear();

                if (count > 8)
                {
                    
                    MessageBox.Show("appoinments limit has been exceeded");
                    
                }
                else
                {
                    adbo.resgisterPatient(patient);
                    MessageBox.Show("patient Registered");
                }


                
                

            }
        }
        
            
            
        private void button4_Click(object sender, EventArgs e)
        {
            string nic = txtnic.Text.Trim();
            PatientDBO sdbo = new PatientDBO();
            sdbo.deletepatient(nic);

            MessageBox.Show("patient delete succesfully!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
            this.Hide();
        }

        private void txtnic_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            PatientDBO sdbo = new PatientDBO();
            string nic = txtnic.Text.Trim();
            string fname = txtfname.Text.Trim();
            string lname = txtlname.Text.Trim();
            string addressl1 = txtaddressl1.Text.Trim();
            string street = txtstreet.Text.Trim();
            string city = txtcity.Text.Trim();

            string front_office_clerksId = txtclerkid.Text.Trim();
            string doctors_nic = txtid.Text.Trim();
            bool is_paid = checkBox1.Checked;


            float reg_fee = float.Parse(txtreg_fee.Text.Trim());
            string appointment_date = dateTimePicker2.Text.Trim();
            string dob = dateTimePicker1.Text.Trim();
            string contact_no = txtcontact.Text.Trim();

            Patient patient = new Patient(nic, fname, lname, addressl1, street, city, front_office_clerksId, doctors_nic, is_paid, reg_fee, appointment_date, dob, contact_no);
            sdbo.updatepatient(patient);
            clear();
            MessageBox.Show("Patient update succesfully!!!");
        }

        private void txtnic_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nic_no = txtnic.Text.Trim();
            PatientDBO sdbo = new PatientDBO();
            Patient patient = sdbo.findPatient(nic_no);

            txtfname.Text = patient.getfname();
            txtlname.Text = patient.getlname();
            txtaddressl1.Text = patient.getaddressl1();
            txtstreet.Text = patient.getstreet();
            txtcity.Text = patient.getcity();
            txtclerkid.Text = patient.getfront_office_clerksId();
            txtid.Text = patient.getdoctors_nic();
            checkBox1.Checked = patient.getis_paid();
            txtreg_fee.Text = patient.getreg_fee().ToString();
            dateTimePicker2.Text = patient.getappoinment_date();
            dateTimePicker1.Text = patient.getdob();
            txtcontact.Text = patient.getcontact_no();


        }


        private void clear()
        {

            txtnic.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtaddressl1.Text = "";
            txtstreet.Text = "";
            txtcity.Text = "";

            txtclerkid.Text = "";
            txtid.Text = "";
             


            txtreg_fee.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker1.Text = "";
            txtcontact.Text = "";




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form18 Form18 = new Form18();
            Form18.Show();
            this.Hide();
        }
    }
}