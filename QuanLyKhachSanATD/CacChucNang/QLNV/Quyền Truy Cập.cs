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
    public partial class Quyền_Truy_Cập : Form
    {
        public Quyền_Truy_Cập()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
