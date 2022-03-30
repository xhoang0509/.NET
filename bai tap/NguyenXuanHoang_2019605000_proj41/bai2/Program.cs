using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);

            Console.WriteLine("Area: " + c1.Area());
            Console.WriteLine("Perimeter: " + c1.Perimeter());
        }
    }
}
