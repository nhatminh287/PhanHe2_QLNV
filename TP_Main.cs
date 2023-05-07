using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe2_QLNV
{
    public partial class TP_Main : Form
    {
        public TP_Main()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap formDn = new DangNhap();
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Hide();
                formDn.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                //do nothing
            }
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            NV_TTCN ttcn = new NV_TTCN();
            Hide();
            ttcn.ShowDialog();
            Show();
        }

        private void btnPBDA_Click(object sender, EventArgs e)
        {
            NV_PBDA pbda = new NV_PBDA();
            Hide();
            pbda.ShowDialog();
            Show();
        }
        private void ChinhSuaPhanCong_Click(object sender, EventArgs e)
        {
            PhanCong_TruongPhong pctp = new PhanCong_TruongPhong();
            Hide();
            pctp.ShowDialog();
            Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            TruongPhong_NhanVien tpnv = new TruongPhong_NhanVien();
            Hide();
            tpnv.ShowDialog();
            Show();
        }
    }
}
