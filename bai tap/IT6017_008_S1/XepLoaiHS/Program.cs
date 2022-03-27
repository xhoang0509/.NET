using System;
using System.Text;
namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string ho_ten, xep_loai;
            float diem_cuoi_ky;
            
            Console.WriteLine("Nhập họ tên: ");
            ho_ten = Console.ReadLine();

            Console.WriteLine("Nhập điểm thi cuối kỳ: ");
            diem_cuoi_ky = float.Parse(Console.ReadLine());

            
            if (diem_cuoi_ky < 5)
            {
                xep_loai = "Yếu";
            }
            else if (diem_cuoi_ky >= 5 && diem_cuoi_ky < 6.5)
            {
                xep_loai = "Trung bình";
            }
            else if (diem_cuoi_ky >= 6.5 && diem_cuoi_ky < 8)
            {
                xep_loai = "Khá";
            }
            else
            {
                xep_loai = "Giỏi";
            }
            Console.WriteLine("Họ tên học sinh: ", ho_ten.ToUpper());
            Console.WriteLine("Điểm: " + diem_cuoi_ky + ", Xếp loại: " + xep_loai);
        }
    }
}
