using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinhvien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // --- SỬA DÒNG NÀY ---
            // Cũ: Application.Run(new Form1());
            // Mới: Chạy form Đăng Nhập đầu tiên
            Application.Run(new frmDangNhap());
        }
    }
}

