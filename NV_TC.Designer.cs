namespace PhanHe2_QLNV
{
    partial class NV_TC
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
            this.btnSuaLuongVaPhuCap = new System.Windows.Forms.Button();
            this.MaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.TenNV = new System.Windows.Forms.Label();
            this.Luong = new System.Windows.Forms.Label();
            this.PhuCap = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(227, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông Tin Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 259);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(670, 17);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 33);
            this.btnDangXuat.TabIndex = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnSuaLuongVaPhuCap
            // 
            this.btnSuaLuongVaPhuCap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaLuongVaPhuCap.Location = new System.Drawing.Point(628, 82);
            this.btnSuaLuongVaPhuCap.Name = "btnSuaLuongVaPhuCap";
            this.btnSuaLuongVaPhuCap.Size = new System.Drawing.Size(84, 47);
            this.btnSuaLuongVaPhuCap.TabIndex = 25;
            this.btnSuaLuongVaPhuCap.Text = "Cập Nhật";
            this.btnSuaLuongVaPhuCap.UseVisualStyleBackColor = false;
            this.btnSuaLuongVaPhuCap.Click += new System.EventHandler(this.btnSuaLuongVaPhuCap_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(25, 82);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(91, 16);
            this.MaNV.TabIndex = 26;
            this.MaNV.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(122, 79);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(187, 22);
            this.txtMaNV.TabIndex = 27;
            this.txtMaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.AutoSize = true;
            this.TenNV.Location = new System.Drawing.Point(25, 126);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(96, 16);
            this.TenNV.TabIndex = 28;
            this.TenNV.Text = "Tên Nhân Viên";
            // 
            // Luong
            // 
            this.Luong.AutoSize = true;
            this.Luong.Location = new System.Drawing.Point(351, 82);
            this.Luong.Name = "Luong";
            this.Luong.Size = new System.Drawing.Size(44, 16);
            this.Luong.TabIndex = 29;
            this.Luong.Text = "Lương";
            // 
            // PhuCap
            // 
            this.PhuCap.AutoSize = true;
            this.PhuCap.Location = new System.Drawing.Point(351, 126);
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.Size = new System.Drawing.Size(58, 16);
            this.PhuCap.TabIndex = 30;
            this.PhuCap.Text = "Phụ Cấp";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(415, 120);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(187, 22);
            this.txtPhuCap.TabIndex = 31;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(415, 79);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(187, 22);
            this.txtLuong.TabIndex = 32;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(122, 120);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(187, 22);
            this.txtTenNV.TabIndex = 33;
            // 
            // NV_TC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.PhuCap);
            this.Controls.Add(this.Luong);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.btnSuaLuongVaPhuCap);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "NV_TC";
            this.Text = "NV_TC";
            this.Load += new System.EventHandler(this.NV_TC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnSuaLuongVaPhuCap;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label TenNV;
        private System.Windows.Forms.Label Luong;
        private System.Windows.Forms.Label PhuCap;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTenNV;
    }
}