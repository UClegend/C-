using System;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class frmDoiMatKhau : Form
    {
        private QuanLyNguoiDung _quanLy;

        // Chỉ cần nhận vào bộ Quản lý, không cần tên tài khoản sẵn
        public frmDoiMatKhau(QuanLyNguoiDung ql)
        {
            InitializeComponent();
            _quanLy = ql;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập thiếu (Phải nhập cả Tên tài khoản)
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) ||
                string.IsNullOrEmpty(txtMatKhauCu.Text) ||
                string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản, Mật khẩu cũ và mới!");
                return;
            }

            // 2. Kiểm tra xác nhận mật khẩu mới
            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại không khớp!", "Lỗi");
                return;
            }

            // 3. Gọi hàm đổi mật khẩu (truyền vào Tài khoản người dùng tự nhập)
            bool ketQua = _quanLy.DoiMatKhau(txtTaiKhoan.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text);

            if (ketQua)
            {
                MessageBox.Show("Đổi mật khẩu thành công! Hãy đăng nhập lại.", "Thành công");
                this.Close(); // Đóng form quay về đăng nhập
            }
            else
            {
                // Nếu sai thì chỉ có thể là sai Tài khoản hoặc sai Mật khẩu cũ
                MessageBox.Show("Tên tài khoản hoặc Mật khẩu CŨ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}