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
    public partial class Sach : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        // tạo kết nối đến database sử dụng thư viện using System.Data.SqlClient;
        SqlConnection con = new SqlConnection(connection);  //Doi tuong ket noi CSDL
        public Sach()
        {
            InitializeComponent();
        }


        private void sachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectCSharpDataSet);

        }

        private void Sach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectCSharpDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.projectCSharpDataSet.Sach);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into Sach(MaSach,TenSach,MaTacGia, MaTheLoai,MaNXB,NamXuatBan)";
            sql += " Values('" + maSachTextBox.Text + "' ,  N'" + tenSachTextBox.Text + " ', '" + maTacGiaTextBox.Text + "', '" +maTheLoaiTextBox.Text + "',N'" + maNXBTextBox.Text + "'," + namXuatBanTextBox.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, con);

            //int demsodonginsert = -1
            try
            {
                // mở kết nối đến cơ sở dữ liệu
                con.Open();
                //chạy câu lệnh nhập ở trên
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            //reload lại datagrid để có dữ liệu mới

            this.sachTableAdapter.Fill(this.projectCSharpDataSet.Sach);
        }
    }
}
