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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtpass.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getConnection();

            string username = txtuname.Text.Trim();
            string password = txtpass.Text.Trim();
            string acctype = cmbacctype.Text;


            try
            {

                if (cmbacctype.SelectedItem == "Admin")
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        Form23 ap = new Form23();
                        ap.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password");

                    }
                }
                else if (cmbacctype.SelectedItem == "Manager")
                {

                    SqlCommand cmd = new SqlCommand("SELECT username, password FROM users WHERE username='" + username + "' AND password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        
                      Form20 mm = new Form20();
                        mm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password");

                    }

                }
                else if (cmbacctype.SelectedItem == "FrontOffice")
                {


                    SqlCommand cmd = new SqlCommand("SELECT username, password FROM users WHERE username='" + username + "' AND password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                       
                        Form18 cm = new Form18();
                        cm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password");

                    }
                }
                else if (cmbacctype.SelectedItem == "Doctor")
                {


                    SqlCommand cmd = new SqlCommand("SELECT username, password FROM users WHERE username='" + username + "' AND password='" + password + "'", conn);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        Form22 dm = new Form22();
                        dm.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password");

                    }
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    this.txtuname.Text = "";
                    this.txtpass.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }  
}

        
    }
}
  
          
