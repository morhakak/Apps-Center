   M S B A M L   `   `   `  ����E  AAppsCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AppsCenter.Apps.TicTacToeAppsCenter.Apps.TicTacToe  5   	   -    'AppsCenter.Apps.TicTacToe.TicTacToeView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AppsCenter.Apps.TicTacToe     5   	     � Title$  Tic Tac Toe��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value��%x   &	        �� 5   
   " ��6$   .�5      ��  � ��$ 50(�6)   �� 5       � ��$
 bold"�6+   5      5      .��5      � -   5         �Name$ MainGrid��5       � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��0��5      $��0��6   #��[  6C   �� 5   
   -   5        $��0��5      $��1��6   #��[  6C   �� 5   
   -   5        $��0��5      $��2��6   #��[  6C   �� 5    
   -   5        $��1��5       $��0��6   #��[  6C   �� 5!   
   -   5        $��1��5!      $��1��6   #��[  6C   �� 5"   
   -   5        $��1��5"      $��2��6   #��[  6C   �� 5#   
   -   5        $��2��5#      $��0��6   #��[  6C   �� 5$   
   -	   5        $��2��5$      $��1��6   #��[  6C   �� 5%   
   -
   5        $��2��5%      $��2��6   #��[  6C   5&      5'      