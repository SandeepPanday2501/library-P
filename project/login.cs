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

namespace project
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
    
        public login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=SHIROYASHA-2501\SQLEXPRESS;Initial Catalog=password;Integrated Security=True";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           con.Open();
        
            com.Connection = con;
            com.CommandText = "select * from pass";
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                if(txtUsername.Text.Equals(dr["username"].ToString())&& txtPassword.Text.Equals(dr["password"].ToString()))
                {
                   MessageBox.Show("Login Successful", "Ready To Go", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    dashboard dsa = new dashboard();
                    dsa.Show();
                    this.Hide();
                    
                }
                else
                MessageBox.Show("Either your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            
            }
        }
    }
}
