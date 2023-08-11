using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class View_Student_Info : Form
    {
        public View_Student_Info()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnroll.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent where enroll Like '" + txtSearchEnroll.Text + "%'";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                dataGridView1.DataSource = Ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);

                dataGridView1.DataSource = Ds.Tables[0];

            }
        }

        private void View_Student_Info_Load(object sender, EventArgs e)
        {

        }

        private void View_Student_Info_Load_1(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            dataGridView1.DataSource = Ds.Tables[0];


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where stuid=" + bid + "";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            rowid = Int64.Parse(Ds.Tables[0].Rows[0][0].ToString());
            txtSName.Text = Ds.Tables[0].Rows[0][1].ToString();
            txtEnroll.Text = Ds.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = Ds.Tables[0].Rows[0][3].ToString();
            txtSem.Text = Ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = Ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = Ds.Tables[0].Rows[0][6].ToString();




        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            string sName = txtSName.Text;
            string enroll = txtEnroll.Text;
            string dep = txtDepartment.Text;
            string sem = txtSem.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;

            if (MessageBox.Show("Data Will Be Updated!", "Success!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewStudent set Sname='" + sName + "',enroll='" + enroll + "',dep='" + dep + "',sem='" + sem + "',contact='" + contact + "',email='" + email + "' where stuid=" + rowid + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);

                View_Student_Info_Load_1(this, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Student_Info_Load_1(this, null);
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted!", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewStudent where stuid= " + rowid + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);

                View_Student_Info_Load_1(this, null);
            }
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Data Not Save!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
