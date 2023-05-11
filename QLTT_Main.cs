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
    public partial class QLTT_Main : Form
    {
        public QLTT_Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NV_PBDA pbda = new NV_PBDA();
            Hide();
            pbda.ShowDialog();
            Show();
        }

        private void button_TTCN_Click(object sender, EventArgs e)
        {
            NV_TTCN ttcnql = new NV_TTCN();
            Hide();
            ttcnql.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            QLTT_TTNV ttnv = new QLTT_TTNV();
            Hide();
            ttnv.ShowDialog();
            Show();
        }

        private void button_TTPC_Click(object sender, EventArgs e)
        {
            QLTT_PC ttpc = new QLTT_PC();
            Hide();
            ttpc.ShowDialog();
            Show();
        }
    }
}
