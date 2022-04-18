using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE02
{
    class Examinee
    {
        public string id { get; set; }
        public string fullname { get; set; }
        public float math { get; set; }
        public float physical { get; set; }

        public Examinee()
        {
        }

        public Examinee(string id, string fullname, float math, float physical)
        {
            this.id = id;
            this.fullname = fullname;
            this.math = math;
            this.physical = physical;
        }

        public virtual float Total()
        {
            return math + physical;
        }

        public string Check(float mark)
        {
            if(Total() > mark)
            {
                return "Thi do";
            } else
            {
                return "Thi truot";
            }
        }
    }
}
