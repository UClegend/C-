using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinhvien
{
    public class QuanLyNguoiDung
    {
        private List<NguoiDung> _danhSachUser;
        private string _filePath = "users.txt"; // File này sẽ nằm trong thư mục bin/Debug

        public QuanLyNguoiDung()
        {
            _danhSachUser = new List<NguoiDung>();
            DocFile();
            // Tạo sẵn 1 tài khoản admin nếu danh sách rỗng
            if (_danhSachUser.Count == 0)
            {
                DangKy("admin", "123", "admin@gmail.com");
            }
        }
        public bool DoiMatKhau(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            // Tìm người dùng có tài khoản và mật khẩu cũ trùng khớp
            var user = _danhSachUser.FirstOrDefault(u => u.TaiKhoan == taiKhoan && u.MatKhau == matKhauCu);

            if (user != null)
            {
                user.MatKhau = matKhauMoi; // Cập nhật mật khẩu mới
                LuuFile();                 // Lưu lại vào file
                return true;
            }
            return false; // Sai mật khẩu cũ hoặc không tìm thấy tài khoản
        }
        public bool DangNhap(string tk, string mk)
        {
            // Kiểm tra có ai trùng tài khoản và mật khẩu không
            return _danhSachUser.Any(u => u.TaiKhoan == tk && u.MatKhau == mk);
        }

        public bool DangKy(string tk, string mk, string email)
        {
            // Kiểm tra tài khoản đã tồn tại chưa
            if (_danhSachUser.Any(u => u.TaiKhoan == tk))
            {
                return false; // Đã tồn tại
            }

            _danhSachUser.Add(new NguoiDung(tk, mk, email));
            LuuFile();
            return true;
        }

        public string LayLaiMatKhau(string tk, string email)
        {
            var user = _danhSachUser.FirstOrDefault(u => u.TaiKhoan == tk && u.Email == email);
            if (user != null)
            {
                return user.MatKhau;
            }
            return null; // Không tìm thấy
        }

        private void LuuFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    foreach (var u in _danhSachUser)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2}", u.TaiKhoan, u.MatKhau, u.Email));
                    }
                }
            }
            catch { }
        }

        private void DocFile()
        {
            if (!File.Exists(_filePath)) return;
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3)
                        {
                            _danhSachUser.Add(new NguoiDung(parts[0], parts[1], parts[2]));
                        }
                    }

                }
            }
            catch { }

        }
    }
}
