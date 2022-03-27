using System;

namespace Chuoi
{
    class Program
    {
        // hien thi moi ky tu
        static void KyTu(string str)
        {
            str = str.Trim();
            while (str.Contains("  "))
            {
                str = str.Replace(" ", string.Empty);
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + "  ");

            }
        }

        // tach tu tu chuoi
        static void TachTu(string str)
        {
            str = str.Trim();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            string[] stringArray = str.Split(" ");
            foreach (var element in stringArray)
            {
                Console.WriteLine(element);
            }
        }

        // dem so lan ky tu xuat hien trong chuoi
        static void SoLanKyTuXuatHien(string str)
        {
            str = str.Replace(" ", string.Empty);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " : ");
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap mot chuoi bat ki: ");
            string yourString = Console.ReadLine();

            Console.Write("Chuoi vua nhap la: " + yourString);

            
            Console.WriteLine("\nHien thi tung ky tu: ");
            KyTu(yourString);

            
            Console.WriteLine("\nHien thi tach tu: ");
            TachTu(yourString);
            

            Console.WriteLine("\nHien Thi so lan xuat hien cua moi ky tu: ");
            SoLanKyTuXuatHien(yourString);
        }
    }
}
