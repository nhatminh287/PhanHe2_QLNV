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
    public partial class NV_TC : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public NV_TC()
        {
            InitializeComponent();
        }
        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    TC_Main tcmain = new TC_Main();
        //    Hide();
        //    tcmain.ShowDialog();
        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NV_TC_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                con.Open();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string strSQL = "SELECT * FROM QLNV.NHANVIEN ";

                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataAdapter adapter = new OracleDataAdapter(oCmd);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                con.Close();

                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[2].HeaderText = "Phái";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Địa Chỉ";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].HeaderText = "Lương";
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[7].HeaderText = "Phụ Cấp";
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[8].HeaderText = "Vai Trò";
                dataGridView1.Columns[9].Width = 100;
                dataGridView1.Columns[9].HeaderText = "Mã Người Quản Lý";
                dataGridView1.Columns[10].Width = 100;
                dataGridView1.Columns[10].HeaderText = "Phòng Ban";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin nhân viên do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Tu dong dien thong tin vao textbox khi click vao 1 o trong datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = Convert.ToString(row.Cells[0].Value);
            txtTenNV.Text = Convert.ToString(row.Cells[1].Value);
            txtLuong.Text = Convert.ToString(row.Cells[6].Value);
            txtPhuCap.Text = Convert.ToString(row.Cells[7].Value);
            
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

        private void btnSuaLuongVaPhuCap_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtLuong.ReadOnly = false;
            txtPhuCap.ReadOnly = false;

            if (txtMaNV.Text == "") { MessageBox.Show("Vui lòng nhập mã"); return; }
            if (txtTenNV.Text == "") { MessageBox.Show("Vui lòng nhập tên"); return; }
            if (txtLuong.Text == "") { MessageBox.Show("Vui lòng nhập lương"); return; }
            if (txtPhuCap.Text == "") { MessageBox.Show("Vui lòng nhập phụ cấp"); return; }


            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "UPDATE QLNV.NHANVIEN SET LUONG = " + txtLuong.Text.ToString() +
                    ", PHUCAP = " + txtPhuCap.Text.ToString() +
                    " WHERE MANV LIKE '" + txtMaNV.Text.ToString() + "'";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaNV.Text + " đã cập nhật thông tin lương và phụ cấp thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                NV_TC_Load(sender, e);
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể cập nhật thông tin lương và phụ cấp do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
