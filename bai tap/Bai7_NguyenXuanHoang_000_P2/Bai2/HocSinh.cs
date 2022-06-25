using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HocSinh
    {
        private string ten;
        private float diem;

        public string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                ten = value;
            }
        }

        public float Diem
        {
            get
            {
                return diem;
            }
            set
            {
                diem = value;
            }
        }

        public HocSinh(string ten, float diem)
        {
            this.ten = ten;
            this.diem = diem;
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


        public static string XepLoai(float diem)
        {
            if (diem > 8)
            {
                return "Gioi";
            }
            else if (diem > 6.5)
            {
                return "Kha";
            }
            else if (diem > 5)
            {
                return "Trung binh";
            }
            else if (diem > 3.5)
            {
                return "Yeu";
            }
            else
            {
                return "Kem";
            }
        }
    }
}
