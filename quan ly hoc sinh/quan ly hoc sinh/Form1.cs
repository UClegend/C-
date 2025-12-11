using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_hoc_sinh
{
    public partial class Form1 : Form
    {
        int stt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text;
            double toan, van;

            // Kiểm tra nhập hợp lệ
            if (hoTen == "")
            {
                MessageBox.Show("nhập họ tên");
                return;
            }

            if (!double.TryParse(txtToan.Text, out toan) || !double.TryParse(txtVan.Text, out van))
            {
                MessageBox.Show("chỉ nhập số");
                return;
            }

            if (toan < 0 || toan > 10 || van < 0 || van > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng 0 - 10");
                return;
            }


            hocsinh hs = new hocsinh(hoTen, toan, van);
            }
         public class hocsinh
    {
      public string hoTen;
            public double Van, Toan;

            public double DiemTB()
            {
                return (Van + Toan) / 2;
            }
        }        
        public string hoTen { get; set; }
        public double diemToan { get; set; }
        public double diemVan { get; set; }
        public hocsinh(string hoTen, double diemToan, double diemVan)
        {
            this.hoTen = hoTen;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
        }

        public double DiemTrungBinh()
        {
            return (diemToan + diemVan) / 2;
        }
    }

         private void lblKetQua1_Click(object sender, EventArgs e)
         {

         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
      

         }

         private void Form1_Load(object sender, EventArgs e)
         {
             dataGridView1.Columns.Add("STT", "STT");
             dataGridView1.Columns.Add("HoTen", "Họ tên");
             dataGridView1.Columns.Add("DiemVan", "Điểm Văn");
             dataGridView1.Columns.Add("DiemToan", "Điểm Toán");
             dataGridView1.Columns.Add("DiemTrungBinh", "Điểm trung bình");
             dataGridView1.Rows.Add(1, "Jake", 7, 8, (7 + 8) / 2.0);
         }

       
 }
}

