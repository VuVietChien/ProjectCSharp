
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maSachLabel;
            System.Windows.Forms.Label tenSachLabel;
            System.Windows.Forms.Label maTacGiaLabel;
            System.Windows.Forms.Label maTheLoaiLabel;
            System.Windows.Forms.Label maNXBLabel;
            System.Windows.Forms.Label namXuatBanLabel;
            this.projectCSharpDataSet = new ThuVien.ProjectCSharpDataSet();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new ThuVien.ProjectCSharpDataSetTableAdapters.SachTableAdapter();
            this.tableAdapterManager = new ThuVien.ProjectCSharpDataSetTableAdapters.TableAdapterManager();
            this.btnThem = new System.Windows.Forms.Button();
            this.maSachTextBox = new System.Windows.Forms.TextBox();
            this.tenSachTextBox = new System.Windows.Forms.TextBox();
            this.namXuatBanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridviewSach = new System.Windows.Forms.DataGridView();
            this.matacgiacombobox = new System.Windows.Forms.ComboBox();
            this.theloaicombobox = new System.Windows.Forms.ComboBox();
            this.nhaxuatbancombobox = new System.Windows.Forms.ComboBox();
            this.Xóa = new System.Windows.Forms.Button();
            this.btnsuasach = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.timkiemtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            maSachLabel = new System.Windows.Forms.Label();
            tenSachLabel = new System.Windows.Forms.Label();
            maTacGiaLabel = new System.Windows.Forms.Label();
            maTheLoaiLabel = new System.Windows.Forms.Label();
            maNXBLabel = new System.Windows.Forms.Label();
            namXuatBanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectCSharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // maSachLabel
            // 
            maSachLabel.AutoSize = true;
            maSachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSachLabel.Location = new System.Drawing.Point(168, 95);
            maSachLabel.Name = "maSachLabel";
            maSachLabel.Size = new System.Drawing.Size(94, 20);
            maSachLabel.TabIndex = 14;
            maSachLabel.Text = "Mã Sách :";
            // 
            // tenSachLabel
            // 
            tenSachLabel.AutoSize = true;
            tenSachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSachLabel.Location = new System.Drawing.Point(168, 133);
            tenSachLabel.Name = "tenSachLabel";
            tenSachLabel.Size = new System.Drawing.Size(100, 20);
            tenSachLabel.TabIndex = 16;
            tenSachLabel.Text = "Tên Sách :";
            // 
            // maTacGiaLabel
            // 
            maTacGiaLabel.AutoSize = true;
            maTacGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maTacGiaLabel.Location = new System.Drawing.Point(710, 99);
            maTacGiaLabel.Name = "maTacGiaLabel";
            maTacGiaLabel.Size = new System.Drawing.Size(87, 20);
            maTacGiaLabel.TabIndex = 18;
            maTacGiaLabel.Text = "Tác Giả :";
            // 
            // maTheLoaiLabel
            // 
            maTheLoaiLabel.AutoSize = true;
            maTheLoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maTheLoaiLabel.Location = new System.Drawing.Point(710, 133);
            maTheLoaiLabel.Name = "maTheLoaiLabel";
            maTheLoaiLabel.Size = new System.Drawing.Size(94, 20);
            maTheLoaiLabel.TabIndex = 20;
            maTheLoaiLabel.Text = "Thể Loại :";
            // 
            // maNXBLabel
            // 
            maNXBLabel.AutoSize = true;
            maNXBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNXBLabel.Location = new System.Drawing.Point(168, 171);
            maNXBLabel.Name = "maNXBLabel";
            maNXBLabel.Size = new System.Drawing.Size(137, 20);
            maNXBLabel.TabIndex = 22;
            maNXBLabel.Text = "Nhà Xuất Bản :";
            // 
            // namXuatBanLabel
            // 
            namXuatBanLabel.AutoSize = true;
            namXuatBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namXuatBanLabel.Location = new System.Drawing.Point(710, 179);
            namXuatBanLabel.Name = "namXuatBanLabel";
            namXuatBanLabel.Size = new System.Drawing.Size(142, 20);
            namXuatBanLabel.TabIndex = 24;
            namXuatBanLabel.Text = "Năm Xuất Bản :";
            // 
            // projectCSharpDataSet
            // 
            this.projectCSharpDataSet.DataSetName = "ProjectCSharpDataSet";
            this.projectCSharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.projectCSharpDataSet;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.MuonTraTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhaXuatBanTableAdapter = null;
            this.tableAdapterManager.SachTableAdapter = this.sachTableAdapter;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TheLoaiTableAdapter = null;
            this.tableAdapterManager.TheThuVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuVien.ProjectCSharpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(171, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 50);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm Sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // maSachTextBox
            // 
            this.maSachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "MaSach", true));
            this.maSachTextBox.Location = new System.Drawing.Point(311, 92);
            this.maSachTextBox.Name = "maSachTextBox";
            this.maSachTextBox.Size = new System.Drawing.Size(100, 22);
            this.maSachTextBox.TabIndex = 15;
            // 
            // tenSachTextBox
            // 
            this.tenSachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "TenSach", true));
            this.tenSachTextBox.Location = new System.Drawing.Point(311, 131);
            this.tenSachTextBox.Name = "tenSachTextBox";
            this.tenSachTextBox.Size = new System.Drawing.Size(195, 22);
            this.tenSachTextBox.TabIndex = 17;
            // 
            // namXuatBanTextBox
            // 
            this.namXuatBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "NamXuatBan", true));
            this.namXuatBanTextBox.Location = new System.Drawing.Point(881, 177);
            this.namXuatBanTextBox.Name = "namXuatBanTextBox";
            this.namXuatBanTextBox.Size = new System.Drawing.Size(159, 22);
            this.namXuatBanTextBox.TabIndex = 25;
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
            this.GridviewSach.Location = new System.Drawing.Point(96, 385);
            this.GridviewSach.Name = "GridviewSach";
            this.GridviewSach.RowHeadersWidth = 51;
            this.GridviewSach.RowTemplate.Height = 24;
            this.GridviewSach.Size = new System.Drawing.Size(982, 150);
            this.GridviewSach.TabIndex = 27;
            this.GridviewSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridviewSach_CellMouseClick);
            // 
            // matacgiacombobox
            // 
            this.matacgiacombobox.FormattingEnabled = true;
            this.matacgiacombobox.Location = new System.Drawing.Point(833, 92);
            this.matacgiacombobox.Name = "matacgiacombobox";
            this.matacgiacombobox.Size = new System.Drawing.Size(198, 24);
            this.matacgiacombobox.TabIndex = 28;
            // 
            // theloaicombobox
            // 
            this.theloaicombobox.FormattingEnabled = true;
            this.theloaicombobox.Location = new System.Drawing.Point(833, 133);
            this.theloaicombobox.Name = "theloaicombobox";
            this.theloaicombobox.Size = new System.Drawing.Size(198, 24);
            this.theloaicombobox.TabIndex = 29;
            // 
            // nhaxuatbancombobox
            // 
            this.nhaxuatbancombobox.FormattingEnabled = true;
            this.nhaxuatbancombobox.Location = new System.Drawing.Point(311, 167);
            this.nhaxuatbancombobox.Name = "nhaxuatbancombobox";
            this.nhaxuatbancombobox.Size = new System.Drawing.Size(241, 24);
            this.nhaxuatbancombobox.TabIndex = 30;
            // 
            // Xóa
            // 
            this.Xóa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Xóa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xóa.Location = new System.Drawing.Point(622, 232);
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
            this.btnsuasach.Location = new System.Drawing.Point(394, 232);
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
            this.btnLamMoi.Location = new System.Drawing.Point(892, 232);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(121, 50);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.Location = new System.Drawing.Point(1, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(72, 33);
            this.btnback.TabIndex = 34;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // timkiemtextbox
            // 
            this.timkiemtextbox.Location = new System.Drawing.Point(425, 346);
            this.timkiemtextbox.Name = "timkiemtextbox";
            this.timkiemtextbox.Size = new System.Drawing.Size(222, 22);
            this.timkiemtextbox.TabIndex = 36;
            this.timkiemtextbox.TextChanged += new System.EventHandler(this.timkiemtextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tìm kiếm sách :";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timkiemtextbox);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnsuasach);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.nhaxuatbancombobox);
            this.Controls.Add(this.theloaicombobox);
            this.Controls.Add(this.matacgiacombobox);
            this.Controls.Add(this.GridviewSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(maSachLabel);
            this.Controls.Add(this.maSachTextBox);
            this.Controls.Add(tenSachLabel);
            this.Controls.Add(this.tenSachTextBox);
            this.Controls.Add(maTacGiaLabel);
            this.Controls.Add(maTheLoaiLabel);
            this.Controls.Add(maNXBLabel);
            this.Controls.Add(namXuatBanLabel);
            this.Controls.Add(this.namXuatBanTextBox);
            this.Controls.Add(this.btnThem);
            this.Name = "Sach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectCSharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectCSharpDataSet projectCSharpDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private ProjectCSharpDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private ProjectCSharpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox maSachTextBox;
        private System.Windows.Forms.TextBox tenSachTextBox;
        private System.Windows.Forms.TextBox namXuatBanTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridviewSach;
        private System.Windows.Forms.ComboBox matacgiacombobox;
        private System.Windows.Forms.ComboBox theloaicombobox;
        private System.Windows.Forms.ComboBox nhaxuatbancombobox;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.Button btnsuasach;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox timkiemtextbox;
        private System.Windows.Forms.Label label2;
    }
}