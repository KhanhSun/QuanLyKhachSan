using QuanLyKhachSanATD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.QLKH
{
    public partial class Form_QLKH : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        public Form_QLKH()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "CCCD", "*" + txtTimKiem.Text + "*");
            (dtgKH.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void Form_QLKH_Load(object sender, EventArgs? e)
        {
            query = "select kh.MaKH, kh.TenKH, kh.GioiTinhKH, kh.EmailKH, kh.SDTKH, kh.QuocTich, kh.CCCD From QLKhachHang kh";
            DataSet ds = sun.getData(query);
            dtgKH.DataSource = ds.Tables[0];
            txtMa.Visible = false;
            txtTen.Visible = false;
            txtEmail.Visible = false;
            txtSDT.Visible = false;
            txtQuocTich.Visible = false;
            txtCCCD.Visible = false;
            cmbSex.Visible = false;
            btnXacNhan.Visible = false;
        }

        private void dtgKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private DataSet getDSKH()
        {
            query = "select kh.MaKH, kh.TenKH, kh.GioiTinhKH, kh.EmailKH, kh.SDTKH, kh.QuocTich, kh.CCCD From QLKhachHang kh Where kh.CCCD";
            DataSet ds = sun.getData(query);
            return ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            txtTimKiem.Visible = false;
            label10.Visible = false;
            txtMa.Visible = true;
            txtTen.Visible = true;
            txtEmail.Visible = true;
            txtSDT.Visible = true;
            txtQuocTich.Visible = true;
            txtCCCD.Visible = true;
            cmbSex.Visible = true;
            btnXacNhan.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            txtTimKiem.Visible = true;
            label10.Visible = true;
            txtMa.Visible = false;
            txtTen.Visible = false;
            txtEmail.Visible = false;
            txtSDT.Visible = false;
            txtQuocTich.Visible = false;
            txtCCCD.Visible = false;
            cmbSex.Visible = false;
            btnXacNhan.Visible = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            query = @"INSERT INTO QLKhachHang (MaKH, TenKH, GioiTinhKH, EmailKH, SDTKH, QuocTich, CCCD) Values ('" + txtMa.Text + "',N'" + txtTen.Text + "','" + cmbSex.Text + "','" + txtEmail.Text + "','" + txtSDT.Text + "',N'" + txtQuocTich.Text + "','" + txtCCCD.Text + "')";
            sun.setData(query, "Them thanh cong");
            Form_QLKH_Load(this, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            query = "delete from QLKhachHang where CCCD = '"+txtTimKiem.Text+"'";
            sun.setData(query, "Xoa thanh cong");
            Form_QLKH_Load(this, null);
        }
    }
}
