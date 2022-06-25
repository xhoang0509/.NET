using System;

namespace Bai2
{
    class Program
    {
        private delegate void UyQuyen(float diem);

        static void showDiemChu(float diem)
        {
            Console.WriteLine("Diem chu: " + HocSinh.DiemChu(diem));
        }
        static void showXepLoai(float diem)
        {
            Console.WriteLine("Xep loai: " + HocSinh.XepLoai(diem));
        }

        static void Main(string[] args)
        {
            HocSinh x = new HocSinh("Xuan Hoang", 10);
            Console.WriteLine("Ten: " + x.Ten);

            UyQuyen dele1 = new UyQuyen(showDiemChu);
            UyQuyen dele2 = new UyQuyen(showXepLoai);
            dele1(x.Diem);
            dele2(x.Diem);
        }
    }
}
