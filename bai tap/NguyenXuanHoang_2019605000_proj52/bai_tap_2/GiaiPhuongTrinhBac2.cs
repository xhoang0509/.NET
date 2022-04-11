using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2
{
    class GiaiPhuongTrinhBac2
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public void Input()
        {
            Console.WriteLine("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = int.Parse(Console.ReadLine());

        }

        public void GiaiPT()
        {
            int delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem !");
            }
            else if (delta == 0)
            {
                int x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + x);
            }
            else
            {
                delta = (int)Math.Sqrt(delta);
                int x1 = (-b + delta) / (2 * a);
                int x2 = (-b - delta) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem x1 = " + x1 + " x2 = " + x2);
            }
        }
    }
}
