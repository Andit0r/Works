   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.ClosingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$   Подтверждение��5   	   $	��220��6   $	��450��6,    � 
ResizeMode$ NoResize=�68   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� $��/question.png��6   �� 5   
   .+�5      �� $<��6Вы хотите закрыть приложение?��6      TextBlockQuestionWindow#��[  6=   �� 5      $��Right=�6   $ 
Horizontal=�65   .+�5      �� -   5         ��Name$ 	YesButton��5      $
��Да��6,    �� 	IsDefault$
 True��69     	YesButton#��[ 6b   �� 5      -   5        $ NoButton��5      $��Нет��6+    �� IsCancel$
 True��69     NoButton#��[ 6I   5      5      5      5      