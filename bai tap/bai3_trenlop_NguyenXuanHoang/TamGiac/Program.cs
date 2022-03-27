using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("NHAP 3 CANH CUA TAM GIAC !");
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = int.Parse(Console.ReadLine());

                while(a + b < c || b + c < a || c + a < b)
                {
                    Console.WriteLine("NHAP SAI ! YEU CAU NHAP LAI !");
                    Console.Write("a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    c = int.Parse(Console.ReadLine());
                }

                float chuVi = a + b + c;
                
                float p = chuVi / 2;                
                double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("CHU VI: " + chuVi);
                Console.WriteLine("DIEN TICH: " + dienTich);
            }
            catch (FormatException e)
            {
                Console.WriteLine("YEU CAU NHAP SO NGUYEN !" + e.Message);
            }
        }
    }
}
