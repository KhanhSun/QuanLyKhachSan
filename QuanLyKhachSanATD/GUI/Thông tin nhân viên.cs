using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSanATD.DAL;

namespace QLNV
{
    public partial class Thông_tin_nhân_viên : Form
    {
        string connectstring = string.Empty;

        ConnectionDB sun = new ConnectionDB();
        string query = "";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void Thông_tin_nhân_viên_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectstring);
            connection.Open();
        }
        public Thông_tin_nhân_viên()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        public void setcombobox(String query, ComboBox combo)
        {
            SqlDataReader rs = sun.getforCmb(query);
            while (rs.Read())
            {
                for (int i = 0; i < rs.FieldCount; i++)
                {
                    combo.Items.Add(rs.GetString(i));
                }
            }
            rs.Close();
        }
        public void connect()
        {
            //Lấy chuỗi kết nối CSDL
            //string strcon = @"Data Source=""; Initial Catalog=QLHOCSINH; User ID=sa;Password = sa";
            try
            {
                //conn = new SqlConnection(strcon);
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
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string MaNV, TenNV, GioiTinh, Email, DiaChi, ChucDanh;
        int SDT, CCCD;
        private void button1_Click(object sender, EventArgs e)
        {
            MaNV = textBox1.Text;
            TenNV = textBox2.Text;
            Email = textBox6.Text;
            DiaChi = textBox4.Text;
            GioiTinh = comboBox1.SelectedValue.ToString();
            SDT = Convert.ToInt16(textBox3.Text);
            CCCD = Convert.ToInt16(textBox5.Text);
            try
            {
                conn.Open();
                string str = "insert into NhanVien VALUES('" + MaNV + "',N'" + TenNV + "'," + GioiTinh + "," + SDT + ",N'" + Email + "'," + CCCD + ",N'" + DiaChi + "',N'" + ChucDanh + "')";
                //cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi" + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete form NhanVien where MaNV = '" + textBox1.Text + "'";
            command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "update form NhanVien where TenNV = '" + textBox2.Text + "',GioiTinh ='" + comboBox1.Text + "',Email='" + textBox3.Text + "',SDT = " + textBox4.Text + ",DiaChi = '" + textBox5.Text + "',SoCMND = " + textBox6.Text + "";
            command.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Thông_tin_nhân_viên_Load_1(object sender, EventArgs e)
        {
            query = "select distinct GioiTinh from NhanVien1";
            setcombobox(query, comboBox1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
