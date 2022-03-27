using System;

namespace HeCoSo
{
    class Program
    {
        static int ChuyenHe10Sang2(int number)
        {
            int temp,tong = 0, i=1;
            do
            {
                temp = number % 2;
                tong += (i * temp);
                number /= 2;
                i = i * 10;
            } while (number > 0);
            return tong;
        }
        static int ChuyenHe10Sang8(int number)
        {
            int temp, tong = 0, i = 1;
            do
            {
                temp = number % 8;
                tong += (i * temp);
                number /= 2;
                i = i * 10;
            } while (number > 0);
            return tong;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Nhap he co so B bat ky (2,8,16): ");
            int B = Convert.ToInt32(Console.ReadLine());

            while(B != 2 || B != 8 || B != 16)
            {
                Console.WriteLine("Nhap he co so B bat ky (2,8,16): ");
                B = Convert.ToInt32(Console.ReadLine());
            }

            if(B == 2)
            {
                Console.WriteLine("Chuyen " + N + " tu he 10 sang he " + N + " la: " + ChuyenHe10Sang2(N));
            }else if(B == 8)
            {
                Console.WriteLine("Chuyen " + N + " tu he 10 sang he " + N + " la: " + ChuyenHe10Sang8(N));
            }
        }
    }
}
