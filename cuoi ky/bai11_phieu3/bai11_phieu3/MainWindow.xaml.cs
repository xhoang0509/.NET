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
using bai11_phieu3.Models;
namespace bai11_phieu3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLyDanhMucSanPhamContext db = new QuanLyDanhMucSanPhamContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            HienThiCB();
        }

        public void HienThiDuLieu()
        {
            var query = from sanpham in db.SanPhams
                        join loaisanpham in db.LoaiSanPhams on sanpham.MaLoaiSanPham equals loaisanpham.MaLoaiSanPham
                        select new
                        {
                            MaSanPham = sanpham.MaSanPham,
                            TenSanPham = sanpham.TenSanPham,
                            SoLuong = sanpham.SoLuong,
                            DonGia = sanpham.DonGia,
                            MaLoaiSanPham = loaisanpham.MaLoaiSanPham,
                            TenLoaiSanPham = loaisanpham.TenLoaiSanPham,
                        };
            dgData.ItemsSource = query.ToList();
        }

        public void HienThiCB()
        {
            var query = from lsp in db.LoaiSanPhams select lsp;
            cbLoaiSanPham.ItemsSource = query.ToList();
            cbLoaiSanPham.DisplayMemberPath = "TenLoaiSanPham";
            cbLoaiSanPham.SelectedValuePath = "MaLoaiSanPham";
            cbLoaiSanPham.SelectedIndex = 0;
        }

        private void dgData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = dgData.SelectedItem;
            if (item != null)
            {
                try
                {
                    Type t = dgData.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMaSanPham.Text = p[0].GetValue(item).ToString();
                    txtMaSanPham.IsEnabled = false;
                    txtTenSanPham.Text = p[1].GetValue(item).ToString();
                    txtTenSanPham.IsEnabled = false;
                    txtSoLuong.Text = p[2].GetValue(item).ToString();
                    txtSoLuong.IsEnabled = false;
                    txtDonGia.Text = p[3].GetValue(item).ToString();
                    txtDonGia.IsEnabled = false;
                    cbLoaiSanPham.SelectedValue = p[4].GetValue(item).ToString();
                    cbLoaiSanPham.IsEnabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn sản phẩm: " + ex.Message, "Thông báo");
                }
            }
        }

        public void clearForm()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            cbLoaiSanPham.SelectedIndex = 0;
            txtMaSanPham.Focus();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(t => t.MaSanPham.Equals(int.Parse(txtMaSanPham.Text)));
            if (query != null)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại !", "Thông báo");
                HienThiDuLieu();
            }
            else
            {
                try
                {
                    if (checkDL())
                    {
                        SanPham spMoi = new SanPham();
                        spMoi.MaSanPham = int.Parse(txtMaSanPham.Text);
                        spMoi.TenSanPham = txtTenSanPham.Text;
                        spMoi.SoLuong = int.Parse(txtSoLuong.Text);
                        spMoi.DonGia = int.Parse(txtDonGia.Text);
                        LoaiSanPham itemSelected = (LoaiSanPham)cbLoaiSanPham.SelectedItem;
                        spMoi.MaLoaiSanPham = itemSelected.MaLoaiSanPham;
                        db.SanPhams.Add(spMoi);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công !", "Thông báo");
                        clearForm();
                        HienThiDuLieu();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Có lỗi khi thêm: " + e1.Message, "Thong Bao");
                }
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            clearForm();
        }

        private bool checkDL()
        {
            string tb = "";
            if (txtMaSanPham.Text == "" || txtTenSanPham.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
                tb += "\nYêu cầu nhập đủ dữ liệu!";
            }
            if (!Regex.IsMatch(txtDonGia.Text, @"\d+"))
            {
                tb += "\nĐơn giá phải là số nguyên";
            }
            else
            {
                if (int.Parse(txtDonGia.Text) < 0)
                {
                    tb += "\nĐơn giá phải lớn hơn 0";
                }
            }
            if (!Regex.IsMatch(txtSoLuong.Text, @"\d+"))
            {
                tb += "\nSố lượng phải là số nguyên";
            }
            else
            {
                if (int.Parse(txtSoLuong.Text) < 0)
                {
                    tb += "\nSố lượng phải lớn hơn 0";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtTenSanPham.IsEnabled = true;
                txtDonGia.IsEnabled = true;
                txtSoLuong.IsEnabled = true;
                cbLoaiSanPham.IsEnabled = true;

                var spSua = db.SanPhams.SingleOrDefault(t => t.MaSanPham.Equals(int.Parse(txtMaSanPham.Text)));
                if (spSua != null)
                {
                    if (checkDL())
                    {
                        spSua.TenSanPham = txtTenSanPham.Text;
                        spSua.DonGia = int.Parse(txtDonGia.Text);
                        spSua.SoLuong = int.Parse(txtSoLuong.Text);
                        LoaiSanPham itemSelected = (LoaiSanPham)cbLoaiSanPham.SelectedItem;
                        spSua.MaLoaiSanPham = itemSelected.MaLoaiSanPham;
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công !", "Thông báo !");
                        HienThiDuLieu();
                    }
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Có lỗi khi sửa: " + e2.Message, "Thong Bao");
            }
        }
    }
}
