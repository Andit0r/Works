   M S B A M L   `   `   `  ����F  BLection0422, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lection0422Lection0422  5   	       Lection0422.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Lection0422     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value :� RoutedEvent	 �� TargetProperty
 g� Duration W� From	 W� To g� AutoReverse��%�  '��       �� 5
   
   " ��6    5      P� 5       �@J�IsMouseOver$
 True��65   . �5      ��  � ��
 �  ��67   5      P� 5       �@J�IsMouseOver$ False��65   . �5      ��  � ��
 � ���67   5      :� 5      $ 	MouseDown��6#   [�5      �� 5      .��5   "   �� .��5   &   W� $	 Height�66   $
 0:0:1D�5   6    505   6    1005   6   $
 True��5   6   5      5      5      5!      5"      .��5#      �� .+�5$   
   �� -   5         ��Name$ AgreeCheckBox��5$      �� 5%   
   $��Ok��6   ��5&      �� 5'      " ��6    5(      �� 5)       �� Binding 6&   ��  �� ElementName$ AgreeCheckBox�� �� Path$ 	IsChecked� �� Value	 False6d   .a�5*      ��  � {�$ False��6:   5+      5-      5/      �� 50   
    �� Orientation$ 
Horizontal=�6    � Cursor$
 Hand��6.   .+�51      A� -   5         A�Name$ ellipse��51      $	��100��6'   $	��100��64   �� 52      -   5         ��Name$
 rect��52      $	��100��6&   $	��100��63   �� 53      -   5         ��Name$ image��53      $	��100��6#   $	��100��60   54      �� 55   
   $��12345 abcde абвгд��6   �� 56   
   $��12345 abcde абвгд��6   �� 57   
   $��12345 abcde абвгд��6   �� 58   
   $��12345 abcde абвгд��6   �� 59   
   $��12345 abcde абвгд��6   �� 5:   
   $��12345 abcde абвгд��6   �� 5<   
   -   5         ��Name$ LightButton��5<      $��light��6&   66   �� 5=   
   -   5        $ 
DarkButton��5=      $
��dark��6%   64   �� 5>   
   $��12345 abcde абвгд��6   �� 5?   
   $��12345 abcde абвгд��6   5@      5A      