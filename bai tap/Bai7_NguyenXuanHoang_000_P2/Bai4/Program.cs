using System;

namespace Bai4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            NguoiLaoDong x = new NguoiLaoDong("Xuan Hoang", 3000);

            Action<double> dele1 = (double thuNhap) => {
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
            };

            Console.WriteLine("Ten: " + x.hoTen);
            dele1(x.thuNhapTinhThue);
        }
    }
}
