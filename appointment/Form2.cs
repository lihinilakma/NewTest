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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrontDBO adbo = new FrontDBO();

            string empid = txtempid.Text.Trim();

            string fname = txtfname.Text.Trim();
            string lname = txtlname.Text.Trim();
            string addressl1 = txtaddressl1.Text.Trim();
            string street = txtstreet.Text.Trim();
            string city = txtcity.Text.Trim();
            string gender = comboBox1.Text.Trim();

            DateTime dob = dateTimePicker1.Value;


            Front front = new Front(empid, fname, lname, addressl1, street, city, gender, dob);

            ArrayList list = new ArrayList();
            list.Add(txthome.Text.Trim());
            list.Add(txtmobile.Text.Trim());

            adbo.registerFront(front,list);
            MessageBox.Show("Front office clerk registration succesfully!!!");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string empid = txtempid.Text.Trim();
            FrontDBO sdbo = new FrontDBO();
            sdbo.deleteclerk(empid);

            MessageBox.Show("Front Office Clerk delete succesfully!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form23 Form23 = new Form23();
            Form23.Show();
            this.Hide();
        }
    }
}
