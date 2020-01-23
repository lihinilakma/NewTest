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
    public partial class Form11 : Form
    {

        private string appointment;


        //public Form11()
        //{

        //}


        public Form11(string appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

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

