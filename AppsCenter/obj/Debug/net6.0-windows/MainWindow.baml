   M S B A M L   `   `   `  ����  
AppsCenter    AppsCenter.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Apps Center��5   	   $	��800��6   $
��1400��6*    � WindowStartupLocation$ CenterScreen=�5   	   ���#A9D6E5 � WindowStyle$
 None=�6C    � 
ResizeMode$ NoResize=�6V    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $# /Styles/AppsCenterStyles.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��2* �6   6,   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,   �� 5      $��2* �6   6*   �� 5      $
��0.5* �6   6,   .+�5   
   �� $��/Images/user-icon.png��6   	 K� ZIndex$	 2��6/   $��30��6@   $��0,0,50,0q�6K   
 J� OpacityMask
 �	#FF4C4C4C6]   �� 5   
   -   5         ��Name$
 user��5      $��	Mor Hakak��5       $
��Bold"�5!      $��20(�5"      $	 2��5#      $��Center=�5$      $��Center=�5%      $��	100,0,0,0q�6*   �� 5&   
   -   5        $ appTitle��5&      $��0��5'      $��0��5(      $��3��5)      $��Center=�5*      $��Apps center��5+      $��Center=�5,      $
��Bold"�5-      $��60(�5.      $
��1406��6   ���	#FF19747E���#D1E8E26B   �� 51   
   -   5        $
 date��52      $�� ��53      $��0��54      $��2��55      $��Center=�56      $��Center=�57      $��20(�58      $��DemiBold"�59      $	��355��5:      ���	#FF19747E
���   �5<      �� 5=   
   -   5         ��Name$ ExistButton��5=      $��/Images/on-off-button.png��5>      $��30��5?      $��2��5@      $��281,107,39,8q�5A      $��2��5C      5D   4   �� 5E   
   -   5        $ GameText��5F      $��Please pick an app��5G      $��1��5H      $��1��5I      $��Center=�5J      $��Center=�5K      $��26(�5L      ���#19747E$��DemiBold"�5N      � 5Q   
   $��2��6   $��1��6!   $��Center=�61   $��Center=�6N   .+�5R      �� -   5        $ CalcualtorImg��5R      $ ��/Images/calculatorIcon.png��6+    J� Opacity$ 1Q�6�      AppsCenterImage#��[  6�   6�   �� 5S      -   5        $ ToDoImg��5S      $��/Images/todo list.png��6%   $ 1Q�6�   #��[  6�   6�   �� 5T      -   5        $ CurrencyConverterImg��5T      $#��/Images/currency exchange.png��62   $ 1Q�6�   #��[  6�   6�   �� 5U      -	   5        $ CarGameAppImg��5U      $��/Images/carImage.png��6+   $ 1Q�6�   #��[  6�   6�   �� 5V      -
   5        $ TicTacToeImg��5V      $��/Images/tic-tac-toe.png��6*   $ 1Q�6�   #��[  6�   6�   �� 5W      -   5        $ UserManagementImg��5W      $$��/Images/userManagementIcon.png��6/   $ 1Q�6�   #��[  6�   6�   5X      �� 5Z   
   -   5        $ Footer��5Z      $��0��5[      $��3��5\      $��3��5]      $��Center=�5^      $��Center=�5_      $
��Bold"�5`      $��23(�5a      $
��1409��6   ���	#FF19747E6+   5c      5d      