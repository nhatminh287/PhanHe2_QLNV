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
    public partial class QLDA_TDA : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public QLDA_TDA()
        {
            InitializeComponent();
        }

        private void QLDA_TDA_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                con.Open();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string strSQL = "SELECT * FROM QLNV.DEAN";

                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataAdapter adapter = new OracleDataAdapter(oCmd);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                con.Close();

                dataGridView1.Columns[0].Width = 130;
                dataGridView1.Columns[0].HeaderText = "Mã Đề Án";
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[1].HeaderText = "Tên Đề Án";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Phòng";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Ngày Bắt Đầu";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin phòng ban do lỗi bên hệ thống", "Lỗi",
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaDA.ReadOnly = true;
            if (txtMaDA.Text == "") { MessageBox.Show("Vui lòng nhập mã đề án"); return; }
            if (txtTenDA.Text == "") { MessageBox.Show("Vui lòng nhập tên đề án"); return; }
            if (dtpNgayBD.Text == "") { MessageBox.Show("Vui lòng nhập ngày bắt đầu"); return; }
            if (txtPhongBan.Text == "") { MessageBox.Show("Vui lòng nhập phòng ban phụ trách"); return; }

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "UPDATE QLNV.DEAN SET TENDA = '" + txtTenDA.Text.ToString() +
                    "', PHONG = '" + txtPhongBan.Text.ToString() +
                    "', NGAYBD =  TO_DATE('" + dtpNgayBD.Value.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd')" +
                    " WHERE MADA LIKE '" + txtMaDA.Text.ToString() + "'";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaDA.Text + " đã cập nhật thông tin  thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                QLDA_TDA_Load(sender, e);
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể cập nhật thông tin lương và phụ cấp do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaDA.Text = Convert.ToString(row.Cells[0].Value);
            txtTenDA.Text = Convert.ToString(row.Cells[1].Value);
            txtPhongBan.Text = Convert.ToString(row.Cells[2].Value);
            dtpNgayBD.Text = Convert.ToString(row.Cells[3].Value);

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemDeAn_Click(object sender, EventArgs e)
        {
            btnThemDeAn.Visible = false;
            btnCapNhat.Visible = false;
            btnXoa.Visible = false;
            btnThemAcp.Visible = true;
            btnHuyThem.Visible = true;
            txtMaDA.ReadOnly = false;
        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            btnThemDeAn.Visible = true;
            btnCapNhat.Visible = true;
            btnXoa.Visible = true;
            btnThemAcp.Visible = false;
            btnHuyThem.Visible = false;
            txtMaDA.ReadOnly = true;
        }

        private void btnThemAcp_Click(object sender, EventArgs e)
        {
            btnThemDeAn.Visible = true;
            btnCapNhat.Visible = true;
            btnXoa.Visible = true;
            btnThemAcp.Visible = false;
            btnHuyThem.Visible = false;
            txtMaDA.ReadOnly = true;

            if (txtMaDA.Text == "") { MessageBox.Show("Vui lòng nhập mã đề án"); return; }
            if (txtTenDA.Text == "") { MessageBox.Show("Vui lòng nhập tên đề án"); return; }
            if (txtPhongBan.Text == "") { MessageBox.Show("Vui lòng nhập phòng ban phụ trách"); return; }
            if (dtpNgayBD.Text == "") { MessageBox.Show("Vui lòng nhập ngày bắt đầu"); return; }
            
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                string strSQL = "INSERT INTO QLNV.DEAN (MADA, TENDA, PHONG, NGAYBD) VALUES ('" + txtMaDA.Text.ToString() +
                    "', '" + txtTenDA.Text.ToString() +
                    "', '" + txtPhongBan.Text.ToString() +
                    "', TO_DATE('" + dtpNgayBD.Value.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd')" + ")";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txtMaDA.Text + " đã thêm thông tin thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                QLDA_TDA_Load(sender, e);
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể thêm thông tin do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLDA_TDA qlda = new QLDA_TDA();
            if (txtMaDA.Text == "") { MessageBox.Show("Vui lòng nhập mã đề án"); return; }
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa đề án?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Hide();
                try
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = conString;
                    con.Open();
                    string strSQL = "DELETE FROM QLNV.DEAN WHERE MADA = '" + txtMaDA.Text.ToString() + "'";


                    MessageBox.Show(strSQL);

                    OracleCommand oCmd = new OracleCommand(strSQL, con);

                    oCmd.ExecuteNonQuery();

                    MessageBox.Show(txtMaDA.Text + " đã xóa thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    QLDA_TDA_Load(sender, e);
                    qlda.ShowDialog();
                    //Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Không thể xóa thông tin do lỗi bên hệ thống", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    qlda.ShowDialog();
                }
            }

            else if (result == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
