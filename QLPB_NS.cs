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
    public partial class QLPB_NS : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public QLPB_NS()
        {
            InitializeComponent();
        }

        private void QLPB_NS_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                con.Open();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string strSQL = "SELECT * FROM QLNV.PHONGBAN";

                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataAdapter adapter = new OracleDataAdapter(oCmd);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                con.Close();

                dataGridView1.Columns[0].Width = 130;
                dataGridView1.Columns[0].HeaderText = "Tên Phòng Ban";
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[1].HeaderText = "Mã Phòng Ban";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Trưởng Phòng";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin phòng ban do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Tu dong dien thong tin vao textbox khi click vao 1 o trong datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtTenPB.Text = Convert.ToString(row.Cells[0].Value);
            txtMaPB.Text = Convert.ToString(row.Cells[1].Value);
            txtTruongPhong.Text = Convert.ToString(row.Cells[2].Value);
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

        private void btnThemTTPB_Click(object sender, EventArgs e)
        {
            btnThemTTPB.Visible = false;
            btnThemAcp.Visible = true;
            btnHuyThem.Visible = true;
            txtMaPB.ReadOnly = false;
            txtTenPB.ReadOnly = false;
            txtTruongPhong.ReadOnly = false;
        }
        private void btnThemAcp_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text == "") { MessageBox.Show("Vui lòng nhập mã phòng ban"); return; }
            if (txtTenPB.Text == "") { MessageBox.Show("Vui lòng nhập tên phòng ban"); return; }
            if (txtMaPB.Text == "") { MessageBox.Show("Vui lòng nhập mã phòng ban"); return; }
            if (txtTruongPhong.Text == "") { MessageBox.Show("Vui lòng nhập trưởng phòng"); return; }
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "INSERT INTO QLNV.PHONGBAN (TENPB, MAPB, TRPHG) VALUES ('" + txtTenPB.Text.ToString() +
                    "', '" + txtMaPB.Text.ToString() + "', '" + txtTruongPhong.Text.ToString() + "')";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaPB.Text + " đã thêm thông tin thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                QLPB_NS_Load(sender, e);
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
            txtMaPB.ReadOnly = true;
            btnThemTTPB.Visible = true;
            btnThemAcp.Visible = false;
            btnHuyThem.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaPB.ReadOnly = true;
            txtTenPB.ReadOnly = false;
            txtTruongPhong.ReadOnly = false;

            if (txtTenPB.Text == "") { MessageBox.Show("Vui lòng nhập tên phòng ban"); return; }
            if (txtMaPB.Text == "") { MessageBox.Show("Vui lòng nhập mã phòng ban"); return; }
            if (txtTruongPhong.Text == "") { MessageBox.Show("Vui lòng nhập trưởng phòng"); return; }

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "UPDATE QLNV.PHONGBAN SET TENPB = '" + txtTenPB.Text.ToString() +
                    "', TRPHG = '" + txtTruongPhong.Text.ToString() +
                    "' WHERE MAPB LIKE '" + txtMaPB.Text.ToString() + "'";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaPB.Text + " đã cập nhật thông tin  thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                QLPB_NS_Load(sender, e);
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