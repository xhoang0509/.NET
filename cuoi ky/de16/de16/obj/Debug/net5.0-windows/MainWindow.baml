   M S B A M L   `   `   `  ����?  ;de16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:de16de16  5   	       de16.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:de16     5   	     � Title$  
MainWindow��5   	   $	��630��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 	Resources&   System.Windows.Controls.DataGrid��%�  '��       '  3    �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 50��6'   �� 5       � ��$	 100��6&   �� 5       � ��
 �����6+    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 50��65   5      5      5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$
 Bold"�6+   5      5      .��5      � $��0,0,0,-6q�6   .+�5   
   �� $��Mã sản phẩm: ��6   $
��Left=�6(   $��	50,30,0,0q�6C   $	��Top=�6V   �� 5   
   $��Tên sản phẩm��6   $
��Left=�6'   $��	50,70,0,0q�6B   $	��Top=�6U   �� 5   
   $��Đơn giá: ��6   $
��Left=�6$   $��
50,110,0,0q�6?   $	��Top=�6S   �� 5   
   $��Số lượng bán: ��6   $
��Left=�6)   $��
50,150,0,0q�6D   $	��Top=�6X   �� 5    
   $��Nhóm hàng: ��6   $
��Left=�6&   $��
50,190,0,0q�6A   $	��Top=�6U   �� 5!   
   -   5         ��Name$ txtMaSP��5!      $
��Left=�6#   $��
186,30,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��300��6~   $��Times New Roman)�6�   ���	#FF2EFF00$��20��6�   �� 5"   
   -   5        $ txtTenSP��5"      $
��Left=�6$   $��
186,70,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��300��6   $��Times New Roman)�6�   ���	#FF2EFF00$��20��6�   �� 5#   
   -   5        $ 	txtDonGia��5#      $
��Left=�6%   $��186,110,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��300��6�   $��Times New Roman)�6�   ���	#FF2EFF00$��20��6�   �� 5$   
   -   5        $ 
txtSoLuong��5$      $
��Left=�6&   $��186,150,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��300��6�   $��Times New Roman)�6�   ���	#FF2EFF00$��20��6�   �� 5%   
   -   5         ��Name$ 
cbNhomHang��5%      $
��Left=�6'   $��186,190,0,0q�6B   $	��Top=�6W   $	��300��6o   $��Times New Roman)�6{   ���	#FF2EFF006�     5&   
   -   5        	  Name$	 dgData��5&      $
��Left=�6#   $	��237��6>   $��
50,243,0,0q�6K   $	��Top=�6_   $	��721��6w   �� 5'   
   -   5        
 ��Name$
 btnAdd��5'      $��Thêm��6!   $
��Left=�60   $��
54,527,0,0q�6K   $	��Top=�6_   �� 5(   
   -   5        $
 btnEdit��5(      $��Sửa��6"   $
��Left=�60   $��192,527,0,0q�6K   $	��Top=�6`   �� 5)   
   -	   5        $
 	btnDelete��5)      $
��Xóa��6$   $
��Left=�62   $��349,527,0,0q�6M   $	��Top=�6b   5*      5+      