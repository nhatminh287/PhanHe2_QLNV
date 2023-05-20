using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Configuration;


namespace PhanHe2_QLNV
{
    public partial class NV_PBDA : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public NV_PBDA()
        {
            InitializeComponent();
        }

        private List<T> GetList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            while(reader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(reader[prop.Name].ToString(), propType));
                }
                list.Add(obj);
            }
            return list;
        }

        private void NV_PBDA_Load(object sender, EventArgs e)
        {
            try
            {
                List<PhongBan> pb = null;
                List<DeAn> da = null;
                con.Open();
                // Lay du lieu phongban
                string strSQL = "SELECT * FROM QLNV.PHONGBAN";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                pb = GetList<PhongBan>(reader);
                //Console.WriteLine(reader);
                dataGridView1.DataSource = pb;

                // Lay du lieu dean
                strSQL = "SELECT * FROM QLNV.DEAN";
                OracleCommand oCmd2 = new OracleCommand(strSQL, con);
                var reader2 = oCmd2.ExecuteReader();
                da = GetList<DeAn>(reader2);
                dataGridView2.DataSource = da;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không thể tìm thấy thông tin cá nhân do lỗi bên hệ thống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
