   M S B A M L   `   `   `  ����  WindowMediaPlayer(    "WindowMediaPlayer.Tabs.PlaylistTab   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      -   5          � 	Resources  5         Play 	 Pause  Forward  Backward  Loop  
LoopActive��%  &	        &	 I     &	 �     &	 �     &	 ,    &	 u    �� 5   
   $��/Resources/play.png��6   $��20��6:   $��20��6E   �� 5   
   $��/Resources/pause.png��6   $��20��6<   $��20��6G   �� 5   
   $��/Resources/forward.png��6    $��20��6@   $��20��6K   �� 5   
   $��/Resources/backward.png��6!   $��20��6B   $��20��6M   �� 5   
   $��/Resources/loop.png��6   $��20��6:   $��20��6E   �� 5   
   $ ��/Resources/loop_active.png��6#   $��20��6G   $��20��6R   5      .��5      �   ContentRoot#��[ 6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $	��200��6"   .+�5      �� $��Playlist��6     Heading2#��[ 6(   7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5      -   5        $
��Auto��5      $��Add Playlist��6C      IconDatas ���� @B ���- @B ���- �� � 	= �� � 	= ��- ���- ��- ���-  	= р�  	= р� ��- �@B ��- �@B �� р� �� 	6�   5      ]� 5!   
   $��1��6   $
��Left=�6!   $��0,5,0,5q�6<   .+�5"      &   System.Windows.Controls.DataGrid  -   5        $��All_Playlists��5"         AutoGenerateColumns .  ���#666666$��0,0,1,0q�6�      
IsReadOnly .    Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6)      Header$ Playlist name��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� 5&        5'      -   5        $��Playlist_Content��5'       .   .  5(        5)      $ Title��6)    68   �� *Title+  5*      $ Artist��6)    69   �� *Artist+  5+      $ Album��6)    68   �� *Album+  5,      $ Duration��6)    6;   �� *
Duration+5.      5/      ]� 51   
   $��2��6   $
��Auto��6!   
�������.+�52      ]� .+�53      �� -   5        	 ��Name$	 btnBackward��53      
�������$	��6,3q�6A   $��0q�6i   .��54      C� 
 C� ResourceKey$
 Backward��6&   55      �� 56      -   5        $	 btnPlayPause��56      
�������$	��6,3q�6B   $��0q�6k   .��57      C� $

 Play��6&   58      �� 59      -   5        $	 
btnForward��59      
�������$	��6,3q�6@   $��0q�6g   .��5:      C� $
 Forward��6&   5;      5<      ]� 5>      ��. .+�5?      � -   5         �Name$ Volume��5?       � Minimum$ 0Q�6.    � Maximum$ 1Q�6:   $��60��6_    � Value 6F   �� *Volume+6_   �� 5@      -	   5        $	 btnLoop��5@      
�������$	��6,3q�6=   $��0q�6a   .��5A      C� $

 Loop��6&   5B      5C      ]� 5E      ��. .+�5F      �� -
   5         ��Name$ 
MusicTimer��5F      $
��Left=�60   
���   �00:006`   �� 5G      -   5        $ MusicFullDuration��5G      $��Right=�67   
���   �00:006h   �� 5H      -   5         ��Name$ Slider_Music��5H      $ 0Q�6/   6�   5I      5J      5K      5L      