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
using QuanLyKhachSanATD.DTO;
using System.Threading.Tasks.Sources;

namespace QLNV
{
    public partial class Danh_sách_nhân_viên : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        private void Danh_sách_nhân_viên_Load(object sender, EventArgs e)
        {

        }
        public Danh_sách_nhân_viên()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thông_tin_nhân_viên form = new Thông_tin_nhân_viên();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thông_tin_nhân_viên form = new Thông_tin_nhân_viên();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thông_tin_nhân_viên form = new Thông_tin_nhân_viên();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            query = "Select * from NhanVien1";
            DataSet ds = sun.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Danh_sách_nhân_viên_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = " select * from NhanVien1 where MaNV = N'" + textBox1.Text + "'";
            DataSet ds = sun.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
    