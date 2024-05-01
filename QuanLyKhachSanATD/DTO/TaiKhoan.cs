using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanATD.DTO
{
    class TaiKhoan
    {
        private string TenTK;
        private string MatkhauTK;
        private string LoaiTaiKhoan;
        public TaiKhoan() 
        { 
        }

        public TaiKhoan(string tenTK, string matkhauTK, string loaiTaiKhoan)
        {
            TenTK = tenTK;
            MatkhauTK = matkhauTK;
            LoaiTaiKhoan = loaiTaiKhoan;
        }

        public string TenTK1 { get => TenTK; set => TenTK = value; }
        public string MatkhauTK1 { get => MatkhauTK; set => MatkhauTK = value; }
        public string LoaiTaiKhoan1 { get => LoaiTaiKhoan; set => LoaiTaiKhoan = value; }
    }
}
