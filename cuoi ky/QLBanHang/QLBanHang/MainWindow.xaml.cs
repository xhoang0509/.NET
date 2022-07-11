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
using QLBanHang.Models;

namespace QLBanHang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            HienThiCB();
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            var query = from sp in db.SanPhams
                        orderby sp.DonGia
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.SoLuong * sp.DonGia
                        };
            dgData.ItemsSource = query.ToList();
        }
        private void HienThiCB()
        {
            var query = from lsp in db.LoaiSanPhams select lsp;
            cbLoaiSP.ItemsSource = query.ToList();
            cbLoaiSP.DisplayMemberPath = "TenLoai";
            cbLoaiSP.SelectedValuePath = "MaLoai";
            cbLoaiSP.SelectedIndex = 0;
        }

        private bool checkDL()
        {
            string tb = "";
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
            {
                tb += "\nYêu cầu nhập đủ dữ liệu !";
            }
            if (!Regex.IsMatch(txtDonGia.Text, @"\d+"))
            {
                tb += "\nYêu cầu đơn giá là số nguyên !";
            }
            else
            {
                if (int.Parse(txtDonGia.Text) < 0)
                {
                    tb += "\nYêu cầu đơn giá lớn hơn 0!";
                }
            }
            if (!Regex.IsMatch(txtSoLuong.Text, @"\d+"))
            {
                tb += "\nYêu cầu số lượng là số nguyên !";
            }
            else
            {
                if (int.Parse(txtSoLuong.Text) < 0)
                {
                    tb += "\nYêu cầu số lượng lớn hơn 0!";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void dgData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object itemSelected = dgData.SelectedItem;
            if (itemSelected != null)
            {
                try
                {
                    Type t = itemSelected.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMaSP.Text = p[0].GetValue(itemSelected).ToString();
                    txtTenSP.Text = p[1].GetValue(itemSelected).ToString();
                    cbLoaiSP.SelectedValue = p[2].GetValue(itemSelected).ToString();                    
                    txtSoLuong.Text = p[3].GetValue(itemSelected).ToString();
                    txtDonGia.Text = p[4].GetValue(itemSelected).ToString();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Có lỗi khi chọn sản phẩm " + e1.Message, "Thông báo");
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
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
                        spMoi.MaSp = txtMaSP.Text;
                        spMoi.TenSp = txtTenSP.Text;
                        spMoi.DonGia = int.Parse(txtDonGia.Text);
                        spMoi.SoLuong = int.Parse(txtSoLuong.Text);
                        LoaiSanPham itemSelected = (LoaiSanPham)cbLoaiSP.SelectedItem;
                        spMoi.MaLoai = itemSelected.MaLoai;
                        db.SanPhams.Add(spMoi);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        HienThiDuLieu();
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Có lỗi thi thêm sản phẩm " + e2.Message, "Thông báo");
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var spSua = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
                if (spSua != null)
                {
                    if (checkDL())
                    {
                        spSua.TenSp = txtTenSP.Text;
                        spSua.DonGia = int.Parse(txtDonGia.Text);
                        spSua.SoLuong = int.Parse(txtSoLuong.Text);
                        LoaiSanPham itemSelected = (LoaiSanPham)cbLoaiSP.SelectedItem;
                        spSua.MaLoai = itemSelected.MaLoai;
                        db.SaveChanges();
                        MessageBox.Show("Sửa sản phẩm thành công", "Thông báo");
                        HienThiDuLieu();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần sửa ");
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show("Có lỗi thi sửa sản phẩm " + e3.Message, "Thông báo");

            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var spXoa = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtMaSP.Text));
            if (spXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButton.YesNo);
                if (rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm này để xóa !", "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            LoaiSanPham itemSelected = (LoaiSanPham)cbLoaiSP.SelectedItem;
            var query = from sp in db.SanPhams
                        where sp.MaLoai == itemSelected.MaLoai
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.SoLuong * sp.DonGia
                        };
            dgData.ItemsSource = query.ToList();
        }

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }
    }
}
