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
            loaddulieucomboboxtennhanvien();
            loaddulieucomboboxsothe();
            hienthiGridviewmuonsach();

        }

        static public string ma = "";
        public void loaddulieumamuontra()
        {

            con.Open();
            string sql = "select top 1 MaMuonTra from muontra order by mamuontra Desc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            MaMuonTra.Text = dr["mamuontra"].ToString();
            con.Close();
        }
        
        private void MaMuonTra_TextChanged(object sender, EventArgs e)
        {
            ma = MaMuonTra.Text;
        }
        static public string getMamuontra()
        {
            return ma;
        }
        public void hienthiGridviewmuonsach()
        {

            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaMuonTra, muontra.SoThe, tendocgia , HoTen from MuonTra";
            sql += "  inner join TheThuVien on TheThuVien.SoThe = MuonTra.SoThe ";
            sql += " inner join NhanVien on NhanVien.MaNhanVien= MuonTra.MaNhanVien order by tendocgia desc";


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


        
        



        private void gridviewmuonsach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MaMuonTra.Text = gridviewmuonsach.CurrentRow.Cells[0].Value.ToString();
            sothecbb.Text = gridviewmuonsach.CurrentRow.Cells[1].Value.ToString();
            tennhaviencbb.Text = gridviewmuonsach.CurrentRow.Cells[3].Value.ToString();



        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            this.Hide();
            a.Show();
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
                    string sql = "select MaMuonTra, muontra.SoThe, tendocgia , HoTen from MuonTra";
                    sql += "  inner join TheThuVien on TheThuVien.SoThe = MuonTra.SoThe ";
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

   

        private void MuonTra_Load(object sender, EventArgs e)
        {


            gridviewmuonsach.Visible = true;
            grouponsach.Visible = true;
            groupBox3.Visible = true;
            
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            if(MaMuonTra.Text != "")
            {
                chi_tiết_mượn_trả a = new chi_tiết_mượn_trả();
                this.Hide();
                a.Show();
            }    
            else
            {
                MessageBox.Show("vui lòng chọn người muốn mượn sách ở dưới bảng người mượn !");
            }    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            configdata config = new configdata();
            string sql = "insert into MuonTra values ( " + sothecbb.SelectedValue + " , N'" + tennhaviencbb.SelectedValue + "')";
            int sosanhdulieu = config.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("Người này đã có mã mượn trả, không thể thêm ! ");
            }
            else
            {
                MessageBox.Show("thêm thành công người mượn ");
                gridviewmuonsach.DataSource = null;
                hienthiGridviewmuonsach();
                loaddulieumamuontra();
                if (MessageBox.Show("Bạn muốn thêm sách cho người này luôn không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chi_tiết_mượn_trả a = new chi_tiết_mượn_trả();
                    this.Hide();
                    a.Show();
                }
            }
             
        }

        private void btntrasach_Click(object sender, EventArgs e)
        {
            chi_tiết_mượn_trả a = new chi_tiết_mượn_trả();
            this.Hide();
            a.Show();
            
          
        }
    }
}
