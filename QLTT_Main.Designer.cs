namespace PhanHe2_QLNV
{
    partial class QLTT_Main
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
            this.button_TTCN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_TTPC = new System.Windows.Forms.Button();
            this.button4_TTPB = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_DX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_TTCN
            // 
            this.button_TTCN.Location = new System.Drawing.Point(24, 105);
            this.button_TTCN.Name = "button_TTCN";
            this.button_TTCN.Size = new System.Drawing.Size(150, 59);
            this.button_TTCN.TabIndex = 0;
            this.button_TTCN.Text = "Thông tin cá nhân";
            this.button_TTCN.UseVisualStyleBackColor = true;
            this.button_TTCN.Click += new System.EventHandler(this.button_TTCN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_TTPC
            // 
            this.button_TTPC.Location = new System.Drawing.Point(200, 105);
            this.button_TTPC.Name = "button_TTPC";
            this.button_TTPC.Size = new System.Drawing.Size(219, 60);
            this.button_TTPC.TabIndex = 2;
            this.button_TTPC.Text = "Thông tin phân công nhân viên ";
            this.button_TTPC.UseVisualStyleBackColor = true;
            this.button_TTPC.Click += new System.EventHandler(this.button_TTPC_Click);
            // 
            // button4_TTPB
            // 
            this.button4_TTPB.Location = new System.Drawing.Point(444, 105);
            this.button4_TTPB.Name = "button4_TTPB";
            this.button4_TTPB.Size = new System.Drawing.Size(147, 59);
            this.button4_TTPB.TabIndex = 3;
            this.button4_TTPB.Text = "Thông tin phòng ban";
            this.button4_TTPB.UseVisualStyleBackColor = true;
            this.button4_TTPB.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(621, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "Thông tin nhân viên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_DX
            // 
            this.button_DX.Location = new System.Drawing.Point(635, 283);
            this.button_DX.Name = "button_DX";
            this.button_DX.Size = new System.Drawing.Size(95, 30);
            this.button_DX.TabIndex = 5;
            this.button_DX.Text = "Đăng xuất";
            this.button_DX.UseVisualStyleBackColor = true;
            this.button_DX.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLTT_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.button_DX);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4_TTPB);
            this.Controls.Add(this.button_TTPC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_TTCN);
            this.Name = "QLTT_Main";
            this.Text = "QLTT_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_TTCN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_TTPC;
        private System.Windows.Forms.Button button4_TTPB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_DX;
    }
}