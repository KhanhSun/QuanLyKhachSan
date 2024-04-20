using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    public class Danh_sach_nhan_vien
    {
        private string organization;
        private string ten;
        private string loai;
        private string CMND;
        private string SDT;
        private string diachi;

        public string Organization { get => organization; set => organization = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public string cMND { get => CMND; set => loai = value; }
        public string sDT { get => SDT; set => SDT = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public Danh_sach_nhan_vien(string organization, string ten, string loai, string CMND, string SDT, string diachi)
        {
            this.organization = organization;
            this.ten = ten;
            this.loai = loai;
            this.CMND = CMND;
            this.SDT = SDT;
            this.diachi = diachi;
        }
    }
}