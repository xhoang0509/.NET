   M S B A M L   `   `   `  ����D  @QLSanPham, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLSanPham	QLSanPham  5   	       QLSanPham.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QLSanPham     5   	   -   5          � Title$  Quản lý sản phẩm��5   	   $	��820��6"   $	��980��6/   $��Times New Roman)�5	   	   $��20(�5
   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  cellBold �� 
TargetType*  $System.Windows.Controls.DataGridCell  FocusVisual1  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border 	 Button.Disabled.Background 
 Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1 �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �    &	 �    &	 �    &	     &	 <    &	 _    &		 �    &	
 �    &	 �    &	 �    7  7  7  7  7  7  7  7 	 7 
 7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   "  6!   .�5      ��  � ��$
 Bold"�6+   5      �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5!      5"      �� 5#   
   $ 	#FFDDDDDD��6;   �� 5$   
   $ 	#FF707070��67   �� 5%   
   $ 	#FFBEE6FD��6>   �� 5&   
   $ 	#FF3C7FB1��6:   �� 5'   
   $ 	#FFC4E5F6��6<   �� 5(   
   $ 	#FF2C628B��68   �� 5)   
   $ 	#FFF4F4F4��6=   �� 5*   
   $ 	#FFADB2B5��69   �� 5+   
   $ 	#FF838383��6=   �� 5,   
   " ��6%   .�5-      ��  �@�FocusVisualStyle8   61   �� 5.       � ��8  6+   �� 5/       � ��8  6,   �� 50       � ��# � ��6+   �� 51       � ��$ 1q�60   �� 52       � ��$ Center=�6;   �� 53       � ��$ Center=�69   �� 54       � ��$ 1q�6(   �� 55       � �� 56      �� 57      " ��6&   .R�58      �� $	 border��6!   $
 50��61   
�������#��z��6U   #��z��6�   $
 true��6�   ._�59      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5:       5;      P� 5<       �@��IsDefaulted$
 true��6=   . �5=   "   �� $ border��6@   # � ��6T    � ��5>      P� 5?       �@J�IsMouseOver$
 true��6=   . �5@   "   �� $ border��6?   8   � ��6S   �� 5A   "   $ border��6@   8   � ��6T   5B      P� 5C       � ��$
 true��6;   . �5D   "   �� $ border��6?   8   � ��6S   �� 5E   "   $ border��6@   8   � ��6T   5F      P� 5G       � {�$ false��6;   . �5H   "   �� $ border��6?   8   � ��6S   �� 5I   "   $ border��6@   8   � ��6T   �� 5J   "   $ contentPresenter��6K   8 	  � ��6i   5K      5M      5O      5P      5Q      .��5R      �� $��0,0,0,-6q�6    5S   
   ��%    5U      .+�5V   
   � $	��809��6   $	��955��6   .+�5W      �� $��Mã sản phẩm��6   $
��Left=�6*   $��	50,50,0,0q�6E   $	��Top=�6X   �� 5X      $��Tên sản phẩm��6   $
��Left=�6+   $��
50,100,0,0q�6F   $	��Top=�6Z   �� 5Y      $��
Đơn giá��6   $
��Left=�6&   $��
50,150,0,0q�6A   $	��Top=�6U   �� 5Z      $��Số lượng bán��6   $
��Left=�6+   $��
50,200,0,0q�6F   $	��Top=�6Z   �� 5[      $��Nhóm hàng��6   $
��Left=�6(   $��
50,250,0,0q�6C   $	��Top=�6W   �� 5\      -   5         ��Name$ txtMasp��5\      $
��Left=�6'   $��
270,50,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��350��6�   $��25��6�   
����  �6�   �� 5]      -   5        $ txtTensp��5]      $
��Left=�6(   $��270,100,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��350��6�   $��25��6�   
����  �6�   �� 5^      -   5        $ 	txtDongia��5^      $
��Left=�6)   $��270,150,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��350��6�   $��25��6�   
����  �6�   �� 5_      -   5        $ txtSl��5_      $
��Left=�6%   $��270,200,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��350��6�   $��25��6�   
����  �6�   �� 5`      -   5         ��Name$ 
cbNhomHang��5`      $
��Left=�6+   $��25��6F   $��270,250,0,0q�6R   $	��Top=�6g   $	��350��6   &   System.Windows.Controls.DataGrid  5a      -   5          Name$ dgData��5a      $��50,315,48,204q�6'      AutoGenerateColumns$ False��6>      CanUserAddRows$ False��6Z      AlternatingRowBackground
 ��ح�   ColumnHeaderStyle 5b      �� 5c      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5d      ��  � ��$
 Bold"�68   �� 5e       � ��$ Center=�6G   5f         Columns 5h      0  *System.Windows.Controls.DataGridTextColumn  5i      ,  &System.Windows.Controls.DataGridColumn   Header$ MãSP��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *MaSp+6P     5j      $ Tên sản phẩm��6)   $ * 6^    6?   �� *
TenSanPham+6^     5k      $ 
Đơn giá��6)   $ * 6U    6:   �� *DonGia+6U     5l      $ Số lượng bán��6)   $ * 6^    6?   �� *
SoLuongBan+6^     5m      $ Nhóm hàng��6)   $ * 6\    6<   �� *TenNhomHang+6\     5n         	CellStyle# [ 6)   $ Tiền bán��6O   $ * 6}    6a   �� *	TienBan+6}   5p      �� 5q      -   5         ��Name$ btnThem��5q      #���  6&   $��Thêm��6M   $
��Left=�6\   $��146,673,0,0q�6w   $	��Top=�6�   $��40��6�   $��82��6�   ���	#FFDDDDDD6�   �� 5r      -	   5        $ btnTim��5r      #���  6%   $
��Tìm��6L   $
��Left=�6Z   $��435,673,0,0q�6u   $	��Top=�6�   $��40��6�   $��82��6�   ���	#FFDDDDDD6�   5s      5t      5u      