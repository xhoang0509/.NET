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

        // hien thi theo tong diem tang dan
        static void hienThiTheoTongDiem()
        {
            dsTS.Sort();

        }
        static void hienThiTheoDiaChi()
        {
            dsTS.Sort(new CompareAddress());
        }

        static void timKiemSBD()
        {
            string sdb;
            Console.Write("Nhap so bao danh can tim: ");
            sdb = Console.ReadLine();
            ThiSinh x = dsTS.Find(x => x.soBD.Contains(sdb));

            if(x  != null)
            {
                Console.WriteLine("\nTim thay");
                ThiSinh.inTieuDe();
                x.xuat();
            } else
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
                            Console.WriteLine("\n\t\tDANH SACH SAP XEP THEO TONG DIEM LA");
                            xuat();
                            break;
                        }
                    case 4:
                        {
                            hienThiTheoDiaChi();
                            Console.WriteLine("\n\t\tDANH SACH SAP XEP THEO DIA CHI LA");
                            xuat();
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
