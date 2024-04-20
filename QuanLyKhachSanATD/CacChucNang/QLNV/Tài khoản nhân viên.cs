using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Tài_khoản_nhân_viên : Form
    {
        public Tài_khoản_nhân_viên()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Quản lí");
            comboBox1.Items.Add("Lế tân");
            comboBox1.Items.Add("Buồng phòng");
            comboBox1.Items.Add("Ẩm thực");
            comboBox1.Items.Add("Kỹ thuật");
            comboBox1.Items.Add("Kinh doanh");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
