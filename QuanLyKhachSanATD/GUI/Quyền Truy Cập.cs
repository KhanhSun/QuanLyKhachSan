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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thông_tin_nhân_viên form = new Thông_tin_nhân_viên();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty; // Clear txtC
            comboBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<String> gv = new List<String>();
        List<String> l = new List<String>();
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void button6_Click(object sender, EventArgs e)
        {
            string tgv = comboBox1.SelectedItem.ToString();
            string tl = listBox1.SelectedItem.ToString();
            int kt = 0;
            foreach (KeyValuePair<string, string> Kvp in dic)
            {
                if (Kvp.Key == tgv)
                {
                    kt++;
                }
            }
            if (kt >= 2)
            {
                MessageBox.Show("Nhân viên này đã được phân công nhiệm vụ !!!");
                return;
            }
            if (dic.ContainsKey(tl))
            {
                MessageBox.Show("Nhiệm vụ này đã có nhân viên đảm nhận!!!");
                return;
            }
            dic.Add(tl, tgv);
            listBox2.Items.Add($"{tgv} đảm nhận nhiệm vụ {tl} ");
        }
    }
}
