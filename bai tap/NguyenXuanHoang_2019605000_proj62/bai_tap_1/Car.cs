using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_1
{
    class Car : Vehicles
    {
        public string color { get; set; }

        public Car()
        {
        }

        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap color: ");
            color = Console.ReadLine();
        }

        public static void Title()
        {
            Vehicles.Title();
            Console.Write("{0,10}", "color");
            Console.WriteLine();
        }

        public override void Output()
        {
            base.Output();
            Console.Write("{0,10}", color);
            Console.WriteLine();
        }
    }
}
