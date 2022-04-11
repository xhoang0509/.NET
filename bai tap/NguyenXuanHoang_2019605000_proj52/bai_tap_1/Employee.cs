using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_1
{
    class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int workingdays { get; set; }
        public double salary
        {
            get
            {
                return workingdays * PRICE;
            }
        }
        public const int PRICE = 50;

        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap workingdays: ");
            workingdays = int.Parse(Console.ReadLine());
        }

        public static void inTieuDe()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,10}{3,15}{4,10}",
                "id", "name", "age", "workingdays", "salary");
        }

        public void Output()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,10}{3,15}{4,10}",
               id, name, age, workingdays, salary);
        }
    }
}
