using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE01
{
    class ThiSinhUT : ThiSinh
    {
        public int khuVuc { get; set; }
        public float diemUuTien { get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhap sdb: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            diemLy = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            diemHoa = float.Parse(Console.ReadLine());
            Console.Write("Nhap khu vuc: ");

            string khuVuc = Console.ReadLine();
            if (string.Compare(khuVuc, "1") == 0)
            {
                diemUuTien = 0;
            }
            else if (string.Compare(khuVuc, "2") == 0)
            {
                diemUuTien = 0.5f;
            }
            else if (string.Compare(khuVuc, "3") == 1)
            {
                diemUuTien = 1;
            }
        }

        public static void InTieuDe()
        {
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", "sdb", "diem toan", "diem ly", "diem hoa", "khu vuc", "diem uu tien", "tong diem");
        }

        public void HienThi()
        {
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", sbd,diemToan,diemLy,diemHoa,khuVuc,diemUuTien,TongDiem());
        }

        public override float TongDiem()
        {
            return base.TongDiem() + diemUuTien;
        }
    }

    class SapXepDiem : IComparer<ThiSinhUT>
    {
        public int Compare(ThiSinhUT x, ThiSinhUT y)
        {
            return (int)(x.TongDiem() - y.TongDiem());
        }
    }
}
