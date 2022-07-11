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
using De02.Models;
namespace De02
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        NhanvienDBContext db = new NhanvienDBContext();
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            var query = from nv in db.Nhanviens
                        join pb in db.PhongBans
                        on nv.MaPhong equals pb.MaPhong
                        group nv.MaPhong by nv.MaPhong;

            MessageBox.Show(query.ToString(), "thông báo");
            //dgData.ItemsSource = query.ToList();
        }
    }
}
