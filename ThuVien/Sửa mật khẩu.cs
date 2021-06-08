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

    public partial class SuaMatKhau : Form
    {
        public SuaMatKhau()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //

        //

        public bool checkPass1()
        {
            //kiểm tra  thông tin nhập đủ hay chưa
            if (textBox3.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP MẬT KHẨU MỚI!!");
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP XÁC NHẬN MẬT KHẨU!!");
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //
        public bool checkPass()
        {
            bool checkLength = false;
            if (textBox2.TextLength >= 6)
            {
                checkLength = true;
            }
            //kiểm tra chữ và số a-z:97; A-Z:65
            bool checkWord = false;
            bool checkNumber = false;
            for (int i = 0; i < textBox2.TextLength; i++)
            {
                if (checkNumber == true && checkWord == true)
                {
                    break;
                }
                if ((textBox2.Text[i] >= 'A' && textBox2.Text[i] <= 'Z') || (textBox2.Text[i] >= 'a' && textBox2.Text[i] <= 'z'))
                {
                    checkWord = true;
                }
                if (textBox2.Text[i] >= '0' && textBox2.Text[i] <= '9')
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectCSharp;Integrated Security=True";
            con.Open();
            //
            if (checkPass1() == true)
            {
                if (textBox3.Text == textBox4.Text)
                {
                    String ab = "update login set password='" + textBox4.Text + "' where username='" + textBox1.Text + "'";
                    SqlCommand ca = new SqlCommand(ab, con);
                    ca.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("SỬA THÀNH CÔNG!!");
                    Main m = new Main();
                    m.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("SỬA THẤT BẠI!!");
                textBox1.Text = "";
                this.Focus();
            }

        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi hệ thống", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectCSharp;Integrated Security=True";
            con.Open();
            String sql = "select *from login where password='" + textBox2.Text + "'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("BẠN CHƯA NHẬP MẬT KHẨU!!");
                    textBox2.Focus();
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("BẠN CHƯA NHẬP TÊN TÀI KHOẢN!!");
                    textBox1.Focus();
                }
                //
                if (checkPass() == false)
                {
                    MessageBox.Show("BẠN NHẬP SAI ĐỊNH DẠNG MẬT KHẨU!!");
                }

                MessageBox.Show("NHẬP ĐÚNG!!");
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("SAI PASSWORD OR USER NAME!!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            dr.Close();
            con.Close();
        }
    }
}
