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
            SqlConnection co = new SqlConnection("Data Source=DESKTOP-VJNST16\\VVLONG;Initial Catalog=ProjectCSharp;Integrated Security=True");
            co.Open();
            String con = "insert into  login(username,password,email) ";
            con += "values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
            /*  con += "values( ";
              con+="N'" + textBox1.Text + "'";
              con += ",N'" + textBox2.Text + "'";
              con += "'" + textBox3.Text + "'";
              con += "'" + textBox4.Text + "'";
              con += ");";*/
            SqlCommand cm = new SqlCommand(con, co);
            //co.Open();
            //mo ket noi csdl
            try
            {
                cm.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                co.Close();
            }
            DangNhap d = new DangNhap();
            d.Show();
            this.Hide();
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
