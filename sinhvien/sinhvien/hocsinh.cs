using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhvien
{
    // *** CLASS HOCSINH (ĐÃ THÊM ID) ***
    public class HocSinh
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public double DiemToan { get; set; }
        public double DiemVan { get; set; }

        public HocSinh(int id, string hoTen, double diemToan, double diemVan)
        {
            Id = id;
            HoTen = hoTen;
            DiemToan = diemToan;
            DiemVan = diemVan;
        }

        public double DiemTrungBinh()
        {
            return (DiemToan + DiemVan) / 2;
        }
    }
}