   M S B A M L   `   `   `  ����  Game    Game.MainPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  MainPage��5   	   $	��450��5   	   $	��600��5   	   ���#242424 � WindowStyle$
 None=�5   	    � WindowState$ Normal=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � AllowsTransparency .  � ShowInTaskbar .  � 	Resources 5         FocusVisual �� Property �� Value	 J� SnapsToDevicePixels
 �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName 
 ButtonStyle1��%m  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    '�� �    7   7  7  7  7  7  7  7  7  7 	 '�� �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   	 . #��� ��6J   $��1��6�   $	
 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5    
   " ��6   .�5!      ��  �@�FocusVisualStyle8   61   �� 5"       � ��8  6+   �� 5#       � ��8  6,   �� 5$       � ��# � ��6+   �� 5%       � ��$ 1q�60   �� 5&       � ��$ Center=�6;   �� 5'       � ��$ Center=�69   �� 5(       � ��$ 1q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      �� $ border��63   $ 12��6!   #��z��6C   #��z��6o   #��z��6�   	 . ._�5-      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. #	 z	 6�   #��z��6  5.       5/      P� 50       �@��IsDefaulted . . �51   "   �� $ border��6@   # � ��6T    � ��52      P� 53       �@J�IsMouseOver . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � �� . . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   5:      P� 5;       � {� .  . �5<   "   �� $ border��6?   8   � ��6S   �� 5=   "   $ border��6@   8   � ��6T   �� 5>   "   $ contentPresenter��6K   8 	  � ��6i   5?      5A      5C      5D      �� 5E   
   " ��6   �� 5F   
   " ��6%   .�5G      ��  �@�FocusVisualStyle8   61   �� 5H       � ��8  6+   �� 5I       � ��8  6,   �� 5J       � ��# � ��6+   �� 5K       � ��$ 1q�60   �� 5L       � ��$ Center=�6;   �� 5M       � ��$ Center=�69   �� 5N       � ��$ 1q�6(   �� 5O       � �� 5P      �� 5Q      " ��6&   .R�5R      �� $ border��63   $ 50��6!   #��z��6C   #��z��6o   #��z��6�   	 . ._�5S      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. #	 z	 6�   #��z��6  5T       5U      P� 5V       �@��IsDefaulted . . �5W   "   �� $ border��6@   # � ��6T    � ��5X      P� 5Y       �@J�IsMouseOver . . �5Z   "   �� $ border��6?   8   � ��6S   �� 5[   "   $ border��6@   8   � ��6T   5\      P� 5]       � �� . . �5^   "   �� $ border��6?   8   � ��6S   �� 5_   "   $ border��6@   8   � ��6T   5`      P� 5a       � {� .  . �5b   "   �� $ border��6?   8   � ��6S   �� 5c   "   $ border��6@   8   � ��6T   �� 5d   "   $ contentPresenter��6K   8 	  � ��6i   5e      5g      5i      5j      5k      .��5l      �� .+�5m   
   � $
��Left=�6   .+�5n      �� -   5        ���#ff1c1c$��40��5n   *   ���#ff1c1c$��40��6K   $��10,10,10,10q�6W   #��� 
 6�   �� 5o      -   5        ���#12fc00$��40��5o   *   $��40��65   ���#12fc00$��
0,10,10,10q�6W   #��� 
 6~   5p      �� 5q   
   $��Center=�6   $��Center=�60   .+�5r      �� -   5        ���#c5ff14$��2q�5r   +   $
��Easy��6?   ���#202020���#c5ff14$��0, 40 , 0, 20q�6x   $��40(�6�   $��
10,0,10,10q�6�   6�   �� 5s      -   5        ���#e000e3$��2q�5s   +   $��Medium��6?   ���#202020���#e000e3$��0, 0 , 0, 20q�6z   $��40(�6�   $��
10,0,10,10q�6�   6�   �� 5t      -   5        ���#2da7f5$��2q�5t   +   $
��Hard��6?   ���#202020���#2da7f5$��0, 0 , 0, 20q�6x   $��40(�6�   $��
10,0,10,10q�6�   6�   5u      5v      5w      