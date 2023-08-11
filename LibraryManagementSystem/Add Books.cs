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
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtBookPub.Text != "" && txtBookPrice.Text != "" && txtBookQuan.Text != "")

            {
                string bname = txtBookName.Text;
                string bauthor = txtAuthor.Text;
                string publication = txtBookPub.Text;
                string pubdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quan = Int64.Parse(txtBookQuan.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-TQGPNNS\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into AddBook(bName,bAuthor,bPub, bPDate,bPrice,bQuan) values('" + bname + "','" + bauthor + "', '" + publication + "','" + pubdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved", "Succeess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtBookPub.Clear();
                txtBookPrice.Clear();
                txtBookQuan.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Not Saved", "Cancel?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

