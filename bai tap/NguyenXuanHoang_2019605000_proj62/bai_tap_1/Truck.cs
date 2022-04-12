using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_1
{
    class Truck : Vehicles
    {
        public int truckload { get; set; }

        public Truck()
        {
        }

        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap truckload: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public static void Title()
        {
            Vehicles.Title();
            Console.Write("{0,10}", "truckload");
            Console.WriteLine();
        }

        public override void Output()
        {
            base.Output();
            Console.Write("{0,10}", truckload);
            Console.WriteLine();
        }
    }
}
