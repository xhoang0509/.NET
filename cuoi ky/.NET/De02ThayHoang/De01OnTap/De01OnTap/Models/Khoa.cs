using System;
using System.Collections.Generic;

namespace De01OnTap.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            BenhNhans = new HashSet<BenhNhan>();
        }

        public int MaKhoa { get; set; }
        public string? TenKhoa { get; set; }

        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
    }
}
