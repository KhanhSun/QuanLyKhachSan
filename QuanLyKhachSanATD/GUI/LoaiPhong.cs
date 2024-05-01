
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanATD.DAL;


namespace QuanLyKhachSanATD.GUI
{
    public partial class LoaiPhong : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query="";
        public LoaiPhong()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Phòng đơn");
            comboBox1.Items.Add("Phòng đôi");
            comboBox1.Items.Add("Phòng VIP");
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoaiPhong_Load_1(object sender, EventArgs? e)
        {
            query = "Select * from LoaiPhong";
            DataSet ds = sun.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RNum.Text != "" && comboBox1.Text != "" && Bedtype.Text != "" && textBox1.Text != "")
            {
                String roomno = RNum.Text;
                String type = comboBox1.Text;
                String bed = Bedtype.Text;
                Int64 price = Int64.Parse(textBox1.Text);

                query = @"insert into LoaiPhong (MaPhong, TenLoaiPhong, LoaiGiuong,GiaPhong) values ('" + roomno + "',N'" + type + "',N'" + bed + "'," + price + ")";
                sun.setData(query, "Đã thêm phòng");

                LoaiPhong_Load_1(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            RNum.Clear();
            comboBox1.SelectedIndex = -1;
            Bedtype.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void LoaiPhong_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void LoaiPhong_Enter(object sender, EventArgs e)
        {
            LoaiPhong_Load_1(this, null);
        }

        private void Bedtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bedtype.Items.Add("Giường đơn");
            Bedtype.Items.Add("Giường đôi"); 
            Bedtype.Items.Add("Giường cao cấp");
        }
    }
}
