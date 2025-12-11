using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class frmDangNhap : Form
    {
        private QuanLyNguoiDung _quanLy;

        public frmDangNhap()
        {
            InitializeComponent();
            _quanLy = new QuanLyNguoiDung();
            // Căn giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;

            if (_quanLy.DangNhap(tk, mk))
            {
                this.Hide();
                Form1 frmMain = new Form1();

                frmMain.TaiKhoanDangNhap = tk; // <--- QUAN TRỌNG: Truyền tên đăng nhập sang

                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form đăng nhập đi

            frmDangKy frm = new frmDangKy(_quanLy);
            frm.ShowDialog(); // Chờ form đăng ký xử lý xong

            this.Show(); // Hiện lại form đăng nhập
        }

        private void lnkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form quên mật khẩu
            frmQuenMatKhau frm = new frmQuenMatKhau(_quanLy);
            frm.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // Lưu ý: Nếu code báo lỗi ở chữ _quanLy, hãy đảm bảo bạn đã khai báo nó ở đầu form
            if (_quanLy == null) _quanLy = new QuanLyNguoiDung();

            frmDoiMatKhau frm = new frmDoiMatKhau(_quanLy);
            frm.ShowDialog();
        }
    }
}

