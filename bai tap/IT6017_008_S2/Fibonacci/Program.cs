using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;

            } else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            
        }
        static void Main(string[] args)
        {
            int n;
            try
            {
                Console.WriteLine("Nhap so nguyen duong n: ");
                n= Convert.ToInt32(Console.ReadLine());
                
                while (n <= 0 )
                {
                    Console.WriteLine("\n\nYEU CAU NHAP SO NGUYEN DUONG !");
                    Console.WriteLine("Nhap so nguyen duong n: ");
                    n = Convert.ToInt32(Console.ReadLine());                    
                }

                Console.WriteLine("So fibonacci thu " + n + " la: " + Fibonacci(n));

                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Yeu cau nhap so ! " + e.Message);
            }
        }
    }
}
