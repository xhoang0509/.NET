using System;
using System.Collections.Generic;

namespace DE02
{
    class Program
    {
        static List<Candidate> list = new List<Candidate>();

        // kiem tra id da ton tai hay chua. co => return true, khong => return false
        static Boolean checkId(string id)
        {
            foreach (var item in list)
            {
                if (string.Compare(item.id, id) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void ThemMotThiSinh()
        {
            Console.WriteLine("\n\t\tNhap thong tin thi sinh: ");
            Candidate x = new Candidate();

            while (true)
            {
                x.Input();
                if (!checkId(x.id))
                {
                    list.Add(x);
                    break;
                }
                else
                {
                    Console.WriteLine("\nID da ton tai, nhap lai !!!");
                }
            }

        }
        static void HienThiDS()
        {
            if (list.Count > 0)
            {
                Console.WriteLine("\n\t\tDS thi sinh la");
                Candidate.Title();
                foreach (var item in list)
                {
                    item.Output();
                }
            }
            else
            {
                Console.WriteLine("\n\t\tDS thi sinh trong");
            }
        }
        static void SXTongDiem()
        {
            list.Sort(new SortTongDiem());
            HienThiDS();
        }
        static void DSThiDo()
        {
            Console.Write("Nhap diem san: ");
            float diemSan = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\t\tDS thi do la: ");
            Candidate.Title();
            foreach (var item in list)
            {
                if (string.Compare(item.Check(diemSan), "Thi do") == 0)
                {
                    item.Output();
                }
            }

        }
        static void DSCungKhuVuc()
        {
            Console.Write("Nhap khu vuc uu tien (1, 2, 3): ");
            string temp = Console.ReadLine();
            int tempDiem = 0;
            if (string.Compare(temp, "1") == 0)
            {
                tempDiem = 0;
            }
            else if (string.Compare(temp, "2") == 0)
            {
                tempDiem = 1;
            }
            else if (string.Compare(temp, "3") == 0)
            {
                tempDiem = 2;
            }
            Console.WriteLine("\n\t\tDS thi sinh cung khu vuc " + temp + " la");
            Candidate.Title();
            foreach (var item in list)
            {
                if (item.prioritized == tempDiem)
                {
                    item.Output();
                }
            }
        }
        static void TimKiemTheoSDB()
        {
            Console.Write("Nhap so bao danh can tim: ");
            string sdb = Console.ReadLine();

            Boolean isFinded = false;
            Candidate temp = new Candidate();
            foreach (var item in list)
            {
                if (string.Compare(item.id, sdb) == 0)
                {
                    temp = item;
                    isFinded = true;
                    break;
                }
            }

            if (isFinded)
            {
                Console.WriteLine("\n\t\tThi sinh co sdb " + sdb + " la");
                Candidate.Title();
                temp.Output();
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay thi sinh co sdb " + sdb);
            }
        }
        static void XoaTheoSDB()
        {
            Console.Write("Nhap so bao danh can xoa: ");
            string sdb = Console.ReadLine();

            Candidate temp = new Candidate();
            Boolean isFinded = false;
            foreach (var item in list)
            {
                if (string.Compare(item.id, sdb) == 0)
                {
                    temp = item;
                    isFinded = true;
                    break;
                }
            }

            if (isFinded)
            {
                list.Remove(temp);
                Console.WriteLine("\n\t\tDS sau khi xoa la");
                HienThiDS();
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay thi sinh co sdb " + sdb);
            }
        }
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("\n1. Them 1 thi sinh");
                Console.WriteLine("2. Hien thi ds thi sinh");
                Console.WriteLine("3. Hien thi ds thi sinh sx theo Tong diem thi");
                Console.WriteLine("4. Ds thi sinh thi do");
                Console.WriteLine("5. Ds thi sinh cung khu vuc");
                Console.WriteLine("6. Tim kiem theo sdb");
                Console.WriteLine("7. Xoa thi sinh theo sbd");
                Console.WriteLine("8. Ket thuc chuong trinh");
                Console.Write("Nhap lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choose)
                {
                    case 1:
                        ThemMotThiSinh();
                        break;
                    case 2:
                        HienThiDS();
                        break;
                    case 3:
                        SXTongDiem();
                        break;
                    case 4:
                        DSThiDo();
                        break;
                    case 5:
                        DSCungKhuVuc();
                        break;
                    case 6:
                        TimKiemTheoSDB();
                        break;
                    case 7:
                        XoaTheoSDB();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (choose != 8);
        }
    }
}
