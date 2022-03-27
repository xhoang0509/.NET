using System;

namespace DanhSach
{
    class Program
    {
        static int isNguyenTo(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            int count = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap danh sach n so: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var danhSach = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + " = ");
                danhSach[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nDANH SACH VUA NHAP LA: ");
            foreach (int item in danhSach) {
                Console.WriteLine(item + " \t ");
            }

            Console.WriteLine("\nDANH SACH SO CHAN LA: ");
            foreach (int item in danhSach)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item + " \t ");
                }
            }

            Console.WriteLine("\nDANH SACH SO LE LA: ");
            foreach (int item in danhSach)
            {
                if (item % 2 == 1)
                {
                    Console.WriteLine(item + " \t ");
                }
            }

            Console.WriteLine("\nDANH SACH NGUYEN TO LA: ");
            foreach (int item in danhSach)
            {
                if (isNguyenTo(item) == 1)
                {
                    Console.WriteLine(item + " \t ");
                }
            }
        }
    }
}
