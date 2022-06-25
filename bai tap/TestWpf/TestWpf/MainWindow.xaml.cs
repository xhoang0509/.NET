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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Cong_Click(object sender, RoutedEventArgs e)
        {
            int result = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void Button_Tru_Click(object sender, RoutedEventArgs e)
        {
            int result = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void Button_Nhan_Click(object sender, RoutedEventArgs e)
        {
            int result = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void Button_Chia_Click(object sender, RoutedEventArgs e)
        {
            int result = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void Button_Reset_Click(object sender, RoutedEventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";

        }
    }
}
