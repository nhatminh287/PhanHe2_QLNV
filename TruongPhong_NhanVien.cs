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
    public partial class TruongPhong_NhanVien : Form
    {
        private OracleDataAdapter adapter;
        private DataTable dataTable;
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public TruongPhong_NhanVien()
        {
            InitializeComponent();
            adapter = new OracleDataAdapter("SELECT MANV, TENNV, PHAI,NGAYSINH,DIACHI, SODT, VAITRO, MANQL, PHG FROM QLNV.NHANVIEN NV, QLNV.PHONGBAN PB where NV.PHG = PB.MAPB AND PB.TRPHG = (SELECT USER FROM DUAL)", con);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
