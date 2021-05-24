
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
            this.sachDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSachTextBox = new System.Windows.Forms.TextBox();
            this.tenSachTextBox = new System.Windows.Forms.TextBox();
            this.maTacGiaTextBox = new System.Windows.Forms.TextBox();
            this.maTheLoaiTextBox = new System.Windows.Forms.TextBox();
            this.maNXBTextBox = new System.Windows.Forms.TextBox();
            this.namXuatBanTextBox = new System.Windows.Forms.TextBox();
            maSachLabel = new System.Windows.Forms.Label();
            tenSachLabel = new System.Windows.Forms.Label();
            maTacGiaLabel = new System.Windows.Forms.Label();
            maTheLoaiLabel = new System.Windows.Forms.Label();
            maNXBLabel = new System.Windows.Forms.Label();
            namXuatBanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectCSharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem.Location = new System.Drawing.Point(129, 293);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Them Sach";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // sachDataGridView
            // 
            this.sachDataGridView.AutoGenerateColumns = false;
            this.sachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sachDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sachDataGridView.DataSource = this.sachBindingSource;
            this.sachDataGridView.Location = new System.Drawing.Point(96, 341);
            this.sachDataGridView.Name = "sachDataGridView";
            this.sachDataGridView.RowHeadersWidth = 51;
            this.sachDataGridView.RowTemplate.Height = 24;
            this.sachDataGridView.Size = new System.Drawing.Size(663, 220);
            this.sachDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSach";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenSach";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaTacGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaTacGia";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaTheLoai";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaTheLoai";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaNXB";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaNXB";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NamXuatBan";
            this.dataGridViewTextBoxColumn6.HeaderText = "NamXuatBan";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // maSachLabel
            // 
            maSachLabel.AutoSize = true;
            maSachLabel.Location = new System.Drawing.Point(93, 64);
            maSachLabel.Name = "maSachLabel";
            maSachLabel.Size = new System.Drawing.Size(67, 17);
            maSachLabel.TabIndex = 14;
            maSachLabel.Text = "Ma Sach:";
            // 
            // maSachTextBox
            // 
            this.maSachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "MaSach", true));
            this.maSachTextBox.Location = new System.Drawing.Point(202, 61);
            this.maSachTextBox.Name = "maSachTextBox";
            this.maSachTextBox.Size = new System.Drawing.Size(100, 22);
            this.maSachTextBox.TabIndex = 15;
            // 
            // tenSachLabel
            // 
            tenSachLabel.AutoSize = true;
            tenSachLabel.Location = new System.Drawing.Point(93, 92);
            tenSachLabel.Name = "tenSachLabel";
            tenSachLabel.Size = new System.Drawing.Size(73, 17);
            tenSachLabel.TabIndex = 16;
            tenSachLabel.Text = "Ten Sach:";
            // 
            // tenSachTextBox
            // 
            this.tenSachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "TenSach", true));
            this.tenSachTextBox.Location = new System.Drawing.Point(202, 89);
            this.tenSachTextBox.Name = "tenSachTextBox";
            this.tenSachTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenSachTextBox.TabIndex = 17;
            // 
            // maTacGiaLabel
            // 
            maTacGiaLabel.AutoSize = true;
            maTacGiaLabel.Location = new System.Drawing.Point(93, 120);
            maTacGiaLabel.Name = "maTacGiaLabel";
            maTacGiaLabel.Size = new System.Drawing.Size(85, 17);
            maTacGiaLabel.TabIndex = 18;
            maTacGiaLabel.Text = "Ma Tac Gia:";
            // 
            // maTacGiaTextBox
            // 
            this.maTacGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "MaTacGia", true));
            this.maTacGiaTextBox.Location = new System.Drawing.Point(202, 117);
            this.maTacGiaTextBox.Name = "maTacGiaTextBox";
            this.maTacGiaTextBox.Size = new System.Drawing.Size(100, 22);
            this.maTacGiaTextBox.TabIndex = 19;
            // 
            // maTheLoaiLabel
            // 
            maTheLoaiLabel.AutoSize = true;
            maTheLoaiLabel.Location = new System.Drawing.Point(93, 148);
            maTheLoaiLabel.Name = "maTheLoaiLabel";
            maTheLoaiLabel.Size = new System.Drawing.Size(91, 17);
            maTheLoaiLabel.TabIndex = 20;
            maTheLoaiLabel.Text = "Ma The Loai:";
            // 
            // maTheLoaiTextBox
            // 
            this.maTheLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "MaTheLoai", true));
            this.maTheLoaiTextBox.Location = new System.Drawing.Point(202, 145);
            this.maTheLoaiTextBox.Name = "maTheLoaiTextBox";
            this.maTheLoaiTextBox.Size = new System.Drawing.Size(100, 22);
            this.maTheLoaiTextBox.TabIndex = 21;
            // 
            // maNXBLabel
            // 
            maNXBLabel.AutoSize = true;
            maNXBLabel.Location = new System.Drawing.Point(93, 176);
            maNXBLabel.Name = "maNXBLabel";
            maNXBLabel.Size = new System.Drawing.Size(63, 17);
            maNXBLabel.TabIndex = 22;
            maNXBLabel.Text = "Ma NXB:";
            // 
            // maNXBTextBox
            // 
            this.maNXBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "MaNXB", true));
            this.maNXBTextBox.Location = new System.Drawing.Point(202, 173);
            this.maNXBTextBox.Name = "maNXBTextBox";
            this.maNXBTextBox.Size = new System.Drawing.Size(100, 22);
            this.maNXBTextBox.TabIndex = 23;
            // 
            // namXuatBanLabel
            // 
            namXuatBanLabel.AutoSize = true;
            namXuatBanLabel.Location = new System.Drawing.Point(93, 204);
            namXuatBanLabel.Name = "namXuatBanLabel";
            namXuatBanLabel.Size = new System.Drawing.Size(103, 17);
            namXuatBanLabel.TabIndex = 24;
            namXuatBanLabel.Text = "Nam Xuat Ban:";
            // 
            // namXuatBanTextBox
            // 
            this.namXuatBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "NamXuatBan", true));
            this.namXuatBanTextBox.Location = new System.Drawing.Point(202, 201);
            this.namXuatBanTextBox.Name = "namXuatBanTextBox";
            this.namXuatBanTextBox.Size = new System.Drawing.Size(100, 22);
            this.namXuatBanTextBox.TabIndex = 25;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(maSachLabel);
            this.Controls.Add(this.maSachTextBox);
            this.Controls.Add(tenSachLabel);
            this.Controls.Add(this.tenSachTextBox);
            this.Controls.Add(maTacGiaLabel);
            this.Controls.Add(this.maTacGiaTextBox);
            this.Controls.Add(maTheLoaiLabel);
            this.Controls.Add(this.maTheLoaiTextBox);
            this.Controls.Add(maNXBLabel);
            this.Controls.Add(this.maNXBTextBox);
            this.Controls.Add(namXuatBanLabel);
            this.Controls.Add(this.namXuatBanTextBox);
            this.Controls.Add(this.sachDataGridView);
            this.Controls.Add(this.btnThem);
            this.Name = "Sach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectCSharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectCSharpDataSet projectCSharpDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private ProjectCSharpDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private ProjectCSharpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView sachDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox maSachTextBox;
        private System.Windows.Forms.TextBox tenSachTextBox;
        private System.Windows.Forms.TextBox maTacGiaTextBox;
        private System.Windows.Forms.TextBox maTheLoaiTextBox;
        private System.Windows.Forms.TextBox maNXBTextBox;
        private System.Windows.Forms.TextBox namXuatBanTextBox;
    }
}