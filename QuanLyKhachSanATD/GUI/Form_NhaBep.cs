using QuanLyKhachSanATD.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanATD.GUI
{
    public partial class Form_NhaBep : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        public Form_NhaBep()
        {
            InitializeComponent();
        }

        private void Form_NhaBep_Load(object sender, EventArgs e)
        {
            query = "select dm.MaMonAn, dm.TenMonAn, dm.SoLuong, dm.TongTien, dm.GhiChuThem, dm.MaNV, md.MaKH, md.MaPhong From NhaBep dm, DatMon md where dm.TenMonAn = md.TenMon";
            DataSet ds = sun.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
