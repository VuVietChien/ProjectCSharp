using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace ThuVien
{
    public partial class Sach : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL
        public Sach()
        {
            InitializeComponent();
            loaddulieucomboboxtacgia();
            loaddulieucomboboxtheloai();
            loaddulieucomboboxnhaxuatban();
            hienthiGridviewsach();
            setbackground();
        }

    

        public void setbackground()
        {
            this.GridviewSach.DefaultCellStyle.Font = new Font("Arial", 12);
            this.GridviewSach.DefaultCellStyle.ForeColor = Color.Black;
            this.GridviewSach.DefaultCellStyle.BackColor = Color.Beige;
            this.GridviewSach.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.GridviewSach.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        public void hienthiGridviewsach()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select masach,tensach, soluong , tentacgia , tentheloai ,tennxb, namxuatban from sach";
            sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
            sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
            sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb order by tensach desc"; 
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về
            

            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaSach";
            column.HeaderText = " Mã Sách";
            GridviewSach.Columns.Add(column);

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "TenSach";
            column1.HeaderText = " Tên Sách";
            GridviewSach.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "soluong";
            column2.HeaderText = " Số Lượng";
            GridviewSach.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "tenTacGia";
            column3.HeaderText = " Tên Tác Giả";
            GridviewSach.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "tenTheLoai";
            column4.HeaderText = " Tên Thể Loại";
            GridviewSach.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "tenNXB";
            column5.HeaderText = " Tên NXB";
            GridviewSach.Columns.Add(column5);

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "NamXuatBan";
            column6.HeaderText = " Năm XB";
            GridviewSach.Columns.Add(column6);

            GridviewSach.DataSource = dt;
            //căn chỉnh cho bảng vừa bằng cái khung datagridview
            GridviewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridviewSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        public void loaddulieucomboboxtacgia()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaTacGia, TenTacGia from TacGia";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            matacgiacombobox.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            matacgiacombobox.DisplayMember = dt.Columns[1].ToString();
            matacgiacombobox.ValueMember = dt.Columns[0].ToString();
            
        }

        public void loaddulieucomboboxtheloai()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaTheLoai, TenTheLoai from TheLoai";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            theloaicombobox.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            theloaicombobox.DisplayMember = dt.Columns[1].ToString();
            theloaicombobox.ValueMember = dt.Columns[0].ToString();

            
        }

        public void loaddulieucomboboxnhaxuatban()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaNXB, TenNXB from NhaXuatban";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            nhaxuatbancombobox.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            nhaxuatbancombobox.DisplayMember = dt.Columns[1].ToString();
            nhaxuatbancombobox.ValueMember = dt.Columns[0].ToString();
        }
        private void sachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.sachBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.projectCSharpDataSet);

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            
            //string sql = "insert into Sach(MaSach,TenSach,MaTacGia, MaTheLoai,MaNXB,NamXuatBan)";
            //sql += " Values('" + maSachTextBox.Text + "' ,  N'" + tenSachTextBox.Text + " ', '" + maTacGiaTextBox.Text + "', '" +maTheLoaiTextBox.Text + "',N'" + maNXBTextBox.Text + "'," + namXuatBanTextBox.Text + ")";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //try
            //{
            //    // mở kết nối đến cơ sở dữ liệu
            //    con.Open();
            //    //chạy câu lệnh nhập ở trên
            //    cmd.ExecuteNonQuery();
            //}
            //catch
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}
            ////reload lại datagrid để có dữ liệu mới
            //this.sachTableAdapter.Fill(this.projectCSharpDataSet.Sach);

            

            if (masachtb.Text == "" || soluongtextbox.Text == "" || tensachtb.Text == "" || theloaicombobox.Text == "" || matacgiacombobox.Text == "" || nhaxuatbancombobox.Text == "" || Namxuatbantb.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn đăng thêm sách mới ", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "insert into Sach(MaSach,TenSach, soluong ,MaTacGia, MaTheLoai,MaNXB,NamXuatBan  )";
                    sql += " Values('" + masachtb.Text + "' ,  N'" + tensachtb.Text + " ', " + soluongtextbox.Text + ", '" + matacgiacombobox.SelectedValue + "', '" + theloaicombobox.SelectedValue + "',N'" + nhaxuatbancombobox.SelectedValue + "'," + Namxuatbantb.Text + ")";
                    int sosanhdulieu = a.InsertDb(sql);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không thêm được dữ liệu");
                    }
                    else
                        if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("mã mượn trả bị trùng, bạn vui lòng nhập mã sách khác");
                    }
                    else
                    {
                        MessageBox.Show("đã thêm sách vào thư viện thành công");
                        GridviewSach.DataSource = null;
                        hienthiGridviewsach();
                    }

                }
            }
            
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn xóa sách này khỏi hệ thống ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                configdata a = new configdata();
                string sql = "delete from Sach where MaSach = '" + masachtb.Text + "'";

                int sosanhdulieu = a.InsertDb(sql);
                if (sosanhdulieu == 0)
                {
                    MessageBox.Show("không xóa được dữ liệu");
                }
                else
                if (sosanhdulieu == -1)
                {

                    MessageBox.Show("Sách vẫn có người đang mượn, không thể xóa được !");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thành công");

                    masachtb.Text = null;
                    tensachtb.Text = null;
                    matacgiacombobox.Text = null;
                    theloaicombobox.Text = "";
                    soluongtextbox.Text = "";
                    nhaxuatbancombobox.Text = "";
                    Namxuatbantb.Text = "";
                    GridviewSach.DataSource = null;
                    hienthiGridviewsach();
                }
            }
            
        }

        private void GridviewSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            masachtb.Text = GridviewSach.CurrentRow.Cells[0].Value.ToString();
            tensachtb.Text = GridviewSach.CurrentRow.Cells[1].Value.ToString();
            soluongtextbox.Text = GridviewSach.CurrentRow.Cells[2].Value.ToString();
            matacgiacombobox.Text = GridviewSach.CurrentRow.Cells[3].Value.ToString();
            theloaicombobox.Text = GridviewSach.CurrentRow.Cells[4].Value.ToString();
            nhaxuatbancombobox.Text = GridviewSach.CurrentRow.Cells[5].Value.ToString();
            Namxuatbantb.Text = GridviewSach.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnsuasach_Click(object sender, EventArgs e)
        {
            if (masachtb.Text == "" || soluongtextbox.Text == "" || tensachtb.Text == "" || theloaicombobox.Text == "" || matacgiacombobox.Text == "" || nhaxuatbancombobox.Text == "" || Namxuatbantb.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            { 
                if (MessageBox.Show("Bạn muốn sửa thông tin của sách ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "update Sach set TenSach = N'" + tensachtb.Text + "', soluong = " + soluongtextbox.Text + " , MaTacGia  = '" + matacgiacombobox.SelectedValue + "',MaTheLoai = '" + theloaicombobox.SelectedValue + "', MaNXB = '" + nhaxuatbancombobox.SelectedValue + "', NamXuatBan = " + Namxuatbantb.Text + "  where MaSach = '" + masachtb.Text + "' ";

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
                        GridviewSach.DataSource = null;
                        hienthiGridviewsach();
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            masachtb.Text = null;
            tensachtb.Text = null;
            matacgiacombobox.Text = null;
            theloaicombobox.Text = "";
            nhaxuatbancombobox.Text = "";
            Namxuatbantb.Text = "";
            GridviewSach.Refresh();

        }



        private void Sach_Load(object sender, EventArgs e)
        {
    
        }

        private void timkiemtextbox_TextChanged(object sender, EventArgs e)
        {
            //con.Open();
            //SqlDataAdapter adapt;
            //DataTable dt;
            //string sql = "select masach,tensach, soluong , tentacgia , tentheloai ,tennxb, namxuatban from sach";
            //sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
            //sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
            //sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb where TenSach like N'%" + timkiemtextbox.Text + "%' or MaSach like '%" + timkiemtextbox.Text + "%' or MaTacGia like '%" + timkiemtextbox.Text + "%' or NamXuatBan like '%" + timkiemtextbox.Text + "%' or MaTheLoai like '%" + timkiemtextbox.Text + "%' ";

            //adapt = new SqlDataAdapter(sql, con);
            //dt = new DataTable();
            //adapt.Fill(dt);
            //GridviewSach.DataSource = dt;
            //con.Close();

            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            string sql = "select masach,tensach, soluong , tentacgia , tentheloai ,tennxb, namxuatban from sach";
            sql += " inner join tacgia on tacgia.matacgia = sach.matacgia ";
            sql += " inner join theloai on theloai.matheloai = sach.matheloai ";
            sql += " inner join nhaxuatban on nhaxuatban.manxb = sach.manxb where Tensach like N'%" + timkiemtextbox.Text + "%' or tennxb like N'%" + timkiemtextbox.Text + "%' or Tentheloai like N'%" + timkiemtextbox.Text + "%' or Tentacgia like N'%" + timkiemtextbox.Text + "%' or masach like N'%" + timkiemtextbox.Text + "%' ";

            adapt = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adapt.Fill(dt);
            GridviewSach.DataSource = null;
            hienthiGridviewsach();
            GridviewSach.DataSource = dt;
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();
        }

        private void btnloadfile_Click(object sender, EventArgs e)
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

            worksheet.Cells[2, 1] = "Mã Sách";
            worksheet.Cells[2, 2] = "Tên Sách";
            worksheet.Cells[2, 3] = "Số Lượng";
            worksheet.Cells[2, 4] = "Tên Tác Giả";
            worksheet.Cells[2, 5] = "Tên Thể Loại";
            worksheet.Cells[2, 6] = " Nhà Xuất Bản";
            worksheet.Cells[2, 7] = "Năm Xuất Bản";

            for (int i = 0; i < GridviewSach.RowCount - 1; i++)// 
            {
                for (int j = 0; j < GridviewSach.ColumnCount; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = GridviewSach.Rows[i].Cells[j].Value;
                }
            }

        }
    }
}
