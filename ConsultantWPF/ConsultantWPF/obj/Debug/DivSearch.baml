   M S B A M L   `   `   `  ����H  DConsultantWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ConsultantWPFConsultantWPF  5   	       ConsultantWPF.DivSearch   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ConsultantWPF     5   	   -   5          � Title$  	DivSearch��5   	   $	��350��6   $	��525��6(    � 	Resources 5	      %   ConsultantWPF.consultantDataSet   consultantDataSet  divisionViewSource �� Source �� Source��%Y   &	        &	      7     5
   
   6"   �� 5   
    6:   �� *
division+8   5      .��5      �� $	��500��6   $	��300��6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   
��� E��.+�5      �� $	��150��6   $��30��6$   $��20(�60   Division Search:5      �� 5      -   5        $��button1��5   (   $��	10,0,10,0q�6   $��Previous Record��67   $��Center=�5      5      �� 5      -   5        $��button2��5   (   $��	10,0,10,0q�6   $��Next Record��67   $��Center=�5      5      5      � 5   
   -   5        $��grdPrdoductDetails��5      $	��240��6)   
������ � DataContext# [ 6N    � ColumnDefinitions 5       �� 5!      $
��Auto �6#   $	��100��60   5#      �� 5$       � RowDefinitions 5&      �� 5'      $
��Auto �6    $��60��6.   6?   �� 5(      $
��Auto �6    $��60��6.   6?   �� 5)      $
��Auto �6    $��60��6.   6?   �� 5*      $��* �6    6-   .+�5/      �� $��7q�6   Division ID:61   �� 50      $��5q�6   $��1��6!   ��61   �� *did+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . .��6�   51      �� 53      $��7q�6   $��1��6#   Division Name:6@   �� 54      $��5q�6   $��1��6!   $��1��6.   ��55      ��  �� Path$ DivisionName�6;   �� 57      $��7q�6   $��2��6#   Manager ID:6=   �� 58      $��5q�6   $��1��6!   $��1��6.   ��59      �� *dname+$ TwoWay=�	 . 
 . 6v   �� 5;      $ 
Horizontal=�6   $��2��62   $��1��6?   .+�5<      �� $��	5,5,5,4.6q�6   $��2��6-   $��1��6:   $	��390��5=   |   ��6   �� *	managerID+$ TwoWay=�	 . 
 . .��6�   5?      5A      5D      5F      5I      