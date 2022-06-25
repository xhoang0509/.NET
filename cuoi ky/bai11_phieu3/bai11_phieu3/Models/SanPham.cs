using System;
using System.Collections.Generic;

#nullable disable

namespace bai11_phieu3.Models
{
    public partial class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int? SoLuong { get; set; }
        public int? DonGia { get; set; }
        public int? MaLoaiSanPham { get; set; }

        public virtual LoaiSanPham MaLoaiSanPhamNavigation { get; set; }
    }
}
