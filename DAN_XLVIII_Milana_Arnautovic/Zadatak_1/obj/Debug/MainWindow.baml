   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zadatak_1	Zadatak_1  5   	       Zadatak_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zadatak_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      ��%    5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridResults��5       $��1��6      
IsReadOnly .    HeadersVisibility$ Column=�5         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �
���   �
���   �$
��Bold"�5       ��5      �� *	OrderList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedOrder+$ PropertyChanged=�	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Product��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5$   %   �� *tblProducts.ProductName+  5%      $
 Price��6%    5&   %   �� *tblProduct.Price+  5(      $
 Username��6%    5)   %   �� *tblOrder.Username+  5+      $

 Date��6%    5,   %   �� *tblOrder.OrderDate+  5-      $
 Status��6%    5.   %   �� *tblOrder.OrderStatus+4  .System.Windows.Controls.DataGridTemplateColumn  51         CellTemplate 52      �� 53      .R�54      �� $��btnConfirmOrder��6%   $��Confirm��6<   $��4q�56   )   $
��Bold"�64   ��55   !   �� *DataContext.ConfirmOrder+$ PropertyChanged=� �� RelativeSource �� *FindAncestor+ �� AncestorType" �56   4   57      59        5:       5;      �� 5<      .R�5=      �� $��btnRejectOrder��6%   $��Reject��6;   $��4q�5?   )   $
��Bold"�64   ��5>   !   �� *DataContext.RejectOrder+$ PropertyChanged=� �� *FindAncestor+" �5?   4   5@      5B        5C       5D      �� 5E      .R�5F      �� $��btnDeleteOrder��6%   $��Delete��6;   $��4q�5H   )   $
��Bold"�64   ��5G   !   �� *DataContext.DeleteOrder+$ PropertyChanged=� �� *FindAncestor+" �5H   4   5I      5K      5M      5N      5P      