
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV;
using QuanLyKhachSan.Form_DK_DN;
using QuanLyKhachSanATD.GUI;
using QuanLyKhachSan.QLKH;

namespace QuanLyKhachSanATD.MainForm
{
    public partial class MainForm : Form
    {
        string tenuser = "";
        string checkquyen = "";
        public MainForm(string tentk, string quyen)
        {
            InitializeComponent();
            checkquyen = quyen;
            tenuser = tentk;
            label1.Text = "User: "+tenuser.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nut dang xuat
            this.Close();
            Form_DN form_DN = new Form_DN();
            form_DN.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PhongBTN_Click(object sender, EventArgs e)
        {
            PhongMenu myForm = new PhongMenu();
            myForm.Show();

        }

        private void DichVuBTN_Click(object sender, EventArgs e)
        {
            DichVu dp = new DichVu();
            dp.ShowDialog();
        }

        private void BepBTN_Click(object sender, EventArgs e)
        {

        }

        private void KTBTN_Click(object sender, EventArgs e)
        {

        }

        private void KHBTN_Click(object sender, EventArgs e)
        {
            Form_QLKH kh = new Form_QLKH();
            kh.ShowDialog();
        }

        private void DTBTN_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            dt.ShowDialog();
        }

        private void KhoBTN_Click(object sender, EventArgs e)
        {
            Kho dp = new Kho();
            dp.ShowDialog();
        }
        void PhanQuyen()
        {
            if (checkquyen == "Nhân viên")
            {
                NVBTN.Enabled = false;
            }
        }
        private void NVBTN_Click(object sender, EventArgs e)
        {
            Chức_năng dp = new Chức_năng();
            dp.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void UserLa_Click(object sender, EventArgs e)
        {
            // trash
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
