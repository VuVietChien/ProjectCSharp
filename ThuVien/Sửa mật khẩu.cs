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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VJNST16\\VVLONG;Initial Catalog=ProjectCSharp;Integrated Security=True";
            con.Open();
            //
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
            con.ConnectionString = "Data Source=DESKTOP-VJNST16\\VVLONG;Initial Catalog=ProjectCSharp;Integrated Security=True";
            con.Open();
            String sql = "select *from login where password='" + textBox2.Text + "'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
