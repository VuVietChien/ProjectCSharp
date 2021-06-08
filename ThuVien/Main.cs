
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
    
    public partial class Main : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL
        public Main()
        {
            InitializeComponent();

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            titlelbl.Visible = true;
        }


        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            titlelbl.Visible = false;

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi hệ thống ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap a = new DangNhap();
                a.Show();
            }
        }



        private void chứcNăngQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            titlelbl.Visible = false;


        }

        private void Main_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sach a = new Sach();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TacGia a = new TacGia();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuonTra a = new MuonTra();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheLoai a = new TheLoai();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien a = new NhanVien();
            a.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocGia a = new DocGia();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheThuVien a = new TheThuVien();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaXuatBan a = new NhaXuatBan();
            a.Show();

        }

  
        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi hệ thống ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaMatKhau sk = new SuaMatKhau();
            sk.Show();
            this.Hide();
        }

       
    }
}

