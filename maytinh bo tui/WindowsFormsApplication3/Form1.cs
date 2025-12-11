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
        const int PHEP_CONG = 1, PHEP_TRU = 2, PHEP_NHAN = 3, PHEP_CHIA = 4;
        //
        int phep_tinh = 0;
        //
        double so_hang1, so_hang2;
        //
        bool nhapSoMoi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (phep_tinh == 0)
                return;
            so_hang2 = Double.Parse(textBox_KetQua.Text);
            double ketqua = 0;
            if (phep_tinh == PHEP_CONG)
                ketqua = so_hang1 + so_hang2;
            else if (phep_tinh == PHEP_TRU)
                ketqua = so_hang1 - so_hang2;
            else if (phep_tinh == PHEP_NHAN)
                ketqua = so_hang1 * so_hang2;
            else
                ketqua = so_hang1 / so_hang2;

            //xuat
            textBox_KetQua.Text = ketqua.ToString();
            phep_tinh = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "7";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "7";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "6";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "6";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox_KetQua.Text == "0" || nhapSoMoi)
        {
                textBox_KetQua.Text = "1";
                nhapSoMoi = false;
        }
            else
                textBox_KetQua.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            {
                phep_tinh = PHEP_NHAN;
                so_hang1 = Double.Parse(textBox_KetQua.Text);
                nhapSoMoi = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "9";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "9";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "5";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "5";
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox_KetQua.Text == "0" || nhapSoMoi)
            {
                textBox_KetQua.Text = "2";
                nhapSoMoi = false;
            }
            else
                textBox_KetQua.Text += "2";
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox_KetQua.Text == "0" || nhapSoMoi)
            {
                textBox_KetQua.Text = "3";
                nhapSoMoi = false;
            }
            else
                textBox_KetQua.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            phep_tinh = PHEP_CONG;
            so_hang1 = Double.Parse(textBox_KetQua.Text);
            nhapSoMoi = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "4";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "4";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "8";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "8";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            {
                if (textBox_KetQua.Text == "0" || nhapSoMoi)
                {
                    textBox_KetQua.Text = "0";
                    nhapSoMoi = false;
                }
                else
                    textBox_KetQua.Text += "0";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                phep_tinh = PHEP_TRU;
                so_hang1 = Double.Parse(textBox_KetQua.Text);
                nhapSoMoi = true;
            }
        }
    }
}
