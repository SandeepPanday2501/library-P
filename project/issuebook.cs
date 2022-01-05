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
    public partial class issuebook : Form
    {
        public issuebook()
        {
            InitializeComponent();
        }

        private void issuebook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=SHIROYASHA-2501\\SQLEXPRESS; database= library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select BookName  from book_tbl", con);
            SqlDataReader Sdr = cmd.ExecuteReader();


            while(Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                    comboBoxBooks.Items.Add(Sdr.GetString(i));

            }
            Sdr.Close();
            con.Close();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtName.Text  !="")
            {
                if (comboBoxBooks.SelectedIndex !=-1 && count  <=2)
                {
                    String enroll = txtEn.Text;
                    String sname = txtName.Text;
                    String sdep = txtDep.Text;
                    String sem = txtSem.Text;
                    Int64 contact = Int64.Parse(txtSCon.Text);
                    string email = txtEAdd.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookissuedate = dateTimePicker.Text;

                    String std = txtEn.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=SHIROYASHA-2501\\SQLEXPRESS; database= library; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = cmd.CommandText = "insert into issue_tbl(StudentEnrollmentNo,StudentName, Department, Semester, StudentContact, EmailAddress, BookName, BookIssueDate) values('" + enroll + "', '" + sname + "', '" + sdep + "', '" + sem + "', " + contact + ",'"+email+"', '" + bookname + "', '" + bookissuedate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select Book. Or Book Limit Reached.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
               
            }
            else
            {
                MessageBox.Show("Enter Vaild Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEn.Text !="")
                {
                String std = txtEn.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=SHIROYASHA-2501\\SQLEXPRESS; database= library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText= "select * from std_tbl where EnrollmentNo ='"+std+"'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                //---------------------
                //Code for count

                cmd.CommandText = "select count(StudentEnrollmentNo) from issue_tbl where StudentEnrollmentNo ='" + std + "'and BookReturnDate is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());


                //-------------------



                if (DS.Tables[0].Rows.Count !=0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtSCon.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEAdd.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtSCon.Clear();
                    txtEAdd.Clear();

                    MessageBox.Show("Invalid No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void txtEn_TextChanged(object sender, EventArgs e)
        {
            if(txtEn.Text =="")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtSCon.Clear();
                txtEAdd.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEn.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?"," Conformation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            this.Close();
        }
    }
}
