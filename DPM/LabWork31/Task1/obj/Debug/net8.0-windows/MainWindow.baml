   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �� .+�5   
   ��  �� Target LoginTextBox6   $��_Логин��6&   �� 5   
   -   5         ��Name$ LoginTextBox��5       �� 	MaxLength$ 30��6(   �� 5   
    EmailTextBox6   $(��"_Электронная почта��6&   �� 5   
   -   5        $ EmailTextBox��5      $	 100��6(   �� 5   
    PasswordBox6   $��_Пароль��6%   G� 5   
   -   5         G�Name$ PasswordBox��5      6+   �� 5   
   -   5         ��Name$ PasswordLenghtTextBlock��5      $!��Длина пароля: 0.��65   �� 5   
    ConfirmationPasswordBox6   $.��(_Подтверждение пароля��61   G� 5   
   -   5        $ ConfirmationPasswordBox��5      �� 5   
    AboutTextBox6   $��_О себе��6&   �� 5   
   -   5        $ AboutTextBox��5      $	 200��6(    �� TextWrapping$
 Wrap=�68    �� AcceptsReturn$
 True��6L   6a   �� 5   
   -   5        $ RemainingSymbolsTextBlock��5      $F��@Оставшееся количество символов: 200.��67   �� 5   
   $��Дата рождения��6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ BirthDatePicker��5      	   DisplayDateStart	 
01.01.19006&   5      �� 5    
   -	   5        $ AgeTextBlock��5       $��Ваш возраст: 0.��6*   �� 5"   
   $��Стаж��6   �� 5#   
   -
   5        
 ��Name$
 WorkExperienceSlider��5#       � Maximum$ 50Q�5$       �� TickFrequency$ 5Q�5%       �� TickPlacement$ BottomRight=�5&      5'      �� 5(   
   -   5        $" ValueWorkExperienceTextBlock��5(      $(��"Стаж: 0 год/года/лет��6:   5)      5*      