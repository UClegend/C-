using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SoHang1_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoHang1_Text.Length == 0)
                Message.Show("chưa nhập số hạng 1");
            if (txt_SoHang2.Text.Length == 0)
                Message.Show("chưa nhập số hạng 2");
        }
    }
}
