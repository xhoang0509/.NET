using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenXuanHoang_2019605000_proj61
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Person()
        {

        }

        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap address: ");
            address = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write("id: {0}, name: {1}, address: {2}", id, name, address);
        }
    }
}
