using System;

namespace CuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tBANG CUU TRUONG");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t\t BANG NHAN " + i);
                for(int j = 0; j < 10; j++)
                {
                    Console.WriteLine("\t{0} x {1} = {2}\n", i, j, i*j);
                }
            }
        }
    }
}
