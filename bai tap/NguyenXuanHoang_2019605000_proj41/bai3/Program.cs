using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("e01");
            Student s2 = new Student("e02", "Xuan Hoang", 10);
            Console.WriteLine("Student 1 id: " + s1.id);
            Console.WriteLine("Student 2 id: " + s2.id + " name: " + s2.name + " mark: " + s2.mark + " scholarship: " + s2.scholarship);
        }
    }
}
