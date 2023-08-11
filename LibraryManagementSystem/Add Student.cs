using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void Add_Student_Load_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDepartment.Clear();
            txtID.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            //txtEmail.Clear();
            txtEmail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtID.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {

                string sName = txtName.Text;
                string enroll = txtID.Text;
                string dep = txtDepartment.Text;
                string sem = txtSemester.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into NewStudent(sName,enroll,dep,sem,contact,email) values ('" + sName + "','" + enroll + "','" + dep + "','" + sem + "'," + contact + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved!", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(" Please Fill!", "Empty Field Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm?", "Alert!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

                this.Close();
        }
    }
}
