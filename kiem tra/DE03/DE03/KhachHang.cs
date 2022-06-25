using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE03
{
    public class KhachHang
    {
        public string name { get; set; }
        public string address { get; set; }
        public int soDien { get; set; }
        public string date { get; set; }

        public KhachHang(string name, string address, int soDien, string date)
        {
            this.name = name;
            this.address = address;
            this.soDien = soDien;
            this.date = date;
        }

        public double price()
        {
            return soDien * 500;
        }

        public override string ToString()
        {
            return $"{name} - {address} - {soDien} - {price()} - {date}";
        }
    }
}
