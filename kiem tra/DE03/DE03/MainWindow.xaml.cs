using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DE03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<String> address = new ObservableCollection<String> { "Hà Nội", "Hải Phòng", "Quảng Ninh" };
        ObservableCollection<KhachHang> khachHangs = new ObservableCollection<KhachHang>();
        public MainWindow()
        {
            InitializeComponent();
            cbAddress.ItemsSource = address;
            cbAddress.SelectedItem = address[0];
        }

        private bool validate()
        {
            string message = "";
            bool error = false;

            if (String.IsNullOrEmpty(txtName.Text)
                || cbAddress.SelectedItem == null
                || String.IsNullOrEmpty(txtElectrolic.Text)
                || dpDate.SelectedDate == null)
            {
                message += "Yêu cầu nhập đủ các trường !";
                error = true;
            }
            else
            {
                if (!Regex.IsMatch(txtElectrolic.Text, @"^\d+$"))
                {
                    message += "\nYêu cầu số điện dùng nhập số !";
                    error = true;
                }
                else
                {
                    int soDien = int.Parse(txtElectrolic.Text);
                    if (soDien < 10 || soDien > 100)
                    {
                        message += "\nYêu cầu số điện lớn hơn 10, nhỏ hơn 100";
                        error = true;
                    }
                }
            }

            lbMessage.Content = message;
            return error;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!validate())
            {
                string name = txtName.Text;
                string address = cbAddress.SelectedItem.ToString();
                int soDien = int.Parse(txtElectrolic.Text);
                string date = dpDate.SelectedDate.Value.Date.ToShortDateString();

                KhachHang x = new KhachHang(name, address, soDien, date);
                khachHangs.Add(x);
                lbData.ItemsSource = khachHangs;
                clear();
            }
        }

        private void clear()
        {
            txtName.Text = "";
            cbAddress.SelectedItem = address[0];
            txtElectrolic.Text = "";
            dpDate.SelectedDate = DateTime.Today;
            txtName.Focus();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            if(lbData.SelectedItem == null)
            {
                lbMessage.Content = "Yêu cầu chọn khách hàng để xem chi tiết !";                
            } else
            {
                KhachHang x = (KhachHang)lbData.SelectedItem;
                Window2 wd2 = new Window2();
                wd2.khachHang = x;
                wd2.ShowDialog();
            }
        }
    }
}
