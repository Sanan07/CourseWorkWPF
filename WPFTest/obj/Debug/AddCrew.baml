   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFTestWPFTest  5   	       WPFTest.AddCrew   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFTest     5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	   (  "MahApps.Metro.Controls.MetroWindow     IsMaxRestoreButtonEnabled  .   � Icon$ Icons/Plane3.png��5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Новый экипаж��5   	   $��434.627��6   $��528.097��6/   .��5      � $��Right=�6   $	��518��6(   .+�5   
   �� -   5         ��Name$ label1��5      $��Consolas)�6    $��18(�66   $#��Капитан экипажа��6D   $
��Left=�6^   $��	72,64,0,0q�6y   $	��Top=�6�   ���	#DD0000006�   �� 5   
   -   5        $ label2��5      $��Consolas)�6    $��18(�66   $)��#Количество состава��6D   $
��Left=�6a   $��
42,242,0,0q�6|   $	��Top=�6�   ���	#DD0000006�   �� 5   
   -   5         ��Name$ textBox1��5      $��15(�6$   $
��Left=�62   $��28��6M   $��
267,64,0,0q�6Y    �� TextWrapping$
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��224��6�   �� 5   
   -   5         ��Name$ button��5      $��OK��6!   $��18(�6.      WPFTest.ButtonHelper   DialogResult$
 TrueX�6<   $
��Left=�6d   $��208,326,0,0q�6   $	��Top=�6�   $	��112��6�   �� 5   
   -   5        $ button1��5      $��Отмена��6"   $��18(�63   	 �� IsCancel	 . $
��Left=�6Q   $��382,326,0,0q�6l   $	��Top=�6�   $	��109��6�   �� 5   
   -   5        $ textBox2��5      $��15(�6$   $
��Left=�62   $��28��6M   $��267,236,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��224��6�   �� 5   
   -   5        $ label3��5      $��Consolas)�6    $��18(�66   $��Второй пилот��6D   $
��Left=�6[   $��101,118,0,0q�6v   $	��Top=�6�   ���	#DD0000006�   �� 5   
   -   5        $ textBox3��5      $��15(�6$   $
��Left=�62   $��28��6M   $��267,118,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��224��6�   �� 5   
   -	   5        $ label4��5      $��Consolas)�6    $��18(�66   $/��)Главный бортпроводник��6D   $
��Left=�6d   $��
12,180,0,0q�6   $	��Top=�6�   ���	#DD0000006�   �� 5   
   -
   5        $ textBox4��5      $��15(�6$   $
��Left=�62   $��28��6M   $��267,176,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��224��6�   5      5      