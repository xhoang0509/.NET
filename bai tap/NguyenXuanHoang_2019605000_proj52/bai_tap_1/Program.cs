using System;

namespace bai_tap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Input();

            Console.WriteLine("\n\t\tTHONG TIN VUA NHAP LA");
            Employee.inTieuDe();
            e1.Output();
        }
    }
}
