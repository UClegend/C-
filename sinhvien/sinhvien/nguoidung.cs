using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhvien
{
    public class NguoiDung
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; } // Dùng để lấy lại mật khẩu

        public NguoiDung(string tk, string mk, string email)
        {
            TaiKhoan = tk;
            MatKhau = mk;
            Email = email;
        }
    }
}