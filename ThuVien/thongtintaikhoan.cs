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
using System.Configuration;

namespace ThuVien
{
    public partial class thongtintaikhoan : Form
    {
        public thongtintaikhoan()
        {
            InitializeComponent();
        }


        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL


        protected void thongtintaikhoan_Load(object sender, EventArgs e)
        {

            con.Open();
            string sql = "select username, password , email from login where username = '"+DangNhap.geta()+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            textBox2.Text= dr["username"].ToString();
            textBox1.Text = dr["password"].ToString();
            textBox3.Text = dr["email"].ToString();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaMatKhau a = new SuaMatKhau();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap a = new DangNhap();
            a.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            this.Hide();
            a.Show();
        }
    }
}
    
