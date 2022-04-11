using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    class TimUSCLN
    {
        public int sothu1 { get; set; }
        public int sothu2 { get; set; }

        public TimUSCLN(int sothu1, int sothu2)
        {
            this.sothu1 = sothu1;
            this.sothu2 = sothu2;
        }

        public int Calculate()
        {
            // Nếu a = 0 => ucln(a,b) = b
            // Nếu b = 0 => ucln(a,b) = a
            if (sothu1 == 0 || sothu2 == 0)
            {
                return sothu1 + sothu2;
            }
            while (sothu1 != sothu2)
            {
                if (sothu1 > sothu2)
                {
                    sothu1 -= sothu2; // sothu1 = sothu1 - sothu2
                }
                else
                {
                    sothu2 -= sothu1;
                }
            }
            return sothu1; // return sothu1 or sothu2, bởi vì lúc này sothu1 và sothu2 bằng nhau
        }


    }
}
