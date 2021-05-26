﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string sql = "select MaSach, TenSach, MaTacGia, MaTheLoai, MaNXB , NamXuatBan from Sach order by TenSach ASC";
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
            column2.DataPropertyName = "MaTacGia";
            column2.HeaderText = " Mã Tác Giả";
            GridviewSach.Columns.Add(column2);
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "MaTheLoai";
            column3.HeaderText = " Mã Thể Loại";
            GridviewSach.Columns.Add(column3);
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "MaNXB";
            column4.HeaderText = " Mã NXB";
            GridviewSach.Columns.Add(column4);
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "NamXuatBan";
            column5.HeaderText = " Năm XB";
            GridviewSach.Columns.Add(column5);

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
            this.sachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectCSharpDataSet);

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

            configdata a = new configdata();
            string sql = "insert into Sach(MaSach,TenSach,MaTacGia, MaTheLoai,MaNXB,NamXuatBan  )";
            sql += " Values('" + maSachTextBox.Text + "' ,  N'" + tenSachTextBox.Text + " ', '" + matacgiacombobox.SelectedValue + "', '" + theloaicombobox.SelectedValue + "',N'" + nhaxuatbancombobox.SelectedValue + "'," + namXuatBanTextBox.Text + ")";
            int sosanhdulieu = a.InsertDb(sql);
            if(sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }    
            else
            if(sosanhdulieu == -1)
            {

                MessageBox.Show("Lỗi không kết nối giữ liệu");
            }
            else
            {
                MessageBox.Show("đã thêm dữ liệu thành công");
                GridviewSach.DataSource = null;
                hienthiGridviewsach();
            }    
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            configdata a = new configdata();
            string sql = "delete from Sach where MaSach = '" + maSachTextBox.Text + "'";
           
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
                GridviewSach.DataSource = null;
                hienthiGridviewsach();
            }
        }

        private void GridviewSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            maSachTextBox.Text = GridviewSach.CurrentRow.Cells[0].Value.ToString();
            tenSachTextBox.Text = GridviewSach.CurrentRow.Cells[1].Value.ToString();
            matacgiacombobox.SelectedValue = GridviewSach.CurrentRow.Cells[2].Value.ToString();
            theloaicombobox.SelectedValue = GridviewSach.CurrentRow.Cells[3].Value.ToString();
            nhaxuatbancombobox.SelectedValue = GridviewSach.CurrentRow.Cells[4].Value.ToString();
            namXuatBanTextBox.Text = GridviewSach.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnsuasach_Click(object sender, EventArgs e)
        {
            configdata a = new configdata();
            string sql = "update Sach set TenSach = N'"+ tenSachTextBox.Text +"', MaTacGia  = '"+matacgiacombobox.SelectedValue +"',MaTheLoai = '"+theloaicombobox.SelectedValue +"', MaNXB = '"+nhaxuatbancombobox.SelectedValue +"', NamXuatBan = "+namXuatBanTextBox.Text+"  where MaSach = '"+maSachTextBox.Text+"' " ;

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            maSachTextBox.Text = null;
            tenSachTextBox.Text = null;
            matacgiacombobox.Text = null;
            theloaicombobox.Text = "";
            nhaxuatbancombobox.Text = "";
            namXuatBanTextBox.Text = "";
            GridviewSach.Refresh();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();


        }

       

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            adapt = new SqlDataAdapter("select MaSach, TenSach, MaTacGia, MaTheLoai, MaNXB, NamXuatBan from Sach ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            GridviewSach.DataSource = dt;
            con.Close();
        }

        private void timkiemtextbox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            string sql = "select MaSach, TenSach, MaTacGia, MaTheLoai, MaNXB , NamXuatBan from Sach where TenSach like N'%" + timkiemtextbox.Text + "%' or MaSach like '%" + timkiemtextbox.Text + "%' or MaTacGia like '%" + timkiemtextbox.Text + "%' or NamXuatBan like '%" + timkiemtextbox.Text + "%' or MaTheLoai like '%" + timkiemtextbox.Text + "%'";
            adapt = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adapt.Fill(dt);
            GridviewSach.DataSource = dt;
            con.Close();
        }
    }
}