   M S B A M L   `   `   `  ����H  DConsultantWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ConsultantWPFConsultantWPF  5   	       ConsultantWPF.DivForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ConsultantWPF     5   	   -   5          � Title$  DivForm��5   	   $	��350��6   $	��500��6&    � 	Resources 5	      %   ConsultantWPF.consultantDataSet   consultantDataSet  divisionViewSource �� Source �� Source��%Y   &	        &	      7     5
   
   6"   �� 5   
    6:   �� *
division+8   5      .��5      �� $	��300��6   $	��480��6    � DataContext# [ 6*   .+�5   
   �� $��50��6   $	��480��6!   
�������.+�5      �� $��40��6   $��24(�6$   $
��Bold"�62    �� TextAlignment$ Center=�5      $��5q�6+   
���  ���� 6H   $�Division Table Data View��6L   6o   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ divisionDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $	��200��6h   $��0,0,5,0q�6�   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   ��6u   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	didColumn��,  &System.Windows.Controls.DataGridColumn   Header$	 did��5   P      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *did+6]     5      -   5        dnameColumn��$ dname��5   T   $ SizeToHeader 6c    6:   �� *dname+6c     5      -   5        managerIDColumn��$ 
manager ID��5   \   $ SizeToHeader 6p    6>   �� *	managerID+6p   5      � 5   
   5       5$      5%      