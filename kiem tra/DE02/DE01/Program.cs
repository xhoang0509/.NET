using System;
using System.Collections.Generic;

namespace DE01
{
    class Program
    {
        static List<ThiSinhUT> thiSinhUTs = new List<ThiSinhUT>();

        static bool CheckSBD(string sbd)
        {
            foreach (var item in thiSinhUTs)
            {
                if (string.Compare(item.sbd, sbd) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Them1ThiSinh()
        {
            Console.WriteLine("\n\t\tNhap thong tin thi sinh");
            ThiSinhUT x = new ThiSinhUT();
            x.NhapThongTin();
            if (CheckSBD(x.sbd))
            {
                Console.WriteLine("\n\t\tSDB da ton tai, khong the nhap !");
            }
            else
            {
                thiSinhUTs.Add(x);
            }
        }

        static void InDS()
        {
            if (thiSinhUTs.Count > 0)
            {
                Console.WriteLine("\n\t\tDS thi sinh la");
                ThiSinhUT.InTieuDe();
                foreach (var item in thiSinhUTs)
                {
                    item.HienThi();
                }
            }
            else
            {
                Console.WriteLine("\n\t\tDS trong");
            }
        }

        static void SapXepTheoTongDiemThi()
        {
            thiSinhUTs.Sort(new SapXepDiem());
            Console.WriteLine("\n\t\tDS sap xep tang dan theo tong diem la");
            InDS();
        }

        static void DSThiDo()
        {
            Console.Write("Nhap diem san: ");
            float diemSan = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tDS thi sinh thi do la: ");
            int count = 0;

            foreach (var item in thiSinhUTs)
            {
                if (string.Compare(item.XetTuyen(diemSan), "Thi do") == 0)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                ThiSinhUT.InTieuDe();
                foreach (var item in thiSinhUTs)
                {
                    if (string.Compare(item.XetTuyen(diemSan), "Thi do") == 0)
                    {
                        item.HienThi();
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\tKhong co thi sinh nao thi do");
            }
        }

        static void DSCungKVUuTien()
        {
            Console.Write("Nhap khu vuc uu tien: ");
            string kv = kv = Console.ReadLine(); ;
            float diemUT = -1;

            if (string.Compare(kv, "1") == 0)
            {
                diemUT = 0;
            }
            else if (string.Compare(kv, "2") == 0)
            {
                diemUT = 0.5f;
            }
            else if (string.Compare(kv, "2") == 0)
            {
                diemUT = 1;
            }

            Console.WriteLine("\n\t\tDS thi sinh o khu vuc " + kv + " la");
            ThiSinhUT.InTieuDe();
            foreach (var item in thiSinhUTs)
            {
                if (item.diemUuTien == diemUT)
                {
                    item.HienThi();
                }
            }
        }

        static void TimKiemTheoSBD()
        {
            Console.Write("Nhap sdb can tim: ");
            string sbd = Console.ReadLine();
            int count = 0;
            foreach (var item in thiSinhUTs)
            {
                if (string.Compare(item.sbd, sbd) == 0)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                ThiSinhUT.InTieuDe();
                foreach (var item in thiSinhUTs)
                {
                    if (string.Compare(item.sbd, sbd) == 0)
                    {
                        item.HienThi();
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay thi sinh co sbd " + sbd);
            }
        }
        static void XoaTheoSBD()
        {
            Console.Write("Nhap sdb can tim: ");
            string sbd = Console.ReadLine();
            ThiSinhUT x = null;
            foreach (var item in thiSinhUTs)
            {
                if (string.Compare(item.sbd, sbd) == 0)
                {
                    x = item;
                    break;
                }
            }

            if (x != null)
            {
                thiSinhUTs.Remove(x);
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay thi sinh co sbd " + sbd);
            }
        }
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Them 1 thi sinh");
                Console.WriteLine("2. Hien thi DS");
                Console.WriteLine("3. DS sap xep theo tong diem thi");
                Console.WriteLine("4. DS thi sinh 'thi do' ");
                Console.WriteLine("5. DS thi sinh 'co cung khu vuc' ");
                Console.WriteLine("6. Tim kiem theo sbd");
                Console.WriteLine("7. Xoa theo sbd");
                while (true)
                {
                    try
                    {
                        Console.Write("Nhap lua chon cua ban: ");
                        choose = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nhap sai du lieu, nhap lai");
                    }
                }
                Console.WriteLine();
                switch (choose)
                {
                    case 1:
                        Them1ThiSinh();
                        break;
                    case 2:
                        InDS();
                        break;
                    case 3:
                        SapXepTheoTongDiemThi();
                        break;
                    case 4:
                        DSThiDo();
                        break;
                    case 5:
                        DSCungKVUuTien();
                        break;
                    case 6:
                        TimKiemTheoSBD();
                        break;
                    case 7:
                        XoaTheoSBD();
                        break;
                    default:
                        break;
                }
            } while (choose != 8);

        }
    }
}
