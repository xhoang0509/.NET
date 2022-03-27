using System;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap vao n nguyen duong: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Yeu cau nhap vao n nguyen duong: ");
                }              
            } while (n < 0);

            int S1 = 0;
            double S2 = 0;
            for(int i = 1; i <= n; i++)
            {
                S1 += i;
                S2 += 1 / i;
            }

            Console.WriteLine("Tong S1 = " + S1);
            Console.WriteLine("Tong S2 = " + S2);


        }
    }
}
