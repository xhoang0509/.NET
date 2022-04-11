using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NguyenXuanHoang_2019605000_proj51
{
    class Program
    {
        // static ThiSinh[] dsTS;
        static List<ThiSinh> dsTS = new List<ThiSinh>();

        static void nhap()
        {
            ThiSinh temp = new ThiSinh();
            temp.nhap();
            dsTS.Add(temp);
        }

        static void xuat()
        {
            ThiSinh.inTieuDe();
            foreach (ThiSinh item in dsTS)
            {
                item.xuat();
            }
        }

        // hien thi theo tong diem >= so
        static void hienThiTheoTongDiem()
        {
            Console.Write("Nhap mot diem bat ky: ");
            float diem = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tDANH SACH THI SINH CO TONG DIEM >= " + diem);
            ThiSinh.inTieuDe();
            foreach (ThiSinh item in dsTS)
            {
                if (item.tongDiem() >= diem)
                {
                    item.xuat();
                }
            }

        }
        static void hienThiTheoDiaChi()
        {
            Console.Write("Nhap dia chi can tim: ");
            string diaChiTemp = Console.ReadLine();
            Console.WriteLine("\n\t\tDANH SACH THI SINH O " + diaChiTemp);
            ThiSinh.inTieuDe();
            foreach (ThiSinh item in dsTS)
            {
                if (item.diaChi.Equals(diaChiTemp))
                {
                    item.xuat();
                }
            }
        }

        static void timKiemSBD()
        {
            string sdb;
            Console.Write("Nhap so bao danh can tim: ");
            sdb = Console.ReadLine();
            ThiSinh x = dsTS.Find(x => x.soBD.Contains(sdb));

            if (x != null)
            {
                Console.WriteLine("\nTim thay");
                ThiSinh.inTieuDe();
                x.xuat();
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("\n1. Nhap 1 thi tinh ");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Hien thi danh sach theo tong diem");
                Console.WriteLine("4. Hien thi danh sach theo dia chi");
                Console.WriteLine("5. Tim kiem theo so bao danh");
                Console.WriteLine("6. Ket thuc chuong trinh");
                Console.Write("Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        {
                            nhap();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\t\tDANH SACH VUA NHAP LA");
                            xuat();
                            break;
                        }
                    case 3:
                        {
                            hienThiTheoTongDiem();
                            break;
                        }
                    case 4:
                        {
                            hienThiTheoDiaChi();
                            break;
                        }
                    case 5:
                        {
                            timKiemSBD();
                            break;
                        }
                }
            } while (chon != 6);
        }
    }
}
