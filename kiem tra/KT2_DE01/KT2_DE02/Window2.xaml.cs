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

namespace KT2_DE02
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public NhanVien nhanVien { get; set; }
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void loadWindow2(object sender, RoutedEventArgs e)
        {
            txtName.Text = nhanVien.name;
            txtSalesMoney.Text = nhanVien.salesPrice + "";
            txtBonus.Text = nhanVien.bonus() + "";
            cbRole.SelectedItem = "hoang";
            dpBirthday.SelectedDate = DateTime.Parse(nhanVien.birthday);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
