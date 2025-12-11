using System;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class frmQuenMatKhau : Form
    {
        private QuanLyNguoiDung _quanLy;

        public frmQuenMatKhau(QuanLyNguoiDung ql)
        {
            InitializeComponent();
            _quanLy = ql;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string pass = _quanLy.LayLaiMatKhau(txtQMK_TaiKhoan.Text, txtQMK_Email.Text);
            if (pass != null)
            {
                MessageBox.Show("Mật khẩu của bạn là: " + pass, "Thông báo");
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản hoặc Email không chính xác!", "Lỗi");
            }
        }
    }
}