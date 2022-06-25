using System;

namespace _7._1
{
    class Program
    {
        private delegate void HienThiThongBao(string thongBao);

        private static void ThongBaoLoi(string loi)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nChuong trinh cua ban co loi bien dich sau: " + loi);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            HienThiThongBao dele1 = ThongBaoLoi;
            dele1("thieu ;");
            dele1("error syntax");
            Console.ReadLine();
        }
    }
}
