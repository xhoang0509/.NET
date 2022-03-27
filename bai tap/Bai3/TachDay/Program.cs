using System;

namespace TachDay
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
        static void DemChanLe(int[] arr, int n, ref int q, ref int k)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    q++;
                }
                else
                {
                    k++;
                }
            }
        }
        static void TachMang(int[] arr, int n, int[] arrChan, int[] arrLe)
        {
            int q = 0, k = 0;
            for (int i = 0; i < n; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    // push to arr chan
                    arrChan[q] = arr[i];
                    q++;
                } else
                {
                    // push to arr le
                    arrLe[k] = arr[i];
                    k++;
                }
            }
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

                int q = 0, k = 0;
                DemChanLe(arr, n, ref q, ref k);
                int[] arrChan = new int[q];
                int[] arrLe = new int[k];

                TachMang(arr, n, arrChan, arrLe);
                Console.WriteLine("=============MANG CHAN=============");
                Xuat(arrChan, q);

                Console.WriteLine("=============MANG LE=============");
                Xuat(arrLe, k);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Yeu cau nhap so nguyen " + e.Message);
            }
        }
    }
}
