using System;
using System.Collections.Generic;
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
using QLBenhNhan.Models;

namespace QLBenhNhan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBenhNhanContext db = new QLBenhNhanContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            HienThiCb();
        }
        private void HienThiDuLieu()
        {
            var query = from bn in db.BenhNhans
                        where bn.SongayNv <= 20
                        orderby bn.SongayNv descending
                        select new
                        {
                            bn.Mabn,
                            bn.Hoten,
                            bn.Diachi,
                            bn.SongayNv,
                            bn.Makhoa,
                            VienPhi = bn.SongayNv * 60000
                        };
            dgData.ItemsSource = query.ToList();
        }

        public void HienThiCb()
        {
            var query = from kk in db.KhoaKhams select kk;
            cbKhoaKham.ItemsSource = query.ToList();
            cbKhoaKham.DisplayMemberPath = "Tenkhoa";
            cbKhoaKham.SelectedValue = "Makhoa";
            cbKhoaKham.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // check ma benh nhan
            //var query = db.BenhNhans.SingleOrDefault(t => t.Mabn.Equals(txtMaBN.Text));
            var query = from bn in db.BenhNhans where bn.Mabn.Equals(txtMaBN.Text) select bn;
            if (query != null)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại", "Thông báo");
                HienThiDuLieu();
            } else
            {
                try
                {

                }
                catch (Exception e2)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại", "Thông báo");
                }
            }
        }

        private bool checkDL()
        {
            string tb = "";
            if (txtMaBN.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSoNgayNV.Text == "")
            {
                tb += "\nYêu cầu nhập đủ thông tin !";
            }
            if (!Regex.IsMatch(txtSoNgayNV.Text, @"\d+"))
            {
                tb += "\nYêu cầu số ngày phải là số nguyên !";
            }
            else
            {
                if (int.Parse(txtSoNgayNV.Text) < 0)
                {
                    tb += "\nSố ngày phải lớn hơn 0 !";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thông báo !");
                return false;
            }
            return true;
        }

        private void txtHoTen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
