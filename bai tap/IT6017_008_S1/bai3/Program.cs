using System;
using System.Text;


namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, c;
            Console.WriteLine("Nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if( a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Yêu cầu nhập tât cả số nguyên dương");
                System.Environment.Exit(1);
            }

            if(a + b <= c || b + c <= a || a + c <= b)
            {
                Console.WriteLine("Yêu cầu nhập tổng 2 số lớn hơn 1 số");
                System.Environment.Exit(1);
            }

            int P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

            Console.WriteLine("Kết quả S = " + S);

        }
    }
}
