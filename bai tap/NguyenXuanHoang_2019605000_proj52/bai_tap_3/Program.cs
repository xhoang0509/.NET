using System;
using System.Collections.Generic;

namespace bai_tap_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimUSCLN> ds = new List<TimUSCLN>();
            int n = 10;
            Random rd = new Random();


            for (int i = 0; i < n; i++)
            {
                ds.Add(new TimUSCLN(rd.Next(0,101), rd.Next(0, 101)));
            }

            foreach (var item in ds)
            {
                Console.WriteLine("UCLN a = " + item.sothu1 + " b = " + item.sothu2 + " la: " + item.Calculate());
            }
        }
    }
}
