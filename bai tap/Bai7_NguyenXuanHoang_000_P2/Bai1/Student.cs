using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{



    class Student
    {
        private string ten;
        private float diem;

        public Student(string ten, float diem)
        {
            this.ten = ten;
            this.diem = diem;
        }

        public float Diem
        {
            get
            {
                return diem;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }
        }

        public static string DiemChu(float diem)
        {
            if (diem < 4)
            {
                return "F";
            }
            else if (diem < 5.5)
            {
                return "D";
            }
            else if (diem < 7.0)
            {
                return "C";
            }
            else if (diem < 8.5)
            {
                return "B";
            }
            else
            {
                return "A";
            }
        }

    }
}
