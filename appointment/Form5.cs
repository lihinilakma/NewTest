using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
 


namespace appointment
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdoc_nic.Text == "" || txtpatient_nic.Text == "" || txtcode.Text == "" || txtdetails.Text == "")
            {
                MessageBox.Show("Please enter values for each textbox...");
            }
            else
            {
                TreatDBO adbo = new TreatDBO();

                string doc_nic = txtdoc_nic.Text.Trim();

                string patient_nic = txtpatient_nic.Text.Trim();
                string treatment_date = dateTimePicker1.Text;
                float treatment_fee = float.Parse(txtfee.Text.Trim());

                string treatment_code = txtcode.Text.Trim();
                string treatment_details = txtdetails.Text.Trim();
                bool is_paid = checkBox1.Checked;

                Treat treat = new Treat(doc_nic, patient_nic, treatment_date, treatment_fee, treatment_code, treatment_details, is_paid);




                adbo.addTreat(treat);
                MessageBox.Show("Add treatment details succesfully ");
            }
        }
         

        private void button2_Click(object sender, EventArgs e)
        {
             Form19 Form19 = new Form19();
            Form19.Show();
            this.Hide();
             
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Total_MouseClick(object sender, MouseEventArgs e)
        {
             

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string patient_nic = txtpatient_nic.Text.Trim();
            TreatDBO sdbo = new TreatDBO();
            sdbo.deletetreat(patient_nic);

            MessageBox.Show("Treatment details delete succesfully!!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 Form18 = new Form18();
            Form18.Show();
            this.Hide();
        }
        }
    }

