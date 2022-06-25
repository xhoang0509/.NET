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

namespace KT2_DE01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<NhanVien> list;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            list = new ObservableCollection<NhanVien>();
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!isError())
            {
                string name = txtName.Text;
                if (String.IsNullOrEmpty(name))
                {

                }
                string gender = "";
                if (rdGender.IsChecked == true)
                {
                    gender = "Nam";
                }
                else
                {
                    gender = "Nữ";
                }
                int workDays = int.Parse(txtWorkDays.Text);
                double salary = double.Parse(txtSalary.Text);
                NhanVien nv = new NhanVien(name, gender, workDays, salary);
                list.Add(nv);
                clearForm();
                lbNhanVIens.ItemsSource = list;
            }

        }

        public bool isError()
        {
            string errorMessage = "";
            bool isError = false;
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSalary.Text) || String.IsNullOrEmpty(txtWorkDays.Text))
            {
                errorMessage += "Yêu cầu nhập đủ dữ liệu các dòng";
                isError = true;

            }
            else
            {
                if (!Regex.IsMatch(txtWorkDays.Text, @"^\d+$") || !Regex.IsMatch(txtSalary.Text, @"^\d+$"))
                {
                    errorMessage += "\nYêu cầu nhập ngày công và lương là số";
                    isError = true;
                }
                else
                {
                    int workDays = int.Parse(txtWorkDays.Text);
                    if (workDays < 20 || workDays > 30)
                    {
                        errorMessage += "\nNgày công yêu cầu lơn hơn 20, nhỏ hơn 30";
                        isError = true;
                    }
                    int salary = int.Parse(txtSalary.Text);
                    if (salary < 3000 || salary > 5000)
                    {
                        errorMessage += "\nLương yêu cầu lơn hơn 3000, nhỏ hơn 5000";
                        isError = true;
                    }
                }
            }
            lbMessage.Content = errorMessage;
            return isError;

        }

        private void clearForm()
        {
            txtName.Text = "";
            txtSalary.Text = "";
            txtWorkDays.Text = "";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            clearForm();
            txtName.Focus();
        }
        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if(lbNhanVIens.SelectedItem == null)
            {
                lbMessage.Content = "Yêu cầu chọn nhân viên !";                
            } else
            {
                NhanVien nv = (NhanVien)lbNhanVIens.SelectedItem;
                list.Remove(nv);
            }
            
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            try
            {
                NhanVien nv = (NhanVien)lbNhanVIens.SelectedItem;
                Window2 windows = new Window2();
                windows.nhanVien = nv;
                windows.ShowDialog();
            }
            catch (Exception)
            {

                error = "Yêu cầu chọn 1 nhân viên";
            }
            lbMessage.Content = error;
        }
    }
}
