   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	       Zadatak_1.View.GuestView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  	GuestView��5      $	��450��6   $	��800��6'   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��6 �6   �� 5      $��30 �6   �� 5      $��6 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridMenu��5      $��2��5      $��1��6       
IsReadOnly .    HeadersVisibility$ Column=�5          AutoGenerateColumns .     HorizontalGridLinesBrush
 �   ���5      �� *ProductList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedProduct+$ PropertyChanged=�y�5"      �� *ViewProduct+$ PropertyChanged=�	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Product��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5'   %   �� *ProductName+  5(      $
 Price��6%    5)   %   �� *Price+4  .System.Windows.Controls.DataGridTemplateColumn  5*      $
 Quantity��6)      CellTemplate 5+      �� 5,      .R�5-      �� $��50��5/   L   ��5-   &   ��  �� Path$ Order.Quantity� �� RelativeSource �� *FindAncestor+ �� AncestorType"  $ PropertyChanged=�5/   L   50      52        53       54      �� 55      .R�56      �� $��80��6%   $��30��57   %   $��Add to order��5:   %   ��58   %   �� $ DataContext.AddToOrder� �� *FindAncestor+"  $ PropertyChanged=�5:   %   5;      5=      5?      �� 5@   
   -   5        $��lblTotalPrice��5B      $��4��5@      $��1��5A      $��Total Price:��5C      $��Center=�5D      $
��Left=�5E      $
��Bold"�5F      $��90��5G      $��323,3.2,0,1.2q�6   �� 5H   
   -   5        $��lblTotal��5I      $��4��5H      $��10,11.2,99.6,3.2q�5K      $��Center=�5L      $��Black"�5M      $��2��6#   ��5J      �� *
TotalPrice+5M   #   �� 5N   
   $��6��6   $��1��6"    �� Orientation$ 
Horizontal=�5O      $��Center=�5P      .+�5Q      �� $��Confirm Order��5R      $	��125��6-   $��
0,6,10,6.4q�69   ��5Q      �� *OrderCommand+5R   9   �� 5S      $��Close��5T      $��
0,6,10,6.4q�6%   $	��125��69   ��5S      �� *Close+5T   9   5U      5V      5W      