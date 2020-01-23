using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace appointment
{
    public partial class Form10 : Form
    {

        private string appointment;


        //public Form10()
        //{
            
        //}


        public Form10(string appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport5 cr = new CrystalReport5();
            cr.SetParameterValue("total", appointment);
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();


            string nic = textBox1.Text;

            conn.Open();
            string sql = "select * from treat3 where nic='" + nic + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "treat3");
            DataTable dt = ds.Tables["treat3"];

            cr.SetDataSource(ds.Tables["treat3"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

         
    }
}
