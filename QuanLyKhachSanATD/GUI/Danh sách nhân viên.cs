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

namespace QLNV
{
    public partial class Danh_sách_nhân_viên : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-KQQI16KN\DUONG123;Initial Catalog=QL_NVBH;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * form QLNV";
            //command.SelectComand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Danh_sách_nhân_viên_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        public Danh_sách_nhân_viên()
        {
            InitializeComponent();
        }
        void CreateColumnForDataGridView()
        {
            var colOrganization = new DataGridViewTextBoxColumn();
            var colTen = new DataGridViewTextBoxColumn();
            var colLoai = new DataGridViewTextBoxColumn();
            var colCMND = new DataGridViewTextBoxColumn();
            var colNumberPhone = new DataGridViewTextBoxColumn();
            var colDiachi = new DataGridViewTextBoxColumn();

            colOrganization.HeaderText = "Tên đăng nhập";
            colTen.HeaderText = "Tên";
            colLoai.HeaderText = "Loại";
            colCMND.HeaderText = "CMND";
            colNumberPhone.HeaderText = "Số điện thoại";
            colDiachi.HeaderText = "Địa chỉ";

            colOrganization.DataPropertyName = "Oganization";
            colTen.DataPropertyName = "Ten";
            colLoai.DataPropertyName = "Loai";
            colCMND.DataPropertyName = "CMND";
            colNumberPhone.DataPropertyName = "NumberPhone";
            colDiachi.DataPropertyName = "Diachi";

            colOrganization.Width = 150;
            colTen.Width = 100;
            colLoai.Width = 80;
            colCMND.Width = 100;
            colNumberPhone.Width = 100;
            colDiachi.Width = 150;

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrganization, colTen, colLoai, colCMND, colNumberPhone, colDiachi });
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadListDSNV()
        {
            dataGridView1.DataSource = ListDSNV.Instance.ListnumberDSNV;
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

        private void Danh_sách_nhân_viên_Load_1(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
            LoadListDSNV();
        }
    }
}
