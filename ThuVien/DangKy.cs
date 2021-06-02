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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-NFOKR1O\\SQLEXPRESS;Initial Catalog=ProjectCSharp;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from login where username='" + textBox2.Text + "' and password='" + textBox3.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            int i = ds1.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("TÀI KHOẢN NÀY ĐÃ TỒN TẠI!!");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox2.Focus();
            }
            else
            {
                String str = "insert into login(username,password,email) ";
                str += "values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
                SqlCommand cm = new SqlCommand(str, con);
                //co.Open();
                //mo ket noi csdl   
                cm.ExecuteNonQuery();
                MessageBox.Show("ĐĂNG KÍ THÀNH CÔNG!!");
                DangNhap d = new DangNhap();
                d.Show();
                this.Hide();
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap d = new DangNhap();
            d.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //checked
            if (textBox3.PasswordChar == '*')
            {
                button3.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                button4.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
