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
using De02.Models;
namespace De02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NhanvienDBContext db = new NhanvienDBContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {
            LoadCB();
            LoadData();
        }
        private void LoadData()
        {
            var query = from nv in db.Nhanviens
                        where nv.Songaycong >= 25
                        orderby nv.Songaycong ascending
                        select new
                        {
                            nv.MaNv,
                            nv.Hoten,
                            nv.Songaycong,
                            Luong = Convert.ToDouble(nv.Luong).ToString("N0"),
                            nv.MaPhong,
                            Thuong = nv.Songaycong >= 27 ? Convert.ToDouble(nv.Luong * 0.1).ToString("N0") : "0"
                        };
            dgData.ItemsSource = query.ToList();
        }

        private void LoadCB()
        {
            var query = from p in db.PhongBans select p;
            cbPhongBan.ItemsSource = query.ToList();
            cbPhongBan.DisplayMemberPath = "TenPhong";
            cbPhongBan.SelectedValuePath = "MaPhong";
            cbPhongBan.SelectedIndex = 0;
        }

        private bool checkDL()
        {
            string tb = "";
            if (txtManv.Text == "" || txtHoten.Text == "" || txtLuong.Text == "" || txtSnc.Text == "")
            {
                tb += "Yêu cầu nhập đủ thông tin";
            }
            if (!Regex.IsMatch(txtLuong.Text, @"\d+"))
            {
                tb += "\nYêu cầu lương phải là số nguyên";
            }
            else
            {
                if (int.Parse(txtLuong.Text) < 3000 || int.Parse(txtLuong.Text) > 9000)
                {
                    tb += "\nYêu cầu lương nhớ hơn 3000, nhò hơn 9000";
                }
            }
            if (!Regex.IsMatch(txtSnc.Text, @"\d+"))
            {
                tb += "\nYêu cầu số ngày công phải là số nguyên";
            }
            else
            {
                if (int.Parse(txtSnc.Text) < 20 || int.Parse(txtSnc.Text) > 30)
                {
                    tb += "\nYêu cầu số ngày công nhớ hơn 20, nhò hơn 30";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thông báo");
                return false;
            }
            return true;
        }

        private void txtAdd_Click(object sender, RoutedEventArgs e)
        {
            var query = db.Nhanviens.SingleOrDefault(t => t.MaNv.Equals(int.Parse(txtManv.Text)));
            if (query != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại !", "Thông báo");
            }
            else
            {
                try
                {
                    if (checkDL())
                    {
                        Nhanvien nvMoi = new Nhanvien();
                        nvMoi.MaNv = int.Parse(txtManv.Text);
                        nvMoi.Hoten = txtHoten.Text;
                        nvMoi.Songaycong = int.Parse(txtSnc.Text);
                        nvMoi.Luong = int.Parse(txtLuong.Text);
                        PhongBan item = (PhongBan)cbPhongBan.SelectedItem;
                        nvMoi.MaPhong = item.MaPhong;
                        db.Nhanviens.Add(nvMoi);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công nhân viên !");
                        LoadData();
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Có lỗi thi thêm nhân viên " + e1.Message, "Thông báo");
                }
            }
        }

        private void txtEdit_Click(object sender, RoutedEventArgs e)
        {
           
            var spSua = db.Nhanviens.SingleOrDefault(t => t.MaNv.Equals(int.Parse(txtManv.Text)));
            if (spSua != null)
            {
                try
                {
                    if(checkDL())
                    {
                        spSua.Hoten = txtHoten.Text;
                        spSua.Songaycong = int.Parse(txtSnc.Text);
                        spSua.Luong = int.Parse(txtLuong.Text);
                        PhongBan item = (PhongBan)cbPhongBan.SelectedItem;
                        spSua.MaPhong = item.MaPhong;
                        db.SaveChanges();
                        MessageBox.Show("Sửa sản phẩm thành công !", "Thông báo");
                        LoadData();
                    }
                }
                catch (Exception e3)
                {
                    MessageBox.Show("Có lỗi khi sửa " + e3.Message, "Thông báo");
                }
            } else
            {
                MessageBox.Show("Không tìm thấy nhân viên cần sửa", "Thông báo");
            }
        }

        private void dgData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            txtManv.IsEnabled = false;
            object item = dgData.SelectedItem;
            if (item != null)
            {
                try
                {
                    Type t = item.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtManv.Text = p[0].GetValue(item).ToString();
                    txtHoten.Text = p[1].GetValue(item).ToString();
                    txtSnc.Text = p[2].GetValue(item).ToString();
                    txtLuong.Text = p[3].GetValue(item).ToString();
                    cbPhongBan.SelectedValue = Convert.ToInt32(p[4].GetValue(item).ToString());
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Có lỗi gfd chọn dòng " + e2.Message, "Thông báo");
                }
            }
        }

        private void txtDelete_Click(object sender, RoutedEventArgs e)
        {
            var nvXoa = db.Nhanviens.SingleOrDefault(t => t.MaNv.Equals(int.Parse(txtManv.Text)));
            if(nvXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không","Thông báo", MessageBoxButton.YesNo);
                if(rs== MessageBoxResult.Yes)
                {
                    db.Nhanviens.Remove(nvXoa);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công nhân viên !", "Thông báo");
                    LoadData();
                }
            } else
            {
                MessageBox.Show("Không tìm thấy nhân viên để xóa !", "Thông báo");
            }

        }

        private void txtSearch_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.ShowDialog();
        }
    }
}

