   M S B A M L   `   `   `  ����J  FMy Covid Record, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:My_Covid_RecordMy_Covid_Record  5   	   (    "My_Covid_Record.VaccineDetailsPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:My_Covid_Record     5   	     � Title$  VaccineDetailsPage��5   	   $
��1024��6$   $
��1440��62    � 	Resources 5
         RoundTextboxCornerTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value	 �� Value
 �� 
TargetName �� Property��%�  &	        �� 5      " ��67   .R�5      �� $ Bd��5   
   #��z��5      
���   �#��z��5   
   $ 5��6>   ._�5      �� $ PART_ContentHost��6   5       5      P� 5       � {� .  . �5      �� #	 � ��6$   $
 Bd��6f    � ���� 5      #	 � ��6$    � ��5      P� 5       � ��$
 Auto��6   . �5      ��  � ��$		 100��6"   5      P� 5       � ��$
 Auto��6    . �5      ��  � ��$	 20��6#   5      5      5      .��5       �� $��20q�6   .+�5"      �  � ColumnDefinitions 5#      �� 5$      $��* �6   �� 5%      $��* �6   .+�5(      �� $
��Left=�6   $��60��6&   $'��!/Resources/images/NZ Gov Logo.png��5)      �� 5+      $��1��6   $��Right=�6   $��44��67   $"��/Resources/images/NZ Gov.png��6C   5,      � 5/       50      �� 51      $��* �6   �� 52      $
��auto �6   �� 53      $��* �6   .+�56      �� $��1��6    �� Orientation$ 
Horizontal=�6    .+�57      �� $0��*/Resources/images/My Covid Record Logo.png��6   $	��100��6A   �� 58      $��My Covid Record��6   $��Inter)�59      $
��Bold"�6%   $��80(�67   5:      5<      � 5?      $��40q�6	    5@      �� 5A      $��* �6   �� 5B      $��* �6   .+�5F      �� $ 
Horizontal=�6   .+�5G      �� -   5         ��Name$ 
HomeButton��5G       J� Opacity$ 0.995Q�6!   $��0q�61   
�������.��5H      �� $&�� /Resources/images/homeButton.png��6   5I      � 5K      $
��5,10q�6   $	��529��6   .+�5L      �� #��[  6   $��25(�6F   $��50��6T   $	��512��6`   �� 5M      -   5        $ SearchButton��5M      $��0q�6%   $��Right=�69   
�������$��10,10,12,9.6q�6h   .��5N      �� $(��"/Resources/images/searchbutton.png��6   $��38��6:   5O      5P      5Q      �� 5T      $��2��6   $��74��6$   $	��Top=�60   .+�5U      �� -   5        $��btnShowPopup��5U      $��Account��6!   $��Medium"�63   $��Right=�6H   $	��Top=�6d   $	��105��6|   $��74��6�   $��25(�5V   ,   $��0q�6:   
�������$��Roboto)�6b   $��1��6v   $��0,0,0,0q�6�    5W       �� 
TargetType��%^   '��       �� 5X      " ��6   .�5Y   	   ��  �@��CornerRadius$	 8��6(   5Z   	   5[      5\      � 5^      -   5         �Name$ myPopup��5^   =    � AllowsTransparency .  � HorizontalOffset$	 1cm��6&   $��Relative=�5_       � 	StaysOpen . $��0q�5`       � PlacementTarget 5_   :   ��  �� ElementName$ btnShowPopup��.��5b      �� $	��304��6   $	��301��6   ._�5c      ]� ���#3A89FF��. $��0,0,0,-39.2q�6<   $��3��6R   $��1��6f    J� RenderTransformOrigin$ 0.522,0.549&�6w   $	��340��6�   $	��Top=�6�   z�5d   	   V� 5e   
   .~�5f      �� �� 5g       �� AngleX$ 0.268Q�6   �� 5h      T� 5i       T� X$ 0.873Q�6   5j      .+�5l   	   � .+�5m   
   � .+�5n      �� ���#3A89FF
�������$	��Top=�6=   $��16(�5o   $   $��Center=�63   $��30,40,215,270q�5p   $   $��Account��6;   5q      � 5s   
   $��0,0,0,0q�6   $	��116��6    .+�5t      �� $��Personal Details��6   $��Center=�6.   
�������$��-57,100,-50,220q�6_   $	��223��6x   $��Inter)�6�   �� 5u      $��Generate QR Code��6   $��Center=�6.   
�������$��-57,125,-50,195q�6`   $	��223��6y   �� 5v      $��Notifcations��6   $��Center=�6*   
�������$��-57,150,-50,170q�6\   $	��223��6u   �� 5w      $"��Generate Vaccine Certificate��6   $��Center=�6;   
�������$��-57,175,-50,145q�6l   $	��223��6�   �� 5x      $��Report an Issue��6   $��Center=�6.   
�������$��-57,200,-50,121q�6_   $	��223��6x   �� 5y      $��Settings��6   $��Center=�6'   
�������$��-57,224,-50,97q�6X   $	��223��6p   5z      � 5|   
   .+�5}      �� -   5        $��Close��5}   .   $��17,255,248,44q�6>   $��Center=�5~   !   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.087,0.689&�6�   $��39��6�   �� 5�      -   5        $��Logout��5�   .   $��242,255,17,44q�6?   $��Center=�5�   "   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.574,0.693&�6�   $��45��6�   $��Inter)�6�   5�      5�   
   5�   	   5�      5�      5�      5�      � 5�      .+�5�      �� $��Your Vaccine Details ��6   $
��Left=�6+   $��50��6F   $��Inter)�6R   $
��Bold"�6e   $��32(�6w   5�      � 5�       5�      �� 5�      $��* �6   �� 5�      $
��auto �6   �� 5�      $��* �6   .+�5�      �� $��1��6   $ Vertical=�6    $��20q�67   .+�5�      ��  �� TextAlignment$ Center=�6   $��Inter)�6(   $��Regular"�6;   $��18(�6P   $L��FAll documents displayed below have been approved by the administrator.��6^   6�   �� 5�      -   5        $��Edit and Upload Details��5�      $��Medium"�6/   $	��300��6C   
���   �
�������$��Roboto)�6v   $��34��6�   $��16(�6�    � UseLayoutRounding . $��0q�6�   $��0,20,0,0q�6�    5�      ��%c   '��       �� 5�      " ��6   .�5�   	   ��  �@��CornerRadius$	 8��6(   64   5�   	   5�      5�      5�      5�      � 5�      .+�5�      �� ���#FFCC00$	��450��6   
���   �$	��Top=�6:   $
��1074��6R   �� 5�      
�������$
��Left=�6   $	��385��67   
���   �$	��Top=�6S   $
��1005��6k   $��
195,34,0,0q�6x   � 5�      .+�5�      �� $
��Left=�6   $
��Wrap=�6+   $��COVID-19 Vaccine��6?   $��Medium"�6W   $	��Top=�6k   $��
210,49,0,0q�6�   $��Roboto)�6�   $��16(�6�   � 5�      .+�5�      �� $
��Left=�6   $��16��6(   $	��Top=�64   $	��100��6L   �� 5�      $
��Left=�6   $
��Wrap=�6,   $��1st Dose��6@   $	��Top=�6P   $��
225,87,0,0q�6h   �� 5�      $
��Left=�6   $
��Wrap=�6,   $��	TextBlock��6@   $	��Top=�6Q   $��250,108,0,0q�6i   $��Roboto)�6~   �� 5�      $��Button��6   $��80��6   $��1095,89,218.6,331.6q�6*   5�      5�      �� 5�      -   5        $��Generate Certificate��5�      $��Medium"�6+   $	��205��6?   ���#3A89FF
�������$��Roboto)�6t   $��34��6�   $��16(�6�    . $��0q�6�   $��590,355,598.6,60.6q�6�    5�      ��%c   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$	 8��6'   63   5�      5�      5�      5�      5�      5�      