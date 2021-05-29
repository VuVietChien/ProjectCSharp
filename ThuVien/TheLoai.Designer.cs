namespace ThuVien
{
    partial class TheLoai
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maTheLoaitextBox = new System.Windows.Forms.TextBox();
            this.tenTheLoaitextBox = new System.Windows.Forms.TextBox();
            this.TimkiemtextBox = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::ThuVien.Properties.Resources.icons8_search_20;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(415, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maTheLoaitextBox
            // 
            this.maTheLoaitextBox.Location = new System.Drawing.Point(160, 36);
            this.maTheLoaitextBox.Name = "maTheLoaitextBox";
            this.maTheLoaitextBox.Size = new System.Drawing.Size(138, 22);
            this.maTheLoaitextBox.TabIndex = 3;
            // 
            // tenTheLoaitextBox
            // 
            this.tenTheLoaitextBox.Location = new System.Drawing.Point(161, 82);
            this.tenTheLoaitextBox.Name = "tenTheLoaitextBox";
            this.tenTheLoaitextBox.Size = new System.Drawing.Size(138, 22);
            this.tenTheLoaitextBox.TabIndex = 4;
            // 
            // TimkiemtextBox
            // 
            this.TimkiemtextBox.Location = new System.Drawing.Point(562, 37);
            this.TimkiemtextBox.Multiline = true;
            this.TimkiemtextBox.Name = "TimkiemtextBox";
            this.TimkiemtextBox.Size = new System.Drawing.Size(177, 33);
            this.TimkiemtextBox.TabIndex = 5;
            this.TimkiemtextBox.TextChanged += new System.EventHandler(this.TimkiemtextBox_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = global::ThuVien.Properties.Resources.icons8_add_book_35;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnthem.Location = new System.Drawing.Point(29, 320);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(129, 53);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = global::ThuVien.Properties.Resources.icons8_support_35;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsua.Location = new System.Drawing.Point(198, 320);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(129, 53);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = global::ThuVien.Properties.Resources.icons8_delete_35;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnxoa.Location = new System.Drawing.Point(198, 382);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(132, 49);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Image = global::ThuVien.Properties.Resources.icons8_synchronize_35;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnlammoi.Location = new System.Drawing.Point(29, 383);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(132, 48);
            this.btnlammoi.TabIndex = 9;
            this.btnlammoi.Text = "Reset";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(376, 339);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.TimkiemtextBox);
            this.groupBox1.Location = new System.Drawing.Point(60, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 452);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThuVien.Properties.Resources.từ_vựng_về_thư_viện_300x200;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.tenTheLoaitextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maTheLoaitextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 127);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(295, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 49);
            this.label4.TabIndex = 14;
            this.label4.Text = "Các Thể Loại Sách";
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnback.Image = global::ThuVien.Properties.Resources._188797746_378192953613005_3137058549730593592_n;
            this.btnback.Location = new System.Drawing.Point(1, 1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(42, 43);
            this.btnback.TabIndex = 10;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ThuVien.Properties.Resources.thuvien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnback);
            this.Name = "TheLoai";
            this.Text = "TheLoai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maTheLoaitextBox;
        private System.Windows.Forms.TextBox tenTheLoaitextBox;
        private System.Windows.Forms.TextBox TimkiemtextBox;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}