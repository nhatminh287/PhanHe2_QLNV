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
using static System.Net.Mime.MediaTypeNames;


namespace PhanHe2_QLNV
{

    public partial class QLNV_NS : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public QLNV_NS()
        {
            InitializeComponent();
        }

        private void QLNV_NS_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                con.Open();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string strSQL = "SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG FROM QLNV.NHANVIEN";

                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataAdapter adapter = new OracleDataAdapter(oCmd);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                con.Close();

                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Mã NV";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Tên NV";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Phái";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Địa Chỉ";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "SĐT";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].HeaderText = "Vai Trò";
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[7].HeaderText = "Mã NQL";
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[8].HeaderText = "Phòng Ban";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin phòng ban do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = Convert.ToString(row.Cells[0].Value);
            txtTenNV.Text = Convert.ToString(row.Cells[1].Value);
            txtPhai.Text = Convert.ToString(row.Cells[2].Value);
            dtpNgaySinh.Text = Convert.ToString(row.Cells[3].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells[4].Value);
            txtSDT.Text = Convert.ToString(row.Cells[5].Value);
            txtVaiTro.Text = Convert.ToString(row.Cells[6].Value);
            txtMaNQL.Text = Convert.ToString(row.Cells[7].Value);
            txtPhongBan.Text = Convert.ToString(row.Cells[8].Value);
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

        private void MaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;

            if (txtMaNV.Text == "") { MessageBox.Show("Vui lòng nhập mã nhân viên"); return; }
            if (txtTenNV.Text == "") { MessageBox.Show("Vui lòng nhập tên nhân viên"); return; }
            if (txtPhai.Text == "") { MessageBox.Show("Vui lòng nhập phái"); return; }
            if (dtpNgaySinh.Text == "") { MessageBox.Show("Vui lòng nhập ngày sinh"); return; }
            if (txtDiaChi.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ"); return; }
            if (txtSDT.Text == "") { MessageBox.Show("Vui lòng nhập SĐT"); return; }
            if (txtVaiTro.Text == "") { MessageBox.Show("Vui lòng nhập vai trò"); return; }
            if (txtPhongBan.Text == "") { MessageBox.Show("Vui lòng nhập phòng ban"); return; }


            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "UPDATE QLNV.NHANVIEN SET TENNV = '" + txtTenNV.Text.ToString() +
                    "', PHAI = '" + txtPhai.Text.ToString() +
                    "', NGAYSINH = TO_DATE('" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd')" +
                    ", DIACHI = '" + txtDiaChi.Text.ToString() +
                    "', SODT = " + txtSDT.Text.ToString() +
                    ", VAITRO = '" + txtVaiTro.Text.ToString() +
                    "', MANQL = '" + txtMaNQL.Text.ToString() +
                    "', PHG = " + txtPhongBan.Text.ToString() +
                    " WHERE MANV LIKE '" + txtMaNV.Text.ToString() + "'";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaNV.Text + " đã cập nhật thông tin  thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                QLNV_NS_Load(sender, e);
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể cập nhật thông tin lương và phụ cấp do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnThemTTNV_Click(object sender, EventArgs e)
        {

            btnThemTTNV.Visible = false;
            btnCapNhat.Visible = false;
            btnThemAcp.Visible = true;
            btnHuyThem.Visible = true;
            txtMaNV.ReadOnly = false;
        }

        private void btnThemAcp_Click(object sender, EventArgs e)
        {

            btnThemTTNV.Visible = true;
            btnCapNhat.Visible = true;
            btnThemAcp.Visible = false;
            btnHuyThem.Visible = false;
            txtMaNV.ReadOnly = true;

            if (txtMaNV.Text == "") { MessageBox.Show("Vui lòng nhập mã nhân viên"); return; }
            if (txtTenNV.Text == "") { MessageBox.Show("Vui lòng nhập tên nhân viên"); return; }
            if (txtPhai.Text == "") { MessageBox.Show("Vui lòng nhập phái"); return; }
            if (dtpNgaySinh.Text == "") { MessageBox.Show("Vui lòng nhập ngày sinh"); return; }
            if (txtDiaChi.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ"); return; }
            if (txtSDT.Text == "") { MessageBox.Show("Vui lòng nhập SĐT"); return; }
            if (txtVaiTro.Text == "") { MessageBox.Show("Vui lòng nhập vai trò"); return; }
            if (txtPhongBan.Text == "") { MessageBox.Show("Vui lòng nhập phòng ban"); return; }

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "INSERT INTO QLNV.NHANVIEN (MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG) VALUES ('" + txtMaNV.Text.ToString() +
                    "', '" + txtTenNV.Text.ToString() +
                    "', '" + txtPhai.Text.ToString() +
                    "', TO_DATE('" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd')" +
                    ", '" + txtDiaChi.Text.ToString() +
                    "', " + txtSDT.Text.ToString() +
                    ", null" +
                    ", null" +
                    ", '" + txtVaiTro.Text.ToString() +
                    "', '" + txtMaNQL.Text.ToString() +
                    "', " + txtPhongBan.Text.ToString() + ")";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaNV.Text + " đã thêm thông tin thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                QLNV_NS_Load(sender, e);
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể thêm thông tin do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            btnThemTTNV.Visible = true;
            btnCapNhat.Visible = true;
            btnThemAcp.Visible = false;
            btnHuyThem.Visible = false;
            txtMaNV.ReadOnly = true;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
