using System;
using System.Collections.Generic;

namespace NguyenXuanHoang_2019605000_proj61
{
    class Program
    {
        static List<Student> listStudent = new List<Student>();

        static void ThemMotSinhVien()
        {
            Console.WriteLine("\n\t\tNhap thong tin sinh vien ");
            Student x = new Student();
            x.Input();
            listStudent.Add(x);
        }

        static void HienThiDS()
        {
            Console.WriteLine("\n\t\tDS sinh vien ");
            Student.Title();
            foreach (var item in listStudent)
            {
                item.Output();
            }
        }

        static void TimKiemTheoId()
        {
            Console.WriteLine("Nhap id can tim kiem: ");
            int id = int.Parse(Console.ReadLine());
            Student x = new Student();
            Boolean finded = false;
            foreach (var item in listStudent)
            {
                if (id == item.id)
                {
                    x = item;
                    finded = true;
                    break;
                }
            }

            if (finded)
            {
                Console.WriteLine("\n\t\tSinh vien co id " + id + " la");
                x.Output();
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay sinh vien co id " + id);
            }
        }

        static void TimKiemTheoAddress()
        {
            Console.WriteLine("Nhap address can tim kiem: ");
            string address = Console.ReadLine();
            Student x = new Student();
            Boolean finded = false;
            foreach (var item in listStudent)
            {
                if (string.Compare(address, item.address) == 0)
                {
                    x = item;
                    finded = true;
                    break;
                }
            }

            if (finded)
            {
                Console.WriteLine("\n\t\tSinh vien co address " + address + " la");
                x.Output();
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay sinh vien co address " + address);
            }
        }

        static void XoaTheoId()
        {
            Console.WriteLine("Nhap id can xoa: ");
            int id = int.Parse(Console.ReadLine());
            Student x = new Student();
            Boolean finded = false;
            foreach (var item in listStudent)
            {
                if (id == item.id)
                {
                    x = item;
                    finded = true;
                    break;
                }
            }

            if (finded)
            {
                listStudent.Remove(x);
                Console.WriteLine("\n\t\tXoa thanh cong sinh vien co id " + id);
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay sinh vien co id " + id);
            }
        }

        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                Console.WriteLine("\n1. Them mot sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim kiem sinh vien theo id");
                Console.WriteLine("4. Tim kiem sinh vien theo address");
                Console.WriteLine("5. Xoa mot sinh vien theo id");
                Console.WriteLine("6. Ket thuc chuong trinh");
                Console.Write("Nhap lua con cua ban: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ThemMotSinhVien();
                        break;
                    case 2:
                        HienThiDS();
                        break;
                    case 3:
                        TimKiemTheoId();
                        break;
                    case 4:
                        TimKiemTheoAddress();
                        break;
                    case 5:
                        XoaTheoId();
                        break;
                    default:
                        break;
                }

            } while (choose != 6);
        }
    }
}
