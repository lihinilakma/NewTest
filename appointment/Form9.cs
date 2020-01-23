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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport6 cr = new CrystalReport6();
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();


            string nic = textBox1.Text;

            conn.Open();
            string sql = "select * from reg_newone where nic='" + nic + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "reg_newone");
            DataTable dt = ds.Tables["reg_newone"];

            cr.SetDataSource(ds.Tables["reg_newone"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
 
        }
    }
}
