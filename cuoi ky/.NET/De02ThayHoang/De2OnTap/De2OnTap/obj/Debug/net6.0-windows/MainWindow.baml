   M S B A M L   `   `   `  ����C  ?De2OnTap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:De2OnTapDe2OnTap  5   	       De2OnTap.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:De2OnTap     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 	Resources��%�  '��       '  z     '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ Time New Roman)�6+   �� 5       � ��
 ��  �6+   5      �� 5   
   "  6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$	 100��65   5      5      .�5      ��  � ��$
 Bold"�6+   �� 5       � ��
 �����6+   5      5      .��5      � .+�5   
   �� $��Mã sãn phẩm: ��6   $
��Left=�6(   $��	72,30,0,0q�6C   $	��Top=�6V   �� 5   
   $��Tên sản phẩm:��6   $
��Left=�6(   $��	72,70,0,0q�6C   $	��Top=�6V   �� 5   
   $��Đơn giá:��6   $
��Left=�6#   $��
72,110,0,0q�6>   $	��Top=�6R   �� 5    
   $��Số lượng bán:��6   $
��Left=�6(   $��
72,150,0,0q�6C   $	��Top=�6W   �� 5!   
   $��Nhóm hàng: ��6   $
��Left=�6&   $��
72,190,0,0q�6A   $	��Top=�6U   �� 5"   
   -   5        $��txtMaSP��5"      $
��Left=�6!   $��
200,30,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��200��6|   $��30��6�   ��5#      �� *SelectedItem.MaSp+ �� ElementName$ dgDSSP�� �� Mode$ OneWay=��� 5$   
   -   5        $��txtTenSP��5$      $
��Left=�6"   $��
200,70,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6f   $	��200��6~   $��30��6�   ��5%      �� *SelectedItem.TenSanPham+$ dgDSSP��$ OneWay=��� 5&   
   -   5        $��	txtDonGia��5&      $
��Left=�6#   $��200,110,0,0q�6>   $
 Wrap=�6S   $	��Top=�6h   $	��200��6�   $��30��6�   ��5'      �� *SelectedItem.DonGia+$ dgDSSP��$ OneWay=��� 5(   
   -   5        $��txtSLBan��5(      $
��Left=�6"   $��200,150,0,0q�6=   $
 Wrap=�6R   $	��Top=�6g   $	��200��6   $��30��6�   ��5)      �� *SelectedItem.SoLuongBan+$ dgDSSP��$ OneWay=��� 5*   
   -   5        $��
cbNhomHang��5*      $
��Left=�6%   $��200,190,0,0q�6@   $	��Top=�6U   $	��200��6m   $��30��6y   &   System.Windows.Controls.DataGrid  5,   
   -   5        $��dgDSSP��5,      	   AutoGenerateColumns$	 False��6!   $��72,225,137,0q�6=   $	��131��6S   $	��Top=�6`   
   Columns
 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *MaSp+6M     5/      $ Tên sản phẩm��6%   $	 100 6Z    6;   �� *
TenSanPham+6Z     50      $ 
Đơn giá��6%   $	 100 6Q    66   �� *DonGia+6Q     51      $ Số lượng bán��6%   $	 100 6Z    6;   �� *
SoLuongBan+6Z     52      $ Nhóm hàng��6%   $	 100 6X    68   �� *TenNhomHang+6X     53      $ Tiền bán��6%   $	 100 6l      
FontWeight$
 Bold"�6x    67   �� *	TienBan+ �� StringFormat$ {0:n0}��6x   55      �� 56   
   -   5        $��btnThem��56      $��Thêm��6    $
��Left=�6/   $��248,380,0,0q�6J   $	��Top=�6_   $	��100��6w   $��30��6�   6�   �� 57   
   -   5        $��btnTim��57      $
��Tìm��6   $
��Left=�6-   $��448,380,0,0q�6H   $	��Top=�6]   $	��100��6u   $��30��6�   6�   58      59      