   M S B A M L   `   `   `  ����C  ?Practos4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Practos4Practos4  5   	       Practos4.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Practos4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $��
0,0,-200,0q�5	       .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Razer��5
         AutoGenerateColumns$ False��6"   $��	0,0,431,0q�6?    J� RenderTransformOrigin$ 0.517,0.495&�6R      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6v      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   MaxWidth$ 80Q�6>      MinWidth$ 80Q�6L      Header$ Имя��6Z   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *name+6Z   4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        
DGCbColumn��$ Тип записи��5   h   $	 120Q�6}   $	 120Q�6�   
   SelectedItemBinding
 6=   �� *
recordtype+6�     5      $	 120Q�6G   $	 120Q�6V   $% Количество денег��6e   	 6%   �� *amountofmoney+6e   4  .System.Windows.Controls.DataGridCheckBoxColumn  5         
Visibility$ Visible=�6G      Width$	 100 6\      CanUserResize$
 True��6h   $ 50Q�6}   $ 50Q�6�   $ 
Вычет��6�   	 6)   �� *	deduction+6�     5      $ Дата записи��6]   $	 120Q�6r   $	 120Q�6�   	 6%   �� *date+ �� StringFormat$ {0:dd.MM.yyyy}��6�      	CellStyle 5      �� 5      .@�5      �� $	��120��6   $	��120��6#    �� MaxDropDownHeight$	 120��60   5      �� 5   
   -   5         ��Name$ RecordDatePicker��5       �� ItemStringFormat$ 
dd.MM.yyyy��6-   $
��Left=�6K   $��
609,28,0,0q�6f   $	��Top=�6z   $	��120��6�   6�   �� 5   
   -   5        $��Сбросить��5      $
��Left=�6$   $��
637,55,0,0q�6?   $	��Top=�6S   $��25��6k   $��64��6w   6�   5      5      