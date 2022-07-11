using System;
using System.Collections.Generic;

#nullable disable

namespace De02.Models
{
    public partial class Nhanvien
    {
        public int MaNv { get; set; }
        public string Hoten { get; set; }
        public int? Songaycong { get; set; }
        public int? Luong { get; set; }
        public int? MaPhong { get; set; }

        public virtual PhongBan MaPhongNavigation { get; set; }
    }
}
