using System;
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
    public partial class PhongMenu : Form
    {
        public PhongMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoaiPhong dp = new LoaiPhong ();
            this.Close ();
            dp.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            this.Close();
            dp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThanhToanPhong dp = new ThanhToanPhong();
            this.Close();
            dp.Show();
        }
    }
}
