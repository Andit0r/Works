   M S B A M L   `   `   `  ����D  @LabWork29, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LabWork29	LabWork29  5   	       LabWork29.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LabWork29     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� $L��FНаведи, чтобы увеличить и сменить цвет��6   �� 5   
   $��
Логин��6   �� 5   
   -   5         ��Name$ LoginTextBox��5      �� 5   
   $A��;Поле обязательно для заполнения��6   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6&   ��  �� ElementName$ LoginTextBox�� �� Path$ Text.IsEmpty� �� Value	 False6f   .a�5      ��  �� Property � y�	 �� Value$	 Hidden=�6;   5      .�5      ��  � ��
	 �  ��63   5      5      �� 5   
   $��1��6   $��50��6   $��25��6(   $��5q�64   �� 5   
   $��2��6   $��50��6   $��25��6(   $��5q�64   �� 5   
   $��3��6   $��50��6   $��25��6(   $��5q�64   �� 5   
   $*��$Зарегестрироваться��6   ��5      �� 5      " ��6    5      ^� 5       
 ^� 
Conditions
 5!      �� 5"   "    �� Binding 6,   �� $ AgreeCheckBox��$ 	IsChecked� �� Value True6j   �� 5#   "    6,   �� $ ReadCheckBox��$ 	IsChecked� True6i   .0�5%      ��  � {�$
	 True��6:   5&      .�5(      ��  � {�$	 False��62   5)      5+      �� 5,   
    �� Orientation$ 
Horizontal=�6   .+�5-      �� -   5         ��Name$ AgreeCheckBox��5-      $��0 6 0 0q�6/   �� 5.      $G��AСогласен с условиями использования��6   5/      �� 51   
   $ 
Horizontal=�6   .+�52      �� -   5        $ ReadCheckBox��52      $��0 6 0 0q�6-   �� 53      $'��!Прочёл соглашение��6   54      55      56      