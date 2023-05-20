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
    public partial class NV_TTCN : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public NV_TTCN()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NV_Main bnmain = new NV_Main();
            Hide();
            bnmain.ShowDialog();
        }

        private void btnSuaTTCN_Click(object sender, EventArgs e)
        {
            txtTenNV.ReadOnly = true;
            dtpNgaySinh.Enabled = true;
            txtPhai.ReadOnly = true;
            txtDiaChi.ReadOnly = false;
            txtLuong.Enabled = true;
            txtPhong.ReadOnly = true;
            txtSDT.ReadOnly = false;
            txtMADA.ReadOnly = true;
            txtPhuCap.ReadOnly = true;
            txtTgTGDA.ReadOnly = true;
            txtMaNQL.ReadOnly = true;
            btnSuaTTCN.Visible = false;
            btnHuySuaTTCN.Visible = true;
            btnSuaTTCNAcp.Visible = true;
        }

        private void btnHuySuaTTCN_Click(object sender, EventArgs e)
        {
            txtTenNV.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            txtPhai.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtLuong.Enabled = false;
            txtPhong.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtMADA.ReadOnly = true;
            txtPhuCap.ReadOnly = true;
            txtTgTGDA.ReadOnly = true;
            txtMaNQL.ReadOnly = true;
            btnSuaTTCN.Visible = true;
            btnHuySuaTTCN.Visible = false;
            btnSuaTTCNAcp.Visible = false;
        }

        private void btnSuaTTCNAcp_Click(object sender, EventArgs e)
        {
            txtTenNV.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            txtPhai.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLuong.Enabled = false;
            txtPhong.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtMADA.ReadOnly = false;
            txtPhuCap.ReadOnly = false;
            txtTgTGDA.ReadOnly = false;
            txtMaNQL.ReadOnly = false;
            btnSuaTTCN.Visible = false;
            btnSuaTTCNAcp.Visible = false;
            btnHuySuaTTCN.Visible = false;

            if (txtTenNV.Text == "") { MessageBox.Show("Vui lòng nhập tên"); return; }
            if (txtPhai.Text == "") { MessageBox.Show("Vui lòng giới tính"); return; }


            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                string conString = connectionStringsSection.ConnectionStrings["con"].ConnectionString;

                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                //int tgian = int.Parse(txtTgTGDA.Text);

                string strSQL = "UPDATE TUAN.NHANVIEN SET TENNV = N'" + txtTenNV.Text.ToString() +
                    "', NGAYSINH = TO_DATE('" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')" +
                    
                    ", SODT = '" + txtSDT.Text.ToString() +
                     
                     "', DIACHI = '" + txtDiaChi.Text.ToString() +

                    "' WHERE MANV LIKE '" + txbMaNV.Text.ToString()  + "'";

                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show(txbMaNV.Text + " đã cập nhật thông tin cá nhân thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể cập nhật thông tin cá nhân do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    

        private void NV_TTCN_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string strSQL = "SELECT * FROM QLNV.NHANVIEN nv, QLNV.PHANCONG pc WHERE nv.MANV = (SELECT user FROM dual) and nv.MANV = pc.MANV ";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                //Console.WriteLine(reader);
                while (reader.Read())
                {                          
                    string ngaysinh = reader["NGAYSINH"].ToString();                  
                    Console.WriteLine(ngaysinh);
                    txbMaNV.Text = reader["MANV"].ToString();
                    txtTenNV.Text = reader["TENNV"].ToString();
                    txtPhai.Text = reader["PHAI"].ToString();
                    string text = reader["NGAYSINH"].ToString();
                    //dtpNgaySinh.Text = reader["NGAYSINH"].ToString();
                    //dtpNgaySinh.Text = date.ToString();
                    txtLuong.Text = reader["LUONG"].ToString(); //lƯƠNG
                    txtPhong.Text = reader["PHG"].ToString(); // pHÒNG
                    txtSDT.Text = reader["SODT"].ToString(); // SĐT
                    txtMADA.Text = reader["MADA"].ToString(); // mÃ ĐỀ ÁN
                    txtDiaChi.Text = reader["DIACHI"].ToString(); // ĐỊA CHỈ
                    txtTgTGDA.Text = reader["THOIGIAN"].ToString(); // THỜI GIAN THAM GIA
                    txtMaNQL.Text = reader["MANQL"].ToString(); // mÃ NQL
                    txtPhuCap.Text = reader["PHUCAP"].ToString(); // pHỤ CẤP
                }
                strSQL = "SELECT TO_CHAR(NGAYSINH, 'DD/MM/YYYY') FROM QLNV.NHANVIEN WHERE MANV = (SELECT user FROM dual)";
                OracleCommand oCmd2 = new OracleCommand(strSQL, con);
                var reader2 = oCmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string ngaysinh = reader2[0].ToString();
                    
                    Console.WriteLine(ngaysinh);
                    //dtpNgaySinh.Text = ngaysinh;
                    dtpNgaySinh.Value = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin cá nhân do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txbMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMADA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
