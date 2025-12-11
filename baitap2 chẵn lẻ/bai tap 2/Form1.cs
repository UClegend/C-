using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_tap_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trong các ListBox
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            int n;

            // Kiểm tra rỗng
            if (txtN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số N!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            // Kiểm tra nhập có phải là số hay không
            try
            {
                n = int.Parse(txtN.Text);
            }
            catch
            {
                MessageBox.Show("Giá trị nhập phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            // Kiểm tra N có hợp lệ không
            if (n <= 0)
            {
                MessageBox.Show("N phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            // Duyệt và hiển thị
            for (int i = 1; i <= n; i++)
            {
                listBox1.Items.Add(i);

                if (i % 2 == 0)
                    listBox2.Items.Add(i); // số chẵn
                else
                    listBox3.Items.Add(i); // số lẻ
            }
         }

    }
}
