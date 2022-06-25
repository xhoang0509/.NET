using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE01
{
    class ThiSinh
    {
        public string sbd { get; set; }
        public string hoTen { get; set; }
        public float diemToan { get; set; }
        public float diemLy { get; set; }
        public float diemHoa { get; set; }

        public ThiSinh()
        {
        }

        public ThiSinh(string sbd, string hoTen, float diemToan, float diemLy, float diemHoa)
        {
            this.sbd = sbd;
            this.hoTen = hoTen;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
        }

        public virtual float TongDiem()
        {
            return diemToan + diemLy + diemHoa;
        }

        public string XetTuyen(float diemsan)
        {
            if (TongDiem() >= diemsan)
            {
                return "Thi do";
            }
            else
            {
                return "Thi truot";
            }
        }
                
    }

    
}
