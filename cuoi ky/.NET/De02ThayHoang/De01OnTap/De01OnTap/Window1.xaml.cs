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
using De01OnTap.Models;

namespace De01OnTap
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        public Window1()
        {
            InitializeComponent();
            Tim();
        }

        private void Tim()
        {
            var query = from bn in ql.BenhNhans
                       join k in ql.Khoas
                       on bn.MaKhoa equals k.MaKhoa
                       where bn.MaKhoa == 1
                       select new
                       {
                           bn.MaBn,
                           bn.HoTen,
                           bn.SoNgayNamVien,
                           k.TenKhoa,
                           bn.VienPhi
                       };
            dgDSBN.ItemsSource = query.ToList();
        }
    }
}
