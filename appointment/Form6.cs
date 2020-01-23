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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            CrystalReport16 cr = new CrystalReport16();
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();

           // 9/1/2019
            string appointmentdate = dateTimePicker1.Text;



            conn.Open();
            string sql = "select * from View_11 where appoinment_date ='" + appointmentdate + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "View_11");
            DataTable dt = ds.Tables["View_11"];

            cr.SetDataSource(ds.Tables["View_11"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();

 

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form20 Form20 = new Form20();
            Form20.Show();
            this.Hide();
        }
    }
}
