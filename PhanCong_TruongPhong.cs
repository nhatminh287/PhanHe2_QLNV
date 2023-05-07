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
    public partial class PhanCong_TruongPhong : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public PhanCong_TruongPhong()
        {
            InitializeComponent();
            
        }
        
        private void INSERT_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string strSQL = "INSERT INTO QLNV.PHANCONG VALUES ('" + textBox1.Text.ToString() +

                "'," + textBox2.Text.ToString() + "," + textBox3.Text.ToString() + ")";
                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Load_Record();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {         
            try
            {
                con.Open();
                string strSQL = "DELETE FROM QLNV.PHANCONG WHERE MANV ='" + textBox1.Text.ToString() +

                "' AND MADA = " + textBox2.Text.ToString() + "AND THOIGIAN = " + textBox3.Text.ToString();
                MessageBox.Show(strSQL);
                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Load_Record();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            try
            {           
                con.Open();
                string strSQL = "UPDATE QLNV.PHANCONG SET THOIGIAN = " + textBox3.Text.ToString() +

                " WHERE MANV LIKE '" + textBox1.Text.ToString() + "' and MADA LIKE " + textBox2.Text.ToString();
                MessageBox.Show(strSQL);

                OracleCommand oCmd = new OracleCommand(strSQL, con);

                oCmd.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Load_Record();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<T> GetList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            while (reader.Read())
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

        private void PhanCong_TruongPhong_Load(object sender, EventArgs e)
        {
            try
            {
                List<PhanCong> pc = null;
                
                con.Open();
                // Lay du lieu phancong
                string strSQL = "SELECT pc.MANV, pc.MADA, pc.THOIGIAN FROM QLNV.PHANCONG pc, QLNV.PHONGBAN pb, QLNV.NHANVIEN nv WHERE pc.MANV = nv.MANV AND nv.PHG = pb.MAPB AND pb.TRPHG = (SELECT USER FROM DUAL)";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                pc = GetList<PhanCong>(reader);
                
                dataGridView1.DataSource = pc;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Load_Record()
        {
            try
            {
                List<PhanCong> pc = null;

                con.Open();
                // Lay du lieu phancong
                string strSQL = "SELECT pc.MANV, pc.MADA, pc.THOIGIAN FROM QLNV.PHANCONG pc, QLNV.PHONGBAN pb, QLNV.NHANVIEN nv WHERE pc.MANV = nv.MANV AND nv.PHG = pb.MAPB AND pb.TRPHG = (SELECT USER FROM DUAL)";
                OracleCommand oCmd = new OracleCommand(strSQL, con);
                var reader = oCmd.ExecuteReader();
                pc = GetList<PhanCong>(reader);
                
                dataGridView1.DataSource = pc;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dataGridView1_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPhancong = dataGridView1.SelectedRows[0].DataBoundItem as PhanCong;
            textBox1.Text = selectedPhancong.MANV.ToString();
            textBox2.Text = selectedPhancong.MADA.ToString();
            textBox3.Text = selectedPhancong.THOIGIAN.ToString();
        }
    }
}
