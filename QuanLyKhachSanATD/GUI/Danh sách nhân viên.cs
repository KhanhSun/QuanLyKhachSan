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
    public partial class Danh_sách_nhân_viên : Form
    {
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

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrganization,colTen, colLoai, colCMND, colNumberPhone , colDiachi });
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadListDSNV()
        {
            dataGridView1.DataSource = ListDSNV.Instance.ListnumberDSNV;
        }
        private void Danh_sách_nhân_viên_Load(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
            LoadListDSNV();
        }
    }
}
