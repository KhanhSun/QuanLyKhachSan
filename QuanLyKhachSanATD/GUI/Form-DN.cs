using DevExpress.Data.Extensions;
using DevExpress.Utils;
using DevExpress.Xpo.DB.Helpers;
using QuanLyKhachSanATD.DTO;
using QuanLyKhachSanATD.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Form_DK_DN
{
    public partial class Form_DN : Form
    {
        int Errorcount = 0;
        public Form_DN()
        {
            InitializeComponent();

        }

        private void Form_DN_Load(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Click(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        private void btDN_Click(object sender, EventArgs e)
        {
            string tentk = UserText.Text;
            string matkhau = PassText.Text;
            string quyen = "";
            if (tentk.Trim() == "") { MessageBox.Show("Nhập tên tài khoản !"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Nhập mật khẩu !"); }
            else
            {
                string query = "Select * from TaiKhoan where usernameAcc = '" + tentk + "' and passwordAcc = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    foreach (TaiKhoan permission in modify.TaiKhoans(query))
                    {
                        // Do something with the permission
                        quyen = permission.LoaiTaiKhoan1;
                    }
                    MainForm un = new MainForm(tentk,quyen);
                    un.Show();
                    this.Close();
                }
                else
                {
                    if(Errorcount == 3)
                    {
                        Application.Exit();
                    }
                    MessageBox.Show("Đăng nhập không thành công! \n Sai 3 lần sẽ tắt chương trình!");
                    Errorcount ++;
                }
            }

        }
        private void PassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
