   M S B A M L   `   `   `  ����   WindowMediaPlayer#    WindowMediaPlayer.VideoPlayer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  -     � 	Resources     Play 	 Pause��%w   &	        &	 1     �� $��/Resources/play.png��$��20��$��20���� $��/Resources/pause.png��$��20��$��20��.��� -    �Name$ 	VideoGrid��  ContentRoot#��[  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+��� $��0��$	��200��.+��� $��
All Videos��  Heading2#��[ 7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  -   $
��Auto��$��	Add Video��   IconDatas ���� @B ���- @B ���- �� � 	= �� � 	= ��- ���- ��- ���-  	= р�  	= р� ��- �@B ��- �@B �� р� �� 	]� $��1��$
��Left=�$��0,5,0,5q�.+�&   System.Windows.Controls.DataGrid  -   $��
All_Videos��   AutoGenerateColumns .     
IsReadOnly . ���#666666$��0,0,1,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150    Header$ Title��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *Title+r� -   
 r�Name$
 mediaElement�� r� Stretch$
 Fill=�$
��Left=� r� LoadedBehavior$ Manual=�$	��200��$	��200��$��5,0,2,0q�]� $��3��
�������.+�]� .+��� -    ��Name$ btnPlayPause��
�������$	��6,3q�$��0q�.��C�  C� ResourceKey$
 Play��]� ��. .+�� -   $��Volume��$��50��$��12�� � Maximum$ 1Q� � Value ��  �� ElementName$ mediaElement�� �� Path$ Volume�]� ��. .+��� -   $��	TextTimer��
���   �
00:00:00�� -	    ��Name$ VideoFullTimer��$��Right=�
���   �
00:00:00�� -
   $��SliderProgress��