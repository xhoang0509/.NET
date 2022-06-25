using System;
using System.Collections.Generic;

namespace NguyenXuanHoang_2019605000_proj63
{
    class Program
    {
        static List<Course> listCourse = new List<Course>();
        static void ThemMotKhoaHoc()
        {
            Console.WriteLine("\n\t\tNhap thong tin mot khoa hoc");
            Course x = new Course();
            x.InputCourse();
            listCourse.Add(x);
        }
        static void HienThiCacKhoaHoc()
        {
            if (listCourse.Count > 0)
            {
                Console.WriteLine("\n\t\tDANH SACH CAC KHOA HOC LA");
                foreach (var item in listCourse)
                {
                    item.DisplayCourseAndStudents();
                }
            }
            else
            {
                Console.WriteLine("\n\t\tBan chua co khoa hoc nao");
            }
        }
        static void TimKiemKhoaHocTheoId()
        {
            Console.WriteLine("Nhap id khoa hoc can tim kiem: ");
            string courseId = Console.ReadLine();
            Boolean finded = false;
            Course x = new Course();
            foreach (var item in listCourse)
            {
                if (string.Compare(item.courseid, courseId) == 0)
                {
                    x = item;
                    finded = true;
                    // khi id khoa hoc khong trung nhau => tim thay thi break;
                    break;
                }
            }

            if (finded)
            {
                Console.WriteLine("\n\t\tKhoa hoc co ma " + courseId + " la");
                x.DisplayCourseAndStudents();
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim hay khoa hoc co ma " + courseId);
            }
        }
        static void TimKiemSinhVien()
        {
            Console.WriteLine("Nhap ma sinh vien can tim kiem: ");
            int studentId = int.Parse(Console.ReadLine());
            Boolean finded = false;
            Student x = new Student();
            foreach (var course in listCourse)
            {
                foreach (var student in course.listStd)
                {
                    if (student.studentid == studentId)
                    {
                        x = student;
                        finded = true;
                        // khi ma sinh vien la duy nhat => chi tim thay 1 sinh vien => break;
                        break;
                    }
                }
            }

            if (finded)
            {
                Console.WriteLine("\n\t\tThong tin sinh vien co ma " + studentId + " la");
                Student.Title();
                Console.WriteLine(x.ToString());
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay sinh vien co ma " + studentId);
            }
        }
        static void XoaKhoaHocTheoId()
        {
            Console.WriteLine("Nhap id khoa hoc can xoa: ");
            string courseId = Console.ReadLine();
            Boolean finded = false;
            Course x = new Course();

            foreach (var item in listCourse)
            {
                if (string.Compare(item.courseid, courseId) == 0)
                {
                    x = item;
                    finded = true;
                    // khi ma sinh vien la duy nhat => chi tim thay 1 sinh vien => break;
                    break;
                }

            }

            if (finded)
            {
                listCourse.Remove(x);
                Console.WriteLine("\n\t\tXoa thanh cong khoa hoc " + courseId);
            }
            else
            {
                Console.WriteLine("\n\t\tKhong tim thay khoa hoc co id " + courseId);
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
                    case 3:
                        TimKiemKhoaHocTheoId();
                        break;
                    case 4:
                        TimKiemSinhVien();
                        break;
                    case 5:
                        XoaKhoaHocTheoId();
                        break;
                    default:
                        break;
                }

            } while (choose != 6);
        }
    }
}
