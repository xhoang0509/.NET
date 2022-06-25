using System;

namespace Bai3
{
    class Program
    {

        public static void InThongTin(string name, float tienHoaHong)
        {
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Tien hoa hong: " + tienHoaHong);
        }
        static void Main(string[] args)
        {
            // bai 5 da sua
            NhanVien x = new NhanVien("Xuan Hoang", 2000);
            Func<float, float> dele1 = delegate (float tienBanHang)
            {
                if (tienBanHang < 1000)
                {
                    return tienBanHang * 0;
                }
                else if (tienBanHang < 3000)
                {
                    return (float)(tienBanHang * 0.05);
                }
                else
                {
                    return (float)(tienBanHang * 0.1);
                }
            };
            Action<string, float> dele2 = InThongTin;

            dele2(x.Ten, dele1(x.TenBanHang));


        }
    }
}
