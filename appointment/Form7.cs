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

namespace appointment
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            CrystalReport cr = new CrystalReport();
            TextObject text = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text1"];
            text.Text = textBox1.Text;
            f6.crystalReportViewer1.ReportSource = cr;
            f6.Show();
        }
    }
}
