using System;

namespace Mang
{
    class Program
    {
        static void Nhap(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + " = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static int TongPhanTuLe(int[] arr, int n)
        {
            int sum = 0;
            foreach(int item in arr)
            {
                if(item % 2 == 1) 
                    sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so luong phan tu mang n = ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                Nhap(arr, n);
                Console.WriteLine("=============MANG VUA NHAP LA=============");
                Xuat(arr, n);

                int result = TongPhanTuLe(arr, n);
                Console.WriteLine("TONG PHAN TU LA: " + result);



            }
            catch (FormatException e)
            {
                Console.WriteLine("Yeu cau nhap so nguyen " + e.Message);
            }
        }
    }
}
