using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenXuanHoang_2019605000_proj61
{
    class Student : Person
    {
        public float maths { get; set; }
        public float physics { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string address, float maths, float physics) : base(id, name, address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.maths = maths;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap maths: ");
            maths = float.Parse(Console.ReadLine());
            Console.Write("Nhap physics: ");
            physics = float.Parse(Console.ReadLine());
        }

        public static void Title()
        {
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}", "Id", "Name", "Address", "Maths", "Physics", "Total");
        }

        public override void Output()
        {
            base.Output();
            Console.Write(",maths: {0}, physics: {1}, total: {2}", maths, physics, Total());
            Console.WriteLine();
        }

        public double Total()
        {
            return maths + physics;
        }

    }
}
