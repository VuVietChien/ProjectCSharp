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
    public partial class NhaXuatBan : Form
    {
        static String connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        SqlConnection con = new SqlConnection(connection);
        public NhaXuatBan()
        {
            InitializeComponent();
            Hienthi();
        }
        public void Hienthi()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            String sql = "SELECT MaNXB, TenNXB, DiaChi, Email FROM NhaXuatBan";
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaNXB";
            column.HeaderText = "Mã Nhà Xuất Bản";
            dataGridView1.Columns.Add(column);
            //cột 2 với fields là maso
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "TenNXB";
            column2.HeaderText = "Tên Nhà Xuất Bản";
            dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "DiaChi";
            column3.HeaderText = "Địa Chỉ";
            dataGridView1.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "Email";
            column4.HeaderText = "Email";
            dataGridView1.Columns.Add(column4);
            dataGridView1.DataSource = dt;
            setbackground();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (maNXBTextBox.Text == "" || tenNXBTextBox.Text == ""|| diaChiTextBox.Text == "" || EmailTextBox.Text =="")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn thêm mới nhà xuất bản ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sqlthemdulieu = "INSERT INTO NhaXuatBan  (MaNXB,TenNXB,DiaChi,Email)";
                    sqlthemdulieu += "VALUES ('" + maNXBTextBox.Text + "'";
                    sqlthemdulieu += ", N'" + tenNXBTextBox.Text + "'";
                    sqlthemdulieu += ", N'" + diaChiTextBox.Text + "'";
                    sqlthemdulieu += ", N'" + EmailTextBox.Text + "'";
                    sqlthemdulieu += ");";
                    int sosanhdulieu = a.InsertDb(sqlthemdulieu);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không thêm được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("Mã nhà xuất bản đã có, vui lòng nhập mã nhà xuất bản khác !");
                    }
                    else
                    {
                        MessageBox.Show("đã thêm thành công");
                        dataGridView1.DataSource = null;

                        Hienthi();
                    }
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (maNXBTextBox.Text == "" || tenNXBTextBox.Text == "" || diaChiTextBox.Text == "" || EmailTextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mục để sửa, vui lòng chọn ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn sửa nhà xuất bản ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata confidb = new configdata();
                    String sqlsua = "update NhaXuatBan set TenNXB=N'" + tenNXBTextBox.Text + "', DiaChi=N'" + diaChiTextBox.Text + "', Email=N'" + EmailTextBox.Text + "' where MaNXB='" + maNXBTextBox.Text + "'";
                    // confidb.InsertDb(sqlsua);
                    int suadulieu = confidb.InsertDb(sqlsua);

                    if (suadulieu == 0)
                    {
                        MessageBox.Show("không sửa được mã nhà xuất bản!");
                    }
                    else if (suadulieu == -1)
                    {
                        MessageBox.Show("lỗi dữu liệu");
                    }
                    else
                    {
                        MessageBox.Show("Đã sửa dữu liệu");
                        dataGridView1.DataSource = null;
                        Hienthi();
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (maNXBTextBox.Text == "" || tenNXBTextBox.Text == "" || diaChiTextBox.Text == "" || EmailTextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mục để xóa, vui lòng chọn ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa thể loại sách ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "delete NhaXuatBan where MaNXB='" + maNXBTextBox.Text + "'";

                    int sosanhdulieu = a.InsertDb(sql);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không xóa được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("Lỗi không kết nối giữ liệu");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công");
                        dataGridView1.DataSource = null;
                        Hienthi();
                    }
                }
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            maNXBTextBox.Text = "";
            tenNXBTextBox.Text = "";
            diaChiTextBox.Text = "";
            EmailTextBox.Text = "";
        }

        private void timkiemtextBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            string sql = "select MaNXB,TenNXB,DiaChi,Email from NhaXuatBan where TenNXB like N'%" + timkiemtextBox.Text + "%'";
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            maNXBTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tenNXBTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            diaChiTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EmailTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        public void setbackground()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial ", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        private void btnexxcel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xuất thông tin ra Excel ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                worksheet.Cells[1, 2] = "Bảng thống kê Nhà Xuất Bản";
                worksheet.Cells[3, 1] = "STT";
                worksheet.Cells[3, 2] = "Mã Nhà Xuất Bản";
                worksheet.Cells[3, 3] = "Tên Nhà Xuất Bản";
                worksheet.Cells[3, 4] = "Địa Chỉ";
                worksheet.Cells[3, 5] = "Email";

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        worksheet.Cells[i + 4, 1] = i + 1;
                        worksheet.Cells[i + 4, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
            }
        }

        private void NhaXuatBan_Load(object sender, EventArgs e)
        {

        }
    }
}
