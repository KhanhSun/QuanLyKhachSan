using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKiThuat.DAO
{
    internal class QLKT_DAO
    {
        private DataProvider _provider = new DataProvider();
        public QLKT_DAO()
        {
            //_provider.connect();
        }
        //Lấy toàn bộ danh sách Phòng
        public DataTable getDSPhong()
        {
            string sqlStr = "SELECT * FROM KyThuat";
            return _provider.executeQuery(sqlStr);
        }

        public DataTable getDSPhong(string MaPhong)
        {
            string sqlStr = "SELECT * FROM KyThuat Where MaPhong='" + MaPhong + "'";
            return _provider.executeQuery(sqlStr);
        }

        public void insert(string MaPhong, int MaNV, DateTime NgayBaoTri, string ThongTinBaoTri, float TienPhuCap)
        {

            string strInsert = "insert into KyThuat values('" + MaPhong + "',N'" + ThongTinBaoTri + "'," + MaNV + "'," + "'," + NgayBaoTri.ToString("MM/dd/yyyy") + "'," + TienPhuCap + "')";
            _provider.executeNonQuery(strInsert);
        }

        public void update(string MaPhong, int MaNV, DateTime NgayBaoTri, string ThongTinBaoTri, float TienPhuCap)
        {
            string strUpdate = "update KyThuat set ThongTinBaoTri =N'" + ThongTinBaoTri + "'," + MaNV + "'," + "'," + NgayBaoTri.ToString("MM/dd/yyyy") + "'," + TienPhuCap + ",MaPhong='" + MaPhong + "'where MaPhong ='" + MaPhong + "'";
            _provider.executeNonQuery(strUpdate);
        }

    }
}