using System;

using System.Collections.Generic;

namespace DanhSach
{
    class Program

    {
        static void Nhap(ref List<string> ThanhPho)
        {
            ThanhPho.Add("Ha Noi");
            ThanhPho.Add("Ho Chi Minh");
            ThanhPho.Add("Hai Phong");
            ThanhPho.Add("Da Nang");
            ThanhPho.Add("Can Tho");
        }
        static void Xuat(List<string> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        static void ThemMoi(ref List<string> ThanhPho)
        {
            ThanhPho.Add("Bac Giang");
            ThanhPho.Add("Bac Ninh");
            ThanhPho.Add("Nam Dinh");
            ThanhPho.Add("Nghe An");
            ThanhPho.Add("Binh Duong");
        }

        
        static void Main(string[] args)
        {
            List<string> ThanhPho = new List<string>();

            Nhap(ref ThanhPho);

            Console.WriteLine("\n===>5 thanh pho truc thuoc trung uong la (da sap xep): ");                    
            ThanhPho.Sort();
            Xuat(ThanhPho);

            Console.WriteLine("\n===>Ds thanh pho sau khi xoa Ha Noi la: ");
            ThanhPho.Remove("Ha Noi");
            Xuat(ThanhPho);

            
            
            Console.WriteLine("\n===>Danh sach sau khi them moi 5 thanh pho:");
            ThemMoi(ref ThanhPho);
            Xuat(ThanhPho);
        }


    }
}
