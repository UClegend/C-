using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlhsv
{
    class hocsinh_cs
    {
        public int ID { get; set; }

        public string TenHS { get; set; }

        public double DiemVan { get; set; }

        public Hocsinh() {}

        public HocSinh(int id, string tenHS, double diemVan, double diemtoan)
        {
            ID = id;
            TenHS = tenHS;
            DiemVan = diemVan;
            DiemToan = diemToan;
        }
        public double DiemTrungBinh()
        }
            return (DiemVan = DiemToan) / 2.0;
}
}