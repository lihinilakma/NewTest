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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * from treatments WHERE patients_nic like  " + (txtnic.Text), conn);
            SDA.Fill(dt);
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
