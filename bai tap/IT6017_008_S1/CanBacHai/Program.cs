using System;

namespace CanBacHai
{

    class Program
    {
        public double MySqrt(float number, double epsilon)
        {
            double result = 1.0f;
            while(Math.Abs(result * result - number) / number >= epsilon)
            {
                result = (number / result - result) / 2 + result;
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Nhap a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap epsilon: ");
            double epsilon = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ket qua la: " + program.MySqrt(a, epsilon));
        }
    }
}
