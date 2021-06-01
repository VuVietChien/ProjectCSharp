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
            hienthiGridviewsach();
            setbackground();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            titlelbl.Visible = true;
        }

        public void setbackground()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }
        public void hienthiGridviewsach()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select masach,tensach , tentacgia , tentheloai ,tennxb from sach";
            sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
            sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
            sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb order by tensach desc";
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaSach";
            column.HeaderText = " Mã Sách";
            dataGridView1.Columns.Add(column);
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "TenSach";
            column1.HeaderText = " Tên Sách";
            dataGridView1.Columns.Add(column1);
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "TenTacGia";
            column2.HeaderText = " Ten Tac Gia";
            dataGridView1.Columns.Add(column2);
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "TenTheLoai";
            column3.HeaderText = " Tên Thể Loại";
            dataGridView1.Columns.Add(column3);
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "TenNXB";
            column4.HeaderText = " Tên NXB";
            dataGridView1.Columns.Add(column4);

            dataGridView1.DataSource = dt;

            //căn chỉnh cho bảng vừa bằng cái khung datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }


        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true; // mở groupbox 2
            titlelbl.Visible = false;
            groupBox1.Visible = !groupBox2.Visible; // đóng groupbox1
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
            groupBox2.Visible = !groupBox1.Visible; // đóng groupbox 2

        }

        private void Main_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if(theotensach.Checked)
            {
                con.Open();
                SqlDataAdapter adapt;
                DataTable dt;
                string sql = "select masach,tensach , tentacgia , tentheloai ,tennxb from sach";
                sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
                sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
                sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb where TenSach like N'%" + timkiemtextbox.Text + "%'";
                
                adapt = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = null;
                hienthiGridviewsach();
                dataGridView1.DataSource = dt;

                con.Close();
            }
            if (theonhaxuatban.Checked)
            {
                con.Open();
                SqlDataAdapter adapt;
                DataTable dt;
                string sql = "select masach,tensach , tentacgia , tentheloai ,tennxb from sach";
                sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
                sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
                sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb where TenNXB like N'%" + timkiemtextbox.Text + "%'";

                adapt = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = null;
                hienthiGridviewsach();
                dataGridView1.DataSource = dt;

                con.Close();
            }
            if (theotacgia.Checked)
            {
                con.Open();
                SqlDataAdapter adapt;
                DataTable dt;
                string sql = "select masach,tensach , tentacgia , tentheloai ,tennxb from sach";
                sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
                sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
                sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb where TenTacGia like N'%" + timkiemtextbox.Text + "%'";

                adapt = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = null;
                hienthiGridviewsach();
                dataGridView1.DataSource = dt;

                con.Close();
            }
            if (theotheloai.Checked)
            {
                con.Open();
                SqlDataAdapter adapt;
                DataTable dt;
                string sql = "select masach,tensach , tentacgia , tentheloai ,tennxb from sach";
                sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
                sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
                sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb where TenTheLoai like N'%" + timkiemtextbox.Text + "%'";

                adapt = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = null;
                hienthiGridviewsach();
                dataGridView1.DataSource = dt;

                con.Close();
            }

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
    }
}
