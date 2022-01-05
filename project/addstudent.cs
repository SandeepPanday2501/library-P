using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class add_student : Form
    {
        public add_student()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" This will delete your unsaved data.", "Are You Sure You Wanna Close?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStName.Text != ""&&txtEn.Text !="" && txtDep.Text != "" && txtSem.Text != "" && txtsStCon.Text != "" && txtEmail.Text != "")
            {


                String sname = txtStName.Text;
                String en = txtEn.Text;
                String sdeprt = txtDep.Text;
                String ssem = txtSem.Text;
                String sscon = txtsStCon.Text;
                String semail= txtEmail.Text;
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =SHIROYASHA-2501\\SQLEXPRESS; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into std_tbl (StudentName,EnrollmentNo,Department,Semester,StudentContact,EmailAddress)values('" + sname + "','"+en+"','" + sdeprt + "','" + ssem + "','" + sscon + "','" + semail + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data is Saved Sucessfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStName.Clear();
                txtEn.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtsStCon.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show("Empty Text!! Please Fill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsStCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
