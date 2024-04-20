using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    public class ListDSNV
    {
        private static ListDSNV instance;
        List<Danh_sach_nhan_vien> listnumberDSNV;
        public List<Danh_sach_nhan_vien> ListnumberDSNV { get => listnumberDSNV; set => listnumberDSNV = value; }
        public static ListDSNV Instance
        {
            get
            {
                if(instance == null)
                    instance = new ListDSNV();
                return instance;
            }
            set => instance = value;
        }
        public ListDSNV()
        {
            ListnumberDSNV = new List<Danh_sach_nhan_vien>();
            ListnumberDSNV.Add(new Danh_sach_nhan_vien("Jayzunzun", "jay", "Quản lí", "040204020441", "0862686521", "Bình Dương"));
            ListnumberDSNV.Add(new Danh_sach_nhan_vien("Taienzo", "tai", "Kỹ thuật", "040204020442", "0862686522", "Bình Dương"));
            ListnumberDSNV.Add(new Danh_sach_nhan_vien("Saboru", "sa", "Buồng phòng", "040204020443", "0862686523", "Bình Dương"));
        }
    }
}
