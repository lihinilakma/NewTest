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

using System.Data.SqlClient;

namespace appointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerDBO adbo = new ManagerDBO();

            string empid = txtempid.Text.Trim();
            
            string fname = txtfname.Text.Trim();
            string lname = txtlname.Text.Trim();
            string addressl1 = txtaddressl1.Text.Trim();
            string street = txtstreet.Text.Trim();
            string city = txtcity.Text.Trim();
            string gender = comboBox1.Text.Trim();

            string dob = dateTimePicker1.Text.Trim();


            Manager manager = new Manager(empid,  fname, lname, addressl1, street, city, gender, dob);
            ArrayList list = new ArrayList();
            list.Add(txthome.Text.Trim());
            list.Add(txtmobile.Text.Trim());

            adbo.registerManager(manager,list);
            MessageBox.Show("manager registration succesfully!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string empid = txtempid.Text.Trim();
            ManagerDBO sdbo = new ManagerDBO();
            sdbo.deletemanager(empid);

            MessageBox.Show("Manager delete succesfully!!!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form23 Form23 = new Form23();
            Form23.Show();
            this.Hide();
        }
    }
}
