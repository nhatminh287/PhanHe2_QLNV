namespace PhanHe2_QLNV
{
    partial class TDA_Main
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
            this.btnPBDA = new System.Windows.Forms.Button();
            this.btnTTCN = new System.Windows.Forms.Button();
            this.btnQuanLyDA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPBDA
            // 
            this.btnPBDA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPBDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPBDA.ForeColor = System.Drawing.Color.Transparent;
            this.btnPBDA.Location = new System.Drawing.Point(292, 235);
            this.btnPBDA.Name = "btnPBDA";
            this.btnPBDA.Size = new System.Drawing.Size(267, 41);
            this.btnPBDA.TabIndex = 16;
            this.btnPBDA.Text = "Xem phòng ban và đề án";
            this.btnPBDA.UseVisualStyleBackColor = false;
            this.btnPBDA.Click += new System.EventHandler(this.btnPBDA_Click);
            // 
            // btnTTCN
            // 
            this.btnTTCN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTCN.ForeColor = System.Drawing.Color.Transparent;
            this.btnTTCN.Location = new System.Drawing.Point(292, 188);
            this.btnTTCN.Name = "btnTTCN";
            this.btnTTCN.Size = new System.Drawing.Size(267, 41);
            this.btnTTCN.TabIndex = 15;
            this.btnTTCN.Text = "Xem thông tin cá nhân";
            this.btnTTCN.UseVisualStyleBackColor = false;
            this.btnTTCN.Click += new System.EventHandler(this.btnTTCN_Click);
            // 
            // btnQuanLyDA
            // 
            this.btnQuanLyDA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuanLyDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDA.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyDA.Location = new System.Drawing.Point(292, 141);
            this.btnQuanLyDA.Name = "btnQuanLyDA";
            this.btnQuanLyDA.Size = new System.Drawing.Size(267, 41);
            this.btnQuanLyDA.TabIndex = 13;
            this.btnQuanLyDA.Text = "Quản lý đề án";
            this.btnQuanLyDA.UseVisualStyleBackColor = false;
            this.btnQuanLyDA.Click += new System.EventHandler(this.btnQuanLyDA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(227, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thông Tin Trưởng Đề Án";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangXuat.Location = new System.Drawing.Point(607, 357);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(108, 33);
            this.btnDangXuat.TabIndex = 23;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // TDA_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnPBDA);
            this.Controls.Add(this.btnTTCN);
            this.Controls.Add(this.btnQuanLyDA);
            this.Controls.Add(this.label1);
            this.Name = "TDA_Main";
            this.Text = "TDA_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPBDA;
        private System.Windows.Forms.Button btnTTCN;
        private System.Windows.Forms.Button btnQuanLyDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
    }
}