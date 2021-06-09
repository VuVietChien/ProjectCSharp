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
        //
        public bool checkMail()
        {
            //liệt kê các trường hợp sai
            //ko chứa @ là false
            if (!textBox4.Text.Contains("@"))
            {
                return false;
            }
            //
            if (!textBox4.Text.Contains(".com"))
            {
                return false;
            }
            int i = textBox4.Text.IndexOf("@");
            int i1 = textBox4.Text.IndexOf(".com");
            String s = textBox4.Text.Substring(i + 1, i1 - i - 1);
            if (s != "gmail")
                return false;
            return true;
        }
        //
        public bool check()
        {
            //kiểm tra  thông tin nhập đủ hay chưa
            if (textBox2.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP TÊN TÀI KHOẢN!!");
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP MẬT KHẨU!!");
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP EMAIL!!");
                textBox4.Focus();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            //truy cập kết nối
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=ProjectCSharp;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from login where username='" + textBox2.Text + "'", con);
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
                if (check() == true && checkMail() == true)
                {
                    //
                    String str = "insert into login(username,password,email) ";
                    str += "values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
                    SqlCommand cm = new SqlCommand(str, con);
                    try
                    {
                        cm.ExecuteNonQuery();
                        MessageBox.Show("ĐĂNG KÍ THÀNH CÔNG!!");
                        DangNhap d = new DangNhap();
                        d.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LỖI!!");
                    }
                    con.Close();
                }
         
                else if (check() == false)
                {
                    MessageBox.Show("NHẬP SAI ĐỊNH DẠNG MẬT KHẨU!!");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                else if (checkMail() == false)
                {
                    MessageBox.Show("NHẬP SAI ĐỊNH DẠNG EMAIL!!");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else
                {
                    MessageBox.Show("ĐĂNG KÍ THẤT BẠI!!");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text="";
                    textBox2.Focus();
                }
            }
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
    }
}
