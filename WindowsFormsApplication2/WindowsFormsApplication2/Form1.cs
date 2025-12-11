using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            if (txt_SoHang1.Text.Length == 0)
                MessageBox.Show("chưa nhập số hạng 1");
            if (txt_SoHang2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số hạng 2");
            //lay dữ liệu
            int sh1, sh2, kq; // khai báo biến
            sh1 = int.Parse(txt_SoHang1.Text);
            sh2 = int.Parse(txt_SoHang2.Text);
            //MessageBox.Show("SH1 là: " + sh1 + "; SH2 là: " + sh2); 
            kq = sh1 + sh2;
            txt_KetQua.Text = (sh1 + sh2).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
