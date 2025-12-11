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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("vui long nhap lai","loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                string kq;
                if (a == 0)
                {
                    if (b == 0)
                        kq = "phuong trinh so nghiem";
                    else
                        kq = "phuong trinh vo nghiem";
                }
                else
                {
                    double x = -b / a;
                kq = "Nghiệm x = " + x;
            }
        lblKetQua.Text = kq;
        }
        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             txtA.Clear();
            txtB.Clear();
            lblKetQua.Text = "";
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {
            -
        }
    }
}
