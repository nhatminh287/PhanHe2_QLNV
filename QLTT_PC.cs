using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe2_QLNV
{
    public partial class QLTT_PC : Form
    {
        private OracleDataAdapter adapter;
        private DataTable dataTable;
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public QLTT_PC()
        {
            InitializeComponent();
            adapter = new OracleDataAdapter("SELECT n.MANV, n.TENNV, d.MADA, d.TENDA, d.PHONG, d.NGAYBD, p.THOIGIAN FROM TUAN.DEAN d INNER JOIN TUAN.PHANCONG p ON d.MADA = p.MADA INNER JOIN TUAN.NHANVIEN n ON p.MANV = n.MANV WHERE n.MANQL = (SELECT USER FROM DUAL) or n.MANV= (SELECT USER FROM DUAL)", con);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
