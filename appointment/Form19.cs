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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport9 cr = new CrystalReport9();
             
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();


            string nic = textBox1.Text;

            conn.Open();
            string sql = "select * from View_6 where nic='" + nic + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "View_6");
            DataTable dt = ds.Tables["View_6"];

            cr.SetDataSource(ds.Tables["View_6"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
  
        }
    }
}
