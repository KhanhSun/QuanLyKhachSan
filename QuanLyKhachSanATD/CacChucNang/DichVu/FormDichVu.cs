using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DichVu
{
    public partial class FormDichVu : Form
    {
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            this.TransparencyKey = Color.Blue;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
