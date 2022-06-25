using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai1
{
    class Program
    {

        static void Main(string[] args)
        {
            var brands = new List<Brand>()
            {
                new Brand{ID = 1, Name = "Vingroup"},
                new Brand{ID = 2, Name = "Samsung"},
                new Brand{ID = 3, Name = "FPT"},
            };

            var products = new List<Product>()
            {
               new Product(1, "O to", 400, new string[] {"Do", "Trang", "Den"}, 1),
                new Product(2, "Dien thoai", 400, new string[] {"Xanh", "Den"}, 2),
                new Product(3, "May giat", 500, new string[] {"Trang"}, 3),
                new Product(4, "Tu lanh", 200, new string[] {"Do", "Trang"}, 3),
                new Product(5, "Laptop", 300, new string[] {"Xanh", "Den", "Do"}, 2),
                new Product(6, "Dieu hoa", 500, new string[] {"Trang"}, 2),
                new Product(7, "Xe may", 500, new string[] {"Trang"}, 1),
            };

            // form and select
            var ketqua = from product in products select product;
            Console.WriteLine("ket qua 1: ");
            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());

            // select once
            var ketqua2 = products.Select(product => product.Name);
            Console.WriteLine("ket qua 2: ");
            foreach (var product in ketqua2)
                Console.WriteLine(product.ToString());

            // select and return new {}
            var ketqua3 = from product in products select new { ten = product.Name.ToUpper(), mausac = string.Join(",", product.Colors) };
            Console.WriteLine("ket qua 3: ");
            foreach (var product in ketqua3)
                Console.WriteLine(product.ten + " - " + product.mausac);

            // where 
            var ketqua4 = from product in products where product.Price == 400 select product;
            var ketqua5 = products.Where(product => product.Price == 400);
            Console.WriteLine("ket qua 4: ");
            foreach (var product in ketqua4)
                Console.WriteLine(product.ToString());
            Console.WriteLine("ket qua 5: ");
            foreach (var product in ketqua5)
                Console.WriteLine(product.ToString());

            // print products have price >= 500 and < 600 or name product contains "e"
            var result = from product in products where ((product.Price >= 500 && product.Price < 600) || product.Name.Contains("e")) select product;
            Console.WriteLine("result 6: ");
            foreach (var product in result)
                Console.WriteLine(product.ToString());

            // orderby: print name and price of product, list sort descending by price
            var result1 = from product in products orderby product.Price ascending select product;
            var result2 = (products.Where(product => product.Price <= 400)).OrderByDescending(product => product.Price);
            Console.WriteLine("result 7: ");
            foreach (var product in result2)
                Console.WriteLine(product.ToString());

            // group by
            var result3 = from product in products
                          where product.Price <= 500
                          group product by product.Brand;
            foreach (var group in result3)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine($"   {product.Name} - {product.Price}");
                }
            }

            // join
            var result4 = from product in products
                          join brand in brands on product.Brand equals brand.ID
                          select new
                          {
                              name = product.Name,
                              brand = brand.Name,
                              price = product.Price
                          };
            // tuong tu
            var result5 = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
            {
                return new
                {
                    name = p.Name,
                    price = p.Price,
                    brand = b.Name,
                };
            });

            foreach (var item in result4)
            {
                Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            }

            
        }
    }
}
