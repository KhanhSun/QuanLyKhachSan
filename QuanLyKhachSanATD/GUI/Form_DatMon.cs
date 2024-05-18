using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanATD.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSanATD.GUI
{
    public partial class Form_DatMon : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";

        public Form_DatMon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaPhong = null;
            txtGhiChu = null;
            txtMaKH = null;
            txtSoLuong = null;
            txtThanhTien = null;
            txtMaMon = null;
            cmbTenMon = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private DataSet getDSKH()
        {
            query = "select dm.MaMonAn, dm.TenMonAn, dm.SoLuong, dm.TongTien, dm.GhiChuThem, dm.MaNV From NhaBep dm";
            DataSet ds = sun.getData(query);
            return ds;
        }

        private void Form_DatMon_Load_1(object sender, EventArgs e)
        {
            query = "select dm.MaMonAn, dm.TenMonAn, dm.SoLuong, dm.TongTien, dm.GhiChuThem, dm.MaNV, md.MaKH, md.MaPhong From NhaBep dm, DatMon md where dm.TenMonAn = md.TenMon";
            DataSet ds = sun.getData(query);
            dgDatMon.DataSource = ds.Tables[0];
        }

        public void setcombobox(String query, ComboBox combo)
        {
            SqlDataReader rs = sun.getforCmb(query);
            while (rs.Read())
            {
                for (int i = 0; i < rs.FieldCount; i++)
                {
                    combo.Items.Add(rs.GetString(i));
                }
            }
            rs.Close();
        }

        private void txtMaKH_TextChanged_1(object sender, EventArgs e)
        {
            query = "select distinct TenMonAn from NhaBep";
            setcombobox(query, cmbTenMon);
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            query = @"INSERT INTO NhaBep (MaMonAn, TenMonAn, SoLuong, TongTien, GhiChuThem, MaNV) Values ('" + null + "','" + cmbTenMon.Text + "')";
            sun.setData(query, "Dat thanh cong");
            Form_DatMon_Load_1(this, null);
        }

        private void cmbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select nb.MaMonAn, nb.TongTien from NhaBep nb where nb.TenMonAn = '" + cmbTenMon.SelectedText + "'";
            DataSet ds = sun.getData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtMaMon.Text = ds.Tables[0].Rows[0]["MaMonAn"].ToString();
                    txtThanhTien.Text = ds.Tables[0].Rows[0]["TongTien"].ToString();
                }
                else
                {
                    // Handle the case where no rows are returned (empty table)
                    txtMaMon.Text = "";
                    txtThanhTien.Text = "";
                }
        }
    }
}
