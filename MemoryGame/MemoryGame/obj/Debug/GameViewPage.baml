   M S B A M L   `   `   `  ����E  AMemoryGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MemoryGame
MemoryGame  5          MemoryGame.GameViewPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MemoryGame     5        N� Title$  GameViewPage��5	      .��5      � -   5         �Name$ GameViewPageGrid��5      .+�5   
   � -   5        $ GameGrid��5      $��0,0,90,-0.4q�6!   5      � 5   
   -   5        $ 
PlayerGrid��5      $��715,0,0,-0.4q�6#   $��Right=�69   .+�5      �� -   5        $��player1name��5   z   $
��Left=�6   $
��Wrap=�63   $�� ��6G   $	��Top=�6O   $��	10,10,0,0q�6g   $��65��6�   �� 5      -   5        $��player1score��5   z   $
��Left=�6   $
��Wrap=�63   $��0��6G   $	��Top=�6P   $��9,31,0,0q�6h   $��65��6�    �� TextAlignment$ Center=�6�   
�������6�   �� 5      -   5        $��player2name��5   z   $
��Left=�6   $
��Wrap=�63   $�� ��6G   $	��Top=�6O   $��	10,86,0,0q�6g   $��65��6�   �� 5      -   5        $��player2score��5   {   $
��Left=�6   $
��Wrap=�63   $��0��6G   $	��Top=�6P   $��	9,107,0,0q�6h   $��65��6�   $ Center=�6�   
�������6�   �� 5      -   5         ��Name$ SaveAndQuitGame��5      $��
0,359,0,71q�6.   $��20��6B   $��Save and Quit��6c   
������� � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 8��69   5      5      5       �� 5%      -	   5        $ ResetGameButton��5%      $��15,409,10.2,21q�6.   $��50��6F   $��20��6Q   $��Reset��6o   
������� 5&      ��%^   '��       �� 5'      " ��6   .�5(      ��  �@��CornerRadius$ 8��69   5)      5*      5+      5/       � 51   
   -
   5          �Name$ GameViewPageView��51      �� 52   
   -   5        $��selectedTheme��52   w   $
��Left=�6   $
��Wrap=�6/   $�� ��6C   $	��Top=�6K   $y�Hidden=�6c   6w   �� 53   
   -   5        $��nrOfCols��53   w   $
��Left=�6   $
��Wrap=�6/   $�� ��6C   $	��Top=�6K   $y�Hidden=�6c   6w   �� 54   
   -   5        $��nrOfRows��54   w   $
��Left=�6   $
��Wrap=�6/   $�� ��6C   $	��Top=�6K   $y�Hidden=�6c   6w   �� 55   
   -   5        $��memoryImagesList��55   w   $
��Left=�6   $
��Wrap=�6/   $�� ��6C   $	��Top=�6K   $y�Hidden=�6c   6w   57      58      