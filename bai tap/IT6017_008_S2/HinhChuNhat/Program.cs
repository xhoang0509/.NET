using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int chieu_dai, chieu_rong;
            try
            {
                Console.WriteLine("Nhap chieu dai: ");
                chieu_dai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap chieu rong: ");
                chieu_rong = Convert.ToInt32(Console.ReadLine());

                while(chieu_rong <= 0 || chieu_dai <= 0)
                {
                    Console.WriteLine("\n\nYEU CAU NHAP SO NGUYEN DUONG !");
                    Console.WriteLine("Nhap chieu dai: ");
                    chieu_dai = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap chieu rong: ");
                    chieu_rong = Convert.ToInt32(Console.ReadLine());
                }

                int chu_vi = (chieu_dai + chieu_rong) * 2;
                int dien_tich = chieu_rong * chieu_dai;

                Console.WriteLine("\n\nChu vi: " + chu_vi);
                Console.WriteLine("Dien tich: " + dien_tich);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Yeu cau nhap so ! " + e.Message);
            }

           
        }
    }
}
