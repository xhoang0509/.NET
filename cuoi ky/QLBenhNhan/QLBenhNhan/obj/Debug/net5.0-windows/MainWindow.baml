   M S B A M L   `   `   `  ����E  AQLBenhNhan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QLBenhNhan
QLBenhNhan  5   	       QLBenhNhan.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QLBenhNhan     5   	   -   5          � Title$'  !Bài thi kết thúc học phần��5   	   $	��688��6+   $	��800��68   $��Times New Roman)�5
   	   $��20(�5   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid ��Name �Name J� Opacity � Points �� Stretch  DataGridStyle1 �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand!   HeadersVisibilityConverter �� 	Converter7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter  �� RelativeSource! �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter"  Name#   Column$ ��Name% �� CanContentScroll& ��Name' �� ScrollableHeight( � Maximum) �� Orientation* �� ViewportHeight+ �� ViewportSize*, �� #ComputedVerticalScrollBarVisibility- � Value. �� Mode/ �� ScrollableWidth0 �� ViewportWidth,1 �� %ComputedHorizontalScrollBarVisibility2 �� Triggers3 ]� 
Conditions4 �� Property5 �� Value��%*  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 (�� �    5E      $" DataGridSelectAllButtonStyle��"  )&	 �	    �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5    
   " ��6%   .�5!      ��  �@�FocusVisualStyle8   61   �� 5"       � ��8  6+   �� 5#       � ��8  6,   �� 5$       � ��# � ��6+   �� 5%       � ��$ 1q�60   �� 5&       � ��$ Center=�6;   �� 5'       � ��$ Center=�69   �� 5(       � ��$ 1q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      �� $	 border��6!   $
 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5-      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5.       5/      P� 50       �@��IsDefaulted$
 true��6=   . �51   "   �� $ border��6@   # � ��6T    � ��52      P� 53       �@J�IsMouseOver$
 true��6=   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � ��$
 true��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   5:      P� 5;       � {�$ false��6;   . �5<   "   �� $ border��6?   8   � ��6S   �� 5=   "   $ border��6@   8   � ��6T   �� 5>   "   $ contentPresenter��6K   8 	  � ��6i   5?      5A      5C      5D      �� 5E   
   " ��6   .�5F      ��  � �� 5G      �� 5H      " ��6&   .R�5I      � .+�5J      �� $ Border��6(   #��� ��68   $
 True��6y   � 5K      $ Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5L       5M      P� 5N       �@J�IsMouseOver$
 True��6=   . �5O   "   �� $ Border��6;   # � ��6O    � ��5P      P� 5Q       � ��$
 True��6;   . �5R   "   �� $ Border��69   # � ��6M    � ��5S      P� 5T       � {�$ False��6;   . �5U   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5V      5X      5Z      5[      �� 5\   
   "  6'   .�5]      ��  � ��# � ��6+   �� 5^       � ��# � ��6+   �� 5_       � �� �	#FF688CAF6,   �� 5`       � ��$ 1q�60   �� 5a        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5b       � ��$
 true��6>   �� 5c       �@��PanningMode$
 Both=�69   �� 5d       �@��IsFlicksEnabled$ False��67   �� 5e       � �� 5f      �� 5g      "  6&   .R�5h      �� #��z��6!   #��z��6K   #��z��6   # z��6�   $
 True��6�   ._�5i      �� $ DG_ScrollViewer��6+   $|�false��6D   ��5j   "   �� 5k   &   " ��66   .R�5l   *   �  5m   .   �� 5n   2   $
��Auto �6C   �� 5o   2   $��* �6C   �� 5p   2   $
��Auto �6C    5r   .   �� 5s   2   $
��Auto �6@   �� 5t   2   $��* �6@   �� 5u   2   $
��Auto �6@   .+�5w   .   �� #��Z 65   $|�false��6d   ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z   �� "!  ��6�  �� *CellsPanelHorizontalOffset+  �� "!    5x   .   $!" PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z#   �� "!  �� 5y   .   $!$ PART_ScrollContentPresenter��6E   $��2��6j   #% z��6~   $��1��6�   �� 5z   .   $& PART_VerticalScrollBar��68   $��2��6X   #( z' 6h   $) Vertical=�6�   $��1��6�   #+ z* 6�   #y�z, 6H  - 6�   �� *VerticalOffset+$. OneWay=�  �� *TemplatedParent+6H  � 5{   .   $��1��63   $��2��6C    5|   2   �� 5}   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+  �� "!  �� 5~   6   $��* �6G   .+�5�   2   �� $& PART_HorizontalScrollBar��6<   $��1��6^   #( z/ 6n   $) 
Horizontal=�6�   #+ z0 6�   #y�z1 6C  - 6�   �� *HorizontalOffset+$. OneWay=�  �� *TemplatedParent+6C  5�   /   5�   +   5�   '   .��5�   "   �� # z 61   5�      5�      5�      5�      2 5�      ]� 5�      3 5�      �� 5�      4 �@��
IsGrouping$
5 true��6:   �� 5�      "4 �@%�IsVirtualizingWhenGrouping$5 false��6\   ./�5�      ��  � ��$ false��6F   5�      5�      5�      .��5�      ��  5�   
   ��%    5�      .+�5�   
   � $��0,0,0,11q�6   $	��671��6!   .+�5�      �� $��Mã bệnh nhân: ��6   $
��Left=�6-   $��	47,43,0,0q�6H   $	��Top=�6[   �� 5�      -   5        6 ��Name$6 txtMaBN��5�      $
��Left=�6'   $��
206,43,0,0q�6B   7 �� TextWrapping$
7 Wrap=�6V   $	��Top=�6j   $	��300��6�   $��22��6�   
����  �$��Times New Roman)�6�   $��20(�6�   �� 5�      $��
Họ tên:��6   $
��Left=�6&   $��	47,88,0,0q�6A   $	��Top=�6T   �� 5�      -   5        $6 txtHoTen��5�      $
��Left=�6(   $��
206,88,0,0q�6C   $
7 Wrap=�6W   $	��Top=�6k   $	��300��6�   $��22��6�   �� 5�      $��Địa chỉ��6   $
��Left=�6&   $��
47,139,0,0q�6A   $	��Top=�6U   �� 5�      -   5        $6 	txtDiaChi��5�      $
��Left=�6)   $��206,139,0,0q�6D   $
7 Wrap=�6Y   $	��Top=�6m   $	��300��6�   $��22��6�   �� 5�      $��Số ngày nằm viện��6   $
��Left=�6/   $��
47,187,0,0q�6J   $	��Top=�6^   �� 5�      -   5        $6 txtSoNgayNV��5�      $
��Left=�6+   $��206,187,0,0q�6F   $
7 Wrap=�6[   $	��Top=�6o   $	��300��6�   $��22��6�   �� 5�      $��
Khoa khám��6   $
��Left=�6(   $��
47,231,0,0q�6C   $	��Top=�6W   �� 5�      -   5        8 ��Name$8 
cbKhoaKham��5�      $
��Left=�6+   $��206,235,0,0q�6F   $	��Top=�6[   $	��300��6s     5�      -   5        9  Name$9 dgData��5�   @   #���  6   $��47,313,34,181q�6P   :   AutoGenerateColumns$: False��6g   ;   AlternatingRowBackground
; ��ح�<   CanUserAddRows$< False��6�   =   Columns= 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn>   Header$> Mã bệnh nhân��6)   ?   Width5  /System.Windows.Controls.DataGridLengthConverter$? * 6X   1  +System.Windows.Controls.DataGridBoundColumn@   Binding@ 6?   �� *Mabn+6X     5�      $> 	Họ tên��6)   $? * 6S   @ 69   �� *Hoten+6S     5�      $> Mã khoa��6)   $? * 6U   @ 6:   �� *Makhoa+6U     5�      $> Địa chỉ��6)   $? * 6U   @ 6:   �� *Diachi+6U     5�      $> Số ngày nằm viện��6)   $? * 6`   @ 6C   �� *
SongayNv+6`     5�      $> Viện phí��6)   $? * 6W   @ 6;   �� *	VienPhi+6W   5�      �� 5�      -   5        A ��Name$A btnAdd��5�   <   #��� 
 6   $��Thêm��6L   $
��Left=�6[   $��250,600,0,0q�6v   $	��Top=�6�   $��26��6�   $��51��6�   ���	#FF8BFF006�   �� 5�      -	   5        $A btnEdit��5�   <   #��� 
 6   $��Sửa��6M   $
��Left=�6[   $��330,600,0,0q�6v   $	��Top=�6�   $��26��6�   $��52��6�   ���	#FF8BFF006�   �� 5�      -
   5        $A 	btnDelete��5�   <   #��� 
 6   $
��Xóa��6O   $
��Left=�6]   $��400,600,0,0q�6x   $	��Top=�6�   $��26��6�   $��51��6�   ���	#FF8BFF006�   �� 5�      -   5        $A 
btnThongKe��5�   <   #��� 
 6   $��Thống kê��6P   $
��Left=�6c   $��482,600,0,0q�6~   $	��Top=�6�   $��26��6�   $��52��6�   ���	#FF8BFF006�   5�      5�      5�      