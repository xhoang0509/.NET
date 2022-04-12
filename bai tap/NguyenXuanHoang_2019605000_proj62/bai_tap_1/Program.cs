using System;
using System.Collections.Generic;

namespace bai_tap_1
{
    class Program
    {
        //List<Vehicles> list = new List<Vehicles>();
        static List<Car> cars = new List<Car>();
        static List<Truck> trucks = new List<Truck>();
        static void nhapDS()
        {
            /*
            Console.WriteLine("\n\t\tNHAP DS 3 CAR");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n\tnhap car " + (i + 1));
                Car temp = new Car();
                temp.Input();
                cars.Add(temp);
            }

            Console.WriteLine("\n\t\tNHAP DS 3 TRUCK");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n\tnhap truck " + (i + 1));
                Truck temp = new Truck();
                temp.Input();
                trucks.Add(temp);
            }
            */
            cars.Add(new Car("car1", "maker1", "model1", 2025, 10000, "red"));
            cars.Add(new Car("car2", "maker2", "model2", 2019, 2000, "blue"));
            cars.Add(new Car("car3", "maker3", "model3", 2022, 3000, "yellow"));

            trucks.Add(new Truck("truck1", "maker1", "model1", 2024, 10200, 20));
            trucks.Add(new Truck("truck2", "maker2", "model2", 2021, 20000, 30));
            trucks.Add(new Truck("truck3", "maker3", "model3", 2027, 700, 40));
        }
        static void xuatDS()
        {
            Console.WriteLine("\n\tDS CAR");
            Car.Title();
            foreach (var item in cars)
            {
                item.Output();
            }

            Console.WriteLine("\n\tDS TRUCK");
            Truck.Title();
            foreach (var item in trucks)
            {
                item.Output();
            }
        }

        static void FindById(string id)
        {
            //List<Vehicles> listFinded = new List<Vehicles>();
            List<Car> carsFinded = new List<Car>();
            List<Truck> trucksFinded = new List<Truck>();
            foreach (var item in cars)
            {
                if (item.id == id)
                {
                    carsFinded.Add(item);
                }
            }

            foreach (var item in trucks)
            {
                if (item.id == id)
                {
                    trucksFinded.Add(item);
                }
            }

            if (carsFinded.Count > 0)
            {
                Console.WriteLine("\n\t\tDS CAR TIM DC LA");
                Car.Title();
                foreach (var item in carsFinded)
                {
                    item.Output();
                }
                Console.WriteLine();


            }
            else if (trucksFinded.Count > 0)
            {
                Console.WriteLine("\n\t\tDS TRUCK TIM DC LA");
                Truck.Title();
                foreach (var item in trucksFinded)
                {
                    item.Output();
                }
            }
            else
            {
                Console.WriteLine("khong tim thay id: " + id);
            }
        }

        static void FindByMaker(string maker)
        {
            //List<Vehicles> listFinded = new List<Vehicles>();
            List<Car> carsFinded = new List<Car>();
            List<Truck> trucksFinded = new List<Truck>();
            foreach (var item in cars)
            {
                if (item.maker == maker)
                {
                    carsFinded.Add(item);
                }
            }

            foreach (var item in trucks)
            {
                if (item.maker == maker)
                {
                    trucksFinded.Add(item);
                }
            }

            if (carsFinded.Count > 0)
            {
                Console.WriteLine("\n\t\tDS CAR TIM DC LA");
                Car.Title();
                foreach (var item in carsFinded)
                {
                    item.Output();
                }
                Console.WriteLine();


            }
            else if (trucksFinded.Count > 0)
            {
                Console.WriteLine("\n\t\tDS TRUCK TIM DC LA");
                Truck.Title();
                foreach (var item in trucksFinded)
                {
                    item.Output();
                }
            }
            else
            {
                Console.WriteLine("khong tim thay id: " + maker);
            }
        }
        static void SapXepTheoGia()
        {
            cars.Sort();
            trucks.Sort();
        }

        static void SapXepTheoNam()
        {
            cars.Sort(new SapXepTheoNam());
            trucks.Sort(new SapXepTheoNam());
        }
        
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("\n1.Nhap tt 3 car, 3 truck");
                Console.WriteLine("2.Hien thi 3 car, 3 truck");
                Console.WriteLine("3.Tim theo id");
                Console.WriteLine("4.Tim theo maker");
                Console.WriteLine("5.Hien thi thong tin sap xep theo gia");
                Console.WriteLine("6.Hien thi thong tin sap xep theo nam");
                Console.WriteLine("0.Thoat");
                Console.Write("Nhap lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        nhapDS();
                        break;
                    case 2:
                        Console.WriteLine("\n\t\tDANH SACH VUA NHAP LA");
                        xuatDS();
                        break;
                    case 3:
                        Console.Write("Nhap id can tim: ");
                        string id = Console.ReadLine();
                        FindById(id);
                        break;
                    case 4:
                        Console.Write("Nhap maker can tim: ");
                        string maker = Console.ReadLine();
                        FindByMaker(maker);
                        break;
                    case 5:
                        Console.Write("\n\t\tTRUOC KHI SAP XEP");
                        xuatDS();
                        Console.Write("\n\t\tSAU KHI SAP XEP");
                        SapXepTheoGia();
                        xuatDS();
                        break;
                    case 6:
                        Console.Write("\n\t\tTRUOC KHI SAP XEP");
                        xuatDS();
                        Console.Write("\n\t\tSAU KHI SAP XEP");
                        SapXepTheoNam();
                        xuatDS();
                        break;
                    default:
                        break;
                }
            } while (choose != 0);
        }
    }
}
