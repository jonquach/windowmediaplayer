   M S B A M L   `   `   `  ����  WindowMediaPlayer%    WindowMediaPlayer.Tabs.MusicTab   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      -   5          � 	Resources  5         Play 	 Pause  Forward  Backward  Loop  
LoopActive��%  &	        &	 I     &	 �     &	 �     &	 ,    &	 u    �� 5   
   $��/Resources/play.png��6   $��20��6:   $��20��6E   �� 5   
   $��/Resources/pause.png��6   $��20��6<   $��20��6G   �� 5   
   $��/Resources/forward.png��6    $��20��6@   $��20��6K   �� 5   
   $��/Resources/backward.png��6!   $��20��6B   $��20��6M   �� 5   
   $��/Resources/loop.png��6   $��20��6:   $��20��6E   �� 5   
   $ ��/Resources/loop_active.png��6#   $��20��6G   $��20��6R   5      .��5      �   ContentRoot#��[ 6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $	��200��6"   .+�5      �� $��
All Musics��6     Heading2#��[ 6*   7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5      -   5        $
��Auto��5      $��
Add musics��6A      IconDatas ���� @B ���- @B ���- �� � 	= �� � 	= ��- ���- ��- ���-  	= р�  	= р� ��- �@B ��- �@B �� р� �� 	6�   5      �� 5!   
   $��1��6   .��5"      &   System.Windows.Controls.DataGrid  -   5        $��
All_Musics��5"         AutoGenerateColumns .     
IsReadOnly .    Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Title+  5%      $ Artist��6)    69   �� *Artist+  5&      $ Album��6)    68   �� *Album+  5'      $ Duration��6)    6;   �� *
Duration+5)      5*      ]� 5,   
   $��2��6   $
��Auto��6!   
�������.+�5-      ]� .+�5.      �� -   5         ��Name$ btnBackward��5.      
�������$	��6,3q�6A   $��0q�6i   .��5/      C� 	 C� ResourceKey$	 Backward��6&   50      �� 51      -   5        $ btnPlayPause��51      
�������$	��6,3q�6B   $��0q�6k   .��52      C� $
	 Play��6&   53      �� 54      -   5        $ 
btnForward��54      
�������$	��6,3q�6@   $��0q�6g   .��55      C� $	 Forward��6&   56      57      ]� 59      ��. .+�5:      � -   5        
 �Name$
 Volume��5:       � Minimum$ 0Q�6.    � Maximum$ 1Q�6:   $��60��6_    � Value 6F   �� *Volume+6_   �� 5;      -   5        $ btnLoop��5;      
�������$	��6,3q�6=   $��0q�6a   .��5<      C� $
	 Loop��6&   5=      5>      ]� 5@      ��. .+�5A      �� -	   5         ��Name$ 
MusicTimer��5A      $
��Left=�60   
���   �00:006`   �� 5B      -
   5        $ MusicFullDuration��5B      $��Right=�67   
���   �00:006h   �� 5C      -   5         ��Name$ Slider_Music��5C      $ 0Q�6/   6�   5D      5E      5F      5G      