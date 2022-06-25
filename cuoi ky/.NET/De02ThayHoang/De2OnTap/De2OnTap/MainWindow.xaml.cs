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
using De2OnTap.Models;

namespace De2OnTap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            DataComboBox();
        }

        private void DataComboBox()
        {
            var query = from nh in ql.NhomHangs
                        select nh.MaNhomHang;

            cbNhomHang.ItemsSource = query.ToList();
            cbNhomHang.SelectedIndex = 0;
        }

        private void LoadItems()
        {
            var query = from sp in ql.SanPhams
                        join nh in ql.NhomHangs
                        on sp.MaNhomHang equals nh.MaNhomHang
                        orderby sp.SoLuongBan descending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            nh.TenNhomHang,
                            sp.TienBan
                        };
            dgDSSP.ItemsSource = query.ToList();
                       
        }

        private void HienThi()
        {
            var query = from sp in ql.SanPhams
                        join nh in ql.NhomHangs
                        on sp.MaNhomHang equals nh.MaNhomHang
                        select new
                        {
                            sp.MaSp,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.SoLuongBan,
                            nh.TenNhomHang,
                            sp.TienBan
                        };
            dgDSSP.ItemsSource = query.ToList();

        }

        private void Clear()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSLBan.Clear();
            cbNhomHang.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            float number1;
            bool ktraDG = float.TryParse(txtDonGia.Text, out number1);

            int number2;
            bool ktraSLB = Int32.TryParse(txtSLBan.Text, out number2);

            var maSP = (from sp in ql.SanPhams
                        where sp.MaSp == int.Parse(txtMaSP.Text)
                        select sp.MaSp).SingleOrDefault();

            try
            {
                if (!ktraDG)
                    throw new Exception("Đơn giá không đúng kiểu dữ liệu");

                if (!ktraSLB)
                    throw new Exception("Số lượng bán không đúng kiểu dữ liệu");

                if (maSP != 0)
                    throw new Exception("Mã SP đã tồn tại");

                int SLBan = int.Parse(txtSLBan.Text);
                if (SLBan < 1)
                    throw new Exception("Số lượng bán phải >= 1");

                SanPham sp = new SanPham();
                sp.MaSp = int.Parse(txtMaSP.Text);
                sp.TenSanPham = txtTenSP.Text;
                sp.DonGia = float.Parse(txtDonGia.Text);
                sp.SoLuongBan = SLBan;
                sp.TienBan = sp.DonGia * sp.SoLuongBan;
                sp.MaNhomHang = int.Parse(cbNhomHang.Text);

                ql.SanPhams.Add(sp);
                ql.SaveChanges();
                Clear();
                HienThi();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgDSSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSSP.SelectedItem;

            if (item != null)
            {
                string tenNH = (dgDSSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;

                var maNH = (from nh in ql.NhomHangs
                            where nh.TenNhomHang == tenNH
                            select nh.MaNhomHang).Single();

                cbNhomHang.SelectedItem = maNH;

            }    
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }
    }
}
