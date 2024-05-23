using QLKiThuat.BUS;
using QLKiThuat.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKiThuat
{
    public partial class frmMain : Form
    {
        QLKT_BUS QLKT_BUS;
        QLKT_DTO QLKT_DTO;
        public frmMain()
        {
            InitializeComponent();
        }

        private void getData_QLKT()
        {
            QLKT_DTO.MaPhong = txtMaPhong_QLKT.Text;
            QLKT_DTO.NgayBaoTri = dtpNgayBaoTri_QLKT.Value;
            QLKT_DTO.MaNV = int.Parse(txtMaNhanVien_QLKT.Text);
            QLKT_DTO.ThongTinBaoTri = txtThongTin_QLKT.Text;
            QLKT_DTO.TienPhuCap = float.Parse(txtTienPhuCap_QLKT.Text);
            //Gán QLKT_DTO cho info trong QLKT_BUS
            QLKT_BUS.Info = QLKT_DTO;
        }

        private void DinhDangLuoi_QLKT()
        {
            dataGridView_QLKT.ReadOnly = true;
            dataGridView_QLKT.Columns[0].HeaderText = "Thông Tin Bảo Trì";
            dataGridView_QLKT.Columns[0].Width = 200;
            dataGridView_QLKT.Columns[1].HeaderText = "Giá Tiền";
            dataGridView_QLKT.Columns[1].Width = 100;
            dataGridView_QLKT.Columns[2].HeaderText = "Ngày Bảo Trì";
            dataGridView_QLKT.Columns[2].Width = 150;
            dataGridView_QLKT.Columns[3].HeaderText = "Mã Phòng";
            dataGridView_QLKT.Columns[3].Width = 150;
            dataGridView_QLKT.Columns[4].HeaderText = "Mã Nhân Viên";
            dataGridView_QLKT.Columns[4].Width = 100;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Thiết lập chuỗi kết nối
            DataProvider.connectionString = @"Data Source=LAPTOP-12NN13S8;Initial Catalog=QLKS;Integrated Security=True;";
            DataProvider provider = new DataProvider();
            provider.connect();
            //Từ câu lệnh này conn sẽ được thiết lặp và có thể gọi DataProvider.conn;
            QLKT_BUS = new QLKT_BUS();
            QLKT_DTO = new QLKT_DTO();

            dataGridView_QLKT.DataSource = QLKT_BUS.GetDSPhong();
            //Định dạng lưới
            DinhDangLuoi_QLKT();
        }

        private void CapNhatDuLieu()
        {
            dataGridView_QLKT.DataSource = QLKT_BUS.GetDSPhong();
        }

        private void btnThem_QLKT_Click(object sender, EventArgs e)
        {
            QLKT_BUS.Info = new QLKT_DTO();
            QLKT_BUS.Info.MaPhong = txtMaPhong_QLKT.Text;
            QLKT_BUS.Info.MaNV = int.Parse(txtMaNhanVien_QLKT.Text);
            QLKT_BUS.Info.NgayBaoTri = dtpNgayBaoTri_QLKT.Value;
            QLKT_BUS.Info.ThongTinBaoTri = txtThongTin_QLKT.Text;
            QLKT_BUS.Info.TienPhuCap = float.Parse(txtTienPhuCap_QLKT.Text);

            float GiaTien_QLKT;
            if (float.TryParse(txtTienPhuCap_QLKT.Text, out GiaTien_QLKT))
            {
                QLKT_BUS.Info.TienPhuCap = GiaTien_QLKT;
            }
            else
            {
                // Xử lý trường hợp chuỗi đầu vào không phải là số hợp lệ
                MessageBox.Show("Giá trị không hợp lệ. Vui lòng nhập số.");
            }
            if (QLKT_BUS.Insert())
            {
                // Cập nhật lại dữ liệu trên DataGridView
                CapNhatDuLieu();
                // Thêm dữ liệu thành công
                MessageBox.Show("Thêm dữ liệu thành công");
                //Xóa dữ liệu trên control sau khi thêm mới
                txtMaPhong_QLKT.Clear();
                txtMaNhanVien_QLKT.Clear();
                txtThongTin_QLKT.Clear();
                txtTienPhuCap_QLKT.Clear();
            }
            else
            {
                // Thêm dữ liệu thất bại
                MessageBox.Show("Thêm dữ liệu thất bại");
            }
        }

        private void btnCapNhat_QLKT_Click(object sender, EventArgs e)
        {
            getData_QLKT();
            if (QLKT_BUS.Update() == true)
            {
                //Load lai danh sach phong len luoi
                dataGridView_QLKT.DataSource = QLKT_BUS.GetDSPhong();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Thoát ra khỏi chương trình
        }

        private void btnTimKiem_QLKT_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ textbox tìm kiếm
            string searchText = txtMaPhong_QLKT.Text.Trim();

            // Lọc dữ liệu trong DataGridView_QLKT
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridView_QLKT.DataSource;

            // Cập nhật DataGridView_QLKT với dữ liệu được lọc
            dataGridView_QLKT.DataSource = bindingSource;
        }

        private void dataGridView_QLKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView_QLKT.SelectedCells;
            if (cell.Count > 0)
            {
                DataGridViewRow row = dataGridView_QLKT.Rows[e.RowIndex];
                txtMaPhong_QLKT.Text = row.Cells["MaPhong"].Value.ToString();
                txtThongTin_QLKT.Text = row.Cells["ThongTinBaoTri"].Value.ToString();
                txtMaNhanVien_QLKT.Text = row.Cells["MaNV"].Value.ToString();
                if (row.Cells["NgayBaoTri"].Value.ToString().Length > 0)
                    dtpNgayBaoTri_QLKT.Value = DateTime.Parse(row.Cells["NgayBaoTri"].Value.ToString());
                txtTienPhuCap_QLKT.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }
    }
}
