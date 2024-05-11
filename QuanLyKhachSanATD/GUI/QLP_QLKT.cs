using QLPhong_QLKyThuat.BUS;
using QLPhong_QLKyThuat.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhong_QLKyThuat
{
    public partial class frmMain : Form
    {
        QLP_BUS QLP_BUS;
        QLP_DTO QLP_DTO;
        TKP_BUS TKP_BUS;
        TKP_DTO TKP_DTO;
        QLKT_BUS QLKT_BUS; 
        QLKT_DTO QLKT_DTO;
        public frmMain()
        {
            InitializeComponent();
        }

        private void getData()
        {
            QLP_DTO.SoPhong = txtSoPhong_QLP.Text;
            QLP_DTO.TinhTrangPhong = txtTinhTrangPhong_QLP.Text;
            QLP_DTO.LoaiPhong = txtLoaiPhong_QLP.Text;
            QLP_DTO.Giuong = txtGiuong_QLP.Text;
            QLP_DTO.GiaTien = float.Parse(txtGiaTien_QLP.Text);
            //Gán QLP_DTO cho info trong QLP_BUS
            QLP_BUS.info = QLP_DTO;
            TKP_BUS.info = TKP_DTO;
            QLKT_BUS.info = QLKT_DTO;
        }

        private void DinhDangLuoi_QLP()
        {
            dataGridView_QLP.ReadOnly = true;
            dataGridView_QLP.Columns[0].HeaderText = "Số Phòng";
            dataGridView_QLP.Columns[0].Width = 100;
            dataGridView_QLP.Columns[1].HeaderText = "Tinh Trạng Phòng";
            dataGridView_QLP.Columns[1].Width = 100;
            dataGridView_QLP.Columns[2].HeaderText = "Loại Phòng";
            dataGridView_QLP.Columns[2].Width = 100;
            dataGridView_QLP.Columns[3].HeaderText = "Giường";
            dataGridView_QLP.Columns[3].Width = 100;
            dataGridView_QLP.Columns[4].HeaderText = "Giá Tiền";
            dataGridView_QLP.Columns[4].Width = 150;
        }

        private void DinhDangLuoi_TKP()
        {
            dataGridView_TKP.ReadOnly = true;
            dataGridView_TKP.Columns[0].HeaderText = "Số Phòng";
            dataGridView_TKP.Columns[0].Width = 100;
            dataGridView_TKP.Columns[1].HeaderText = "Tinh Trạng Phòng";
            dataGridView_TKP.Columns[1].Width = 100;
            dataGridView_TKP.Columns[2].HeaderText = "Loại Phòng";
            dataGridView_TKP.Columns[2].Width = 100;
            dataGridView_TKP.Columns[3].HeaderText = "Giường";
            dataGridView_TKP.Columns[3].Width = 100;
            dataGridView_TKP.Columns[4].HeaderText = "Giá Tiền";
            dataGridView_TKP.Columns[4].Width = 150;
        }

        private void DinhDangLuoi_QLKT()
        {
            dataGridView_QLKT.ReadOnly = true;
            dataGridView_QLKT.Columns[0].HeaderText = "Số Phòng";
            dataGridView_QLKT.Columns[0].Width = 100;
            dataGridView_QLKT.Columns[1].HeaderText = "Tinh Trạng Phòng";
            dataGridView_QLKT.Columns[1].Width = 100;
            dataGridView_QLKT.Columns[2].HeaderText = "Mô Tả";
            dataGridView_QLKT.Columns[2].Width = 250;
            dataGridView_QLKT.Columns[3].HeaderText = "Giá Tiền";
            dataGridView_QLKT.Columns[3].Width = 150;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Thiết lập chuỗi kết nối
            DataProvider.connectionString = @"Data Source=LAPTOP-12NN13S8;Initial Catalog=QLKS;Integrated Security=True;";
            DataProvider provider = new DataProvider();
            provider.connect();
            //Từ câu lệnh này conn sẽ được thiết lặp và có thể gọi DataProvider.conn;
            QLP_BUS = new QLP_BUS();
            QLP_DTO = new QLP_DTO();
            TKP_BUS = new TKP_BUS();
            TKP_DTO = new TKP_DTO();
            QLKT_BUS = new QLKT_BUS();
            QLKT_DTO = new QLKT_DTO();

            dataGridView_QLP.DataSource = QLP_BUS.getDSPhong();
            //Định dạng lưới
            DinhDangLuoi_QLP();

            dataGridView_TKP.DataSource = TKP_BUS.getDSPhong();
            //Định dạng lưới
            DinhDangLuoi_TKP();

            dataGridView_QLKT.DataSource = QLKT_BUS.getDSPhong();
            //Định dạng lưới
            DinhDangLuoi_QLKT();
        }
        private void CapNhatDuLieu()
        {
            dataGridView_QLP.DataSource = QLP_BUS.getDSPhong();
            dataGridView_TKP.DataSource = TKP_BUS.getDSPhong();
            dataGridView_QLKT.DataSource = QLKT_BUS.getDSPhong();
        }
        private void btnThem_QLP_Click(object sender, EventArgs e)
        {
            QLP_BUS.info = new QLP_DTO();
            QLP_BUS.info.SoPhong = txtSoPhong_QLP.Text;
            QLP_BUS.info.TinhTrangPhong = txtTinhTrangPhong_QLP.Text;
            QLP_BUS.info.LoaiPhong = txtLoaiPhong_QLP.Text;
            QLP_BUS.info.Giuong = txtGiuong_QLP.Text;
            QLP_BUS.info.GiaTien = float.Parse(txtGiaTien_QLP.Text);

            float GiaTien_QLP;
            if (float.TryParse(txtGiaTien_QLP.Text, out GiaTien_QLP))
            {
                QLP_BUS.info.GiaTien = GiaTien_QLP;
            }
            else
            {
                // Xử lý trường hợp chuỗi đầu vào không phải là số hợp lệ
                MessageBox.Show("Giá trị không hợp lệ. Vui lòng nhập số.");
            }
            if (QLP_BUS.insert())
            {
                // Cập nhật lại dữ liệu trên DataGridView
                CapNhatDuLieu();
                // Thêm dữ liệu thành công
                MessageBox.Show("Thêm dữ liệu thành công");
                //Xóa dữ liệu trên control sau khi thêm mới
                txtSoPhong_QLP.Clear();
                txtTinhTrangPhong_QLP.Clear();
                txtLoaiPhong_QLP.Clear();
                txtGiuong_QLP.Clear();
                txtGiaTien_QLP.Clear();
            }
            else
            {
                // Thêm dữ liệu thất bại
                MessageBox.Show("Thêm dữ liệu thất bại");
            }
        }

        private void btnThem_QLKT_Click(object sender, EventArgs e)
        {
            QLKT_BUS.info = new QLKT_DTO();
            QLKT_BUS.info.MaPhong = txtSoPhong_QLKT.Text;
            QLKT_BUS.info.MaNV = int.Parse(txtTinhTrangPhong_QLKT.Text);
            QLKT_BUS.info.NgayBaoTri = int.Parse();
            QLKT_BUS.info.ThongTinBaoTri = txtMoTa_QLKT.Text;
            QLKT_BUS.info.TienPhuCap = float.Parse(txtGiaTien_QLKT.Text);

            float GiaTien_QLKT;
            if (float.TryParse(txtGiaTien_QLKT.Text, out GiaTien_QLKT))
            {
                QLKT_BUS.info.TienPhuCap = GiaTien_QLKT;
            }
            else
            {
                // Xử lý trường hợp chuỗi đầu vào không phải là số hợp lệ
                MessageBox.Show("Giá trị không hợp lệ. Vui lòng nhập số.");
            }
            if (QLKT_BUS.insert())
            {
                // Cập nhật lại dữ liệu trên DataGridView
                CapNhatDuLieu();
                // Thêm dữ liệu thành công
                MessageBox.Show("Thêm dữ liệu thành công");
                //Xóa dữ liệu trên control sau khi thêm mới
                txtSoPhong_QLKT.Clear();
                txtTinhTrangPhong_QLKT.Clear();
                txtMoTa_QLKT.Clear();
                txtGiaTien_QLKT.Clear();
            }
            else
            {
                // Thêm dữ liệu thất bại
                MessageBox.Show("Thêm dữ liệu thất bại");
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Thoát ra khỏi chương trình
        }

        private void btnSua_QLP_Click(object sender, EventArgs e)
        {
            getData();
            if (QLP_BUS.insert() == true)
            {
                //Load lai danh sach phong len luoi
                dataGridView_QLP.DataSource = QLP_BUS.getDSPhong();
                MessageBox.Show("Thêm thành công");
            }
        }
        private void btnCapNhat_QLKT_Click(object sender, EventArgs e)
        {
            getData();
            if (QLKT_BUS.insert() == true)
            {
                //Load lai danh sach phong len luoi
                dataGridView_QLKT.DataSource = QLKT_BUS.getDSPhong();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btnCapNhat_TKP_Click(object sender, EventArgs e)
        {
            getData();
            if (TKP_BUS.update() == true)
            {
                //Load lai danh sach phong len luoi
                dataGridView_TKP.DataSource = TKP_BUS.getDSPhong();
                MessageBox.Show("Sửa thành công");
            }
        }

        private void btnXoa_QLP_Click(object sender, EventArgs e)
        {
            getData();
            if (QLP_BUS.delete() == true)
            {
                //Load lai danh sach phong len luoi
                dataGridView_QLP.DataSource = QLP_BUS.getDSPhong();
                MessageBox.Show("Xóa thành công");
            }
        }


        private void dataGridView_QLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView_QLP.SelectedCells;
            if (cell.Count > 0)
            {
                DataGridViewRow row = dataGridView_QLP.Rows[e.RowIndex];
                txtSoPhong_QLP.Text = row.Cells["SoPhong"].Value.ToString();
                txtTinhTrangPhong_QLP.Text = row.Cells["TinhTrangPhong"].Value.ToString();
                txtLoaiPhong_QLP.Text = row.Cells["LoaiPhong"].Value.ToString();
                txtGiuong_QLP.Text = row.Cells["Giuong"].Value.ToString();
                txtGiaTien_QLP.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }

        private void dataGridView_TKP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView_QLP.SelectedCells;
            if (cell.Count > 0)
            {
                DataGridViewRow row = dataGridView_TKP.Rows[e.RowIndex];
                txtSoPhong_TKP.Text = row.Cells["SoPhong"].Value.ToString();
                txtTinhTrangPhong_TKP.Text = row.Cells["TinhTrangPhong"].Value.ToString();
                txtLoaiPhong_TKP.Text = row.Cells["LoaiPhong"].Value.ToString();
                txtGiuong_TKP.Text = row.Cells["Giuong"].Value.ToString();
                txtGiaTien_TKP.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }

        private void dataGridView_QLKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView_QLKT.SelectedCells;
            if (cell.Count > 0)
            {
                DataGridViewRow row = dataGridView_QLP.Rows[e.RowIndex];
                txtSoPhong_QLKT.Text = row.Cells["SoPhong"].Value.ToString();
                txtTinhTrangPhong_QLKT.Text = row.Cells["TinhTrangPhong"].Value.ToString();
                txtMoTa_QLKT.Text = row.Cells["MoTa"].Value.ToString();
                txtGiaTien_QLKT.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }
    }
}
