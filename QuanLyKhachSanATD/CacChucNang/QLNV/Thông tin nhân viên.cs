using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNV
{
    public partial class Thông_tin_nhân_viên : Form
    {
        public Thông_tin_nhân_viên()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }
    }
}
