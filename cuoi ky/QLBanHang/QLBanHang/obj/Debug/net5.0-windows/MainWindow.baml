   M S B A M L   `   `   `  ����D  @QLBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLBanHang	QLBanHang  5   	       QLBanHang.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QLBanHang     5   	   -   5          � Title$  Quản lý bán hàng��5   	   $	��675��6"   $	��800��6/   .��5      ��  � 	Resources 5   
      	baseStyle �� 
TargetType �� Property �� Value �� BasedOn �� Triggers P� Property P� Value	 �� 
TargetType��%�  &	        '�� �     7   '�� 8    �� 5      " ��6&   .�5      ��  � ��$ Times New Roman)�6/   �� 5       � ��$ 20(�6-   �� 5       � ��$ Italic$�6.   5      �� 5      8   " ��69    5      P� 5       �@J�IsMouseOver$
 True��65   . �5      ��  � ��
 �  ��67   5      5      �� 5      " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��6:   �� 5       � �� 5      �� 5      "	 ��6*   .R�5      � .+�5    "   A� 
����� �6*   �� 5!   "   $��Center=�63   $��Center=�6P   5"      5#      5%      �� 5&       � ��$ 80��6*   �� 5'       � ��$ 30��6+   �� 5(       �@�Cursor$
 Hand��6+   5)      5*      .+�5+   
   � .+�5,      �� $��Mã sản phẩm��6   $
��Left=�6*   $��	29,14,0,0q�6E   $	��Top=�6X   �� 5-      -   5        
 ��Name$
 txtMaSP��5-      $
��Left=�6'   $��
127,18,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��251��6�   $��20(�6�   $��Times New Roman)�6�   $��Italic$�6�   $��Normal"�6�   �� 5.      $��Tên sản phẩm��6   $
��Left=�6+   $��	29,55,0,0q�6F   $	��Top=�6Y   �� 5/      -   5        $
 txtTenSP��5/      $
��Left=�6(   $��
127,59,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��251��6�   $��20(�6�   $��Times New Roman)�6�   $��Italic$�6�   $��Normal"�6�   �� 50      $��Loại sản phẩm��6   $
��Left=�6,   $��	29,98,0,0q�6G   $	��Top=�6Z   �� 51      $��
Đơn giá��6   $
��Left=�6&   $��
29,139,0,0q�6A   $	��Top=�6U   �� 52      -   5        $
 	txtDonGia��52      $
��Left=�6)   $��127,143,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��251��6�   $��20(�6�   $��Times New Roman)�6�   $��Italic$�6�   $��Normal"�6�   �� 53      $��Số lượng��6   $
��Left=�6'   $��
29,179,0,0q�6B   $	��Top=�6V   �� 54      -   5        $
 
txtSoLuong��54      $
��Left=�6*   $��127,183,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��251��6�   $��20(�6�   $��Times New Roman)�6�   $��Italic$�6�   $��Normal"�6�   �� 55      -   5         ��Name$ cbLoaiSP��55      $
��Left=�6)   $��127,102,0,0q�6D   $	��Top=�6Y   $	��251��6q   $��20(�6}   $��Times New Roman)�6�   $��Italic$�6�   $��Normal"�6�   &   System.Windows.Controls.DataGrid  56      -   5          Name$ dgData��56      $��29,238,31,74q�6'      AutoGenerateColumns$ False��6=      CanUserAddRows$ False��6Y      AlternatingRowBackground
 �����   Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *MaSp+6Q     59      $ Tên SP��6)   $ * 6S    69   �� *TenSp+6S     5:      $ Mã loại SP��6)   $ * 6X    6=   �� *MaLoai+6X     5;      $ Số lượng��6)   $ * 6W    6;   �� *	SoLuong+6W     5<      $ 
Đơn giá��6)   $ * 6U    6:   �� *DonGia+6U     5=      $ Thành tiền��6)   $ * 6[    6=   �� *	ThanhTien+6[   5?      �� 5@      -   5         ��Name$ btnAdd��5@      $��Thêm��6%   $
��Left=�64   $��275,585,0,0q�6O   $	��Top=�6d   6|   �� 5A      -	   5        $ btnEdit��5A      $��Sửa��6&   $
��Left=�64   $��377,585,0,0q�6O   $	��Top=�6d   6|   �� 5B      -
   5        $ 	btnDelete��5B      $
��Xóa��6(   $
��Left=�66   $��489,585,0,0q�6Q   $	��Top=�6f   6~   �� 5C      -   5        $ 	btnSearch��5C      $
��Tìm��6(   $
��Left=�66   $��587,585,0,0q�6Q   $	��Top=�6f   6~   �� 5D      -   5        $ 
btnThongKe��5D      $��Thống kê��6)   $
��Left=�6<   $��689,585,0,0q�6W   $	��Top=�6l   6�   5E      5F      5G      