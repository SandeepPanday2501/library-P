using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbook abs = new addbook();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();
            vb.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebook ib = new issuebook();
            ib.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_student ads = new add_student();
            ads.Show();
        }

        private void viewStudentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent vs = new viewstudent();
            vs.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook rb = new returnbook();
            rb.Show();
        }

        private void allBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completebook cb  = new completebook();
            cb.Show();

        }
    }

    }
    

