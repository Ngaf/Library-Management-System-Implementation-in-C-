using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from AddBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    txtBName.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();



        }
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEnroll.Text != "")
            {
                string eid = txtEnroll.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll='" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //..............................
                //Number Of Books Issued To An Enrollment No:
                cmd.CommandText = "select count(std_enroll) from IBook where std_enroll='" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());



                //...........................


                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();  
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Error!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (txtBName.SelectedIndex != -1 && count <= 1)
                {
                    String enroll = txtEnroll.Text;
                    string sname = txtName.Text;
                    string sdep = txtDepartment.Text;
                    string sem = txtSemester.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    string email = txtEmail.Text;
                    string bookname = txtBName.Text;
                    string bookIssueDate = txtDate.Text;

                    string eid = txtEnroll.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "insert into IBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);


                    MessageBox.Show("Successful", "Book Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Book OR Issued Limit Exceeded", "No Selected Book", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Invalid Enrollment No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnroll.Text == "")
            {
                txtName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtEmail.Clear();
                txtContact.Clear();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}






