   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFTestWPFTest  5   	       WPFTest.First   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFTest     5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   e aTelerik.Windows.Controls, Version=2016.1.217.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7?telerik1http://schemas.telerik.com/2008/xaml/presentation  5   	   -   5        $��0q�5   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � 
ResizeMode$ NoResize=�5   	    � Icon$ Icons/Plane3.png��5   	   
�������   WindowTransitionsEnabled .  � WindowStartupLocation$ CenterScreen=�5   	       IsMaxRestoreButtonEnabled .   � Title$% Главная страница��5   	   $	��880��6"   $��1098.571��6/   $	��600��5   	   $
��1010��6    � 	Resources 5         
SearchTile �� 
TargetType!  MahApps.Metro.Controls.Tile	 �� Property
 �� Value �� Triggers P� Property P� Value��%�   &	        �� 5   
   "  6#   .�5      �� 	 � ��
 �#9856a36+    5      P� 5       �@J�IsMouseOver . . �5       �� 	 � ��
 �#12FF1263   5!      5#      5$      .��5&      � .+�5'   
     -   5          Name$ tile3��5'       J� 	AllowDrop .    Title$ Самолеты��68      TitleFontSize$ 24��6J   $
��Left=�6^   $��650,130,0,0q�6y   #��� ��6�   $	��Top=�6�   $	��425��6�   $	��279��6�    � ToolTip$ Самолеты��6  .��5(      �� -   5         ��Name$ image��5(      $	��186��6#   $	��178��60   $��Icons/Plane3.png��6<    J� RenderTransformOrigin$ 0.551,0.511&�6V   5)        5+   
   -   5        $ tile2��5+       . $ Оборудование��68   $ 24��6M   ���#EC407A$
��Left=�6u   $��134,371,0,0q�6�   $	��Top=�6�   $	��501��6�   $	��184��6�   $ Оборудование��6�   .��5,      �� -   5        $ image3��5,      $��Icons/equip.png��6$   $	��134��6=   $	��228��6J   $ 
0.429,0.46&�6V   5-        5.   
   -   5        $ tile1��5.       . $ Экипаж��68   $ 24��6G   $
��Left=�6Z   $��392,130,0,0q�6u   $	��Top=�6�   $	��228��6�   $	��243��6�   ���	#FF93D44F$ Экипаж��6�   .��5/      �� -   5        $ image2��5/      $��Icons/crew.png��6$   $	��136��6<   $	��164��6I   50        51   
   -   5        $
 tile��51      $ 
Рейсы��6'   $ 24��65   $	��Top=�6H   $	��243��6`   $	��228��6l   $��33.333(�6y   $ 
Рейсы��6�   $
��Left=�6�   $��Consolas)�6�   #��[  6�   $��134,130,0,0q�6    HighlightBrush#���  6   J� SnapsToDevicePixels . .��52      �� -	   5        $ image1��52      $��Icons/suit.png��6$   $	��136��6<   $	��164��6I   53      �� 55   
   -
   5         ��Name$ label��55      $��35(�6   ���	#FFEC08EC$
��Left=�6D   $��	70,33,0,0q�6_   $	��Top=�6r   $$��Выберите раздел:��6�   
�������6�     56   
   -   5        $ tile4��56      $ Статистика��6'   $ 24��6:   ���#34495e$
��Left=�6b   $��134,569,0,0q�6}   $	��Top=�6�   $	��795��6�   $	��198��6�   .��57      �� -   5        $ image4��57      $��Icons/chart.png��6$   $	��136��6=   $	��164��6J   58      59      5;      