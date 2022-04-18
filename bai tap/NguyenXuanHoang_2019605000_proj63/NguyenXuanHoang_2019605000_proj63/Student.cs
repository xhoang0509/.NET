using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenXuanHoang_2019605000_proj63
{
    class Student
    {
        public int studentid { get; set; }
        public string name { get; set; }
        public string mark { get; set; }

        public void InputStudent()
        {
            Console.WriteLine("Nhap studentid: ");
            studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap name: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap mark: ");
            mark = Console.ReadLine();
        }

        public static void Title()
        {
            Console.WriteLine("{0,-10}{2,-10}{2,-10}", "studentid", "name", "mark");
        }

        public override string ToString()
        {
            return string.Format("{0,-10}{2,-10}{2,-10}", studentid,name,mark);
        }
    }
}
