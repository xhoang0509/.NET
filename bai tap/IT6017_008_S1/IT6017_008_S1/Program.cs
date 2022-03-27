using System;

namespace IT6017_008_S1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from S1!");
            int x, y;
            Console.Write("nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ket qua la: " + (x + y));
            Console.ReadKey();
        }
    }
}
