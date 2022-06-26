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
using QLBanHang.Models;

namespace QLBanHang
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        join lsp in db.LoaiSanPhams
                        on sp.MaLoai equals lsp.MaLoai
                        where lsp.MaLoai == "2"
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.DonGia,
                            sp.SoLuong,
                            ThanhTien = sp.DonGia * sp.SoLuong,
                            TenLoai = lsp.TenLoai,
                        };
            dgData.ItemsSource = query.ToList();
        }
    }
}
