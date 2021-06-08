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


  
      

        protected void thongtintaikhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection("Data Source=localhost\\VVLONG;Initial Catalog=ProjectCSharp;Integrated Security=True"))
            {

                con1.Open();
                SqlDataReader m = null;
                SqlCommand myCommand = new SqlCommand("select * from login where username='" + textBox2.Text + "'", con1);
                DataTable dta = new DataTable();
                m = myCommand.ExecuteReader();
               // dta.Load(m);
                if (m.Read())
                {
                    //textBox2.Text = m["username"].ToString();
                    textBox1.Text = m["password"].ToString();

                    textBox3.Text = m["email"].ToString();

                }
                con1.Close();
            }//end using
        }
    }
}
    
