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
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void theLoaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.theLoaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectCSharpDataSet);

        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectCSharpDataSet1.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.projectCSharpDataSet.TheLoai);
            

        }

       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            configdata confidb = new configdata();
            string sqlthemdulieu = "INSERT INTO TheLoai (MaTheLoai,TenTheLoai)";
            sqlthemdulieu += "VALUES ('" + maTheLoaiTextBox.Text + "'";
            sqlthemdulieu += ", N'" + tenTheLoaiTextBox.Text + "'";
            sqlthemdulieu += ");";
            confidb.InsertDb(sqlthemdulieu);
        }
    }
}
