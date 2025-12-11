using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_hoc_sinh
{
    internal class hocsinh
    {
        // Thuộc tính (biến)
        public string hoTen { get; set; }
        public double diemToan { get; set; }
        public double diemVan { get; set; }

        // Hàm khởi tạo mặc định
        public hocsinh()
        {
            hoTen = "";
            diemToan = 0;
            diemVan = 0;
        }

        // Hàm khởi tạo có tham số
        public hocsinh (string hoTen, double diemToan, double diemVan)
        {
            this.hoTen = hoTen;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
        }

        // Phương thức tính điểm trung bình
        public double DiemTrungBinh()
        {
            return (diemToan + diemVan) / 2;
        }

        // Phương thức hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine("Họ tên: " + hoTen);
            Console.WriteLine("Điểm Toán: " + diemToan);
            Console.WriteLine("Điểm Văn: " + diemVan);
            Console.WriteLine("Điểm trung bình: " + DiemTrungBinh());
        }
    }
}
