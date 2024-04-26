using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KyThuat
{
    public partial class MainForm : Form
    {
        public string chuoiKetNoi = "Data Source=LAPTOP-12NN13S8;Initial Catalog=QL_KyThuat;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public MainForm()
        {
            InitializeComponent();

            cboTrangThaiBaoTri.Items.Add("Hoàn thành");
            cboTrangThaiBaoTri.Items.Add("Đang xử lý");
        }
        private void btnLichBaoTri_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn nút lên lịch bảo trì
            string maThietBi = txtMaThietBi.Text;
            DateTime ngayBaoTri = dtpNgayBaoTri.Value;
            string moTaCongViec = txtMoTaCongViec.Text;

            // Lưu thông tin bảo trì vào cơ sở dữ liệu (CSDL) hoặc tệp tin
            LuuThongTinBaoTriVaoCSDL(maThietBi, ngayBaoTri, moTaCongViec);
        }

        private void btnXacNhanSua_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn nút xác nhận sửa chữa
            int maBaoTri = Convert.ToInt32(txtMaBaoTri.Text);

            // Cập nhật trạng thái công việc bảo trì trong CSDL
            CapNhatTrangThaiBaoTri(maBaoTri, "HoanThanh");
        }

        private void btnLuuChiPhi_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn nút lưu chi phí sửa chữa
            int maBaoTri = Convert.ToInt32(txtMaBaoTri.Text);
            decimal chiPhiSuaChua = Convert.ToDecimal(txtChiPhiSuaChua.Text);
            string moTaSuaChua = txtMoTaSuaChua.Text;

            // Lưu thông tin chi phí sửa chữa vào CSDL
            LuuChiPhiSuaChuaVaoCSDL(maBaoTri, chiPhiSuaChua, moTaSuaChua);
        }

        private void LuuThongTinBaoTriVaoCSDL(string maThietBi, DateTime ngayBaoTri, string moTaCongViec)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(chuoiKetNoi));
                //fix
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lên lịch bảo trì: " + ex.Message);
            }
        }

        private void CapNhatTrangThaiBaoTri(int maBaoTri, string trangThai)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(chuoiKetNoi))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE MaintenanceStatus SET TrangThai = @TrangThai WHERE MaBaoTri = @MaBaoTri", connection);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@MaBaoTri", maBaoTri);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật trạng thái bảo trì thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái bảo trì: " + ex.Message);
            }
        }

        private void LuuChiPhiSuaChuaVaoCSDL(int maBaoTri, decimal chiPhiSuaChua, string moTaSuaChua)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(chuoiKetNoi))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO RepairCost (MaBaoTri, ChiPhi, MoTaSuaChua) VALUES (@MaBaoTri, @ChiPhi, @MoTaSuaChua)", connection);
                    cmd.Parameters.AddWithValue("@MaBaoTri", maBaoTri);
                    cmd.Parameters.AddWithValue("@ChiPhiSuaChua", chiPhiSuaChua);
                    cmd.Parameters.AddWithValue("@MoTaSuaChua", moTaSuaChua);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu chi phí sửa chữa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu chi phí sửa chữa: " + ex.Message);
            }
        }

        private void cboTrangThaiBaoTri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
