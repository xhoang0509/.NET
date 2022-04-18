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
            Console.WriteLine("Nhap course id: ");
            courseid = Console.ReadLine();
            Console.WriteLine("Nhap course name: ");
            courseName = Console.ReadLine();
            Console.WriteLine("Nhap fee: ");
            fee = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so luong sinh vien: ");
            int lenghtListStudent = int.Parse(Console.ReadLine());
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
        }

        public List<Student> GetAllStudents()
        {
            List<Student> temp = new List<Student>();
            foreach (var item in listStd)
            {
                temp.Add(item);
            }
            return temp;
        }
    }
}
