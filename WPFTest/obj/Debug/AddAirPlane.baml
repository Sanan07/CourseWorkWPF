   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFTestWPFTest  5   	       WPFTest.AddAirPlane   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFTest     5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	   (  "MahApps.Metro.Controls.MetroWindow     IsMaxRestoreButtonEnabled  .   � Icon$ Icons/Plane3.png��5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Новый самолет��5   	   $��442.965��6   $��528.097��60   .��5      � $��Right=�6   $	��518��6(   .+�5   
   �� -   5         ��Name$ label5��5      $��Consolas)�6    $��18(�66   $'��!Название самолета��6D   $
��Left=�6`   $��	27,58,0,0q�6{   $	��Top=�6�   ���	#DD0000006�   �� 5   
   -   5        $ label6��5      $��Consolas)�6    $��18(�66   $��Год выпуска��6D   $
��Left=�6Z   $��
86,178,0,0q�6u   $	��Top=�6�   ���	#DD0000006�   �� 5   
   -   5         ��Name$ textBox2��5      $��15(�6$   $
��Left=�62   $��28��6M   $��
267,58,0,0q�6Y    �� TextWrapping$
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��224��6�   �� 5   
   -   5         ��Name$ 	comboBox3��5      $��15(�6&   $
��Left=�64   $��267,110,0,0q�6O   $	��Top=�6d   $	��224��6|   �� 5   
   -   5        $ label7��5      $��Consolas)�6    $��18(�66   $ ��Производители��6D   $
��Left=�6\   $��
66,117,0,0q�6w   $	��Top=�6�   ���	#DD000000 J� RenderTransformOrigin$ 0.472,0.538&�6�   �� 5   
   -   5        $ label8��5      $��Consolas)�6    $��18(�66   $��Количество��6D   $
��Left=�6Y   $��
96,242,0,0q�6t   $	��Top=�6�   ���	#DD000000$ 	0.5,2.209&�6�   �� 5   
   -   5        	 ��Name$	 button2��5      $��OK��6"   $��18(�6/      WPFTest.ButtonHelper
   DialogResult$

 TrueX�6=   $
��Left=�6e   $��207,321,0,0q�6�   $	��Top=�6�   $	��112��6�   �� 5   
   -   5        $	 button3��5      $��Отмена��6"   $��18(�63    �� IsCancel . $
��Left=�6Q   $��382,321,0,0q�6l   $	��Top=�6�   $	��109��6�   �� 5   
   -	   5        $ textBox3��5      $
��Left=�6$   $��15(�6?   $��31��6M   $��267,178,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��224��6�   *  $MahApps.Metro.Controls.NumericUpDown  5   
   -
   5          Name$ numericUpDown2��5         Minimum$ 1Q�67   $��15(�6C   $
��Left=�6Q   $��267,247,0,0q�6l   $	��Top=�6�   $ 0.057,-0.449&�6�   $	��224��6�   5      5      