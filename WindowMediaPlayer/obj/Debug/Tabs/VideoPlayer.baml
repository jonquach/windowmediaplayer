   M S B A M L   `   `   `  ����  WindowMediaPlayer#    WindowMediaPlayer.VideoPlayer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      -   5          � 	Resources  5         Play 	 Pause��%�   &	        &	 I     �� 5   
   $��/Resources/play.png��6   $��20��6:   $��20��6E   �� 5   
   $��/Resources/pause.png��6   $��20��6<   $��20��6G   5      .��5      � -   5         �Name$ 	VideoGrid��5   0     ContentRoot#��[ 6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $	��200��6"   .+�5      �� $��
All Videos��6     Heading2#��[ 6*   7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5      -   5        $
��Auto��5      $��	Add Video��6B      IconDatas ���� @B ���- @B ���- �� � 	= �� � 	= ��- ���- ��- ���-  	= р�  	= р� ��- �@B ��- �@B �� р� �� 	6�   5      ]� 5   
   $��1��6   $
��Left=�6!   $��0,5,0,5q�6<   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
All_Videos��5         AutoGenerateColumns .     
IsReadOnly . ���#666666$��0,0,1,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6)      Header$ Title��65   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6D   �� *Title+5!      r� 5"      -   5        
 r�Name$
 mediaElement��5"       r� Stretch$
 Fill=�61   $
��Left=�6@    r� LoadedBehavior$ Manual=�6[   $	��200��6s   $	��200��6�   $��5,0,2,0q�6�   5#      ]� 5%   
   $��3��6   
�������.+�5&      ]� .+�5'      �� -   5         ��Name$ btnPlayPause��5'      
�������$	��6,3q�6B   $��0q�6k   .��5(      C�  C� ResourceKey$
 Play��6&   5)      5*      ]� 5,      ��. .+�5-      � -   5        $��Volume��5-      $��50��6,   $��12��67    � Maximum$ 1Q�6C    � Value 6O   ��  �� ElementName$ mediaElement�� �� Path$ Volume�5.      ]� 50      ��. .+�51      �� -   5        $��	TextTimer��51      
���   �
00:00:006J   �� 52      -	   5         ��Name$ VideoFullTimer��52      $��Right=�64   
���   �
00:00:006h   �� 53      -
   5        $��SliderProgress��53      6�   54      55      56      57      