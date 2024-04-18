using QuanLyKhachSanATD.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Form_DK_DN
{
    public partial class Form_DN : Form
    {
        String _username = "nvd";
        String _password = "15042004";
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

        private void btDN_Click(object sender, EventArgs e)
        {
            if (Checkinfo(UserText.Text, PassText.Text))
            {
                MainForm MF = new MainForm();
                MF.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Try again please !!");
        }
        bool Checkinfo(string username, string password)
        {
            if (_username.Equals(username) && _password.Equals(password))
            {
                return true;
            }
            return false;
        }
        private void PassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
