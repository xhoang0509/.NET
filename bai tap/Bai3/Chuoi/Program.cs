using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 chuoi ky tu: ");
            string s = Console.ReadLine();
            char[] sArr = s.Trim().ToCharArray();
            int length = sArr.Length;

            string check = "";
            for(int i = 0; i < length; i++)
            {
               if(i == length/2)
                {
                    break;
                }
                if (sArr[i] == sArr[length - 1 - i])
                {
                    check = "Doi xung";

                }
                else
                {
                    check = "Khong doi xung";
                }

            }

                        
            Console.WriteLine("Chuoi vua nhap la: " + s);
            Console.WriteLine("Ket qua: " + check);
        }
    }
}
