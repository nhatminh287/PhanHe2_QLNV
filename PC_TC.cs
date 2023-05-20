using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Globalization;

namespace PhanHe2_QLNV
{
    public partial class PC_TC : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public PC_TC()
        {
            InitializeComponent();
        }

        private void PC_TC_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                con.Open();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string strSQL = "SELECT * FROM QLNV.PHANCONG";

                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataAdapter adapter = new OracleDataAdapter(oCmd);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                con.Close();

                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Mã Đề Án";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Thời Gian";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin phân công do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
    }
}
