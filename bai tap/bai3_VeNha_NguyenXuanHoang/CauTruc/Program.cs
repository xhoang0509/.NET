using System;

namespace CauTruc
{
    class Program
    {   
        struct HocSinh
        {
            public string hoTen;
            public int tuoi;
            public bool gioiTinh; // true-name | nu-false
        }

        static void Nhap(out HocSinh hocSinh)
        {
            Console.Write("Nhap ho ten: ");
            hocSinh.hoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            hocSinh.tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            hocSinh.gioiTinh = Convert.ToBoolean(Console.ReadLine());
        }

        // tinh tong tuoi 
        static int TongTuoi(HocSinh[] dsHocSinh)
        {
            int tong = 0;
            foreach (var element in dsHocSinh)
            {
                tong += element.tuoi;
            }
            return tong;
        }

        static void Main(string[] args)
        {
            HocSinh[] dsHocSinh = new HocSinh[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\tNHAP THONG TIN CHO HOC SINH " + (i + 1));
                Nhap(out dsHocSinh[i]);
            }
            Console.WriteLine("Tong tuoi 5 hoc sinh: " + TongTuoi(dsHocSinh));
        }
    }
}
