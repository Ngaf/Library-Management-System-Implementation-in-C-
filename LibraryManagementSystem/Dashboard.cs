using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
             Add_Books abs = new Add_Books();
            abs.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Book vb = new View_Book();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student ast = new Add_Student();
            ast.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Student_Info vsi = new View_Student_Info();
            vsi.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Book rd = new Return_Book();
            rd.Show();
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Books_Details bd= new Books_Details();
            bd.Show();
        }
    }
}
