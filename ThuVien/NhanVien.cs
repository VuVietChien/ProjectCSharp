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
    public partial class NhanVien : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL
        public NhanVien()
        {
            InitializeComponent();
            HienThiGridView();
        }

        public void HienThiGridView()
        {
            //Load du lieu tu csdl
            DataTable dt = new DataTable();
            configdata configdb = new configdata();
            //String sql = "SELECT MaNhanVien, HoTen, NgaySinh, GioiTinh, SDT FROM NhanVien";
            String sql = " SELECT MaNhanVien, HoTen, SDT,";
            sql += " CONVERT(varchar , NgaySinh, 103) as NgaySinh,";
            sql += " CASE When GioiTinh = 'False' Then N'Nữ'";
            sql += " When GioiTinh = 'True' Then 'Nam'";
            sql += " END as GioiTinh";
            sql += " FROM NhanVien";
            //Hứng dl trả về
            dt = configdb.selectDb(sql);


            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaNhanVien";
            column.HeaderText = "Mã nhân viên";
            gridviewNhanVien.Columns.Add(column);
            //
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "HoTen";
            column1.HeaderText = "Họ tên";
            gridviewNhanVien.Columns.Add(column1);
            //
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "SDT";
            column4.HeaderText = "Số điện thoại";
            gridviewNhanVien.Columns.Add(column4);
            //
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "NgaySinh";
            column2.HeaderText = "Ngày sinh";
            gridviewNhanVien.Columns.Add(column2);
            //
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "GioiTinh";
            column3.HeaderText = "Giới tính";
            gridviewNhanVien.Columns.Add(column3);
            //

            gridviewNhanVien.DataSource = dt;

            //
            gridviewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridviewNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            configdata configdb = new configdata();

            String sqlThemDuLieu = "INSERT INTO NhanVien(MaNhanVien, HoTen, NgaySinh, GioiTinh, SDT) ";
            sqlThemDuLieu += "VALUES ('" + txtMaNhanVien.Text + "'";
            sqlThemDuLieu += ",N' " + txtHoTen.Text + "'";
            sqlThemDuLieu += ", CONVERT(datetime, '" + ngaySinh.Text + "' , 103)";
            sqlThemDuLieu += ",'" + gioiTinh.Checked + "'";
            sqlThemDuLieu += ",'" + txtDienThoai.Text + "'";
            sqlThemDuLieu += "); ";

            int soSanhDuLieu = configdb.InsertDb(sqlThemDuLieu);

            if (soSanhDuLieu == 0)
            {
                MessageBox.Show("Không thêm được dữ liệu");

            }
            else if (soSanhDuLieu == -1)
            {
                MessageBox.Show("Lỗi dữ liệu");

            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                gridviewNhanVien.DataSource = null;
                HienThiGridView();
            }
            //Hiển thị dữ liệu
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            configdata configdb = new configdata();
            string sql = "update NhanVien set HoTen = N'" + txtHoTen.Text + "',SDT = '" + txtDienThoai.Text + "', NgaySInh =  CONVERT(datetime, '" + ngaySinh.Text + "' , 103), GioiTinh = '" + gioiTinh.Checked + "'  where MaNhanVien = '" + txtMaNhanVien.Text + "' ";

            int sosanhdulieu = configdb.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không sửa được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("Lỗi dữ liệu");
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu thành công");
                gridviewNhanVien.DataSource = null;
                HienThiGridView();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            configdata configdb = new configdata();
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = '" + txtMaNhanVien.Text + "'";

            int sosanhdulieu = configdb.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không xóa được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("Lỗi dữ liệu");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thành công");

                txtMaNhanVien.Text = null;
                txtHoTen.Text = null;
                txtDienThoai.Text = null;
                ngaySinh.Text = null;
                gioiTinh.Checked = false;
                gridviewNhanVien.DataSource = null;
                HienThiGridView();
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = null;
            txtHoTen.Text = null;
            txtDienThoai.Text = null;
            ngaySinh.Text = null;
            gioiTinh.Checked = false;
            gridviewNhanVien.Refresh();
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            string sql = "select MaNhanVien, HoTen, SDT, NgaySinh, CASE When GioiTinh = 'False' Then N'Nữ' When GioiTinh = 'True' Then 'Nam' END as GioiTinh from NhanVien where MaNhanVien like N'%" + txtTimKiemNhanVien.Text + "%' or MaNhanVien like '%" + txtTimKiemNhanVien.Text + "%' or HoTen like '%" + txtTimKiemNhanVien.Text + "%'";
            adapt = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adapt.Fill(dt);
            gridviewNhanVien.DataSource = dt;
            con.Close();
        }

        private void gridviewNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNhanVien.Text = gridviewNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = gridviewNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtDienThoai.Text = gridviewNhanVien.CurrentRow.Cells[2].Value.ToString();
            //

            int nam = Int32.Parse(gridviewNhanVien.CurrentRow.Cells[3].Value.ToString().Split('/')[2]);
            int thang = Int32.Parse(gridviewNhanVien.CurrentRow.Cells[3].Value.ToString().Split('/')[1]);
            int ngay = Int32.Parse(gridviewNhanVien.CurrentRow.Cells[3].Value.ToString().Split('/')[0]);

            ngaySinh.Value = new DateTime(nam, thang, ngay);
            //ngaySinh.Text = gridviewNhanVien.CurrentRow.Cells[2].Value.ToString();


            //gioiTinh.Text = gridviewNhanVien.CurrentRow.Cells[4].Value.ToString();
            String a = gridviewNhanVien.CurrentRow.Cells[4].Value.ToString();
            if (a.Equals("Nam"))
            {
                gioiTinh.Checked = true;
            }
            else
            {
                gioiTinh.Checked = false;
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();
        }
    }
}
