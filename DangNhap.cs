using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace PhanHe2_QLNV
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == null)
            {
                MessageBox.Show("Vui lòng nhập Username");
                return;
            }

            if (txbPw.Text == null)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            string conString = "USER ID=" + txbUsername.Text + ";PASSWORD=" + txbPw.Text + ";DATA SOURCE=DESKTOP-6ELD45C";

            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["con"].ConnectionString = conString;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                MessageBox.Show("Đăng nhập thành công!");
                Hide();
                string strSQL = "select GRANTED_ROLE from user_role_privs";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                OracleDataReader dr;
                dr = oCmd.ExecuteReader();
                dr.Read();
                string role = dr["GRANTED_ROLE"].ToString();
                switch (role)
                {
                    case "R_NHANVIEN":
                        NV_Main nv = new NV_Main();
                        Hide();
                        nv.ShowDialog();
                        Show();
                        break;
                    case "R_TRUONGPHONG":
                        TP_Main tp = new TP_Main();
                        Hide();
                        tp.ShowDialog();
                        Show();
                        break;
                    case "R_QLTT":
                        QLTT_Main ql = new QLTT_Main();
                        Hide();
                        ql.ShowDialog();
                        Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
