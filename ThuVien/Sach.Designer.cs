
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
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(38, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 50);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm Sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 43);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bảng Quản Lý Sách";
            // 
            // GridviewSach
            // 
            this.GridviewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewSach.Location = new System.Drawing.Point(0, 61);
            this.GridviewSach.Name = "GridviewSach";
            this.GridviewSach.RowHeadersWidth = 51;
            this.GridviewSach.RowTemplate.Height = 24;
            this.GridviewSach.Size = new System.Drawing.Size(1062, 193);
            this.GridviewSach.TabIndex = 27;
            this.GridviewSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridviewSach_CellMouseClick);
            // 
            // matacgiacombobox
            // 
            this.matacgiacombobox.FormattingEnabled = true;
            this.matacgiacombobox.Location = new System.Drawing.Point(156, 173);
            this.matacgiacombobox.Name = "matacgiacombobox";
            this.matacgiacombobox.Size = new System.Drawing.Size(229, 30);
            this.matacgiacombobox.TabIndex = 28;
            // 
            // theloaicombobox
            // 
            this.theloaicombobox.FormattingEnabled = true;
            this.theloaicombobox.Location = new System.Drawing.Point(156, 220);
            this.theloaicombobox.Name = "theloaicombobox";
            this.theloaicombobox.Size = new System.Drawing.Size(229, 30);
            this.theloaicombobox.TabIndex = 29;
            // 
            // nhaxuatbancombobox
            // 
            this.nhaxuatbancombobox.FormattingEnabled = true;
            this.nhaxuatbancombobox.Location = new System.Drawing.Point(156, 282);
            this.nhaxuatbancombobox.Name = "nhaxuatbancombobox";
            this.nhaxuatbancombobox.Size = new System.Drawing.Size(229, 30);
            this.nhaxuatbancombobox.TabIndex = 30;
            // 
            // Xóa
            // 
            this.Xóa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xóa.Location = new System.Drawing.Point(260, 71);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(121, 50);
            this.Xóa.TabIndex = 31;
            this.Xóa.Text = "Xóa Sách";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // btnsuasach
            // 
            this.btnsuasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuasach.Location = new System.Drawing.Point(38, 71);
            this.btnsuasach.Name = "btnsuasach";
            this.btnsuasach.Size = new System.Drawing.Size(121, 50);
            this.btnsuasach.TabIndex = 32;
            this.btnsuasach.Text = "Sửa Sách";
            this.btnsuasach.UseVisualStyleBackColor = true;
            this.btnsuasach.Click += new System.EventHandler(this.btnsuasach_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(260, 159);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(121, 50);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // timkiemtextbox
            // 
            this.timkiemtextbox.Location = new System.Drawing.Point(312, 27);
            this.timkiemtextbox.Name = "timkiemtextbox";
            this.timkiemtextbox.Size = new System.Drawing.Size(273, 24);
            this.timkiemtextbox.TabIndex = 36;
            this.timkiemtextbox.TextChanged += new System.EventHandler(this.timkiemtextbox_TextChanged);
            // 
            // MaSachlbl
            // 
            this.MaSachlbl.AutoSize = true;
            this.MaSachlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSachlbl.Location = new System.Drawing.Point(6, 84);
            this.MaSachlbl.Name = "MaSachlbl";
            this.MaSachlbl.Size = new System.Drawing.Size(82, 20);
            this.MaSachlbl.TabIndex = 38;
            this.MaSachlbl.Text = "Mã Sách";
            // 
            // Tensachlb
            // 
            this.Tensachlb.AutoSize = true;
            this.Tensachlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tensachlb.Location = new System.Drawing.Point(6, 125);
            this.Tensachlb.Name = "Tensachlb";
            this.Tensachlb.Size = new System.Drawing.Size(88, 20);
            this.Tensachlb.TabIndex = 39;
            this.Tensachlb.Text = "Tên Sách";
            // 
            // nhaxuatbanlb
            // 
            this.nhaxuatbanlb.AutoSize = true;
            this.nhaxuatbanlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaxuatbanlb.Location = new System.Drawing.Point(6, 292);
            this.nhaxuatbanlb.Name = "nhaxuatbanlb";
            this.nhaxuatbanlb.Size = new System.Drawing.Size(125, 20);
            this.nhaxuatbanlb.TabIndex = 40;
            this.nhaxuatbanlb.Text = "Nhà Xuất Bản";
            // 
            // masachtb
            // 
            this.masachtb.Location = new System.Drawing.Point(156, 79);
            this.masachtb.Name = "masachtb";
            this.masachtb.Size = new System.Drawing.Size(229, 28);
            this.masachtb.TabIndex = 41;
            // 
            // tensachtb
            // 
            this.tensachtb.Location = new System.Drawing.Point(156, 117);
            this.tensachtb.Name = "tensachtb";
            this.tensachtb.Size = new System.Drawing.Size(229, 28);
            this.tensachtb.TabIndex = 42;
            // 
            // Namxuatbantb
            // 
            this.Namxuatbantb.Location = new System.Drawing.Point(156, 328);
            this.Namxuatbantb.Name = "Namxuatbantb";
            this.Namxuatbantb.Size = new System.Drawing.Size(229, 28);
            this.Namxuatbantb.TabIndex = 43;
            // 
            // Tacgialb
            // 
            this.Tacgialb.AutoSize = true;
            this.Tacgialb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tacgialb.Location = new System.Drawing.Point(6, 183);
            this.Tacgialb.Name = "Tacgialb";
            this.Tacgialb.Size = new System.Drawing.Size(75, 20);
            this.Tacgialb.TabIndex = 44;
            this.Tacgialb.Text = "Tác Giả";
            // 
            // theloailb
            // 
            this.theloailb.AutoSize = true;
            this.theloailb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theloailb.Location = new System.Drawing.Point(6, 230);
            this.theloailb.Name = "theloailb";
            this.theloailb.Size = new System.Drawing.Size(82, 20);
            this.theloailb.TabIndex = 45;
            this.theloailb.Text = "Thể Loại";
            // 
            // namxuatbanlb
            // 
            this.namxuatbanlb.AutoSize = true;
            this.namxuatbanlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namxuatbanlb.Location = new System.Drawing.Point(6, 336);
            this.namxuatbanlb.Name = "namxuatbanlb";
            this.namxuatbanlb.Size = new System.Drawing.Size(130, 20);
            this.namxuatbanlb.TabIndex = 46;
            this.namxuatbanlb.Text = "Năm Xuất Bản";
            // 
            // btnback
            // 
            this.btnback.AutoEllipsis = true;
            this.btnback.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnback.BackColor = System.Drawing.SystemColors.Control;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 367);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnsuasach);
            this.groupBox2.Controls.Add(this.Xóa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(667, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 242);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.GridviewSach);
            this.groupBox3.Controls.Add(this.timkiemtextbox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(34, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1047, 269);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(58, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1081, 689);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(214, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Thông tin quyển sách";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(138, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Chức năng";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1164, 781);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Sach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridviewSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private ProjectCSharpDataSet projectCSharpDataSet;
        //private System.Windows.Forms.BindingSource sachBindingSource;
        //private ProjectCSharpDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        //private ProjectCSharpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThem;
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
    }
}