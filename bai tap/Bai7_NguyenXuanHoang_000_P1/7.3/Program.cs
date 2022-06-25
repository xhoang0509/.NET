using System;

namespace _7._3
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

        static void GuiThongDiep(string ten)
        {
            Console.WriteLine("\nThong diep da duoc gui cho: " + ten);
        }

        static void CanhBao(string phienBan)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBan nen dung phien ban " + phienBan);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            HienThiThongBao dele1 = ThongBaoLoi;

            HienThiThongBao dele2 = GuiThongDiep;

            HienThiThongBao multiDele;

            multiDele = dele1 + dele2;

            HienThiThongBao dele3 = CanhBao;

            multiDele += dele3;

            multiDele += CanhBao;
            multiDele += CanhBao;

            multiDele -= dele2;
            multiDele("ABC");

            Console.ReadLine();
        }
    }
}
