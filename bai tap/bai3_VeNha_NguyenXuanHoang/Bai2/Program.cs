using System;

namespace Mang
{
    class Program
    {
        static void NhapMang(int[] arr, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 100);
            }
        }
        static void XuatMang(int[] arr, int n)
        {
            foreach (int item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int element in arr)
            {
                if (element < min)
                    min = element;
            }
            return min;
        }
        static int Max(int[] arr)
        {
            int max = arr[0];
            foreach (int element in arr)
            {
                if (element > max)
                    max = element;
            }
            return max;
        }

        static int TinhTong(int[] arr)
        {
            int result = 0;
            foreach (int element in arr)
            {
                result += element;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            NhapMang(arr, n);

            Console.WriteLine("Mang vua nhap la: ");
            XuatMang(arr, n);
            Console.WriteLine("Min cua mang: " + Min(arr));
            Console.WriteLine("Max cua mang: " + Max(arr));
            Console.WriteLine("Tong: " + TinhTong(arr));
        }
    }
}
