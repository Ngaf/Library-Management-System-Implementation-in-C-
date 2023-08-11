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

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsp = new Dashboard();
                dsp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error!);
            }
        }

        private void textPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        /*private void btnLogin_Click(object sender, MouseEventArgs e)
{
SqlConnection con = new SqlConnection();
con.ConnectionString = "data source = DESKTOP-TQGPNNS\\SQLEXPRESS; database=LMS; integrated security=True";
SqlCommand cmd = new SqlCommand();
cmd.Connection = con;
cmd.CommandText = "select * from loginTable where username = '"+txtUsername.Text+"' and pass = '" +txtPassword.Text+"'";
SqlDataAdapter da = new SqlDataAdapter(cmd);
DataSet ds = new DataSet();
da.Fill(ds);

if (ds.Tables[0].Rows.Count !=0)
{
this.Hide();
Dashboard dsp = new Dashboard();
dsp.Show();
}
else
{
MessageBox.Show("Wrong Username Or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error!);
}
*/
    }
}
