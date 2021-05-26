using System;
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
    public partial class TacGia : Form
    {
        public TacGia()
        {
            InitializeComponent();
            hienthitacgia();
        }

        public void hienthitacgia()
        {
            // load dữ liệu từ csdl
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select MaTacGia, TenTacGia, GhiChu from TacGia order by TenTacGia ASC ";
            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaTacGia";
            column.HeaderText = " Mã Tác Giả";
            GridviewTacGia.Columns.Add(column);
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "TenTacGia";
            column1.HeaderText = " Tên Tác Giả";
            GridviewTacGia.Columns.Add(column1);
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "GhiChu";
            column2.HeaderText = "Ghi Chú";
            GridviewTacGia.Columns.Add(column2);

            GridviewTacGia.DataSource = dt;
            GridviewTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridviewTacGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void tacGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tacGiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectCSharpDataSet);

        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectCSharpDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.projectCSharpDataSet.TacGia);

        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            configdata a = new configdata();
            string sql = "insert TacGia values ( '" + maTacGiaTextBox.Text + "',N'" + tenTacGiaTextBox.Text + "',N'" + ghiChuTextBox.Text + "')";
            
            int sosanhdulieu = a.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("Lỗi không kết nối giữ liệu");
            }
            else
            {
                MessageBox.Show("đã thêm dữ liệu thành công");
                GridviewTacGia.DataSource = null;
                hienthitacgia();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            configdata a = new configdata();
            string sql = "update TacGia set TenTacGia = N'" + tenTacGiaTextBox.Text + "', GhiChu  = '" + ghiChuTextBox.Text + "'";
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
                GridviewTacGia.DataSource = null;
                hienthitacgia();
            }
        }
    }
    
}
