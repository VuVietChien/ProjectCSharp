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
        //
        public bool checkPass()
        {
            bool checkLength = false;
            if (textBox3.TextLength >= 6)
            {
                checkLength = true;
            }
            //kiểm tra chữ và số a-z:97; A-Z:65
            bool checkWord = false;
            bool checkNumber = false;
            for (int i = 0; i < textBox3.TextLength; i++)
            {
                if (checkNumber == true && checkWord == true)
                {
                    break;
                }
                if ((textBox3.Text[i] >= 'A' && textBox3.Text[i] <= 'Z') || (textBox3.Text[i] >= 'a' && textBox3.Text[i] <= 'z'))
                {
                    checkWord = true;
                }
                if (textBox3.Text[i] >= '0' && textBox3.Text[i] <= '9')
                {
                    {
                        checkNumber = true;
                    }
                }

            }
            if (checkNumber == true && checkWord == true && checkLength == true)
            {
                return true;
            }
            return false;
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP TÊN TÀI KHOẢN!!");
                textBox1.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP MẬT KHẨU!!");
                textBox3.Focus();
            }
            //
            if (checkPass() == false)
            {
                MessageBox.Show("BẠN NHẬP SAI ĐỊNH DẠNG MẬT KHẨU!!");
            }

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Data Source=NOBINOBI\\SQLEXPRESS;Initial Catalog=ProjectCSharp;Integrated Security=True";

            sql.Open();
            string newc = "select * from login where username='" + textBox1.Text + "' and password='" + textBox3.Text + "'";
            /*  SqlDataAdapter adp = new SqlDataAdapter(newc, sql);
              *//*DataSet ds = new DataSet();
              adp.Fill(ds);//Thêm hoặc làm mới các hàng trong Tập dữ liệu để khớp với các hàng trong nguồn dữ liệu.
              DataTable dt = ds.Tables[0];*/
            SqlCommand sq = new SqlCommand(newc, sql);
            SqlDataReader da = sq.ExecuteReader();//lấy dữ liệu
            if (da.Read() == true)//
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG!!");
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP THẤT BẠI!!");
                textBox1.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
            }
            sql.Close();

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
