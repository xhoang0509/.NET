using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenXuanHoang_2019605000_proj63
{
    class Course
    {
        public string courseid { get; set; }
        public string courseName { get; set; }
        public int fee { get; set; }
        public List<Student> listStd { get; set; }

        public Course()
        {
            List<Student> li = new List<Student>();
        }

        public void InputCourse()
        {
            Console.Write("Nhap course id: ");
            courseid = Console.ReadLine();
            Console.Write("Nhap course name: ");
            courseName = Console.ReadLine();
            Console.Write("Nhap fee: ");
            fee = int.Parse(Console.ReadLine());

            Console.Write("Nhap so luong sinh vien: ");
            int lenghtListStudent = int.Parse(Console.ReadLine());
            listStd = new List<Student>();
            for (int i = 0; i < lenghtListStudent; i++)
            {
                Console.WriteLine("\n\t\tNhap sinh vien " + (i + 1));
                Student x = new Student();
                x.InputStudent();
                listStd.Add(x);
            }
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("=== Course Information ===");
            Console.WriteLine("course id: " + courseid);
            Console.WriteLine("course name: " + courseName);
            Console.WriteLine("course fee: " + fee);

            Student.Title();
            foreach (var item in listStd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> listAddStudents = new List<Student>();
            foreach (var item in listStd)
            {
                listAddStudents.Add(item);
            }
            return listAddStudents;
        }
    }
}
