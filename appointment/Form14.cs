using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appointment
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersDBO sdbo = new UsersDBO();
            string username = textBox1.Text.Trim();
            string password = textBox3.Text.Trim();
            string category = comboBox1.Text.Trim();


            Users users = new Users(username, password, category);
            sdbo.addUser(users);
            MessageBox.Show("Create account succesfully!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form23 Form23 = new Form23();
            Form23.Show();
            this.Hide();
        }
    }
}
