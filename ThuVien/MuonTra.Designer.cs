
namespace ThuVien
{
    partial class MuonTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaMuonTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tennhaviencbb = new System.Windows.Forms.ComboBox();
            this.ngaymuondatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.gridviewmuonsach = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sothecbb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grouponsach = new System.Windows.Forms.GroupBox();
            this.timkiemsothe = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewmuonsach)).BeginInit();
            this.grouponsach.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mượn Trả:";
            // 
            // MaMuonTra
            // 
            this.MaMuonTra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MaMuonTra.Enabled = false;
            this.MaMuonTra.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaMuonTra.Location = new System.Drawing.Point(613, 57);
            this.MaMuonTra.Multiline = true;
            this.MaMuonTra.Name = "MaMuonTra";
            this.MaMuonTra.Size = new System.Drawing.Size(70, 49);
            this.MaMuonTra.TabIndex = 1;
            this.MaMuonTra.TextChanged += new System.EventHandler(this.MaMuonTra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Nhân Viên Tạo Mã Mượn Trả  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Mượn :";
            // 
            // tennhaviencbb
            // 
            this.tennhaviencbb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tennhaviencbb.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tennhaviencbb.FormattingEnabled = true;
            this.tennhaviencbb.Location = new System.Drawing.Point(718, 191);
            this.tennhaviencbb.Name = "tennhaviencbb";
            this.tennhaviencbb.Size = new System.Drawing.Size(256, 29);
            this.tennhaviencbb.TabIndex = 6;
            // 
            // ngaymuondatetimepicker
            // 
            this.ngaymuondatetimepicker.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaymuondatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaymuondatetimepicker.Location = new System.Drawing.Point(718, 245);
            this.ngaymuondatetimepicker.Name = "ngaymuondatetimepicker";
            this.ngaymuondatetimepicker.Size = new System.Drawing.Size(256, 28);
            this.ngaymuondatetimepicker.TabIndex = 7;
            // 
            // gridviewmuonsach
            // 
            this.gridviewmuonsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewmuonsach.Location = new System.Drawing.Point(0, 53);
            this.gridviewmuonsach.Name = "gridviewmuonsach";
            this.gridviewmuonsach.RowHeadersWidth = 51;
            this.gridviewmuonsach.RowTemplate.Height = 24;
            this.gridviewmuonsach.Size = new System.Drawing.Size(1306, 194);
            this.gridviewmuonsach.TabIndex = 16;
            this.gridviewmuonsach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewmuonsach_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 85);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thêm người mượn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Thẻ :";
            // 
            // sothecbb
            // 
            this.sothecbb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sothecbb.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothecbb.FormattingEnabled = true;
            this.sothecbb.Location = new System.Drawing.Point(718, 136);
            this.sothecbb.Name = "sothecbb";
            this.sothecbb.Size = new System.Drawing.Size(256, 29);
            this.sothecbb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(547, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(536, 54);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bảng Quản Lý Mượn Trả";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grouponsach
            // 
            this.grouponsach.BackColor = System.Drawing.Color.PeachPuff;
            this.grouponsach.Controls.Add(this.button3);
            this.grouponsach.Controls.Add(this.label18);
            this.grouponsach.Controls.Add(this.MaMuonTra);
            this.grouponsach.Controls.Add(this.label1);
            this.grouponsach.Controls.Add(this.label2);
            this.grouponsach.Controls.Add(this.label3);
            this.grouponsach.Controls.Add(this.button1);
            this.grouponsach.Controls.Add(this.label4);
            this.grouponsach.Controls.Add(this.sothecbb);
            this.grouponsach.Controls.Add(this.tennhaviencbb);
            this.grouponsach.Controls.Add(this.ngaymuondatetimepicker);
            this.grouponsach.Location = new System.Drawing.Point(109, 93);
            this.grouponsach.Name = "grouponsach";
            this.grouponsach.Size = new System.Drawing.Size(1306, 409);
            this.grouponsach.TabIndex = 20;
            this.grouponsach.TabStop = false;
            // 
            // timkiemsothe
            // 
            this.timkiemsothe.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemsothe.ForeColor = System.Drawing.Color.Red;
            this.timkiemsothe.Location = new System.Drawing.Point(788, 12);
            this.timkiemsothe.Multiline = true;
            this.timkiemsothe.Name = "timkiemsothe";
            this.timkiemsothe.Size = new System.Drawing.Size(90, 35);
            this.timkiemsothe.TabIndex = 24;
            this.timkiemsothe.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(394, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(318, 21);
            this.label16.TabIndex = 23;
            this.label16.Text = "Tìm kiếm theo mã mượn trả hoặc số thẻ :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1048, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 85);
            this.button3.TabIndex = 23;
            this.button3.Text = "Thêm sách cho mượn hoặc xác nhận trả sách ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(6, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(382, 34);
            this.label18.TabIndex = 22;
            this.label18.Text = "Bảng thêm người mượn sách";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Image = global::ThuVien.Properties.Resources._188797746_378192953613005_3137058549730593592_n;
            this.btnback.Location = new System.Drawing.Point(0, -2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(42, 43);
            this.btnback.TabIndex = 19;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timkiemsothe);
            this.groupBox3.Controls.Add(this.gridviewmuonsach);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(109, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1306, 247);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng người đang mượn sách :";
            // 
            // MuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThuVien.Properties.Resources.ảnh_mượn_sách;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1516, 779);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grouponsach);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label7);
            this.Name = "MuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn Sách";
            this.Load += new System.EventHandler(this.MuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewmuonsach)).EndInit();
            this.grouponsach.ResumeLayout(false);
            this.grouponsach.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaMuonTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tennhaviencbb;
        private System.Windows.Forms.DateTimePicker ngaymuondatetimepicker;
        private System.Windows.Forms.DataGridView gridviewmuonsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sothecbb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox grouponsach;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox timkiemsothe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}