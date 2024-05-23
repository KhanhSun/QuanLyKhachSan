using QLKiThuat.DAO;
using QLKiThuat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKiThuat.BUS
{
    internal class QLKT_BUS
    {
        //Để truy xuất xuống CSDL
        private readonly QLKT_DAO data = new QLKT_DAO();
        //Chứa thông tin của 1 Phòng
        public QLKT_DTO Info { get; set; }

        public DataTable GetDSPhong()
        {
            return data.getDSPhong();
        }
        public DataTable GetDSPhong(string MaPhong)
        {
            return data.getDSPhong(MaPhong);
        }
        public bool Insert()
        {
            try
            {
                data.insert(Info.MaPhong, Info.MaNV, Info.NgayBaoTri, Info.ThongTinBaoTri, Info.TienPhuCap);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu" + ex.Message);
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                data.update(Info.MaPhong, Info.MaNV, Info.NgayBaoTri, Info.ThongTinBaoTri, Info.TienPhuCap);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi updata dữ liệu" + ex.Message);
                return false;
            }
        }
    }
}
