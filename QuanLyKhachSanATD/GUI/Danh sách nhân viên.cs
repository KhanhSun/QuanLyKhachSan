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
        string connectstring = "Data Source=DESKTOP-I7E37RP;Database=QLKS;Trusted_Connection=True;";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * form NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Danh_sách_nhân_viên_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectstring);
            connection.Open();
            loaddata();
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
            try
            {
                connection.Open();
                command = new SqlCommand("select * from NhanVien", connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Danh_sách_nhân_viên_Load_1(object sender, EventArgs e)
        {

        }
    }
}
    