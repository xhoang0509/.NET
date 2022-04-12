using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_1
{
    class Vehicles : IVechicle, IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicles()
        {

        }

        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap maker: ");
            maker = Console.ReadLine();
            Console.Write("Nhap model: ");
            model = Console.ReadLine();
            Console.Write("Nhap year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhap price: ");
            price = double.Parse(Console.ReadLine());
        }

        public static void Title()
        {
            Console.Write("{0,-12}{1,-12}{2,-12}{3,7}{4,7}", "id", "maker", "model", "year", "price");
        }

        public virtual void Output()
        {
            Console.Write("{0,-12}{1,-12}{2,-12}{3,7}{4,7}", id, maker, model, year, price);
        }

        public override string ToString()
        {
            return string.Format("{0,-12}{1,-12}{2,-12}{3,7}{4,7}", id, maker, model, year, price);
        }

        public override bool Equals(object obj)
        {
            return obj is Vehicles vehicles &&
                   id == vehicles.id;
        }

        public int CompareTo(object obj)
        {
            Vehicles x = (Vehicles)obj;
            return (int)(this.price - x.price);
        }
    }

    class SapXepTheoNam : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.year - y.year;
        }
    }
}
