using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nam;
            nam = int.Parse(textBoxNam.Text);
            String ketqua;
            if (laNamNhuan(nam))
            {
                ketqua = "Nam" + nam + "la nam nhuan";
            }
            else
            {
                ketqua = "Nam " + nam + " khong phai la nam nhuan";
            }
            iblKetQua.Text = ketqua;
        }
        static bool laNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private void iblKetQua_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
