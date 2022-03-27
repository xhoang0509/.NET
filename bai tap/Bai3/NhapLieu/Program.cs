using System;

namespace NhapLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            // use do
            Console.Write("DO: Nhap n (0 < n < 100) = ");
            n = int.Parse(Console.ReadLine());
            while (n < 0 || n > 100)
            {
                Console.Write("YEU CAU Nhap n (0 < n < 100) = ");
                n = int.Parse(Console.ReadLine());
            }

            // use do while
            do
            {
                Console.Write("WHILE: Nhap n (0 < n < 100) = ");
                n = int.Parse(Console.ReadLine());
            } while (n< 0 || n > 100);
        }
    }
}

