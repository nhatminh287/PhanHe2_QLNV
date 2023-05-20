namespace PhanHe2_QLNV
{
    partial class QLNV_NS
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
            this.MaNV = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.Label();
            this.Phai = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.Label();
            this.VaiTro = new System.Windows.Forms.Label();
            this.MaNQL = new System.Windows.Forms.Label();
            this.PhongBan = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.txtMaNQL = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.btnHuyThem = new System.Windows.Forms.Button();
            this.btnThemAcp = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemTTNV = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 212);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(703, 373);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(91, 40);
            this.btnDangXuat.TabIndex = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(8, 82);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(48, 16);
            this.MaNV.TabIndex = 25;
            this.MaNV.Text = "Mã NV";
            this.MaNV.Click += new System.EventHandler(this.MaNV_Click);
            // 
            // TenNV
            // 
            this.TenNV.AutoSize = true;
            this.TenNV.Location = new System.Drawing.Point(8, 128);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(53, 16);
            this.TenNV.TabIndex = 26;
            this.TenNV.Text = "Tên NV";
            // 
            // Phai
            // 
            this.Phai.AutoSize = true;
            this.Phai.Location = new System.Drawing.Point(8, 170);
            this.Phai.Name = "Phai";
            this.Phai.Size = new System.Drawing.Size(34, 16);
            this.Phai.TabIndex = 27;
            this.Phai.Text = "Phái";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(228, 82);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(69, 16);
            this.NgaySinh.TabIndex = 28;
            this.NgaySinh.Text = "Ngày Sinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(228, 128);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(49, 16);
            this.DiaChi.TabIndex = 29;
            this.DiaChi.Text = "Địa Chỉ";
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(228, 170);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(34, 16);
            this.SDT.TabIndex = 30;
            this.SDT.Text = "SĐT";
            // 
            // VaiTro
            // 
            this.VaiTro.AutoSize = true;
            this.VaiTro.Location = new System.Drawing.Point(475, 82);
            this.VaiTro.Name = "VaiTro";
            this.VaiTro.Size = new System.Drawing.Size(51, 16);
            this.VaiTro.TabIndex = 31;
            this.VaiTro.Text = "Vai Trò";
            // 
            // MaNQL
            // 
            this.MaNQL.AutoSize = true;
            this.MaNQL.Location = new System.Drawing.Point(475, 128);
            this.MaNQL.Name = "MaNQL";
            this.MaNQL.Size = new System.Drawing.Size(56, 16);
            this.MaNQL.TabIndex = 32;
            this.MaNQL.Text = "Mã NQL";
            // 
            // PhongBan
            // 
            this.PhongBan.AutoSize = true;
            this.PhongBan.Location = new System.Drawing.Point(475, 170);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(73, 16);
            this.PhongBan.TabIndex = 33;
            this.PhongBan.Text = "Phòng Ban";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(62, 76);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(114, 22);
            this.txtMaNV.TabIndex = 34;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(62, 122);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(114, 22);
            this.txtTenNV.TabIndex = 35;
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(62, 164);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(114, 22);
            this.txtPhai.TabIndex = 36;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(303, 122);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(114, 22);
            this.txtDiaChi.TabIndex = 38;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(303, 164);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(114, 22);
            this.txtSDT.TabIndex = 39;
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Location = new System.Drawing.Point(550, 164);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(114, 22);
            this.txtPhongBan.TabIndex = 40;
            // 
            // txtMaNQL
            // 
            this.txtMaNQL.Location = new System.Drawing.Point(550, 122);
            this.txtMaNQL.Name = "txtMaNQL";
            this.txtMaNQL.Size = new System.Drawing.Size(114, 22);
            this.txtMaNQL.TabIndex = 41;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Location = new System.Drawing.Point(550, 76);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(114, 22);
            this.txtVaiTro.TabIndex = 42;
            // 
            // btnHuyThem
            // 
            this.btnHuyThem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHuyThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThem.ForeColor = System.Drawing.Color.Black;
            this.btnHuyThem.Location = new System.Drawing.Point(696, 76);
            this.btnHuyThem.Name = "btnHuyThem";
            this.btnHuyThem.Size = new System.Drawing.Size(92, 39);
            this.btnHuyThem.TabIndex = 46;
            this.btnHuyThem.Text = "Hủy";
            this.btnHuyThem.UseVisualStyleBackColor = false;
            this.btnHuyThem.Visible = false;
            this.btnHuyThem.Click += new System.EventHandler(this.btnHuyThem_Click);
            // 
            // btnThemAcp
            // 
            this.btnThemAcp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemAcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAcp.ForeColor = System.Drawing.Color.Black;
            this.btnThemAcp.Location = new System.Drawing.Point(695, 126);
            this.btnThemAcp.Name = "btnThemAcp";
            this.btnThemAcp.Size = new System.Drawing.Size(93, 39);
            this.btnThemAcp.TabIndex = 45;
            this.btnThemAcp.Text = "Thêm";
            this.btnThemAcp.UseVisualStyleBackColor = false;
            this.btnThemAcp.Visible = false;
            this.btnThemAcp.Click += new System.EventHandler(this.btnThemAcp_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(696, 82);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(92, 33);
            this.btnCapNhat.TabIndex = 44;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemTTNV
            // 
            this.btnThemTTNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTTNV.ForeColor = System.Drawing.Color.Black;
            this.btnThemTTNV.Location = new System.Drawing.Point(670, 114);
            this.btnThemTTNV.Name = "btnThemTTNV";
            this.btnThemTTNV.Size = new System.Drawing.Size(124, 50);
            this.btnThemTTNV.TabIndex = 43;
            this.btnThemTTNV.Text = "Thêm Thông Tin Nhân Viên";
            this.btnThemTTNV.UseVisualStyleBackColor = false;
            this.btnThemTTNV.Click += new System.EventHandler(this.btnThemTTNV_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(303, 79);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(114, 19);
            this.dtpNgaySinh.TabIndex = 47;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // QLNV_NS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnHuyThem);
            this.Controls.Add(this.btnThemAcp);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemTTNV);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.txtMaNQL);
            this.Controls.Add(this.txtPhongBan);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtPhai);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.PhongBan);
            this.Controls.Add(this.MaNQL);
            this.Controls.Add(this.VaiTro);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.Phai);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QLNV_NS";
            this.Text = "QLNV_NS";
            this.Load += new System.EventHandler(this.QLNV_NS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label TenNV;
        private System.Windows.Forms.Label Phai;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label VaiTro;
        private System.Windows.Forms.Label MaNQL;
        private System.Windows.Forms.Label PhongBan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.TextBox txtMaNQL;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.Button btnHuyThem;
        private System.Windows.Forms.Button btnThemAcp;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemTTNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}