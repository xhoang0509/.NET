using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using QLSanPham.Models;
namespace QLSanPham
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLySanPhamDBContext db = new QuanLySanPhamDBContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }

        private void HienThiDL()
        {

            var query = from sp in db.SanPhams
                        join nh in db.NhomHangs
                        on sp.MaNhomHang equals nh.MaNhomHang
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            nh.TenNhomHang,
                            sp.MaNhomHang,
                            TienBan = sp.DonGia * sp.SoLuongBan
                        };
            dgData.ItemsSource = query.ToList();
        }

        private void HienThiCB()
        {
            var query = from nh in db.NhomHangs select nh;
            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.DisplayMemberPath = "TenNhomHang";
            cbNhomHang.SelectedValue = "MaNhomHang";
            cbNhomHang.SelectedIndex = 0;
        }

        private bool checkDL()
        {
            string tb = "";
            if (txtMasp.Text == "" || txtTensp.Text == "" || txtDongia.Text == "" || txtSl.Text == "")
            {
                tb += "\nYêu cầu nhập đủ thông tin !";
            }
            if (!Regex.IsMatch(txtDongia.Text, @"\d+"))
            {
                tb += "\nĐơn giá phải là số nguyên ";
            }
            else
            {
                if (int.Parse(txtDongia.Text) < 0)
                {
                    tb += "\nĐơn giá phải lớn hơn 0";
                }
            }
            if (!Regex.IsMatch(txtSl.Text, @"\d+"))
            {
                tb += "\nSố lượng sp là số nguyên ";
            }
            else
            {
                if (int.Parse(txtSl.Text) < 1)
                {
                    tb += "\nSố lượng phải >= 1";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thông báo");
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(int.Parse(txtMasp.Text)));
            if (query != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo");
                HienThiDL();
            }
            else
            {
                try
                {
                    if (checkDL())
                    {
                        SanPham spMoi = new SanPham();
                        spMoi.MaSp = int.Parse(txtMasp.Text);
                        spMoi.TenSanPham = txtTensp.Text;
                        spMoi.DonGia = int.Parse(txtDongia.Text);
                        spMoi.SoLuongBan = int.Parse(txtSl.Text);
                        spMoi.TienBan = int.Parse(txtDongia.Text) * int.Parse(txtSl.Text);
                        NhomHang item = (NhomHang)cbNhomHang.SelectedItem;
                        spMoi.MaNhomHang = item.MaNhomHang;
                        db.SanPhams.Add(spMoi);
                        db.SaveChanges();
                        MessageBox.Show("Thêm sản phẩm mới thành công !", "Thông báo");
                        HienThiDL();
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Có lỗi khi thêm sản phẩm " + e1.Message, "Thông báo");
                }
            }
        }

        private void dgData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = dgData.SelectedItem;
            if (item != null)
            {
                try
                {
                    Type t = item.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMasp.Text = p[0].GetValue(dgData.SelectedValue).ToString();
                    txtTensp.Text = p[1].GetValue(dgData.SelectedValue).ToString();
                    txtDongia.Text = p[2].GetValue(dgData.SelectedValue).ToString();
                    txtSl.Text = p[3].GetValue(dgData.SelectedValue).ToString();
                    cbNhomHang.SelectedValue = p[5].GetValue(dgData.SelectedValue).ToString();
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Có lỗi khi chọn sản phẩm " + e2.Message, "Thông báo");
                }
            }
        }
    }
}
