using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DE03
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        //ObservableCollection<String> address = new ObservableCollection<String> { "Hà Nội", "Hải Phòng", "Quảng Ninh" };
        public KhachHang khachHang { get; set; }
        public Window2()
        {
            InitializeComponent();
            cbAddress.ItemsSource = MainWindow.address;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void loadWindow2(object sender, RoutedEventArgs e)
        {
            txtName.IsEnabled = false;
            txtName.Text = khachHang.name;
            cbAddress.IsEnabled = false;
            cbAddress.SelectedItem = khachHang.address;
            txtElectrolic.IsEnabled = false;
            txtElectrolic.Text = khachHang.soDien + "";
            dpDate.IsEnabled = false;
            dpDate.SelectedDate = DateTime.Parse(khachHang.date);
            txtPrice.IsEnabled = false;
            txtPrice.Text = khachHang.price() + "";
        }
    }
}
