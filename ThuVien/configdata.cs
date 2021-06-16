using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ThuVien
{
    class configdata
    {
        static String connection = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString;
        //công việc chính là thêm ,sửa , xóa thông qua câu lệnh sql
        SqlConnection con = new SqlConnection(connection);

        public int InsertDb(String sql)
        {

            SqlCommand cmd = new SqlCommand(sql, con);
            int i = -1;
            try
            {
                // mở kết nối csdl
                con.Open();
                //cmd.ExecuteNonQuery();
                i = cmd.ExecuteNonQuery();
            }
            catch
            {
                 i = -1;
            }
            finally
            {
                con.Close();
            }
            return i;
        }

       
        public DataTable selectDb(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            //lưới chứa dữu liệu trả về
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                //sử dụng sql reader
                SqlDataReader dr = cmd.ExecuteReader();
                tb.Load(dr, LoadOption.OverwriteChanges);
                if (tb.Rows.Count == 0)
                {
                    return null;
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return tb;
        }
    }
}

