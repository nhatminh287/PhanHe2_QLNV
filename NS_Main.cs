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
    public partial class NS_Main : Form
    {
        public NS_Main()
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

        private void btnQuanLyPhongBan_Click(object sender, EventArgs e)
        {
            QLPB_NS qlpbns = new QLPB_NS();
            Hide();
            qlpbns.ShowDialog();
            Show();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            QLNV_NS qlnvns = new QLNV_NS();
            Hide();
            qlnvns.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
