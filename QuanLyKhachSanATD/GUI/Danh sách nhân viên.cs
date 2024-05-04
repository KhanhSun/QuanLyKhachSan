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
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * form QLNhanVien";
            //command.SelectComand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Danh_sách_nhân_viên_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(query);
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
            string query= "UPDATE QLNhanVien SET MaNV=N'"+QLNhanVien.MaNV+ "',TenNV =N'"+QLNhanVien.TenNV+"',GioiTinh=N'"+QLNhanVien.GioiTinh+"',SDT="+QLNhanVien.SDT+",Email=N'"+QLNhanVien.Email+"',CCCD="+QLNhanVien.CCCD+",DiaChi=N'"+QLNhanVien.DiaChi+"',ChucDanh=N'"QLNhanVien.ChucDanh + "'";
            try
            {
                if(MessageBox.Show("Bạn có muốn sửa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    Modify.Command(query);
                    MessageBox.Show("Sua thanh cong !!");
                    Danh_sách_nhân_viên_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi sua:" + ex.Message);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            if(name=="") {
                Danh_sách_nhân_viên_Load(sender, e);
            }
            else
            {
                string query = "Select * from QLNhanVien Where MaNV ='" + name + "'";
                dataGridView1.DataSource = Modify.table(query);
            }
        }
    }
}
    