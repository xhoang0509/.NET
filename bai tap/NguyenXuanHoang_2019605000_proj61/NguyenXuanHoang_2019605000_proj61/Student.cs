using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenXuanHoang_2019605000_proj61
{
    class Student : Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }

        public Student()
        {

        }

        public Student(byte maths, byte physics)
        {
            
            this.maths = maths;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap maths: ");
            maths = byte.Parse(Console.ReadLine());
            Console.WriteLine("Nhap physics: ");
            physics = byte.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.Write(",maths: {0}, physics: {1}, total: {2}", maths, physics, Total());
        }

        public double Total()
        {
            return maths + physics;
        }

    }
}
