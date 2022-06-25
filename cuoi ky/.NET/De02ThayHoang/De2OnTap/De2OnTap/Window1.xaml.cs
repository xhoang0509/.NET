using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using De2OnTap.Models;

namespace De2OnTap
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public Window1()
        {
            InitializeComponent();
            Tim();
        }

        private void Tim()
        {
            var query = from sp in ql.SanPhams
                        join nh in ql.NhomHangs
                        on sp.MaNhomHang equals nh.MaNhomHang
                        where sp.MaNhomHang == 1
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            nh.TenNhomHang,
                            sp.TienBan
                        };
            dgDSSP.ItemsSource = query.ToList();
                        
        }
    }
}
