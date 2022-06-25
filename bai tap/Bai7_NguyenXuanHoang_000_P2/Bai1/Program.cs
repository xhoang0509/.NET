using System;

namespace Bai1
{
    class Program
    {
        static Student x = new Student("Hung mom", 9);
        private delegate void HienDiemChu(float diem);

        static void HienDiem(float diem)
        {
            Console.WriteLine("Ten: " + x.Ten);
            Console.WriteLine("Diem: " + Student.DiemChu(diem));
        }

        

        static void Main(string[] args)
        {           
            HienDiemChu dele1 = HienDiem;            
            dele1(x.Diem);
        }
    }
}
