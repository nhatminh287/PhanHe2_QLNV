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
    public partial class TC_Main : Form
    {
        public TC_Main()
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

        private void btnTTCN_Click(object sender, EventArgs e)
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

        private void btnXemPhanCong_Click(object sender, EventArgs e)
        {
            PC_TC pctc = new PC_TC();
            Hide();
            pctc.ShowDialog();
            Show();
        }
        private void btnXemNhanVien_Click(object sender, EventArgs e)
        {
            NV_TC nvtc = new NV_TC();
            Hide();
            nvtc.ShowDialog();
            Show();
        }
    }
}
