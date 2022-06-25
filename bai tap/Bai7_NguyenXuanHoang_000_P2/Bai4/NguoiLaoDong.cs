using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class NguoiLaoDong
    {
        public string hoTen { get; set; }
        public double thuNhapTinhThue { get; set; }

        public NguoiLaoDong(string hoTen, double thuNhapTinhThue)
        {
            this.hoTen = hoTen;
            this.thuNhapTinhThue = thuNhapTinhThue;
        }

        public static void TinhThue(double thuNhap)
        {
            double thue = 0;
            if (thuNhap < 5)
            {
                thue = thuNhap * 0.05;
            }
            else if (thuNhap < 10)
            {
                thue = thuNhap * 0.1;
            }
            else
            {
                thue = thuNhap * 0.2;
            }

            Console.WriteLine("Thue thu nhap la: " + thue);
        }

    }
}
