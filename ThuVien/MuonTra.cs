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
    public partial class MuonTra : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL
        public MuonTra()
        {
            InitializeComponent();
            loaddulieucomboboxsothe();
            loaddulieucomboboxtensach();
            loaddulieucomboboxtennhanvien();
            loaddulieumamuontra();
            hienthiGridviewmuonsach();
        }

        public void loaddulieumamuontra()
        {

            con.Open();
            string sql = "select MaMuonTra from muontra";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            MaMuonTra.Text = dr["mamuontra"].ToString();
            con.Close();
        }

        public void hienthiGridviewmuonsach()
        {

            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaMuonTra, muontra.SoThe, tendocgia , HoTen,ngaymuon , tensach , soluongmuon from MuonTra";
            sql += "  inner join TheThuVien on TheThuVien.SoThe = MuonTra.SoThe ";
            sql += "inner join Sach on Sach.MaSach = MuonTra.MaSach";
            sql += " inner join NhanVien on NhanVien.MaNhanVien= MuonTra.MaNhanVien order by tensach desc";


            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaMuonTra";
            column.HeaderText = "Mã Mượn Trả";
            gridviewmuonsach.Columns.Add(column);

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "sothe";
            column1.HeaderText = " Số thẻ đọc giả";
            gridviewmuonsach.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "tendocgia";
            column2.HeaderText = " Tên Đọc Giả";
            gridviewmuonsach.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "hoten";
            column3.HeaderText = " Tên Nhân Viên ";
            gridviewmuonsach.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "NgayMuon";
            column4.HeaderText = " Ngày Mượn";
            gridviewmuonsach.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "TenSach";
            column5.HeaderText = " Tên Sách";
            gridviewmuonsach.Columns.Add(column5);

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "soluongmuon";
            column6.HeaderText = " Số lượng mượn";
            gridviewmuonsach.Columns.Add(column6);

            gridviewmuonsach.DataSource = dt;
            //căn chỉnh cho bảng vừa bằng cái khung datagridview
            gridviewmuonsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridviewmuonsach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewmuonsach.DefaultCellStyle.Font = new Font("Arial", 12);
            this.gridviewmuonsach.DefaultCellStyle.ForeColor = Color.Black;
            this.gridviewmuonsach.DefaultCellStyle.BackColor = Color.Beige;
            this.gridviewmuonsach.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.gridviewmuonsach.DefaultCellStyle.SelectionBackColor = Color.Gray;

        }
        public void loaddulieucomboboxsothe()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select SoThe from TheThuVien";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            sothecbb.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            sothecbb.ValueMember = dt.Columns[0].ToString();
        }
        public void loaddulieucomboboxtensach()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select masach ,TenSach  from Sach";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            tensachcbb.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            tensachcbb.DisplayMember = dt.Columns[1].ToString();
            tensachcbb.ValueMember = dt.Columns[0].ToString();
        }
        public void loaddulieucomboboxtennhanvien()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select manhanvien ,hoten  from NhanVien";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            tennhaviencbb.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            tennhaviencbb.DisplayMember = dt.Columns[1].ToString();
            tennhaviencbb.ValueMember = dt.Columns[0].ToString();
        }


        public int kiemtrasoluong()
        {


            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = ("select soluong from sach where masach ='" + tensachcbb.SelectedValue + "';");
            dt = config.selectDb(sql);
            DataRow dr = dt.Rows[0];
            int soluong = Convert.ToInt32(dr["soluong"].ToString());

            int soluongmuon = Convert.ToInt32(soluongsachtb.Text);
            int kiemtra = soluong - soluongmuon;
            return kiemtra;

            //if (soluong - soluongmuon >= 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}  
        }

        public int soluongsach()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = ("select soluong from sach where masach ='" + tensachcbb.SelectedValue + "';");
            dt = config.selectDb(sql);
            DataRow dr = dt.Rows[0];
            int soluongsach = Convert.ToInt32(dr["soluong"].ToString());
            return soluongsach;
        }
        public int soluongmuon()
        {


            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = ("select soluongmuon from muontra where mamuontra =" + tramamuontratextbox.Text + ";");
            dt = config.selectDb(sql);
            DataRow dr = dt.Rows[0];
            int soluongmuon = Convert.ToInt32(dr["soluongmuon"].ToString());
            return soluongmuon;


        }

        public int soluongtra()
        {
            int soluongtra = Convert.ToInt32(traslsach.Text);
            return soluongtra;
        }

        public void updateslsach()
        {
            configdata a = new configdata();
            string sql1 = "update Sach set soluong = " + kiemtrasoluong() + "  where masach = '" + tensachcbb.SelectedValue + "'; ";
            a.InsertDb(sql1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtrasoluong() >= 0)
                {
                    if (sothecbb.Text == "" || tennhaviencbb.Text == "" || ngaymuondatetimepicker.Text == "" || tensachcbb.Text == "" || soluongsachtb.Text == "")
                    {
                        MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn muốn thêm thông tin người mượn ", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            configdata a = new configdata();
                            string sql = "insert into MuonTra( sothe, manhanvien ,ngaymuon, Masach,soluongmuon  )";
                            sql += " Values(" + sothecbb.Text + " ,  N'" + tennhaviencbb.SelectedValue + " ', '" + ngaymuondatetimepicker.Text + "', '" + tensachcbb.SelectedValue + "', '" + soluongsachtb.Text + "')";
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
                                MessageBox.Show("đã thêm dữ liệu thành công");
                                gridviewmuonsach.DataSource = null;
                                hienthiGridviewmuonsach();
                            }
                            updateslsach();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("số lượng sách trong thư viên không đủ, vui lòng giảm bớt số lượng sách !");
                }
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai định dạng của số lượng, số lượng phải là kiểu số nguyên !");
            }
        }

        private void gridviewmuonsach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MaMuonTra.Text = gridviewmuonsach.CurrentRow.Cells[0].Value.ToString();
            sothecbb.Text = gridviewmuonsach.CurrentRow.Cells[1].Value.ToString();
            tennhaviencbb.Text = gridviewmuonsach.CurrentRow.Cells[3].Value.ToString();
            ngaymuondatetimepicker.Text = gridviewmuonsach.CurrentRow.Cells[4].Value.ToString();
            tensachcbb.Text = gridviewmuonsach.CurrentRow.Cells[5].Value.ToString();
            soluongsachtb.Text = gridviewmuonsach.CurrentRow.Cells[6].Value.ToString();

            tramamuontratextbox.Text = gridviewmuonsach.CurrentRow.Cells[0].Value.ToString();
            trathecbb.Text = gridviewmuonsach.CurrentRow.Cells[1].Value.ToString();
            tratennvcbb.Text = gridviewmuonsach.CurrentRow.Cells[3].Value.ToString();
            traangaymuon.Text = gridviewmuonsach.CurrentRow.Cells[4].Value.ToString();
            tratensach.Text = gridviewmuonsach.CurrentRow.Cells[5].Value.ToString();
            traslsach.Text = gridviewmuonsach.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            this.Hide();
            a.Show();
        }

        private void btntrasach_Click(object sender, EventArgs e)
        {
           try
            {
                if (soluongmuon() == soluongtra())
                {
                    configdata a = new configdata();
                    string sql = "delete from muontra where mamuontra = '" + tramamuontratextbox.Text + "'";

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
                        MessageBox.Show("Trả sách thành công !");
                    }
                    gridviewmuonsach.DataSource = null;
                    hienthiGridviewmuonsach();
                }
                else
                {
                    if (soluongmuon() - soluongtra() > 0)
                    {
                        configdata a = new configdata();
                        string sql1 = "update Sach set soluong = " + (soluongsach() + soluongtra()) + "  where masach = '" + tensachcbb.SelectedValue + "'; ";
                        a.InsertDb(sql1);
                        string sql2 = "update MuonTra set soluongmuon = " + (soluongmuon() - soluongtra()) + "  where mamuontra = " + tramamuontratextbox.Text + "; ";
                        a.InsertDb(sql2);
                        MessageBox.Show("Trả Sách Thành Công !");
                        gridviewmuonsach.DataSource = null;
                        hienthiGridviewmuonsach();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sách bạn trả nhiều hơn số lượng sách bạn mượn, vui lòng kiểm tra lại số lượng trả !");
                    }
                }
            }
            catch
            {
                MessageBox.Show("bạn nhập sai định dạng số lượng, số lượng phải kiểu số nguyên");
            }
        }

     

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

                try
            {
                if (timkiemsothe.Text != "")
                {
                    con.Open();
                    SqlDataAdapter adapt;
                    DataTable dt;
                    string sql = "select MaMuonTra, muontra.SoThe, tendocgia , HoTen,ngaymuon , tensach , soluongmuon from MuonTra";
                    sql += "  inner join TheThuVien on TheThuVien.SoThe = MuonTra.SoThe ";
                    sql += "inner join Sach on Sach.MaSach = MuonTra.MaSach";
                    sql += " inner join NhanVien on NhanVien.MaNhanVien= MuonTra.MaNhanVien where mamuontra = " + timkiemsothe.Text + " or muontra.sothe =  " + timkiemsothe.Text + "";
                    adapt = new SqlDataAdapter(sql, con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    gridviewmuonsach.DataSource = null;
                    hienthiGridviewmuonsach();
                    gridviewmuonsach.DataSource = dt;
                    con.Close();
                }
                else
                {
                    gridviewmuonsach.DataSource = null;
                    hienthiGridviewmuonsach();
                }
            }
            catch
            {
                MessageBox.Show("bạn nhập sai định dạng mã mượn trả hoặc số thẻ, mã mượn trả hoặc số thẻ là số nguyên !");
            }
        }

        private void timkiemtb_TextChanged(object sender, EventArgs e)
        {
            if(timkiemtb.Text != "")
            {
                con.Open();
                SqlDataAdapter adapt;
                DataTable dt;
                string sql = "select MaMuonTra, muontra.SoThe, tendocgia , HoTen,ngaymuon , tensach , soluongmuon from MuonTra";
                sql += "  inner join TheThuVien on TheThuVien.SoThe = MuonTra.SoThe ";
                sql += "inner join Sach on Sach.MaSach = MuonTra.MaSach";
                sql += " inner join NhanVien on NhanVien.MaNhanVien= MuonTra.MaNhanVien where nhanvien.hoten like  N'%" + timkiemtb.Text + "%' or thethuvien.tendocgia like  N'%" + timkiemtb.Text + "%' or sach.tensach like  N'%" + timkiemtb.Text + "%' ";
                adapt = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapt.Fill(dt);
                gridviewmuonsach.DataSource = null;
                hienthiGridviewmuonsach();
                gridviewmuonsach.DataSource = dt;
                con.Close();
            }    
            else
            {
                gridviewmuonsach.DataSource = null;
                hienthiGridviewmuonsach();
            }    
        }

        private void MuonTra_Load(object sender, EventArgs e)
        {

            groupBox2.Visible = true;
            gridviewmuonsach.Visible = false;
            grouptraxach.Visible = false;
            grouponsach.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            grouponsach.Visible = true;
            gridviewmuonsach.Visible = true;

        }

        private void trasachchinh_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            gridviewmuonsach.Visible = true;
            grouptraxach.Visible = true;
        }
    }
}
