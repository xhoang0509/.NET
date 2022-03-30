using System;

namespace bai4_phieu_baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person();
            student.Input();
            Console.WriteLine("\nThong tin sinh vien vua nhap la");
            student.Output();
        }
    }
}
