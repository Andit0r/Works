   M S B A M L   `   `   `  ����F  BLection0531, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lection0531Lection0531  5   	   L HWpfControlLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:WpfControlLibrary;assembly=WpfControlLibraryWpfControlLibrary 5   	       Lection0531.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Lection0531     5   	   RcontrolsLib:clr-namespace:WpfControlLibrary;assembly=WpfControlLibrary     5   	     � Title$  
MainWindow��5   	   $	��150��6   $	��600��6)    � 	Resources 5       �� 
TargetType   CustomButton ��Name � Cursor ��Name �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value��%�  &	        �� 5   
   " ��6   .R�5      �� $ border��6   $��50��6%   #��z��5      $
 Hand��5      
�������._�5      �� $ content��6#   $��Center=�5      $��Center=�5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      �� $	 border��6   
 � ��
 � ���6G   �� 5      $	 content��6   
 � ��$
 Left=�6Q   5      5      5      .��5       �� $  ��6   .+�5!   
     WpfControlLibrary.Entry     Hint$	 123��6      Lection0531.Entry  5#   
   -   5          Name$ 
LoginEntry��5#   Q      Lection0531.Entry   Edited$ Entry_Edited��6      Deleted$ Entry_Deleted��6,      Hint$ 
Логин��6D      	MaxLength$ 5��5$         Lection0531.CustomButton  5&   
   �� 5(   
   ��6   ��  �� ElementName$ 
LoginEntry�� �� Path$
 Hint��� 5)   
   $��12345��6   �� 5*   
   $��ok��6   #��[  6   
�������$  ��6]   �� 5+   
   $��cancel��6   #��[  6"   
���  ��6K   �� 5,   
   $��cancel��6   $  ��6"   5-      5.      