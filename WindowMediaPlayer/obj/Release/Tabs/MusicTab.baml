   M S B A M L   `   `   `  ����   WindowMediaPlayer%    WindowMediaPlayer.Tabs.MusicTab   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  -     � 	Resources     Play 	 Pause  Forward  Backward  Loop  
LoopActive��%q  &	        &	 1     &	 c     &	 �     &	 �     &	 �     �� $��/Resources/play.png��$��20��$��20���� $��/Resources/pause.png��$��20��$��20���� $��/Resources/forward.png��$��20��$��20���� $��/Resources/backward.png��$��20��$��20���� $��/Resources/loop.png��$��20��$��20���� $ ��/Resources/loop_active.png��$��20��$��20��.���   ContentRoot#��[  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$	��200��.+��� $��
All Musics��  Heading2#��[ 7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  -   $
��Auto��$��
Add musics��   IconDatas ���� @B ���- @B ���- �� � 	= �� � 	= ��- ���- ��- ���-  	= р�  	= р� ��- �@B ��- �@B �� р� �� 	�� $��1��.��&   System.Windows.Controls.DataGrid  -   $��
All_Musics��   AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Title��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Title+  $ Artist�� �� *Artist+  $ Album�� �� *Album+  $ Duration�� �� *
Duration+]� $��2��$
��Auto��
�������.+�]� .+��� -    ��Name$ btnBackward��
�������$	��6,3q�$��0q�.��C� 	 C� ResourceKey$	 Backward���� -   $ btnPlayPause��
�������$	��6,3q�$��0q�.��C� $
	 Play���� -   $ 
btnForward��
�������$	��6,3q�$��0q�.��C� $	 Forward��]� ��. .+�� -   
 �Name$
 Volume�� � Minimum$ 0Q� � Maximum$ 1Q�$��60�� � Value �� *Volume+�� -   $ btnLoop��
�������$	��6,3q�$��0q�.��C� $
	 Loop��]� ��. .+��� -	    ��Name$ 
MusicTimer��$
��Left=�
���   �00:00�� -
   $ MusicFullDuration��$��Right=�
���   �00:00�� -    ��Name$ Slider_Music��$ 0Q�