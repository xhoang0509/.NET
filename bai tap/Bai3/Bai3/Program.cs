using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hay nhap vao 2 so.");
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Hay nhap so nguyen ", e.Message);
                
            }
        }
    }
}
