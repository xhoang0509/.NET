   M S B A M L   `   `   `  ����B  >De16725, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:De16725De16725  5   	       De16725.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:De16725     5   	     � Title$  Nguyễn Thị Huyền��5   	   $	��557��6"   $	��800��6/    � 	Resources 5	         Template_btn �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  &	        '  �     �� 5
   
   " ��6/   .R�5      � .+�5      A� 
���2͚�6/   �� 5      $��Center=�6#   $��Center=�6@   5      5      �� 5   
   "  6   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Bold"�6+   5      5      .��5      � .+�5   
   �� $��QUẢN LÝ BỆNH NHÂN��6   $��Center=�6,   $��0,5,0,0q�6I   $	��Top=�6Z   $��Times New Roman)�6r   $��20(�6�   $
��Bold"�6�   �� 5   
   $��Mã bệnh nhân: ��6   $
��Left=�6)   $��	40,40,0,0q�6D   $	��Top=�6W   $��Times New Roman)�6o   $��14(�6�   �� 5   
   $��Họ tên: ��6   $
��Left=�6#   $��	40,80,0,0q�6>   $	��Top=�6Q   $��Times New Roman)�6i   $��14(�6�   �� 5   
   $��Địa chỉ: ��6   $
��Left=�6$   $��
40,120,0,0q�6?   $	��Top=�6S   $��Times New Roman)�6k   $��14(�6�   �� 5   
   $��Số ngày nằm viện: ��6   $
��Left=�6-   $��
40,160,0,0q�6H   $	��Top=�6\   $��Times New Roman)�6t   $��14(�6�   �� 5   
   $��Khoa khám: ��6   $
��Left=�6&   $��
40,200,0,0q�6A   $	��Top=�6U   $��Times New Roman)�6m   $��14(�6�   �� 5   
   -   5        $��txtMaBN��5      $
��Left=�6!   $��
203,40,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��212��6|   $��30��6�   $��Times New Roman)�6�   $��14(�6�   
����  ���5      �� *SelectedItem.Mabn+ �� ElementName$ dgDSBN�� �� Mode$ OneWay=��� 5    
   -   5        $��txtHoTen��5       $
��Left=�6"   $��
203,80,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��212��6}   $��30��6�   $��Times New Roman)�6�   $��14(�6�   
����  ���5!      �� *SelectedItem.Hoten+$ dgDSBN��$ OneWay=��� 5"   
   -   5        $��	txtDiaChi��5"      $
��Left=�6#   $��203,120,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��212��6   $��30��6�   $��Times New Roman)�6�   $��14(�6�   
����  ���5#      �� *SelectedItem.Diachi+$ dgDSBN��$ OneWay=��� 5$   
   -   5        $��txtSoNgayNV��5$      $
��Left=�6%   $��203,160,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��212��6�   $��30��6�   $��Times New Roman)�6�   $��14(�6�   
����  ���5%      �� *SelectedItem.SongayNv+$ dgDSBN��$ OneWay=��� 5&   
   -   5        $��
cbKhoaKham��5&      $
��Left=�6%   $��203,200,0,0q�6@   $	��Top=�6U   $	��212��6m   $��30��6y   &   System.Windows.Controls.DataGrid  5'   
   -   5        $��dgDSBN��5'      $��Times New Roman)�6!   $��14(�6>   $��36,253,71,137q�6L   	   
IsReadOnly$
	 True��5(      
   CanUserReorderColumns$
 False��6%      CanUserResizeColumns$ False��6C      CanUserDeleteRows$ False��6`      AutoGenerateColumns$ False��6z      CanUserResizeRows$ False��6�      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã bệnh nhân��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Mabn+6T     5+      $ 	Họ tên��6%   $	 150 6O    65   �� *Hoten+6O     5,      $ Mã khoa��6%   $	 100 6Q    66   �� *Makhoa+6Q     5-      $ Địa chỉ��6%   $	 100 6Q    66   �� *Diachi+6Q     5.      $ Số ngày nằm viện��6%   $	 120 6\    6?   �� *
SongayNv+6\     5/      $ Viện phí��6%   $	 100 6S    67   �� *	VienPhi+   ElementStyle 50      �� 51      " ��6    .�52      ��  � ��$ Right=�6D   �� 53       � ��
 �  ��6;   �� 54       � ��$
 Bold"�6;   �� 55       � ��$ Italic$�6:   56      58      5:      �� 5;   
   -   5         ��Name$ btThem��5;   I   #��[  6   $��Thêm��6:   $	��100��6Y   $��30��6e   $��80,400,595,87q�6q   6�   �� 5<   
   -   5        $ btSua��5<   H   #��[  6   $��Sửa��6:   $	��100��6W   $��30��6c   $��200,400,441,84q�6o   6�   �� 5=   
   -	   5        $ btXoa��5=   H   #��[  6   $
��Xóa��6:   $	��100��6W   $��30��6c   $��320,400,297,84q�6o   6�   �� 5>   
   -
   5        $ 	btThongKe��5>   M   #��[  6   $��Thống kê��6:   $	��100��6`   $��30��6l   $��440,400,145,82q�6x   6�   5@      5A      