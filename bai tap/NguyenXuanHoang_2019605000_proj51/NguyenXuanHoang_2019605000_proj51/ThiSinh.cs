using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenXuanHoang_2019605000_proj51
{
    class ThiSinh : IComparable
    {
        public string soBD;
        private string hoTen;
        public string diaChi;
        float toan, ly, hoa, diemUT;

        public void nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("\nNhap so bao danh: ");
                    soBD = Console.ReadLine();
                    Console.Write("Nhap ho ten: ");
                    hoTen = Console.ReadLine();
                    Console.Write("Nhap dia chi: ");
                    diaChi = Console.ReadLine();
                    Console.Write("Nhap diem toan: ");
                    toan = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem ly: ");
                    ly = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem hoa: ");
                    hoa = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem uu tien: ");
                    diemUT = float.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("CO LOI, NHAP LAI " + e.Message);
                }
            }
        }

        public float tongDiem()
        {
            return toan + ly + hoa + diemUT;
        }

        public static void inTieuDe()
        {
            string kq = String.Format("{0,-15}{1,-20}{2,-15}{3,8}{4,8}{5,8}{6,8}{7,8}",
                "So bao danh", "Ho ten", "Dia Chi", "Toan", "Ly", "Hoa", "Diem UT", "Diem TK");
            Console.WriteLine(kq);
        }

        public void xuat()
        {
            string kq = String.Format("{0,-15}{1,-20}{2,-15}{3,8}{4,8}{5,8}{6,8}{7,8}",
              soBD, hoTen, diaChi, toan, ly, hoa, diemUT, tongDiem());
            Console.WriteLine(kq);
        }

        public int CompareTo(object obj)
        {
            ThiSinh temp = (ThiSinh)obj;
            return (int)(this.tongDiem() - temp.tongDiem());
        }
    }

    class CompareAddress : IComparer<ThiSinh>
    {

        public int Compare(ThiSinh x, ThiSinh y)
        {
            return (x.diaChi.CompareTo(y.diaChi));
        }
    }
}
