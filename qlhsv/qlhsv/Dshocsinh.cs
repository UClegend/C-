using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlhsv
{
    class Dshocsinh
    {
        private list<HocSinh> DanhSach { get; set; }

        public Dshocsinh()
        {
            DanhSach = new list<HocSinh>();
        }
        public void Them(HocSinh hs)
        {
            DanhSach.add(hs);
        }
        public bool Xoa(int id)
        {
            var hs = DanhSach.FirstOrDefault(h => h.ID == id);
            if (hs != null)
            {
                DanhSach.Remove(hs);
                return true;
            }
            return false;
        }
        public bool CapNhat(HocSinh hsMoi)
        {
            var hsCu = DanhSach.FirstOrDefault(h => h.ID == hsMoi.ID);
            if (hsCu != null)
            {
                hsCu.TenHS = hsMoi.TenHS;
                hsCu.DiemVan = hsMoi.DiemVan;
                hsCu.DiemToan = hsMoi.DiemToan;
                return true;
            }
            return false;
        }
        public list<HocSinh> getDanhSach()
        {
            return DanhSach;
        }
    }
}
