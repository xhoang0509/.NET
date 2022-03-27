using System;

namespace GiaiThua
{
    class Program
    {
        static int GiaiThua(int number)
        {
            if(number == 1)
            {
                return 1;
            } else
            {
                return number * GiaiThua(number - 1);
            }
        }
        static void Main(string[] args)
        {
            int n;
            try
            {
                Console.WriteLine("Nhap mot so nguyen duong n = ");
                n = Convert.ToInt32(Console.ReadLine());

                while(n <= 0)
                {
                    Console.WriteLine("\nYEU CAU NHAP SO NGUYEN DUONG !");
                    Console.WriteLine("Nhap mot so nguyen duong n = ");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nGiai thua cua " + n + " la: " + GiaiThua(n));
                 
            }
            catch (FormatException e)
            {
                Console.WriteLine("Yeu cau nhap chu so " + e.Message);
                throw;
            }
        }
    }
}
