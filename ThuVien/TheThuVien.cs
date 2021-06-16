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
    public partial class TheThuVien : Form
    {
        static String connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        //công việc chính là thêm ,sửa , xóa thông qua câu lệnh sql
        SqlConnection con = new SqlConnection(connection);
        public TheThuVien()
        {
            InitializeComponent();
            Hienthi();
        }

        public void Hienthi()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            String sql = "SELECT *FROM TheThuVien";
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SoThe";
            column.HeaderText = "Số Thẻ";
            dataGridView1.Columns.Add(column);
            //cột 2 với fields là maso
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "TenDocGia";
            column2.HeaderText = "Tên độc giả";
            dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "DiaChi";
            column3.HeaderText = "Địa chỉ";
            dataGridView1.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "NgayBatDau";
            column4.HeaderText = "Ngày Bắt Đầu";
            dataGridView1.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "NgayHetHan";
            column5.HeaderText = "Ngày Hết Hạn";
            dataGridView1.Columns.Add(column5);

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "GhiChu";
            column6.HeaderText = "Ghi Chú";
            dataGridView1.Columns.Add(column6);

            dataGridView1.DataSource = dt;
            // setbackground();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(getvaluedate1() < getvaluedate2())
            {
                configdata a = new configdata();
                string sqlthemdulieu = "INSERT INTO TheThuVien (SoThe,TenDocGia,DiaChi,NgayBatDau,NgayHetHan,GhiChu)";
                sqlthemdulieu += "VALUES ('" + SoThetextBox.Text + "'";
                sqlthemdulieu += ", N'" + TenDocGiatextBox.Text + "'";
                sqlthemdulieu += ", N'" + DiaChitextBox.Text + "'";
                sqlthemdulieu += ", CONVERT(DATETIME,'" + dateTimePicker1.Text + "',103)";
                sqlthemdulieu += ", CONVERT(DATETIME,'" + dateTimePicker2.Text + "',103)";
                sqlthemdulieu += ", N'" + GhiChutextBox.Text + "'";
                sqlthemdulieu += ");";
                int sosanhdulieu = a.InsertDb(sqlthemdulieu);
                if (sosanhdulieu == 0)
                {
                    MessageBox.Show("không thêm được dữ liệu");
                }
                else
                if (sosanhdulieu == -1)
                {

                    MessageBox.Show("Lỗi không kết nối dữ liệu");
                }
                else
                {
                    MessageBox.Show("đã thêm dữ liệu thành công");
                    dataGridView1.DataSource = null;
                    Hienthi();
                }
            }
            else
            {
                MessageBox.Show("ngày kết thúc sớm hơn ngày bắt đầu, vui lòng kiểm tra lại");
            }    
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            configdata a = new configdata();
            string sql = "delete TheThuVien where SoThe='" + SoThetextBox.Text + "'";

            int sosanhdulieu = a.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không xóa được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("Lỗi không kết nối dữ liệu");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thành công");
                dataGridView1.DataSource = null;
                Hienthi();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            configdata confidb = new configdata();
            String sqlsua = "update TheThuVien set TenDocGia=N'" + TenDocGiatextBox.Text + "', DiaChi=N'" + DiaChitextBox.Text + "' NgayBatDau = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',103), NgayHetHan= CONVERT(DATETIME,'" + dateTimePicker2.Text + "',103), GhiChu=N'" + GhiChutextBox.Text + "'where SoThe='" + SoThetextBox.Text + "'";
            // confidb.InsertDb(sqlsua);
            int suadulieu = confidb.InsertDb(sqlsua);

            if (suadulieu == 0)
            {
                MessageBox.Show("không sửa được dữ liệu");
            }
            else if (suadulieu == -1)
            {
                MessageBox.Show("lỗi dữ liệu");
            }
            else
            {
                MessageBox.Show("Đã sửa dữ liệu");
                dataGridView1.DataSource = null;
                Hienthi();
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            SoThetextBox.Text = "";
            TenDocGiatextBox.Text = "";
            DiaChitextBox.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            GhiChutextBox.Text = "";
        }

        private void TimKiemtextBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapt;
            DataTable dt;
            string sql = "select TenDocGia,DiaChi,NgayBatDau,NgayHetHan,GhiChu from TheThuVien where SoThe like N'%" + TimKiemtextBox.Text + "%'";
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
            SoThetextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TenDocGiatextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DiaChitextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            GhiChutextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        public DateTime getvaluedate1()
        {
            DateTime ngaybd = Convert.ToDateTime(dateTimePicker1.Text.ToString());
            return ngaybd;
        }
        public DateTime getvaluedate2()
        {
            DateTime ngaybd = Convert.ToDateTime(dateTimePicker2.Text.ToString());
            return ngaybd;
        }
    }
}
