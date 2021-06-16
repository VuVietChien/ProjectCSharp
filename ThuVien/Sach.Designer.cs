
namespace ThuVien
{
    partial class Sach
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridviewSach = new System.Windows.Forms.DataGridView();
            this.matacgiacombobox = new System.Windows.Forms.ComboBox();
            this.theloaicombobox = new System.Windows.Forms.ComboBox();
            this.nhaxuatbancombobox = new System.Windows.Forms.ComboBox();
            this.Xóa = new System.Windows.Forms.Button();
            this.btnsuasach = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.timkiemtextbox = new System.Windows.Forms.TextBox();
            this.MaSachlbl = new System.Windows.Forms.Label();
            this.Tensachlb = new System.Windows.Forms.Label();
            this.nhaxuatbanlb = new System.Windows.Forms.Label();
            this.masachtb = new System.Windows.Forms.TextBox();
            this.tensachtb = new System.Windows.Forms.TextBox();
            this.Namxuatbantb = new System.Windows.Forms.TextBox();
            this.Tacgialb = new System.Windows.Forms.Label();
            this.theloailb = new System.Windows.Forms.Label();
            this.namxuatbanlb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soluongtextbox = new System.Windows.Forms.TextBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnloadfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Snow;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Image = global::ThuVien.Properties.Resources.icons8_add_book_35;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(35, 157);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 57);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm Sách";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(588, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bảng Quản Lý Sách";
            // 
            // GridviewSach
            // 
            this.GridviewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewSach.Location = new System.Drawing.Point(10, 58);
            this.GridviewSach.Name = "GridviewSach";
            this.GridviewSach.RowHeadersWidth = 51;
            this.GridviewSach.RowTemplate.Height = 24;
            this.GridviewSach.Size = new System.Drawing.Size(1396, 222);
            this.GridviewSach.TabIndex = 27;
            this.GridviewSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridviewSach_CellMouseClick);
            // 
            // matacgiacombobox
            // 
            this.matacgiacombobox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matacgiacombobox.ForeColor = System.Drawing.Color.Red;
            this.matacgiacombobox.FormattingEnabled = true;
            this.matacgiacombobox.Location = new System.Drawing.Point(197, 142);
            this.matacgiacombobox.Name = "matacgiacombobox";
            this.matacgiacombobox.Size = new System.Drawing.Size(278, 30);
            this.matacgiacombobox.TabIndex = 2;
            // 
            // theloaicombobox
            // 
            this.theloaicombobox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theloaicombobox.ForeColor = System.Drawing.Color.Red;
            this.theloaicombobox.FormattingEnabled = true;
            this.theloaicombobox.Location = new System.Drawing.Point(197, 220);
            this.theloaicombobox.Name = "theloaicombobox";
            this.theloaicombobox.Size = new System.Drawing.Size(278, 30);
            this.theloaicombobox.TabIndex = 3;
            // 
            // nhaxuatbancombobox
            // 
            this.nhaxuatbancombobox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaxuatbancombobox.ForeColor = System.Drawing.Color.Red;
            this.nhaxuatbancombobox.FormattingEnabled = true;
            this.nhaxuatbancombobox.Location = new System.Drawing.Point(197, 257);
            this.nhaxuatbancombobox.Name = "nhaxuatbancombobox";
            this.nhaxuatbancombobox.Size = new System.Drawing.Size(278, 30);
            this.nhaxuatbancombobox.TabIndex = 4;
            // 
            // Xóa
            // 
            this.Xóa.AutoSize = true;
            this.Xóa.BackColor = System.Drawing.Color.Snow;
            this.Xóa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xóa.Image = global::ThuVien.Properties.Resources.icons8_delete_35;
            this.Xóa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xóa.Location = new System.Drawing.Point(261, 64);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(159, 64);
            this.Xóa.TabIndex = 2;
            this.Xóa.Text = "Xóa Sách";
            this.Xóa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Xóa.UseVisualStyleBackColor = false;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // btnsuasach
            // 
            this.btnsuasach.AutoSize = true;
            this.btnsuasach.BackColor = System.Drawing.Color.Snow;
            this.btnsuasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuasach.Image = global::ThuVien.Properties.Resources.icons8_support_35;
            this.btnsuasach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuasach.Location = new System.Drawing.Point(35, 64);
            this.btnsuasach.Name = "btnsuasach";
            this.btnsuasach.Size = new System.Drawing.Size(159, 64);
            this.btnsuasach.TabIndex = 0;
            this.btnsuasach.Text = "Sửa Sách";
            this.btnsuasach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsuasach.UseVisualStyleBackColor = false;
            this.btnsuasach.Click += new System.EventHandler(this.btnsuasach_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoSize = true;
            this.btnLamMoi.BackColor = System.Drawing.Color.Snow;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::ThuVien.Properties.Resources.icons8_synchronize_35;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(261, 157);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(159, 59);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // timkiemtextbox
            // 
            this.timkiemtextbox.Location = new System.Drawing.Point(381, 31);
            this.timkiemtextbox.Name = "timkiemtextbox";
            this.timkiemtextbox.Size = new System.Drawing.Size(273, 24);
            this.timkiemtextbox.TabIndex = 0;
            this.timkiemtextbox.TextChanged += new System.EventHandler(this.timkiemtextbox_TextChanged);
            // 
            // MaSachlbl
            // 
            this.MaSachlbl.AutoSize = true;
            this.MaSachlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSachlbl.Location = new System.Drawing.Point(18, 64);
            this.MaSachlbl.Name = "MaSachlbl";
            this.MaSachlbl.Size = new System.Drawing.Size(94, 20);
            this.MaSachlbl.TabIndex = 38;
            this.MaSachlbl.Text = "Mã Sách :";
            // 
            // Tensachlb
            // 
            this.Tensachlb.AutoSize = true;
            this.Tensachlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tensachlb.Location = new System.Drawing.Point(18, 111);
            this.Tensachlb.Name = "Tensachlb";
            this.Tensachlb.Size = new System.Drawing.Size(100, 20);
            this.Tensachlb.TabIndex = 39;
            this.Tensachlb.Text = "Tên Sách :";
            // 
            // nhaxuatbanlb
            // 
            this.nhaxuatbanlb.AutoSize = true;
            this.nhaxuatbanlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaxuatbanlb.Location = new System.Drawing.Point(18, 267);
            this.nhaxuatbanlb.Name = "nhaxuatbanlb";
            this.nhaxuatbanlb.Size = new System.Drawing.Size(137, 20);
            this.nhaxuatbanlb.TabIndex = 40;
            this.nhaxuatbanlb.Text = "Nhà Xuất Bản :";
            // 
            // masachtb
            // 
            this.masachtb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masachtb.ForeColor = System.Drawing.Color.Red;
            this.masachtb.Location = new System.Drawing.Point(197, 64);
            this.masachtb.Multiline = true;
            this.masachtb.Name = "masachtb";
            this.masachtb.Size = new System.Drawing.Size(278, 28);
            this.masachtb.TabIndex = 0;
            // 
            // tensachtb
            // 
            this.tensachtb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensachtb.ForeColor = System.Drawing.Color.Red;
            this.tensachtb.Location = new System.Drawing.Point(197, 103);
            this.tensachtb.Name = "tensachtb";
            this.tensachtb.Size = new System.Drawing.Size(278, 30);
            this.tensachtb.TabIndex = 1;
            // 
            // Namxuatbantb
            // 
            this.Namxuatbantb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namxuatbantb.ForeColor = System.Drawing.Color.Red;
            this.Namxuatbantb.Location = new System.Drawing.Point(197, 301);
            this.Namxuatbantb.Name = "Namxuatbantb";
            this.Namxuatbantb.Size = new System.Drawing.Size(278, 30);
            this.Namxuatbantb.TabIndex = 5;
            // 
            // Tacgialb
            // 
            this.Tacgialb.AutoSize = true;
            this.Tacgialb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tacgialb.Location = new System.Drawing.Point(18, 152);
            this.Tacgialb.Name = "Tacgialb";
            this.Tacgialb.Size = new System.Drawing.Size(87, 20);
            this.Tacgialb.TabIndex = 44;
            this.Tacgialb.Text = "Tác Giả :";
            // 
            // theloailb
            // 
            this.theloailb.AutoSize = true;
            this.theloailb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theloailb.Location = new System.Drawing.Point(18, 226);
            this.theloailb.Name = "theloailb";
            this.theloailb.Size = new System.Drawing.Size(94, 20);
            this.theloailb.TabIndex = 45;
            this.theloailb.Text = "Thể Loại :";
            // 
            // namxuatbanlb
            // 
            this.namxuatbanlb.AutoSize = true;
            this.namxuatbanlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namxuatbanlb.Location = new System.Drawing.Point(18, 309);
            this.namxuatbanlb.Name = "namxuatbanlb";
            this.namxuatbanlb.Size = new System.Drawing.Size(142, 20);
            this.namxuatbanlb.TabIndex = 46;
            this.namxuatbanlb.Text = "Năm Xuất Bản :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.soluongtextbox);
            this.groupBox1.Controls.Add(this.lblSoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.matacgiacombobox);
            this.groupBox1.Controls.Add(this.nhaxuatbanlb);
            this.groupBox1.Controls.Add(this.tensachtb);
            this.groupBox1.Controls.Add(this.Tensachlb);
            this.groupBox1.Controls.Add(this.namxuatbanlb);
            this.groupBox1.Controls.Add(this.masachtb);
            this.groupBox1.Controls.Add(this.Tacgialb);
            this.groupBox1.Controls.Add(this.MaSachlbl);
            this.groupBox1.Controls.Add(this.nhaxuatbancombobox);
            this.groupBox1.Controls.Add(this.Namxuatbantb);
            this.groupBox1.Controls.Add(this.theloailb);
            this.groupBox1.Controls.Add(this.theloaicombobox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // soluongtextbox
            // 
            this.soluongtextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongtextbox.ForeColor = System.Drawing.Color.Red;
            this.soluongtextbox.Location = new System.Drawing.Point(197, 184);
            this.soluongtextbox.Name = "soluongtextbox";
            this.soluongtextbox.Size = new System.Drawing.Size(278, 30);
            this.soluongtextbox.TabIndex = 49;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(18, 190);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(154, 20);
            this.lblSoluong.TabIndex = 48;
            this.lblSoluong.Text = "Số Lượng Sách  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Thông tin quyển sách";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.btnloadfile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnsuasach);
            this.groupBox2.Controls.Add(this.Xóa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(949, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 388);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // btnloadfile
            // 
            this.btnloadfile.BackColor = System.Drawing.Color.Snow;
            this.btnloadfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnloadfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadfile.Image = global::ThuVien.Properties.Resources.icons8_export_excel_35;
            this.btnloadfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloadfile.Location = new System.Drawing.Point(158, 257);
            this.btnloadfile.Name = "btnloadfile";
            this.btnloadfile.Size = new System.Drawing.Size(159, 62);
            this.btnloadfile.TabIndex = 4;
            this.btnloadfile.Text = "Export Excel";
            this.btnloadfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnloadfile.UseVisualStyleBackColor = false;
            this.btnloadfile.Click += new System.EventHandler(this.btnloadfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(163, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.GridviewSach);
            this.groupBox3.Controls.Add(this.timkiemtextbox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1412, 286);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ThuVien.Properties.Resources.icons8_search_35;
            this.pictureBox2.Location = new System.Drawing.Point(73, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(112, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tìm kiếm thông tin :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(58, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1418, 689);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThuVien.Properties.Resources.sách;
            this.pictureBox1.Location = new System.Drawing.Point(502, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.AutoEllipsis = true;
            this.btnback.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnback.BackColor = System.Drawing.SystemColors.Control;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Image = global::ThuVien.Properties.Resources.home3;
            this.btnback.Location = new System.Drawing.Point(-2, -3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(44, 43);
            this.btnback.TabIndex = 34;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Sach
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::ThuVien.Properties.Resources.sách;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1501, 781);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridviewSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridviewSach;
        private System.Windows.Forms.ComboBox matacgiacombobox;
        private System.Windows.Forms.ComboBox theloaicombobox;
        private System.Windows.Forms.ComboBox nhaxuatbancombobox;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.Button btnsuasach;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox timkiemtextbox;
        private System.Windows.Forms.Label MaSachlbl;
        private System.Windows.Forms.Label Tensachlb;
        private System.Windows.Forms.Label nhaxuatbanlb;
        private System.Windows.Forms.TextBox masachtb;
        private System.Windows.Forms.TextBox tensachtb;
        private System.Windows.Forms.TextBox Namxuatbantb;
        private System.Windows.Forms.Label Tacgialb;
        private System.Windows.Forms.Label theloailb;
        private System.Windows.Forms.Label namxuatbanlb;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnloadfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox soluongtextbox;
        private System.Windows.Forms.Label lblSoluong;
    }
}