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
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }

        private void returnbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEn.Clear();
        }
        string bname;
        string bdate;
        Int64 rowid;

        private void btnSt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=SHIROYASHA-2501\\SQLEXPRESS; database= library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from issue_tbl where StudentEnrollmentNo = '" + txtEn.Text + "' and BookReturnDate IS NUll";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value  !=null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookN.Text = bname;
            txtBookIssue.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=SHIROYASHA-2501\\SQLEXPRESS; database= library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update issue_tbl set BookReturnDate ='"+dateTimePicker1.Text+"' where StudentEnrollmentNo = '"+txtEn.Text+"'and StudentId = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Sucessful.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            returnbook_Load(this, null);

            
        }

        private void txtEn_TextChanged(object sender, EventArgs e)
        {
            if (txtEn.Text == "")
                panel2.Visible = false;
            dataGridView1.DataSource = null;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEn.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", " Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }
    }
}
