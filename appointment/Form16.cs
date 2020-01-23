using System;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {
             

        }
        string docnic;
        string appoinment_date;

        private void button1_Click(object sender, EventArgs e)
        {

            string docnic = txtdoc_nic.Text.Trim();
            string appoinment_date = dateTimePicker1.Text;



            SqlConnection conn = DBConnection.getConnection();

            SqlDataAdapter adapt = new SqlDataAdapter("select * from patients where doctors_nic = '" + docnic + "' AND appoinment_date = '" + appoinment_date + "'", conn);
             
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form22 Form22 = new Form22();
            Form22.Show();
            this.Hide();
        }
    }
}
