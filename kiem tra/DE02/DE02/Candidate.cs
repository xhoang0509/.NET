using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE02
{
    class Candidate : Examinee
    {
        public int address { get; set; }
        public float prioritized { get; set; }

        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap fullname: ");
            fullname = Console.ReadLine();
            Console.Write("Nhap math: ");
            math = float.Parse(Console.ReadLine());
            Console.Write("Nhap physical: ");
            physical = float.Parse(Console.ReadLine());
            Console.Write("Nhap address: ");
            address = int.Parse(Console.ReadLine());
            Console.Write("Nhap prioritized (khu vuc: 1, 2, 3): ");
            string temp = Console.ReadLine();
            if (string.Compare(temp, "1") == 0)
            {
                prioritized = 0;
            }
            else if (string.Compare(temp, "2") == 0)
            {
                prioritized = 1;
            }
            else if (string.Compare(temp, "3") == 0)
            {
                prioritized = 2;
            }
        }

        public static void Title()
        {
            Console.WriteLine("{0,-5}{1,-10}{2,5}{3,5}{4,10}{5,10}{6,10}", "id", "fullname", "math", "physical", "address", "prioritized", "total");
        }

        public void Output()
        {
            Console.WriteLine("{0,-5}{1,-10}{2,5}{3,5}{4,10}{5,10}{6,10}", id, fullname, math, physical, address, prioritized, Total());
        }

        public override float Total()
        {
            return base.Total() + prioritized;
        }
    }

    class SortTongDiem : IComparer<Candidate>
    {
        public int Compare(Candidate x, Candidate y)
        {
            return (int)(x.Total() - y.Total());
        }
    }
}
