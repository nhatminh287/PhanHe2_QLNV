namespace PhanHe2_QLNV
{
    partial class TC_Main
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
            this.btnXemNhanVien = new System.Windows.Forms.Button();
            this.btnXemPhanCong = new System.Windows.Forms.Button();
            this.btnTTCN = new System.Windows.Forms.Button();
            this.btnPBDA = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(236, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tài Chính";
            // 
            // btnXemNhanVien
            // 
            this.btnXemNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemNhanVien.Location = new System.Drawing.Point(273, 150);
            this.btnXemNhanVien.Name = "btnXemNhanVien";
            this.btnXemNhanVien.Size = new System.Drawing.Size(267, 41);
            this.btnXemNhanVien.TabIndex = 1;
            this.btnXemNhanVien.Text = "Xem nhân viên";
            this.btnXemNhanVien.UseVisualStyleBackColor = false;
            this.btnXemNhanVien.Click += new System.EventHandler(this.btnXemNhanVien_Click);
            // 
            // btnXemPhanCong
            // 
            this.btnXemPhanCong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXemPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhanCong.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemPhanCong.Location = new System.Drawing.Point(273, 197);
            this.btnXemPhanCong.Name = "btnXemPhanCong";
            this.btnXemPhanCong.Size = new System.Drawing.Size(267, 41);
            this.btnXemPhanCong.TabIndex = 2;
            this.btnXemPhanCong.Text = "Xem phân công";
            this.btnXemPhanCong.UseVisualStyleBackColor = false;
            this.btnXemPhanCong.Click += new System.EventHandler(this.btnXemPhanCong_Click);

            // 
            // btnTTCN
            // 
            this.btnTTCN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTCN.ForeColor = System.Drawing.Color.Transparent;
            this.btnTTCN.Location = new System.Drawing.Point(273, 244);
            this.btnTTCN.Name = "btnTTCN";
            this.btnTTCN.Size = new System.Drawing.Size(267, 41);
            this.btnTTCN.TabIndex = 3;
            this.btnTTCN.Text = "Xem thông tin cá nhân";
            this.btnTTCN.UseVisualStyleBackColor = false;
            this.btnTTCN.Click += new System.EventHandler(this.btnTTCN_Click);

            // 
            // btnPBDA
            // 
            this.btnPBDA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPBDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPBDA.ForeColor = System.Drawing.Color.Transparent;
            this.btnPBDA.Location = new System.Drawing.Point(273, 291);
            this.btnPBDA.Name = "btnPBDA";
            this.btnPBDA.Size = new System.Drawing.Size(267, 41);
            this.btnPBDA.TabIndex = 4;
            this.btnPBDA.Text = "Xem phòng ban và đề án";
            this.btnPBDA.UseVisualStyleBackColor = false;
            this.btnPBDA.Click += new System.EventHandler(this.btnPBDA_Click);

            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(620, 374);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 33);
            this.btnDangXuat.TabIndex = 23;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // 
            // TC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnPBDA);
            this.Controls.Add(this.btnTTCN);
            this.Controls.Add(this.btnXemPhanCong);
            this.Controls.Add(this.btnXemNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "TC_Main";
            this.Text = "TC_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemNhanVien;
        private System.Windows.Forms.Button btnXemPhanCong;
        private System.Windows.Forms.Button btnTTCN;
        private System.Windows.Forms.Button btnPBDA;
        private System.Windows.Forms.Button btnDangXuat;
    }
}