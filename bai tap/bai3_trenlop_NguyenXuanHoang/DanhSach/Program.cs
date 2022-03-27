using System;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void Chuyen(List<float> arr, int n, int j)
        {



            for (int i = n - 1; i > j; i--)
            {
                Console.WriteLine(arr[i - 1] + " " + arr[i]);
                arr[i] = arr[i - 1];
            }

        }
        static void Xuat(List<float> arr)
        {
            foreach (float item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static int TimViTri(List<float> arr, float x)
        {
            if (x < arr[0])
            {
                return 0;
            }
            if (x > arr[arr.Count - 1])
            {
                return arr.Count;
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] >= x)
                {
                    return i;
                }
            }
            return 0;

        }
        static void Chen(List<float> arr, int k, float x)
        {
            arr.Add(0);
            for (int i = arr.Count - 1; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[k] = x;
        }
        static void Main(string[] args)
        {
            List<float> arrFloat = new List<float>(6);

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap phan tu " + i + " = ");
                arrFloat.Add(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Mang vua nhap tang dan la: ");
            arrFloat.Sort();
            Xuat(arrFloat);

            for (int index = 0; index < arrFloat.Count; index++)
            {
                if (arrFloat[index] < 0)
                {
                    arrFloat.Remove(arrFloat[index]);
                    index--;
                }
            }

            if (arrFloat.Count > 0)
            {
                Console.WriteLine("\nMang sau khi xoa so am la !");
                Xuat(arrFloat);
            }
            else
            {
                Console.WriteLine("\nMang khong con phan tu nao");
            }

            Console.Write("\nNhap mot so bat ki: ");
            float n = float.Parse(Console.ReadLine());


            int viTri = TimViTri(arrFloat, n);
            Chen(arrFloat, viTri, n);

            Console.WriteLine("\nMang sau khi them la: ");
            Xuat(arrFloat);
        }
    }
}
