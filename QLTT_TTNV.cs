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
    public partial class QLTT_TTNV : Form
    {
        private OracleDataAdapter adapter;
        private DataTable dataTable;
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public QLTT_TTNV()
        {
            InitializeComponent();
            adapter = new OracleDataAdapter("SELECT MANV, TENNV, PHAI,NGAYSINH,DIACHI, SODT, VAITRO, MANQL, PHG FROM QLNV.NHANVIEN where NHANVIEN.MANQL=(SELECT USER FROM DUAL)", con);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void QLTT_TTNV_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
