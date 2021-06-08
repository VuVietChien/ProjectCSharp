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
    public partial class TacGia : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL
        public TacGia()
        {
            InitializeComponent();
            hienthiGridviewTacGia();
            setbackground();
        }
        public void setbackground()
        {
            this.gridviewtacgia.DefaultCellStyle.Font = new Font("Arial", 12);
            this.gridviewtacgia.DefaultCellStyle.ForeColor = Color.Black;
            this.gridviewtacgia.DefaultCellStyle.BackColor = Color.Beige;
            this.gridviewtacgia.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.gridviewtacgia.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }
        public void hienthiGridviewTacGia()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaTacGia, TenTacGia, GhiChu from TacGia order by TenTacGia ASC";
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaTacGia";
            column.HeaderText = " Mã Tác Giả";
            gridviewtacgia.Columns.Add(column);
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "TenTacGia";
            column1.HeaderText = " Tên Tác Giả";
            gridviewtacgia.Columns.Add(column1);
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "GhiChu";
            column2.HeaderText = " Thông tin tác giả";
            gridviewtacgia.Columns.Add(column2);


            gridviewtacgia.DataSource = dt;

            //căn chỉnh cho bảng vừa bằng cái khung datagridview
            gridviewtacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridviewtacgia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnsuatacgia_Click(object sender, EventArgs e)
        {
            if (matacgiatextbox.Text == "" || tentacgiatextbox.Text == "" || ghichutextbox.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn sửa tác giả tác giả ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "update TacGia set TenTacGia = N'" + tentacgiatextbox.Text + "', GhiChu  = N'" + ghichutextbox.Text + "' where MaTacGia = '" + matacgiatextbox.Text + "'";

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
                        gridviewtacgia.DataSource = null;
                        hienthiGridviewTacGia();
                    }
                }

            }
           
        }

        private void btnthemtacgia_Click(object sender, EventArgs e)
        {
            if (matacgiatextbox.Text == "" || tentacgiatextbox.Text == "" || ghichutextbox.Text == "")
            {
                MessageBox.Show("có mục bạn đang để trống, vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn thêm mới tác giả ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configdata a = new configdata();
                    string sql = "insert into TacGia (MaTacGia,TenTacGia,GhiChu )";
                    sql += " Values('" + matacgiatextbox.Text + "' ,  N'" + tentacgiatextbox.Text + "', N'" + ghichutextbox.Text + "')";
                    int sosanhdulieu = a.InsertDb(sql);
                    if (sosanhdulieu == 0)
                    {
                        MessageBox.Show("không thêm được dữ liệu");
                    }
                    else
                    if (sosanhdulieu == -1)
                    {

                        MessageBox.Show("Mã tác giả đã có, vui lòng nhập mã tác giả khác !");
                    }
                    else
                    {
                        MessageBox.Show("đã thêm dữ liệu thành công");
                        gridviewtacgia.DataSource = null;
                        hienthiGridviewTacGia();
                    }
                }
                
            }    
            
        }

        private void btnxoatacgia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thể loại sách ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                configdata a = new configdata();
                string sql = "delete from TacGia where MaTacGia = '" + matacgiatextbox.Text + "'";

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

                    matacgiatextbox.Text = null;
                    tentacgiatextbox.Text = null;
                    ghichutextbox.Text = null;

                    hienthiGridviewTacGia();
                }
            }
        }

        private void gridviewtacgia_MouseClick(object sender, MouseEventArgs e)
        {
            matacgiatextbox.Text = gridviewtacgia.CurrentRow.Cells[0].Value.ToString();
            tentacgiatextbox.Text = gridviewtacgia.CurrentRow.Cells[1].Value.ToString();
            ghichutextbox.Text = gridviewtacgia.CurrentRow.Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            matacgiatextbox.Text = null;
            tentacgiatextbox.Text = null;
            ghichutextbox.Text = null;
            gridviewtacgia.DataSource = null;
            hienthiGridviewTacGia();
        }

        private void timkiemtacgiatextbox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt1;
            DataTable dt;
            string sql = "select MaTacGia, TenTacGia, GhiChu from TacGia where MaTacGia like N'%" + timkiemtacgiatextbox.Text + "%' or TenTacGia like '%" + timkiemtacgiatextbox.Text + "%' or GhiChu like '%" + timkiemtacgiatextbox.Text + "%'";
            adapt1 = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adapt1.Fill(dt);
            gridviewtacgia.DataSource = dt;
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            a.Show();

        }

        private void btnexport_Click(object sender, EventArgs e)
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
            worksheet.Cells[1, 2] = " BẢNG THÔNG TIN TÁC GIẢ";
            worksheet.Cells[3, 1] = "Mã Tác Giả";
            worksheet.Cells[3, 2] = "Tên Tác Giả";
            worksheet.Cells[3, 3] = "Ghi Chú";
          

            for (int i = 0; i < gridviewtacgia.RowCount - 1; i++)// 
            {
                for (int j = 0; j < gridviewtacgia.ColumnCount; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = gridviewtacgia.Rows[i].Cells[j].Value;
                }
            }
        }

   
    }
}
