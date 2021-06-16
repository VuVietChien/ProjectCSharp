
namespace ThuVien
{
    partial class chi_tiết_mượn_trả
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
            this.ctmuonsach = new System.Windows.Forms.GroupBox();
            this.CTtensach = new System.Windows.Forms.ComboBox();
            this.CTSoLuongMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTMaMuonTra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cttrasachbtn = new System.Windows.Forms.Button();
            this.btnmuonsach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CTngaymuondatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.gridviewCTmuonsach = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ctmuonsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCTmuonsach)).BeginInit();
            this.SuspendLayout();
            // 
            // ctmuonsach
            // 
            this.ctmuonsach.BackColor = System.Drawing.Color.PeachPuff;
            this.ctmuonsach.Controls.Add(this.CTtensach);
            this.ctmuonsach.Controls.Add(this.CTSoLuongMuon);
            this.ctmuonsach.Controls.Add(this.label2);
            this.ctmuonsach.Controls.Add(this.label18);
            this.ctmuonsach.Controls.Add(this.pictureBox1);
            this.ctmuonsach.Controls.Add(this.CTMaMuonTra);
            this.ctmuonsach.Controls.Add(this.label1);
            this.ctmuonsach.Controls.Add(this.label3);
            this.ctmuonsach.Controls.Add(this.cttrasachbtn);
            this.ctmuonsach.Controls.Add(this.btnmuonsach);
            this.ctmuonsach.Controls.Add(this.label4);
            this.ctmuonsach.Controls.Add(this.CTngaymuondatetimepicker);
            this.ctmuonsach.Location = new System.Drawing.Point(12, 82);
            this.ctmuonsach.Name = "ctmuonsach";
            this.ctmuonsach.Size = new System.Drawing.Size(1319, 335);
            this.ctmuonsach.TabIndex = 21;
            this.ctmuonsach.TabStop = false;
            // 
            // CTtensach
            // 
            this.CTtensach.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTtensach.FormattingEnabled = true;
            this.CTtensach.Location = new System.Drawing.Point(322, 142);
            this.CTtensach.Name = "CTtensach";
            this.CTtensach.Size = new System.Drawing.Size(256, 31);
            this.CTtensach.TabIndex = 25;
            // 
            // CTSoLuongMuon
            // 
            this.CTSoLuongMuon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CTSoLuongMuon.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTSoLuongMuon.Location = new System.Drawing.Point(322, 198);
            this.CTSoLuongMuon.Multiline = true;
            this.CTSoLuongMuon.Name = "CTSoLuongMuon";
            this.CTSoLuongMuon.Size = new System.Drawing.Size(256, 30);
            this.CTSoLuongMuon.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số Lượng Mượn :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(6, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(261, 34);
            this.label18.TabIndex = 22;
            this.label18.Text = "Chi tiết mượn sách ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThuVien.Properties.Resources.ảnh_mượn_sách;
            this.pictureBox1.Location = new System.Drawing.Point(876, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // CTMaMuonTra
            // 
            this.CTMaMuonTra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CTMaMuonTra.Enabled = false;
            this.CTMaMuonTra.Font = new System.Drawing.Font("Times New Roman", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTMaMuonTra.Location = new System.Drawing.Point(409, 59);
            this.CTMaMuonTra.Multiline = true;
            this.CTMaMuonTra.Name = "CTMaMuonTra";
            this.CTMaMuonTra.Size = new System.Drawing.Size(54, 50);
            this.CTMaMuonTra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mượn Trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Sách :";
            // 
            // cttrasachbtn
            // 
            this.cttrasachbtn.BackColor = System.Drawing.Color.Aqua;
            this.cttrasachbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cttrasachbtn.Location = new System.Drawing.Point(613, 132);
            this.cttrasachbtn.Name = "cttrasachbtn";
            this.cttrasachbtn.Size = new System.Drawing.Size(212, 59);
            this.cttrasachbtn.TabIndex = 17;
            this.cttrasachbtn.Text = "Xác nhận trả sách";
            this.cttrasachbtn.UseVisualStyleBackColor = false;
            this.cttrasachbtn.Click += new System.EventHandler(this.cttrasachbtn_Click);
            // 
            // btnmuonsach
            // 
            this.btnmuonsach.BackColor = System.Drawing.Color.Yellow;
            this.btnmuonsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmuonsach.Location = new System.Drawing.Point(613, 224);
            this.btnmuonsach.Name = "btnmuonsach";
            this.btnmuonsach.Size = new System.Drawing.Size(212, 59);
            this.btnmuonsach.TabIndex = 17;
            this.btnmuonsach.Text = "xác nhận mượn thêm sách";
            this.btnmuonsach.UseVisualStyleBackColor = false;
            this.btnmuonsach.Click += new System.EventHandler(this.btnmuonsach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Mượn :";
            // 
            // CTngaymuondatetimepicker
            // 
            this.CTngaymuondatetimepicker.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTngaymuondatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CTngaymuondatetimepicker.Location = new System.Drawing.Point(322, 255);
            this.CTngaymuondatetimepicker.Name = "CTngaymuondatetimepicker";
            this.CTngaymuondatetimepicker.Size = new System.Drawing.Size(256, 28);
            this.CTngaymuondatetimepicker.TabIndex = 7;
            // 
            // gridviewCTmuonsach
            // 
            this.gridviewCTmuonsach.AllowUserToAddRows = false;
            this.gridviewCTmuonsach.AllowUserToDeleteRows = false;
            this.gridviewCTmuonsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewCTmuonsach.Location = new System.Drawing.Point(8, 423);
            this.gridviewCTmuonsach.MultiSelect = false;
            this.gridviewCTmuonsach.Name = "gridviewCTmuonsach";
            this.gridviewCTmuonsach.ReadOnly = true;
            this.gridviewCTmuonsach.RowHeadersWidth = 51;
            this.gridviewCTmuonsach.RowTemplate.Height = 24;
            this.gridviewCTmuonsach.Size = new System.Drawing.Size(1323, 332);
            this.gridviewCTmuonsach.TabIndex = 22;
            this.gridviewCTmuonsach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewCTmuonsach_CellMouseClick);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Image = global::ThuVien.Properties.Resources.icons8_back_arrow_40;
            this.btnback.Location = new System.Drawing.Point(-5, -2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 43);
            this.btnback.TabIndex = 26;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(543, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 46);
            this.label5.TabIndex = 27;
            this.label5.Text = "Bảng chi tiết mượn trả";
            // 
            // chi_tiết_mượn_trả
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 767);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.gridviewCTmuonsach);
            this.Controls.Add(this.ctmuonsach);
            this.Name = "chi_tiết_mượn_trả";
            this.Text = "chi_tiết_mượn_trả";
            this.Load += new System.EventHandler(this.chi_tiết_mượn_trả_Load);
            this.ctmuonsach.ResumeLayout(false);
            this.ctmuonsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCTmuonsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ctmuonsach;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CTMaMuonTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmuonsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CTngaymuondatetimepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CTSoLuongMuon;
        private System.Windows.Forms.DataGridView gridviewCTmuonsach;
        private System.Windows.Forms.ComboBox CTtensach;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button cttrasachbtn;
        private System.Windows.Forms.Label label5;
    }
}