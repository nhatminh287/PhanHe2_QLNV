namespace PhanHe2_QLNV
{
    partial class QLPB_NS
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
            this.btnThemTTPB = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.MaPB = new System.Windows.Forms.Label();
            this.TenPB = new System.Windows.Forms.Label();
            this.TruongPhong = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtTruongPhong = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(220, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông Tin Phòng Ban";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 234);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnThemTTPB
            // 
            this.btnThemTTPB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemTTPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTTPB.ForeColor = System.Drawing.Color.Black;
            this.btnThemTTPB.Location = new System.Drawing.Point(639, 130);
            this.btnThemTTPB.Name = "btnThemTTPB";
            this.btnThemTTPB.Size = new System.Drawing.Size(145, 49);
            this.btnThemTTPB.TabIndex = 9;
            this.btnThemTTPB.Text = "Thêm Thông Tin Phòng Ban";
            this.btnThemTTPB.UseVisualStyleBackColor = false;
            this.btnThemTTPB.Click += new System.EventHandler(this.btnThemTTPB_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(652, 91);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(118, 33);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(652, 387);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(118, 33);
            this.btnDangXuat.TabIndex = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MaPB
            // 
            this.MaPB.AutoSize = true;
            this.MaPB.Location = new System.Drawing.Point(67, 100);
            this.MaPB.Name = "MaPB";
            this.MaPB.Size = new System.Drawing.Size(95, 16);
            this.MaPB.TabIndex = 25;
            this.MaPB.Text = "Mã Phòng Ban";
            // 
            // TenPB
            // 
            this.TenPB.AutoSize = true;
            this.TenPB.Location = new System.Drawing.Point(64, 145);
            this.TenPB.Name = "TenPB";
            this.TenPB.Size = new System.Drawing.Size(100, 16);
            this.TenPB.TabIndex = 26;
            this.TenPB.Text = "Tên Phòng Ban";
            // 
            // TruongPhong
            // 
            this.TruongPhong.AutoSize = true;
            this.TruongPhong.Location = new System.Drawing.Point(348, 100);
            this.TruongPhong.Name = "TruongPhong";
            this.TruongPhong.Size = new System.Drawing.Size(92, 16);
            this.TruongPhong.TabIndex = 27;
            this.TruongPhong.Text = "Trưởng Phòng";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(170, 94);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.ReadOnly = true;
            this.txtMaPB.Size = new System.Drawing.Size(143, 22);
            this.txtMaPB.TabIndex = 28;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(170, 139);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(143, 22);
            this.txtTenPB.TabIndex = 31;
            // 
            // txtTruongPhong
            // 
            this.txtTruongPhong.Location = new System.Drawing.Point(446, 94);
            this.txtTruongPhong.Name = "txtTruongPhong";
            this.txtTruongPhong.Size = new System.Drawing.Size(154, 22);
            this.txtTruongPhong.TabIndex = 32;
            // 
            // btnThemAcp
            // 
            this.btnThemAcp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemAcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAcp.ForeColor = System.Drawing.Color.Black;
            this.btnThemAcp.Location = new System.Drawing.Point(714, 130);
            this.btnThemAcp.Name = "btnThemAcp";
            this.btnThemAcp.Size = new System.Drawing.Size(70, 49);
            this.btnThemAcp.TabIndex = 33;
            this.btnThemAcp.Text = "Thêm";
            this.btnThemAcp.UseVisualStyleBackColor = false;
            this.btnThemAcp.Visible = false;
            this.btnThemAcp.Click += new System.EventHandler(this.btnThemAcp_Click);
            // 
            // btnHuyThem
            // 
            this.btnHuyThem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHuyThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThem.ForeColor = System.Drawing.Color.Black;
            this.btnHuyThem.Location = new System.Drawing.Point(639, 129);
            this.btnHuyThem.Name = "btnHuyThem";
            this.btnHuyThem.Size = new System.Drawing.Size(69, 49);
            this.btnHuyThem.TabIndex = 34;
            this.btnHuyThem.Text = "Hủy";
            this.btnHuyThem.UseVisualStyleBackColor = false;
            this.btnHuyThem.Visible = false;
            this.btnHuyThem.Click += new System.EventHandler(this.btnHuyThem_Click);
            // 
            // QLPB_NS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuyThem);
            this.Controls.Add(this.btnThemAcp);
            this.Controls.Add(this.txtTruongPhong);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.TruongPhong);
            this.Controls.Add(this.TenPB);
            this.Controls.Add(this.MaPB);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemTTPB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QLPB_NS";
            this.Text = "QLPB_NS";
            this.Load += new System.EventHandler(this.QLPB_NS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemTTPB;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label MaPB;
        private System.Windows.Forms.Label TenPB;
        private System.Windows.Forms.Label TruongPhong;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtTruongPhong;
        private System.Windows.Forms.Button btnThemAcp;
        private System.Windows.Forms.Button btnHuyThem;
    }
}