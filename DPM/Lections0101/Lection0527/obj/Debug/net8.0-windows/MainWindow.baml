   M S B A M L   `   `   `  ����F  BLection0527, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lection0527Lection0527  5   	       Lection0527.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:Lection0527     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5        Lection0527.AgeConverter   ageConverter%   Lection0527.AgeToColorConverter  colorConverter��%:   &	        &	        5   
   6     5	   
   6$   5
      .��5      �� ��6   �� *	MyCat.Age+ �� 	Converter# [ .+�5   
   �� ��6   �� *	MyCat.Age+# [  �� 5   
   ��6   �� *MyCat.FullInfo+�� 5   
   ��6   �� *CurrentDate.Today+ �� ConverterCulture$ ru-ru�� �� StringFormat$ {0:dd MMMM yyyy}���� 5   
   ��6   �� *
MyCat.Id+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   ��6   �� *
MyCat.Name+�� 5   
   ��6   �� *	MyCat.Age+$ {0:C}���� 5   
   ��6   �� *	MyCat.Age+$ {0:C}���� 5   
   ��6   �� *	MyCat.Age+$ {0:0.00}���� 5   
   ��6   �� *	MyCat.Age+$ {0:C}��$ ru-RU���� 5   
   ��6   �� *MyCat.Breed+ �� TargetNullValue$( "неизвестно, порода���� 5   
   -   5         ��Name$ NameTextBox��5      ��5      �� *.+�� 5   
   -   5        $ YearTextBox��5      ��5      �� 	 �� Path$
	 Year�$ OneWay=��� 5!   
   -   5        $ ColorTextBox��5!      ��5"      �� *
Background+
 �� RelativeSource
 ��  �� Mode$ FindAncestor=� �� AncestorType" ���� 5#   
   $	��100��5$      $	��100��6    
���   ���5#      �� *Text+ �� ElementName$ ColorTextBox��5$   -   5&      5'      