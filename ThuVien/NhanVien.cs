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
            if (txtMaNhanVien.Text == "" || txtHoTen.Text == "" || txtDienThoai.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn thêm mới nhân viên ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    String sqlThemDuLieu = "INSERT INTO NhanVien(MaNhanVien, HoTen, NgaySinh, GioiTinh, SDT) ";
                    sqlThemDuLieu += "VALUES ('" + txtMaNhanVien.Text + "'";
                    sqlThemDuLieu += ",N' " + txtHoTen.Text + "'";
                    sqlThemDuLieu += ", CONVERT(datetime, '" + ngaySinh.Text + "' , 103)";
                    sqlThemDuLieu += ",'" + gioiTinh.Checked + "'";
                    sqlThemDuLieu += ",'" + txtDienThoai.Text + "'";
                    sqlThemDuLieu += "); ";
                    int sosanhdulieu = a.InsertDb(sqlThemDuLieu);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không thêm được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("Mã nhân viên đã có, vui lòng nhập mã khác !");
                    }
                    else
                    {
                        
                        MessageBox.Show("đã thêm dữ liệu thành công");
                        gridviewNhanVien.DataSource = null;
                        HienThiGridView();
                    }
                }

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtHoTen.Text == "" || txtDienThoai.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn sửa nhân viên ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "update NhanVien set HoTen = N'" + txtHoTen.Text + "',SDT = '" + txtDienThoai.Text + "', NgaySInh =  CONVERT(datetime, '" + ngaySinh.Text + "' , 103), GioiTinh = '" + gioiTinh.Checked + "'  where MaNhanVien = '" + txtMaNhanVien.Text + "' ";

                    int sosanhdulieu = a.InsertDb(sql);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không sửa được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("Lỗi không kết nối giữ liệu");
                    }
                    else
                    {
                        MessageBox.Show("Sửa dữ liệu thành công");
                        gridviewNhanVien.DataSource = null;
                        HienThiGridView();
                    }
                }

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                configdata a = new configdata();
                string sql = "DELETE FROM NhanVien WHERE MaNhanVien = '" + txtMaNhanVien.Text + "'";

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

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                /*
                //MessageBox.Show("you press enter then this focus to txtHoTen");
                String a = "";
                //MessageBox.Show(txtMaNhanVien.Text);


                a = txtMaNhanVien.Text;
                txtMaNhanVien.Text = a;
                */
                //txtHoTen.Focus();

                
            }
            
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == 13)
            {
                ngaySinh.Focus();
            }
            */
        }

        private void ngaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == 13)
            {
                txtDienThoai.Focus();
            }
            */
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)//& e.KeyChar != '.' & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '-')
            {
                e.Handled = true;
            }
            /*
            if (e.KeyChar == 13)
            {
                gioiTinh.Focus();
            }
            */
        }

        private void gioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btThem.PerformClick();
            }
        }

        private void loadfile_Click(object sender, EventArgs e)
        {
            {
                // mở file excel 
                //trước tiên phải thêm thư viện Microsoft.Office.Interop.Excel
                // khởi tạo excel
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                // khởi tạo wordbook
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                //khởi tạo worksheet và chạy excel
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;

                // đổ dữ liệu vào sheets

                worksheet.Cells[2, 1] = "Mã Nhân Viên";
                worksheet.Cells[2, 2] = "Họ Tên";
                worksheet.Cells[2, 3] = "Điện Thoại";
                worksheet.Cells[2, 4] = "Ngày Sinh";
                worksheet.Cells[2, 5] = "Giới Tính";

                for (int i = 0; i < gridviewNhanVien.RowCount - 1; i++)
                {
                    for (int j = 0; j < gridviewNhanVien.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 3, j + 1] = gridviewNhanVien.Rows[i].Cells[j].Value;
                    }
                }

            }
        }

        private void txtMaNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHoTen.Focus();
                
                e.SuppressKeyPress = true;
                e.Handled = true;
                
            }
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ngaySinh.Focus();
                // Hai dòng cuối ngăn tiếng bip
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ngaySinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDienThoai.Focus();
                // Hai dòng cuối ngăn tiếng bip
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gioiTinh.Focus();
                // Hai dòng cuối ngăn tiếng bip
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
