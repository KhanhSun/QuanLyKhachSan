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
using System.Data.SqlClient;

namespace QLNV
{
    public partial class Thông_tin_nhân_viên : Form
    {
        public Thông_tin_nhân_viên()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        public void connect()
        {
            //Lấy chuỗi kết nối CSDL
            string strcon = "Data Source="điền của m vào dùm"; Initial Catalog=QLHOCSINH; User ID=sa;Password = sa";
            try
            {
                conn = new SqlConnection(strcon);
                // Mở kết nối
                conn.Open();
                //Ko làm gì thì đóng kết nối lại
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không kết nối được CSDL", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }
        string MaNV, TenNV, GioiTinh, Email, DiaChi, ChucDanh;
        int SDT, CCCD;
        private void button1_Click(object sender, EventArgs e)
        {
            MaNV= textBox1.Text;
            TenNV= textBox2.Text;
            Email= textBox6.Text;
            DiaChi=textBox4.Text;
            GioiTinh= comboBox1.SelectedValue.ToString();
            ChucDanh = comboBox2.SelectedValue.ToString();
            SDT= Convert.ToInt16(textBox3.Text);
            CCCD= Convert.ToInt16(textBox5.Text);
            try
            {
                conn.Open();
                string str = "insert into QlNhanVien VALUES('" + MaNV + "',N'" + TenNV + "'," + GioiTinh + "," + SDT + ",N'" + Email + "'," + CCCD + ",N'" + DiaChi + "',N'" + ChucDanh + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi" + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty; // Clear txtA
            textBox2.Text = string.Empty; // Clear txtB
            textBox3.Text = string.Empty; // Clear txtC
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
