
namespace ThuVien
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadfile = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.gioiTinh = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridviewNhanVien = new System.Windows.Forms.DataGridView();
            this.btHome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(600, 447);
            this.txtTimKiemNhanVien.Multiline = true;
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(339, 33);
            this.txtTimKiemNhanVien.TabIndex = 40;
            this.txtTimKiemNhanVien.TextChanged += new System.EventHandler(this.txtTimKiemNhanVien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 68);
            this.label6.TabIndex = 39;
            this.label6.Text = "Quản lý nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.loadfile);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btLamMoi);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox2.Location = new System.Drawing.Point(816, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 267);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // loadfile
            // 
            this.loadfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadfile.Location = new System.Drawing.Point(168, 175);
            this.loadfile.Name = "loadfile";
            this.loadfile.Size = new System.Drawing.Size(139, 64);
            this.loadfile.TabIndex = 30;
            this.loadfile.Text = "Ghi Excel";
            this.loadfile.UseVisualStyleBackColor = true;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::ThuVien.Properties.Resources.icons8_delete_35;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(286, 29);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(139, 63);
            this.btXoa.TabIndex = 28;
            this.btXoa.Text = "   Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::ThuVien.Properties.Resources.icons8_add_book_35;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(36, 29);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(139, 64);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "   Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamMoi.Image = global::ThuVien.Properties.Resources.icons8_refresh_16;
            this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLamMoi.Location = new System.Drawing.Point(286, 105);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(139, 64);
            this.btLamMoi.TabIndex = 29;
            this.btLamMoi.Text = "   Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::ThuVien.Properties.Resources.icons8_support_35;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(36, 105);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(139, 64);
            this.btSua.TabIndex = 27;
            this.btSua.Text = "   Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.ngaySinh);
            this.groupBox1.Controls.Add(this.gioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 267);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(191, 29);
            this.txtMaNhanVien.Multiline = true;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(265, 30);
            this.txtMaNhanVien.TabIndex = 16;
            this.txtMaNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaNhanVien_KeyDown);
            this.txtMaNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNhanVien_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(191, 73);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(265, 30);
            this.txtHoTen.TabIndex = 17;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(191, 162);
            this.txtDienThoai.MaxLength = 10;
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(265, 30);
            this.txtDienThoai.TabIndex = 18;
            this.txtDienThoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDienThoai_KeyDown);
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // ngaySinh
            // 
            this.ngaySinh.CustomFormat = "dd/MM/yyyy";
            this.ngaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaySinh.Location = new System.Drawing.Point(191, 120);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(265, 30);
            this.ngaySinh.TabIndex = 19;
            this.ngaySinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngaySinh_KeyDown);
            this.ngaySinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ngaySinh_KeyPress);
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSize = true;
            this.gioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinh.Location = new System.Drawing.Point(191, 209);
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Size = new System.Drawing.Size(69, 26);
            this.gioiTinh.TabIndex = 20;
            this.gioiTinh.Text = "Nam";
            this.gioiTinh.UseVisualStyleBackColor = true;
            this.gioiTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gioiTinh_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Giới tính";
            // 
            // gridviewNhanVien
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewNhanVien.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridviewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewNhanVien.Location = new System.Drawing.Point(80, 486);
            this.gridviewNhanVien.Name = "gridviewNhanVien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewNhanVien.RowTemplate.Height = 24;
            this.gridviewNhanVien.Size = new System.Drawing.Size(1179, 241);
            this.gridviewNhanVien.TabIndex = 36;
            this.gridviewNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewNhanVien_CellMouseClick);
            // 
            // btHome
            // 
            this.btHome.Image = global::ThuVien.Properties.Resources.home5;
            this.btHome.Location = new System.Drawing.Point(1, 1);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(43, 39);
            this.btHome.TabIndex = 42;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::ThuVien.Properties.Resources.icons8_search_40;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(299, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 33);
            this.label7.TabIndex = 41;
            this.label7.Text = "     Tìm kiếm nhân viên";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThuVien.Properties.Resources.thu_vien_dep_co_thiet_ke_doc_dao_ai_cung_muon_ghe_chan_mot_lan_147973;
            this.ClientSize = new System.Drawing.Size(1311, 759);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiemNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridviewNhanVien);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DateTimePicker ngaySinh;
        private System.Windows.Forms.CheckBox gioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridviewNhanVien;
        private System.Windows.Forms.Button loadfile;
    }
}