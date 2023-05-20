namespace PhanHe2_QLNV
{
    partial class QLDA_TDA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemDeAn = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MaDA = new System.Windows.Forms.Label();
            this.TenDA = new System.Windows.Forms.Label();
            this.NgayBD = new System.Windows.Forms.Label();
            this.PhongBan = new System.Windows.Forms.Label();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnThemAcp = new System.Windows.Forms.Button();
            this.btnHuyThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(801, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản Lý Đề Án";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 240);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(649, 389);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(118, 33);
            this.btnDangXuat.TabIndex = 27;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(613, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 38);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemDeAn
            // 
            this.btnThemDeAn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemDeAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDeAn.ForeColor = System.Drawing.Color.Black;
            this.btnThemDeAn.Location = new System.Drawing.Point(613, 87);
            this.btnThemDeAn.Name = "btnThemDeAn";
            this.btnThemDeAn.Size = new System.Drawing.Size(154, 41);
            this.btnThemDeAn.TabIndex = 25;
            this.btnThemDeAn.Text = "Thêm Đề Án";
            this.btnThemDeAn.UseVisualStyleBackColor = false;
            this.btnThemDeAn.Click += new System.EventHandler(this.btnThemDeAn_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(613, 182);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(154, 38);
            this.btnCapNhat.TabIndex = 28;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(235, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quản Lý Đề Án";
            // 
            // MaDA
            // 
            this.MaDA.AutoSize = true;
            this.MaDA.Location = new System.Drawing.Point(46, 99);
            this.MaDA.Name = "MaDA";
            this.MaDA.Size = new System.Drawing.Size(65, 16);
            this.MaDA.TabIndex = 30;
            this.MaDA.Text = "Mã Đề Án";
            // 
            // TenDA
            // 
            this.TenDA.AutoSize = true;
            this.TenDA.Location = new System.Drawing.Point(46, 147);
            this.TenDA.Name = "TenDA";
            this.TenDA.Size = new System.Drawing.Size(70, 16);
            this.TenDA.TabIndex = 31;
            this.TenDA.Text = "Tên Đề Án";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSize = true;
            this.NgayBD.Location = new System.Drawing.Point(296, 99);
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Size = new System.Drawing.Size(90, 16);
            this.NgayBD.TabIndex = 32;
            this.NgayBD.Text = "Ngày Bắt Đầu";
            // 
            // PhongBan
            // 
            this.PhongBan.AutoSize = true;
            this.PhongBan.Location = new System.Drawing.Point(296, 147);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(73, 16);
            this.PhongBan.TabIndex = 33;
            this.PhongBan.Text = "Phòng Ban";
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(122, 141);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(138, 22);
            this.txtTenDA.TabIndex = 34;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(122, 93);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(138, 22);
            this.txtMaDA.TabIndex = 35;
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Location = new System.Drawing.Point(392, 141);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(138, 22);
            this.txtPhongBan.TabIndex = 36;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(392, 96);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(114, 19);
            this.dtpNgayBD.TabIndex = 48;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // btnThemAcp
            // 
            this.btnThemAcp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemAcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAcp.ForeColor = System.Drawing.Color.Black;
            this.btnThemAcp.Location = new System.Drawing.Point(661, 87);
            this.btnThemAcp.Name = "btnThemAcp";
            this.btnThemAcp.Size = new System.Drawing.Size(70, 41);
            this.btnThemAcp.TabIndex = 49;
            this.btnThemAcp.Text = "Thêm Đề Án";
            this.btnThemAcp.UseVisualStyleBackColor = false;
            this.btnThemAcp.Visible = false;
            this.btnThemAcp.Click += new System.EventHandler(this.btnThemAcp_Click);
            // 
            // btnHuyThem
            // 
            this.btnHuyThem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHuyThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThem.ForeColor = System.Drawing.Color.Black;
            this.btnHuyThem.Location = new System.Drawing.Point(661, 134);
            this.btnHuyThem.Name = "btnHuyThem";
            this.btnHuyThem.Size = new System.Drawing.Size(70, 39);
            this.btnHuyThem.TabIndex = 50;
            this.btnHuyThem.Text = "Hủy";
            this.btnHuyThem.UseVisualStyleBackColor = false;
            this.btnHuyThem.Visible = false;
            this.btnHuyThem.Click += new System.EventHandler(this.btnHuyThem_Click);
            // 
            // QLDA_TDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuyThem);
            this.Controls.Add(this.btnThemAcp);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txtPhongBan);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.PhongBan);
            this.Controls.Add(this.NgayBD);
            this.Controls.Add(this.TenDA);
            this.Controls.Add(this.MaDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemDeAn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QLDA_TDA";
            this.Text = "QLDA_TDA";
            this.Load += new System.EventHandler(this.QLDA_TDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemDeAn;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaDA;
        private System.Windows.Forms.Label TenDA;
        private System.Windows.Forms.Label NgayBD;
        private System.Windows.Forms.Label PhongBan;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Button btnThemAcp;
        private System.Windows.Forms.Button btnHuyThem;
    }
}