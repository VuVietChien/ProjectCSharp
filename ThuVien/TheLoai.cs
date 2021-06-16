using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class TheLoai : Form
    {
        static String connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        SqlConnection con = new SqlConnection(connection);
        public TheLoai()
        {
            InitializeComponent();
            Hienthi();
        }


        public void Hienthi()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            String sql = "SELECT MaTheLoai, TenTheLoai FROM TheLoai";
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaTheLoai";
            column.HeaderText = "Mã Thể Loại";
            dataGridView1.Columns.Add(column);
            //cột 2 với fields là maso
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "TenTheLoai";
            column2.HeaderText = "Tên Thể Loại";
            dataGridView1.Columns.Add(column2);
            dataGridView1.DataSource = dt;
            setbackground();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (maTheLoaitextBox.Text == "" || tenTheLoaitextBox.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn thêm mới thể loại ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sqlthemdulieu = "INSERT INTO TheLoai (MaTheLoai,TenTheLoai)";
                    sqlthemdulieu += "VALUES ('" + maTheLoaitextBox.Text + "'";
                    sqlthemdulieu += ", N'" + tenTheLoaitextBox.Text + "'";
                    sqlthemdulieu += ");";
                    int sosanhdulieu = a.InsertDb(sqlthemdulieu);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không thêm được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("lỗi khi thêm dữ liệu, vui lòng kiểm tra lại các dữ liệu ( mã thể loại ) !");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        dataGridView1.DataSource = null;
                        Hienthi();
                    }
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (maTheLoaitextBox.Text == "" || tenTheLoaitextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mục để sửa, vui lòng chọn ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn sửa thể loại sách ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata confidb = new configdata();
                    String sqlsua = "update TheLoai set TenTheLoai=N'" + tenTheLoaitextBox.Text + "' where MaTheLoai='" + maTheLoaitextBox.Text + "'";
                    confidb.InsertDb(sqlsua);
                    int suadulieu = confidb.InsertDb(sqlsua);

                    if (suadulieu == 0)
                    {
                        MessageBox.Show("không sửa được mã thể loại!");
                    }
                    else if (suadulieu == -1)
                    {
                        MessageBox.Show("lỗi dữu liệu");
                    }
                    else
                    {
                        MessageBox.Show("Đã sửa thành công");
                        dataGridView1.DataSource = null;
                        Hienthi();
                    }
                } }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (maTheLoaitextBox.Text == "" || tenTheLoaitextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mục để xóa, vui lòng chọn ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa thể loại sách ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "delete TheLoai where MaTheLoai='" + maTheLoaitextBox.Text + "'";

                    int sosanhdulieu = a.InsertDb(sql);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không xóa được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("Bạn chưa chọn cái cần xóa, vui lòng chọn mục cần xóa?");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = null;
                        Hienthi();
                    }
                }
            }
        } 

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            maTheLoaitextBox.Text = "";
            tenTheLoaitextBox.Text = "";
        }

        private void TimkiemtextBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            string sql = "select MaTheLoai, TenTheLoai from TheLoai where TenTheLoai like N'%" + TimkiemtextBox.Text + "%'";
            adapt = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.ShowDialog();
        }

        public void setbackground()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial ", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            maTheLoaitextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tenTheLoaitextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
