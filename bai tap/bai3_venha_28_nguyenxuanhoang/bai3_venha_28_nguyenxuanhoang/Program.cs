using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace bai3_venha_28_nguyenxuanhoang
{
    class Program
    {
        static string fileNameInput = "student.txt";
        static List<SinhVien> sinhVienArr = new List<SinhVien>();
        struct SinhVien
        {
            public int id;
            public string ten;
            string gioiTinh;
            int tuoi;
            float diemToan, diemLy, diemHoa;


            public SinhVien(int id, string ten, string gioiTinh, int tuoi, float diemToan, float diemLy, float diemHoa)
            {
                this.id = id;
                this.ten = ten;
                this.gioiTinh = gioiTinh;
                this.tuoi = tuoi;
                this.diemToan = diemToan;
                this.diemLy = diemLy;
                this.diemHoa = diemHoa;
            }

            public void Nhap()
            {
                try
                {
                    int length = sinhVienArr.Count;
                    this.id = sinhVienArr[length - 1].id + 1;
                    Console.Write("Nhap ten: ");
                    this.ten = Console.ReadLine();
                    Console.Write("Nhap gioi tinh: ");
                    this.gioiTinh = Console.ReadLine();
                    Console.Write("Nhap tuoi: ");
                    this.tuoi = int.Parse(Console.ReadLine());
                    Console.Write("Nhap diem toan: ");
                    this.diemToan = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem ly: ");
                    this.diemLy = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem hoa: ");
                    this.diemHoa = float.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("CO LOI KHI NHAP SINH VIEN " + e.Message);
                }
            }
            public void Sua(int id)
            {
                try
                {
                    this.id = id;
                    Console.Write("Nhap ten: ");
                    this.ten = Console.ReadLine();
                    Console.Write("Nhap gioi tinh: ");
                    this.gioiTinh = Console.ReadLine();
                    Console.Write("Nhap tuoi: ");
                    this.tuoi = int.Parse(Console.ReadLine());
                    Console.Write("Nhap diem toan: ");
                    this.diemToan = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem ly: ");
                    this.diemLy = float.Parse(Console.ReadLine());
                    Console.Write("Nhap diem hoa: ");
                    this.diemHoa = float.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("CO LOI KHI SUA SINH VIEN " + e.Message);
                }
            }
            public void TieuDe()
            {
                Console.WriteLine("15%s 15%s 15%s 15%s 15%s 15%s 15%s");
            }
            public void Xuat()
            {
                Console.WriteLine("id: " + this.id + " | ten: " + this.ten + " | gioi tinh: " + this.gioiTinh + " | tuoi: " + this.tuoi +
                    " | toan: " + this.diemToan + " | ly: " + this.diemLy + " | hoa: " +
                    this.diemHoa + " | trung binh: " + this.TrungBinh() + " | hoc luc: " + this.HocLuc());

            }
            public string XuatRaw()
            {
                return this.id + "|" + this.ten + "|" + this.gioiTinh + "|" + this.tuoi + "|" + this.diemToan + "|" + this.diemLy + "|" + this.diemHoa;

            }
            public float TrungBinh()
            {
                return (this.diemToan + this.diemHoa + this.diemLy) / 3;
            }
            public string HocLuc()
            {
                string hocLuc = "";
                if (this.TrungBinh() < 5)
                {
                    hocLuc = "Yeu";
                }
                else if (5 <= this.TrungBinh() && this.TrungBinh() < 6.5)
                {
                    hocLuc = "Trung Binh";
                }
                else if (6.5 <= this.TrungBinh() && this.TrungBinh() < 8)
                {
                    hocLuc = "Kha";
                }
                else
                {
                    hocLuc = "Gioi";
                }

                return hocLuc;
            }



        }

        static public void docFile(string fileNameInput)
        {

            try
            {
                StreamReader sr = new StreamReader(fileNameInput);

                string st = "";
                string[] info;
                while ((st = sr.ReadLine()) != null)
                {
                    info = st.Split("|");
                    SinhVien sv = new SinhVien(int.Parse(info[0]), info[1], info[2], int.Parse(info[3]), float.Parse(info[4]), float.Parse(info[5]), float.Parse(info[6]));
                    sinhVienArr.Add(sv);

                }
                sr.Close();
            }
            catch (FormatException et)
            {
                Console.WriteLine(et.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n====> LOI DOC FILE" + e.Message);

            }
        }
        static public void ghiFile(string fileNameInput)
        {

            try
            {
                StreamWriter sw = new StreamWriter(fileNameInput);
                foreach (SinhVien item in sinhVienArr)
                {
                    sw.WriteLine(item.XuatRaw());
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n====> LOI GHI FILE" + e.Message);

            }
        }
        static void NhapSinhVien()
        {
            SinhVien sinhVienNew = new SinhVien();
            sinhVienNew.Nhap();
            sinhVienArr.Add(sinhVienNew);
        }
        static void XuatDS()
        {
            foreach (SinhVien i in sinhVienArr)
            {
                i.Xuat();
            }
        }
        static void CapNhatSinhVien(int id)
        {
            try
            {
                Console.WriteLine("Sua thong tin sinh vien: " + id);
                SinhVien sinhVienNew = new SinhVien();
                sinhVienNew.Sua(id);
                for (int i = 0; i < sinhVienArr.Count; i++)
                {
                    if (sinhVienArr[i].id == id)
                    {
                        sinhVienArr[i] = sinhVienNew;
                    }
                }
                Console.WriteLine("Cap nhat sinh vien id = " + id + " thanh cong !");
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi khi cap nhat " + e.Message);
            }
        }
        static void XoaSinhVien(int id)
        {
            for (int i = 0; i < sinhVienArr.Count; i++)
            {
                if (sinhVienArr[i].id == id)
                {
                    sinhVienArr.RemoveAt(i);
                }
            }
            Console.WriteLine("Xoa sinh vien id = " + id + " thanh cong !");
        }
        static void TimKiemSinhVien(string name)
        {
            Boolean notFound = false;
            for (int i = 0; i < sinhVienArr.Count; i++)
            {
                if (sinhVienArr[i].ten == name)
                {
                    Console.WriteLine("Sinh vien co ten la " + name);
                    sinhVienArr[i].Xuat();
                    notFound = false;
                    break;
                }
                else
                {
                    notFound = true;
                }
            }
            if (notFound)
            {
                Console.WriteLine("Khong tim thay sinh vien co ten la: " + name);
            }
        }
        static void SapXepTheoDiemTb()
        {
            for(int i = 0; i < sinhVienArr.Count - 1; i++)
            {
                for(int j = i; j < sinhVienArr.Count; j++)
                {
                    if(sinhVienArr[i].TrungBinh() < sinhVienArr[j].TrungBinh())
                    {
                        SinhVien sv = new SinhVien();
                        sv = sinhVienArr[i];
                        sinhVienArr[i] = sinhVienArr[j];
                        sinhVienArr[j] = sv;
                    }
                }
            }
        }
        static void SapXepTheoTheoTen()
        {
            for (int i = 0; i < sinhVienArr.Count - 1; i++)
            {
                for (int j = i; j < sinhVienArr.Count; j++)
                {
                    if (String.Compare(sinhVienArr[i].ten, sinhVienArr[j].ten) < 0)
                    {
                        SinhVien sv = new SinhVien();
                        sv = sinhVienArr[i];
                        sinhVienArr[i] = sinhVienArr[j];
                        sinhVienArr[j] = sv;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            docFile(fileNameInput);
            Console.WriteLine("MENU");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Cap nhan thong tin sinh vien boi ID");
            Console.WriteLine("3. Xoa sinh vien boi ID");
            Console.WriteLine("4. Tim kiem sinh vien theo ten");
            Console.WriteLine("5. Sap xep sinh  vien theo diem trung binh");
            Console.WriteLine("6. Sap xep sinh vien theo ten");
            Console.WriteLine("7. Hien thi danh sach sinh vien");
            Console.WriteLine("8. Ghi danh sach sinh vien vao file 'student.txt'");
            Console.WriteLine("0. Thoat !");

            int choose = 0;
            do
            {

                Console.Write("\nNhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("\nNhap mot sinh vien moi !");
                            NhapSinhVien();
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Console.Write("\nNhap id = ");
                                int id = int.Parse(Console.ReadLine());
                                CapNhatSinhVien(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Co loi khi nhap id");

                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                Console.Write("\nNhap id = ");
                                int id = int.Parse(Console.ReadLine());
                                XoaSinhVien(id);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Co loi khi nhap id ");
                            }
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                Console.Write("\nNhap ten can tim kiem = ");
                                string name = Console.ReadLine();
                                TimKiemSinhVien(name);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Co loi khi nhap ten");
                            }
                            break;
                        }
                    case 5:
                        {
                            SapXepTheoDiemTb();
                            Console.WriteLine("Danh sach da duoc sap xep theo diem trung binh!");
                            break;
                        }
                    case 6:
                        {
                            SapXepTheoTheoTen();
                            Console.WriteLine("Danh sach da duoc sap xep theo ten!");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\nDanh sach sinh vien: ");
                            XuatDS();
                            break;
                        }
                    case 8:
                        {
                            try
                            {
                                Console.WriteLine("GHI FILE THANH CONG !");
                                ghiFile(fileNameInput);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Loi ghi file");
                            }
                            break;
                        }

                }
            } while (choose != 0);

        }
    }
}
