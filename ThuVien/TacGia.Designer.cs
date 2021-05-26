
namespace ThuVien
{
    partial class TacGia
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
            System.Windows.Forms.Label maTacGiaLabel;
            System.Windows.Forms.Label tenTacGiaLabel;
            System.Windows.Forms.Label ghiChuLabel;
            this.projectCSharpDataSet = new ThuVien.ProjectCSharpDataSet();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter = new ThuVien.ProjectCSharpDataSetTableAdapters.TacGiaTableAdapter();
            this.tableAdapterManager = new ThuVien.ProjectCSharpDataSetTableAdapters.TableAdapterManager();
            this.maTacGiaTextBox = new System.Windows.Forms.TextBox();
            this.tenTacGiaTextBox = new System.Windows.Forms.TextBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridviewTacGia = new System.Windows.Forms.DataGridView();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            maTacGiaLabel = new System.Windows.Forms.Label();
            tenTacGiaLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectCSharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // maTacGiaLabel
            // 
            maTacGiaLabel.AutoSize = true;
            maTacGiaLabel.Location = new System.Drawing.Point(133, 91);
            maTacGiaLabel.Name = "maTacGiaLabel";
            maTacGiaLabel.Size = new System.Drawing.Size(85, 17);
            maTacGiaLabel.TabIndex = 1;
            maTacGiaLabel.Text = "Ma Tac Gia:";
            // 
            // tenTacGiaLabel
            // 
            tenTacGiaLabel.AutoSize = true;
            tenTacGiaLabel.Location = new System.Drawing.Point(133, 142);
            tenTacGiaLabel.Name = "tenTacGiaLabel";
            tenTacGiaLabel.Size = new System.Drawing.Size(91, 17);
            tenTacGiaLabel.TabIndex = 3;
            tenTacGiaLabel.Text = "Ten Tac Gia:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(133, 191);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(63, 17);
            ghiChuLabel.TabIndex = 5;
            ghiChuLabel.Text = "Ghi Chu:";
            // 
            // projectCSharpDataSet
            // 
            this.projectCSharpDataSet.DataSetName = "ProjectCSharpDataSet";
            this.projectCSharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.projectCSharpDataSet;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.MuonTraTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhaXuatBanTableAdapter = null;
            this.tableAdapterManager.SachTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = this.tacGiaTableAdapter;
            this.tableAdapterManager.TheLoaiTableAdapter = null;
            this.tableAdapterManager.TheThuVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuVien.ProjectCSharpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maTacGiaTextBox
            // 
            this.maTacGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tacGiaBindingSource, "MaTacGia", true));
            this.maTacGiaTextBox.Location = new System.Drawing.Point(249, 91);
            this.maTacGiaTextBox.Name = "maTacGiaTextBox";
            this.maTacGiaTextBox.Size = new System.Drawing.Size(100, 22);
            this.maTacGiaTextBox.TabIndex = 2;
            // 
            // tenTacGiaTextBox
            // 
            this.tenTacGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tacGiaBindingSource, "TenTacGia", true));
            this.tenTacGiaTextBox.Location = new System.Drawing.Point(249, 142);
            this.tenTacGiaTextBox.Name = "tenTacGiaTextBox";
            this.tenTacGiaTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenTacGiaTextBox.TabIndex = 4;
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tacGiaBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(249, 191);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(100, 22);
            this.ghiChuTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 43);
            this.label1.TabIndex = 27;
            this.label1.Text = "Bảng Quản Lý Tác Giả ";
            // 
            // GridviewTacGia
            // 
            this.GridviewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewTacGia.Location = new System.Drawing.Point(49, 288);
            this.GridviewTacGia.Name = "GridviewTacGia";
            this.GridviewTacGia.RowHeadersWidth = 51;
            this.GridviewTacGia.RowTemplate.Height = 24;
            this.GridviewTacGia.Size = new System.Drawing.Size(695, 150);
            this.GridviewTacGia.TabIndex = 28;
            // 
            // btnThemTG
            // 
            this.btnThemTG.Location = new System.Drawing.Point(62, 230);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(114, 41);
            this.btnThemTG.TabIndex = 29;
            this.btnThemTG.Text = "Thêm Tác Giả";
            this.btnThemTG.UseVisualStyleBackColor = true;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(237, 230);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 41);
            this.btnsua.TabIndex = 30;
            this.btnsua.Text = "Sửa Tác Giả";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 31;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(559, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 41);
            this.button4.TabIndex = 32;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThemTG);
            this.Controls.Add(this.GridviewTacGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(maTacGiaLabel);
            this.Controls.Add(this.maTacGiaTextBox);
            this.Controls.Add(tenTacGiaLabel);
            this.Controls.Add(this.tenTacGiaTextBox);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextBox);
            this.Name = "TacGia";
            this.Text = "TacGia";
            this.Load += new System.EventHandler(this.TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectCSharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectCSharpDataSet projectCSharpDataSet;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private ProjectCSharpDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private ProjectCSharpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maTacGiaTextBox;
        private System.Windows.Forms.TextBox tenTacGiaTextBox;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridviewTacGia;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}