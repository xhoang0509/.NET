using System;
using System.Collections.Generic;

namespace NguyenXuanHoang_2019605000_proj63
{
    class Program
    {
        static List<Course> listCourse = new List<Course>();
        static void ThemMotKhoaHoc()
        {
            Course x = new Course();
            listCourse.Add(x);
        }
        static void HienThiCacKhoaHoc()
        {
            Console.WriteLine("\n\t\tDANH SACH CAC KHOA HOC LA");
            foreach (var item in listCourse)
            {
                item.DisplayCourseAndStudents();
            }
        }
        static void Main(string[] args)
        {
            int choose;

            do
            {
                Console.WriteLine("\n1. Them mot khoa hoc");
                Console.WriteLine("\n2. Hien thi cac khoa hoc");
                Console.WriteLine("\n3. Tim kiem khoa hoc");
                Console.WriteLine("\n4. Tim kiem sinh vien");
                Console.WriteLine("\n5. Xoa mot khoa hoc");
                Console.WriteLine("\n6. Ket thuc chuong trinh");
                Console.Write("Nhap lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ThemMotKhoaHoc();
                        break;
                    case 2:
                        HienThiCacKhoaHoc();
                        break;
                    default:
                        break;
                }

            } while (choose != 6);
        }
    }
}
