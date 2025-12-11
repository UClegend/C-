using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_lap_trinh_huong_doi_tuong
{
    class chuNhat
    {
        private double dai;
        private double rong;

        public chuNhat()
        {
            dai = 0;
            rong = 0;
        }
        public chuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public void Info()
        {
            Console.WriteLine("Chiều dài:" + dai);
            Console.WriteLine("chiều rộng" + rong);
        }
        public double DienTich()
        {
            return dai * rong;
        }
        public double Chuvi()
        {
            return 2 * (dai * +rong);
        }
    }
}
