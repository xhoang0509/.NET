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
using De01OnTap.Models;

namespace De01OnTap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
            DataComboBox();
        }

        private void DataComboBox()
        { 
            var query = from k in ql.Khoas
                        select k.MaKhoa;
            cbKhoaKham.ItemsSource = query.ToList();
            cbKhoaKham.SelectedIndex = 0;
        }

        private void LoadItems()
        {
            var query = from bn in ql.BenhNhans
                        join k in ql.Khoas
                        on bn.MaKhoa equals k.MaKhoa
                        orderby bn.SoNgayNamVien descending
                        select new
                        {
                            bn.MaBn,
                            bn.HoTen,
                            bn.SoNgayNamVien,
                            k.TenKhoa,
                            bn.VienPhi
                        };
            dgDSBN.ItemsSource = query.ToList();
                        
        }

        private void HienThi()
        {
            var query = from bn in ql.BenhNhans
                        join k in ql.Khoas
                        on bn.MaKhoa equals k.MaKhoa
                        select new
                        {
                            bn.MaBn,
                            bn.HoTen,
                            bn.SoNgayNamVien,
                            k.TenKhoa,
                            bn.VienPhi
                        };
            dgDSBN.ItemsSource = query.ToList();

        }

        private void Clear()
        {
            txtMaBN.Clear();
            txtHoTen.Clear();
            txtSoNgayNamVien.Clear();
            cbKhoaKham.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int number;
            bool ktra = Int32.TryParse(txtSoNgayNamVien.Text, out number);

            var maBN = (from bn in ql.BenhNhans
                        where bn.MaBn == int.Parse(txtMaBN.Text)
                        select bn.MaBn).SingleOrDefault();
            try
            {
                if (!ktra)
                    throw new Exception("Số ngày nằm viên không đúng kiểu dữ liệu");

                if (maBN != 0)
                    throw new Exception("Mã BN đã tồn tại");

                int soNgayNamVien = int.Parse(txtSoNgayNamVien.Text);
                if (soNgayNamVien < 1)
                    throw new Exception("Số ngày nằm viện phải >= 1");

                BenhNhan bn = new BenhNhan();
                bn.MaBn = int.Parse(txtMaBN.Text);
                bn.HoTen = txtHoTen.Text;
                bn.SoNgayNamVien = soNgayNamVien;
                bn.VienPhi = bn.SoNgayNamVien * 200000;
                bn.MaKhoa = int.Parse(cbKhoaKham.Text);

                ql.BenhNhans.Add(bn);
                ql.SaveChanges();
                Clear();
                HienThi();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgDSBN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSBN.SelectedItem;

            if (item != null)
            {
                string tenKhoa = (dgDSBN.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;

                var maKhoa = (from k in ql.Khoas
                              where k.TenKhoa == tenKhoa
                              select k.MaKhoa).Single();

                cbKhoaKham.SelectedItem = maKhoa;
            }    
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }
    }
}
