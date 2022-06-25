using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class NhanVien
    {
        private string ten;
        private float tienBanHang;

        public string Ten
        {
            get
            {
                return ten;
            }
        }

        public float TenBanHang
        {
            get
            {
                return tienBanHang;
            }
        }

        public NhanVien(string ten, float tienBanHang)
        {
            this.ten = ten;
            this.tienBanHang = tienBanHang;
        }

        public static float TinhTienHoaHong(float tienBanHang)
        {
            if (tienBanHang < 1000)
            {
                return tienBanHang * 0;
            }
            else if (tienBanHang < 3000)
            {
                return (float)(tienBanHang * 0.05);
            }
            else
            {
                return (float)(tienBanHang * 0.1);
            }
        }

       

    }
}
