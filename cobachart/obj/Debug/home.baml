   M S B A M L   `   `   `  ����D  @cobachart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:cobachart	cobachart  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          cobachart.home   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:cobachart     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� Title$
  home��5
      .��5      �  � 	Resources 5   
      CleanSeparator �� 
TargetType  LiveCharts.Wpf.Separator �� Property �� Value��%P   &	        �� 5      "  6+   .�5      ��  � {� .  6>   5      5       � ColumnDefinitions 5   
   �� 5      $
��1200 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
     LiveCharts.Wpf.Gauge     Uses360Mode . $��1��6'   $��1��64      From$ 0Q�5      		   To$		 100Q�6   
   Value$
 50Q�6   
������ 6)   #  LiveCharts.Wpf.CartesianChart  5   
   $��0��6   &   LiveCharts.Wpf.Charts.Base.Chart   AxisY 5        LiveCharts.Wpf.Axis     
Foreground
 ����   Title$ 	Blue Axis��63     5      
 �\\��$ Red Axis��62      Position$ RightTop=�6C      	Separator 5         5!      #��[  6(   6R   5#        5$      
 �/kU�$ 
Green Axis��67   $ RightTop=�6J    5%        5&      #��[  6(   6R   5(         Series 5+        LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 	1,5,3,5,3 6!      	ScalesYAt$ 0��64     5-      $ 20,30,70,20,10 6!   $ 1��6:     5/      $ 600,300,200,600,800 6!   $ 2��6?   52      &	   System.Windows.Controls.DataGrid	  53   
   -   5         	 Name$ 
myDataGrid��57      $��1��53       	  AutoGenerateColumns . $��Stretch=�54      $��Stretch=�55      $��10q�56       	  Columns 58      0
  *System.Windows.Controls.DataGridTextColumn
  59      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L   
  5:      $	 Age��6%   $ * 6J    62   �� *Age+6J   
  5;      $ 
Occupation��6%   $ * 6X    69   �� *
Occupation+6X   5=      � 5?   
   $��1��6    5@      �� 5A      �� 5B      .+�5D      �� $��0��6   $	��200��6"   $	��100��6.   
���� ��
�������$��1q�5G       �� CornerRadius$ 10��5H      $��Center=�5I      $��Center=�5J       �� Padding$ 10q�5K      ._�5L      �� .+�5M      �� $��
Card Title��6    $
��Bold"�62   $��16(�6D   $��0,0,0,10q�6R   �� 5N      $C��=This is a small card-like box created using a Border element.��6    $
��Wrap=�6e   5O      5P      �� 5Q      $��1��6   $	��200��6"   $	��100��6.   
����+��
�������$��1q�5T      $ 10��5U      $��Center=�5V      $��Center=�5W      $ 10q�5X      ._�5Y      �� .+�5Z      �� $��
Card Title��6    $
��Bold"�62   $��16(�6D   $��0,0,0,10q�6R   �� 5[      $C��=This is a small card-like box created using a Border element.��6    $
��Wrap=�6e   5\      5]      5^      5a      5b      