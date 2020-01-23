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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            CrystalReport8 cr = new CrystalReport8();
            SqlConnection conn = new SqlConnection();
            conn = DBConnection.getConnection();

            conn.Open();
            string sql = "select * from doctor_new order by experience desc";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "doctor_new");
            DataTable dt = ds.Tables["doctor_new"];

            cr.SetDataSource(ds.Tables["doctor_new"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();

 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form20 Form20 = new Form20();
            Form20.Show();
            this.Hide();
        }
    }
}
