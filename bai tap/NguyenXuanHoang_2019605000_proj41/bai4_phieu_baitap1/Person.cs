using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_phieu_baitap1
{
    class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public void CheckAge()
        {
            if (age >= 18)
            {
                Console.WriteLine("Ban da du tuoi bau cu");
            }
            else
            {
                Console.WriteLine("Ban con nho");
            }
        }

        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap address: ");
            address = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-20}{4,-10}", id, name, age, email, address);
        }
    }
}
