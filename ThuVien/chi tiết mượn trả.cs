using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class chi_tiết_mượn_trả : Form
    {
        public chi_tiết_mượn_trả()
        {
            InitializeComponent();


        }

        public void loadmamuontra()
        {

            CTMaMuonTra.Text = MuonTra.getMamuontra();
        }
        public void loaddulieucomboboxtensach()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select masach,tensach  from sach";
            //hứng dữ liệu từ sql trả về vào DataTable
            dt = config.selectDb(sql);
            CTtensach.DataSource = new BindingSource(dt, null);
            // gán giá trị và hiển thị giữ liệu cho combobox
            CTtensach.DisplayMember = dt.Columns[1].ToString();
            CTtensach.ValueMember = dt.Columns[0].ToString();
        }
        public void hienthiGridviewCTmuonsach()
        {

            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select CTmuontra.MaMuonTra, tensach, soluongmuon , ngaymuon from CTMuonTra";
            sql += "  inner join MuonTra on MuonTra.mamuontra = CTMuonTra.mamuontra ";
            sql += " inner join Sach on Sach.masach = CTMuonTra.masach  where CTmuontra.MaMuonTra = " + MuonTra.getMamuontra() + " ";


            dt = config.selectDb(sql);
            // hứng dữ liệu trả về


            //thay đổi tên trường khi hiển thị

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "mamuontra";
            column.HeaderText = " Mã Mượn Trả";
            gridviewCTmuonsach.Columns.Add(column);

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "tensach";
            column1.HeaderText = " Tên Sách";
            gridviewCTmuonsach.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "soluongmuon";
            column2.HeaderText = " Số Lượng Mượn";
            gridviewCTmuonsach.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Ngaymuon";
            column3.HeaderText = " Ngày Mượn Sách ";
            gridviewCTmuonsach.Columns.Add(column3);


            gridviewCTmuonsach.DataSource = dt;
            //căn chỉnh cho bảng vừa bằng cái khung datagridview
            gridviewCTmuonsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridviewCTmuonsach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewCTmuonsach.DefaultCellStyle.Font = new Font("Arial", 12);
            this.gridviewCTmuonsach.DefaultCellStyle.ForeColor = Color.Black;
            this.gridviewCTmuonsach.DefaultCellStyle.BackColor = Color.Beige;
            this.gridviewCTmuonsach.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.gridviewCTmuonsach.DefaultCellStyle.SelectionBackColor = Color.Gray;

            int count = gridviewCTmuonsach.Rows.Count;
            if (count == 1)
            {
                cttrasachbtn.Visible = false;
            }
            else
            {
                cttrasachbtn.Visible = true;
            }    

        }


        private void chi_tiết_mượn_trả_Load(object sender, EventArgs e)
        {
            hienthiGridviewCTmuonsach();
            loaddulieucomboboxtensach();
            loadmamuontra();
          
        }

        public int soluongmuontra()
        {
            int soluongtra = Convert.ToInt32(CTSoLuongMuon.Text);
            return soluongtra;
        }

        public int kiemtraslmuon()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = ("select soluongmuon from ctmuontra where mamuontra =" + CTMaMuonTra.Text + ";");
            dt = config.selectDb(sql);
            DataRow dr = dt.Rows[0];
            int soluongmuon = Convert.ToInt32(dr["soluongmuon"].ToString());
            return soluongmuon;
        }
        public int soluongsach()
        {
            configdata config = new configdata();
            DataTable dt = new DataTable();
            string sql = "select soluong from sach where masach ='" + CTtensach.SelectedValue + "';";
            dt = config.selectDb(sql);
            DataRow dr = dt.Rows[0];
            int soluongsach = Convert.ToInt32(dr["soluong"].ToString());
            return soluongsach;
        }
        
        public void updateslsachkhimuon()
        {
            configdata a = new configdata();
            string sql1 = "update Sach set soluong = " + (soluongsach() - soluongmuontra()) + "  where masach = '" + CTtensach.SelectedValue + "'; ";
            a.InsertDb(sql1);
        }
        public void insertsachmuon()
        {
            configdata a = new configdata();
            string sql = "insert into CTMuonTra( mamuontra , masach ,soluongmuon, ngaymuon )";
            sql += " Values(" + CTMaMuonTra.Text + " ,  N'" + CTtensach.SelectedValue + "'," + CTSoLuongMuon.Text + " , CONVERT(DATETIME,'" + CTngaymuondatetimepicker.Text + "',103) )";
            int sosanhdulieu = a.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("@@@");
            }
            else
            {
                MessageBox.Show("đã thêm dữ liệu thành công");
                gridviewCTmuonsach.DataSource = null;
                hienthiGridviewCTmuonsach();
            }
        }
        public void updatesachmuon()
        {
            configdata a = new configdata();
            string sql = "update ctmuontra set soluongmuon = "+(kiemtraslmuon() + soluongmuontra())+" where masach = '"+CTtensach.SelectedValue+"'";

            int sosanhdulieu = a.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("@@@");
            }
            else
            {
                MessageBox.Show("mượn sách thành công !");
                gridviewCTmuonsach.DataSource = null;
                hienthiGridviewCTmuonsach();
            }
        }

        public int kiemtradulieu()
        {
                int soluong = 0;
                configdata config = new configdata();
                DataTable dt = new DataTable();
                string sql = "select * from ctmuontra where (masach ='" + CTtensach.SelectedValue + "' and mamuontra = " + CTMaMuonTra.Text + ");";
                dt = config.selectDb(sql);
                if(dt != null)
                {
                    soluong = dt.Rows.Count;
                }    
                return soluong;
        }
        private void btnmuonsach_Click(object sender, EventArgs e)
        {
            try
            {
                if (CTSoLuongMuon.Text == "")
                {
                    MessageBox.Show("bạn chưa điền số lượng sách cần mượn , vui lòng nhập đầy đủ thông tin ");
                }
                else
                if (soluongsach() - soluongmuontra() >= 0)
                {
                    if (kiemtradulieu() == 0)
                    {
                        insertsachmuon();
                        updateslsachkhimuon();
                    }
                    else
                    {
                        updatesachmuon();
                        updateslsachkhimuon();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            MuonTra a = new MuonTra();
            this.Hide();
            a.Show();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            MuonTra a = new MuonTra();
            this.Hide();
            a.Show();
        }

        private void gridviewCTmuonsach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CTMaMuonTra.Text = gridviewCTmuonsach.CurrentRow.Cells[0].Value.ToString();
            CTtensach.Text = gridviewCTmuonsach.CurrentRow.Cells[1].Value.ToString();
            CTSoLuongMuon.Text = gridviewCTmuonsach.CurrentRow.Cells[2].Value.ToString();
            CTngaymuondatetimepicker.Text = gridviewCTmuonsach.CurrentRow.Cells[3].Value.ToString();



        }


        public void updateslsachthuvienkhitra1()
        {
            configdata a = new configdata();
            string sql1 = "update Sach set soluong = " + (soluongsach() + soluongmuontra()) + "  where masach = '" + CTtensach.SelectedValue + "'; ";
            a.InsertDb(sql1);
        }
        public void updateslsachmuonkhitra()
        {
            configdata a = new configdata();
            string sql = "update CTMuonTra set soluongmuon  =  " + (kiemtraslmuon() - soluongmuontra()) +" where masach = '"+CTtensach.SelectedValue+"' ";
            int sosanhdulieu = a.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("@@@");
            }
            else
            {
                MessageBox.Show("trả sách thành công !");
                gridviewCTmuonsach.DataSource = null;
                hienthiGridviewCTmuonsach();
            }
        }
        public void deleteslsachmuonkhitra()
        {
            configdata a = new configdata();
            string sql = "delete CTMuonTra  where (masach = '" + CTtensach.SelectedValue + "' and soluongmuon = "+CTSoLuongMuon.Text+" and mamuontra = "+CTMaMuonTra.Text+" ) ";
            int sosanhdulieu = a.InsertDb(sql);
            if (sosanhdulieu == 0)
            {
                MessageBox.Show("không thêm được dữ liệu");
            }
            else
            if (sosanhdulieu == -1)
            {

                MessageBox.Show("@@@");
            }
            else
            {
                MessageBox.Show("Trả sách thành công !");
                gridviewCTmuonsach.DataSource = null;
                hienthiGridviewCTmuonsach();
            }
        }
        private void cttrasachbtn_Click(object sender, EventArgs e)
        {

            if (CTSoLuongMuon.Text == "")
            {
                MessageBox.Show("bạn chưa điền số lượng sách cần trả , vui lòng nhập đầy đủ thông tin ");
            }
            else
            if (kiemtraslmuon() - soluongmuontra() > 0)
            {
                updateslsachthuvienkhitra1();
                updateslsachmuonkhitra();
            }
            else
            {
                if (kiemtraslmuon() - soluongmuontra() == 0)
                {
                    updateslsachthuvienkhitra1();
                    deleteslsachmuonkhitra();
                }
                else
            {
                MessageBox.Show("số lượng bạn trả nhiều hơn số lượng bạn đã mượn, vui lòng kiểm tra lại !");
            }   
                    
        }
 
     }
  }
}
