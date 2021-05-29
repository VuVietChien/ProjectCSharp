using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThuVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection();
            //sql.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectCSharp;Integrated Security=True";
            sql.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectCSharp;Integrated Security=True";
            sql.Open();
            string newc = "select username from login where username='" + textBox1.Text + "' and password='" + textBox3.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(newc, sql);
            DataSet ds = new DataSet();
            adp.Fill(ds);//Thêm hoặc làm mới các hàng trong Tập dữ liệu để khớp với các hàng trong nguồn dữ liệu.
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count >= 1)
            {
                // String set = textBox1.Text;
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("DANG NHAP THAT BAI!!");
                textBox1.Text = "";
                textBox3.Text = "";
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy r = new DangKy();
            r.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fo = new ForgetPassword();
            this.Dispose(false);
            fo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox3.PasswordChar == '\0')
            {
                button4.BringToFront();
                textBox3.PasswordChar = '*';////hiển thị *
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                button3.BringToFront();//đưa nút khác về phía trước
                textBox3.PasswordChar = '\0';//hiển thị kí tự
            }
        }
    }
}
