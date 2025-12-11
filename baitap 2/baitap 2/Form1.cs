using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            listBox1.Items.Clear();
            int n;

            // 
            if (txtN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số N!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            // 
            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            //
            if (radToanBo.Checked)
            {
                for (int i = 1; i <= n; i++)
                    listBox1.Items.Add(i);
            }
            else if (radChan.Checked)
            {
                for (int i = 1; i <= n; i++)
                    if (i % 2 == 0)
                        listBox1.Items.Add(i);
            }
            else if (radLe.Checked)
            {
                for (int i = 1; i <= n; i++)
                    if (i % 2 != 0)
                        listBox1.Items.Add(i);
            }
            else
            {
                MessageBox.Show("Hãy chọn một tùy chọn (Toàn bộ / Chẵn / Lẻ)!", "Thông báo");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
