using System;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class frmDangKy : Form
    {
        private QuanLyNguoiDung _quanLy;

        // Nhận đối tượng quản lý từ form đăng nhập truyền sang
        public frmDangKy(QuanLyNguoiDung ql)
        {
            InitializeComponent();
            _quanLy = ql;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnXacNhanDK_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập thiếu
            if (string.IsNullOrEmpty(txtDK_TaiKhoan.Text) || string.IsNullOrEmpty(txtDK_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                return;
            }

            // 2. Gọi hàm đăng ký từ class Quản Lý
            bool ketQua = _quanLy.DangKy(txtDK_TaiKhoan.Text, txtDK_MatKhau.Text, txtDK_Email.Text);

            if (ketQua)
            {
                // 3. Thông báo thành công
                MessageBox.Show("Đăng ký thành công! Hãy đăng nhập ngay.", "Thông báo");

                // 4. Đóng form Đăng Ký lại -> Tự động quay về Form Đăng Nhập đang chờ sẵn
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản này đã tồn tại, vui lòng chọn tên khác.", "Lỗi");
            }
        }
    }
}