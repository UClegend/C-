using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            double diem;

            try
            {
                diem = double.Parse(txtDiem.Text);
            }
            catch
            {
                MessageBox.Show("Giá trị nhập phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            // Kiểm tra khoảng hợp lệ
            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
          return;
            }
            string kq;
            if (diem >= 10)
                kq = "Xuất sắc thiên tài ";
            else if (diem >= 8)
                kq = "Giỏi";
            else if (diem >= 6.5)
                kq = "Khá";
            else if (diem >= 5)
                kq = "Trung bình";
            else
                kq = "Yếu";

            lblKetQua.Text = "Xếp loại: " + kq;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDiem.Clear();
            lblKetQua.Text = "";
            txtDiem.Focus();
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
