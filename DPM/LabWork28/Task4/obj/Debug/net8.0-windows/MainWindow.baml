   M S B A M L   `   `   `  ����@  <Task4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task4Task4  5   	       Task4.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)      BaseFont#��[  5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��
Логин��6   �� 5   
   $��1��6   �� 5   
   $��Пароль��6   $��1��6!   �� 5   
   $��1��6   $��1��6   �� 5   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5      �� $
��ОК��6   �� 5      $��Отмена��6     CancelButton#��[ 6&   5      �� 5   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Center=�6K   .+�5      �� -   5         ��Name$ LightThemeRadioButton��5      $��Светлая��64   6F   5       �� 5!   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Bottom=�6K   .+�5"      �� -   5        $ DarkThemeRadioButton��5"      $��Тёмная��63   6D   5#      �� 5%   
   $��Images/child.jpg��6   $��2��6*   $
��Left=�67   $��Center=�6R   $
��Fill=�6m   5&      5'      