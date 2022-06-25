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

namespace KT2_DE02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        ObservableCollection<String> listCb = new ObservableCollection<String> { "Cơ hữu", "Hợp đồng", "Cộng tác viên" };
        ObservableCollection<NhanVien> list = new ObservableCollection<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            cbRole.ItemsSource = listCb;
            cbRole.SelectedItem = listCb[0];

        }

        private bool checkError()
        {

            string message = "";
            bool error = false;

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSalesMoney.Text)
                || (dpBirthday.SelectedDate == null)
                || String.IsNullOrEmpty(cbRole.SelectedItem.ToString())
                )
            {
                message += "Yêu cầu nhập đủ các trường !";
                error = true;
            }
            else
            {
                if (!Regex.IsMatch(txtSalesMoney.Text, @"^\d+$"))
                {
                    message += "\nSố tiền lương phải là số !";
                    txtSalesMoney.Text = "";
                    txtSalesMoney.Focus();
                    error = true;
                }
                else
                {
                    int year = 2022 - int.Parse(dpBirthday.SelectedDate.Value.Date.ToShortDateString().Split("/").Last());
                    if (year < 19 || year > 60)
                    {
                        message += "\nYêu cầu tuổi lơn hơn 19, nhỏ hơn 60";
                        error = true;
                    }
                    if (double.Parse(txtSalesMoney.Text) < 0)
                    {
                        message += "\nYêu cầu số tiền bán hàng lơn hơn 0";
                        error = true;
                    }
                }

            }
            lbMessage.Content = message;
            return error;

        }

        private void clearForm()
        {
            txtName.Text = "";
            dpBirthday.SelectedDate = null;
            txtSalesMoney.Text = "";
            txtName.Focus();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!checkError())
                {
                    string name = txtName.Text;
                    string role = cbRole.SelectedItem.ToString();
                    string birthday = dpBirthday.SelectedDate.Value.Date.ToShortDateString();
                    double salesPrice = double.Parse(txtSalesMoney.Text);

                    NhanVien x = new NhanVien(name, role, birthday, salesPrice);
                    list.Add(x);
                    lbNhanVien.ItemsSource = list;
                    clearForm();
                }
            }
            catch (Exception a)
            {
                lbMessage.Content = a.Message;
            }


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            clearForm();
            cbRole.IsEnabled = false;
            dpBirthday.DisplayDate = DateTime.Today;
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            if (lbNhanVien.SelectedItem == null)
            {
                lbMessage.Content = "\nBạn chưa chọn dòng nào để xem";
            }else
            {
                try
                {
                    NhanVien x = (NhanVien)lbNhanVien.SelectedItem;
                    Window2 window2 = new Window2();
                    window2.nhanVien = x;
                    window2.ShowDialog();
                }
                catch (Exception)
                {

                    
                }
            }
        }
    }
}
