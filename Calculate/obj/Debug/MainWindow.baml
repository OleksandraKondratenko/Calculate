   M S B A M L   `   `   `  ����D  @Calculate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Calculate	Calculate  5   	       Calculate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Calculate     5   	     � Title$  	Calculate��5   	   $	��700��6   $
��1100��6(   .��5	      � -   5         �Name$
 Calc��5	      
������� � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��57* �6   �� 5      $	��58* �6   �� 5      $	��57* �6   �� 5      $	��58* �6   �� 5      $	��58* �6   �� 5      $	��58* �6   .+�5   
   �� -   5         ��Name$ 
entryField��5       $��0��5!      $	��120(�5"      $��6��5#      $��0��6!    �� 	UndoLimit$ 99��6*    �� TextAlignment$ Right=�69   $��Bottom=�6O   
���   �
�������$��	Agency FB)�6�   .��6�   5%      	� 5&   
   -   5         	�Name$ 	Radio_Dec��5+       	� 	GroupName$ Osnova��5&      	 d� 	IsChecked$
	 TrueY�5(   
   $��0��5)   
   $��1��5*   
   $��25(�5,      $	��DEC��5-   
   
�������$��2,1,2,2q�6G   
 J� RenderTransformOrigin$
 0.49,0.5&�6X   $	��100��6y   	� 5.   
   -   5        $ 	Radio_Hex��53   
   $ Osnova��5.      $��0��5/   
   $��2��50   
   $��25(�51      $	��HEX��52   
   
�������$��2q�53   L   	� 55   
   -   5        $ 	Radio_Oct��59      $ Osnova��55      $��0��56   
   $��3��57   
   $��25(�58      $	��OCT��5:   
   
�������$��2q�6G   	� 5;   
   -   5        $ 	Radio_Bin��5?   
   $ Osnova��5;      $��0��5<   
   $��4��5=   
   $��25(�5>      $	��BIN��5@   
   
�������$��2,6,2,2q�6G   �� 5B   
   $��2��6   $��1��6"   $��25(�6.   $��2q�6<   $��5��6G   �� 5C   
   $��3��6   $��5��6!   $��2��6.   $��25(�6:   $��2q�6H   �� 5D   
   $��4��6   $��5��6"   $��3��6/   $��25(�6;   $��2q�6I   �� 5E   
   $��2��6   $��4��6"   $��4��6/   $��25(�6;   $��2q�6I   �� 5F   
   $��3��6   $��4��6"   $��5��6/   $��25(�6;   $��2q�6I   �� 5G   
   $��4��6   $��4��6"   $��6��6/   $��25(�6;   $��2q�6I   �� 5H   
   $��2��6   $��7��6"   $��25(�6.   $��2q�6<   $��3��6G   �� 5I   
   $��3��6   $��8��6"   $��25(�6.   $��2q�6<   $��3��6G   �� 5J   
   $��4��6   $��9��6"   $��25(�6.   $��2q�6<   $��3��6G   �� 5K   
   $��3��6   $��6��6"   $��0��6/   $��25(�6;   $��2q�6I   �� 5L   
   -   5         ��Name$ 	Button_Pi��5L      $��2��6$   $��1��64   $	��log��6A   $��25(�6O   $��2q�6u   �� 5M   
   -   5        $ Button_n_fakt��5M      $��2��6(   $��6��68   $��n!��6E   $��25(�6R   $��2q�6|   �� 5N   
   -	   5        $ Button_koren��5N      $��3��6'   $	��√��67   $��25(�6C   $��2q�6l   $��1��6w   �� 5O   
   -
   5        $ Button_stepen��5O      $��4��6(   $	��x²��68   $��25(�6E   $��2q�6j   $��1��6u   �� 5P   
   -   5        $ Button_plus��5P      $��5��6&   $��5��66   $��+��6C   $��25(�6O   $��2q�6]   �� 5Q   
   -   5        $ Button_minus��5Q      $��5��6'   $��4��67   $��-��6D   $��25(�6P   $��2q�6^   �� 5R   
   -   5        $ Button_devide��5R      $��5��6(   $��3��68   $��/��6E   $��25(�6Q   $��2q�6_   �� 5S   
   -   5        $ Button_mult��5S      $��5��6&   $��2��66   $��*��6C   $��25(�6O   $��2q�6]   �� 5T   
   -   5        $ Button_clear��5T      $��5��6'   $��1��67   $��CLEAR��6D   $��25(�6T   $��2q�6b   �� 5U   
   $��4��6   $��6��6!   $��.��6.   $��25(�6:   $��2q�6H   �� 5V   
   -   5        $ Button_percent��5V      $��%��6)   $��25(�65   $��3q�6Z   $��6��6e   $��1��6r   �� 5W   
   -   5        $ Button_squer��5W      $��5��6(   $��6��68   $��=��6E   $��25(�6Q   $��2q�6_   6j   �� 5X   
   -   5        $ 
Button_sin��5X      $��2��6%   $��2��65   $	��sin��6B   $��25(�6P   $��2q�6w   �� 5Y   
   -   5        $ 
Button_cos��5Y      $��3��6%   $��2��65   $	��cos��6B   $��25(�6P   $��2q�6w   �� 5Z   
   -   5        $ 	Button_tg��5Z      $��4��6$   $��2��64   $��tg��6A   $��25(�6N   $��2q�6t   �� 5[   
   -   5        $	 BIN��5[      $��1��6   $��25(�60   $��2q�6>   $��4��6I   �� 5\   
   -   5        $	 OCT��5\      $��1��6!   $��25(�62   $��2q�6@   $��3��6K   $�� ��6Y   �� 5]   
   -   5        $	 HEX��5]      $��1��6   $��25(�60   $��2q�6>   $��2��6I   5b      5c      