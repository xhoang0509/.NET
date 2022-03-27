using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap so thu a = ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so thu b = ");
                float b = float.Parse(Console.ReadLine());

                float result = 0;
                bool compare1, compare2, compare3, compare4;
                string pt;
                do
                {
                    Console.Write("Nhap toan tu (+,-,*,/): ");
                    pt = Console.ReadLine();

                    compare1 = String.Equals(pt, "+");
                    compare2 = String.Equals(pt, "-");
                    compare3 = String.Equals(pt, "*");
                    compare4 = String.Equals(pt, "/");
                } while (compare1 && compare2 && compare3 && compare4);

                
                switch (pt)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("KET QUA: {0}", result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Yeu cau nhap so thuc " + e.Message);

            }
        }
    }
}
