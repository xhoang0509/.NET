using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2_DE02
{
    public class NhanVien
    {
        public string name { get; set; }
        public string role { get; set; }
        public string birthday { get; set; }
        public double salesPrice { get; set; }

        public NhanVien(string name, string role, string birthday, double salesPrice)
        {
            this.name = name;
            this.role = role;
            this.birthday = birthday;
            this.salesPrice = salesPrice;
        }

        public double bonus()
        {
            if(salesPrice < 1000)
            {
                return 0;
            } else if(salesPrice < 5000)
            {
                return 0.05 * salesPrice;
            } else
            {
                return 0.1 * salesPrice;
            }
        }

        public override string ToString()
        {
            return $"{name} - {birthday} - {role} - Tiền bán hàng: {salesPrice} - Hoa hồng: {bonus()}";
        }
    }
}
