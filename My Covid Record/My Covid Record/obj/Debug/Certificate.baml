   M S B A M L   `   `   `  ����J  FMy Covid Record, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:My_Covid_RecordMy_Covid_Record  5   	   !    My_Covid_Record.Certificate   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:My_Covid_Record     5   	     � Title$  Certificate��5   
    � WindowState$ 	Maximized=�6    � 	Resources 5
         RoundTextboxCornterTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property	 P� Value
 �� Value �� 
TargetName �� Property��%�  &	        �� 5   
   " ��6>   .R�5      �� $ Bd��5   
   #��z��5      
���   �#��z��5   
   $ 5��6>   ._�5      �� $ PART_ContentHost��6   5       5      P� 5       � {�	 .  . �5      �� #
 � ��63   $ Bd��6u    � ���� 5      #
 � ��63    � ��5      P� 5       � ��$
	 Auto��6+   . �5      ��  � ��$	
 100��61   5      P� 5       � ��$
	 Auto��6,   . �5      ��  � ��$
 20��62   5      5      5      .��5      �� .��5    
   �� $��20q�6   .+�5"      �  � ColumnDefinitions 5#      �� 5$      $��* �6'   �� 5%      $��* �6'   .+�5(      �� $
��Left=�6   $��60��63   $'��!/Resources/images/NZ Gov Logo.png��6?   �� 5)      $��1��6   $��Right=�6(   $��44��6D   $"��/Resources/images/NZ Gov.png��6P   5*      � 5-       5.      �� 5/      $��* �6'   �� 50      $
��auto �6'   �� 51      $��* �6'   .+�54      �� $��1��6    �� Orientation$ 
Horizontal=�6-   .+�55      �� $0��*/Resources/images/My Covid Record Logo.png��6   $	��100��6Q   �� 56      $��My Covid Record��6   $��Inter)�57      $
��Bold"�6%   $��80(�67   58      5:      � 5=      $��40q�6    5>      �� 5?      $��* �6'   �� 5@      $��* �6'   .+�5D      �� $ 
Horizontal=�6   .+�5E      �� -   5         ��Name$ 
HomeButton��5E       J� Opacity$ 0.995Q�61   $��0q�6A   
�������.��5F      �� $&�� /Resources/images/homeButton.png��6    5G      � 5I      $
��5,10q�6   $	��529��6)   .+�5J      �� #��[  6"   $��25(�6Z   $��50��6h   $	��512��6t   �� 5K      -   5        $ SearchButton��5K   !   $��0q�68   $��Right=�6L   
�������$��10,10,12,9.6q�6{   .��5L      �� $(��"/Resources/images/searchbutton.png��6$   $��38��6P   5M      5N      5O      �� 5R      $��2��6   $��74��61   $	��Top=�6=   .+�5S      �� -   5        $��btnShowPopup��5S      $��Account��61   $��Medium"�6C   $��Right=�6X   $	��Top=�6t   $	��105��6�   $��74��6�   $��25(�5T   ,   $��0q�6:   
�������$��Roboto)�6b   $��1��6v   $��0,0,0,0q�6�    5U       �� 
TargetType��%^   '��       �� 5V      " ��6$   .�5W   "   ��  �@��CornerRadius$
 8��6A   5X      5Y      5Z      � 5\      -   5         �Name$ myPopup��5\   M    � AllowsTransparency .  � HorizontalOffset$	 1cm��66   $��Relative=�5]       � 	StaysOpen . $��0q�5^       � PlacementTarget 5]   :   ��  �� ElementName$ btnShowPopup��.��5`      �� $	��304��6!   $	��301��6-   ._�5a      ]� ���#3A89FF��. $��0,0,0,-39.2q�6R   $��3��6h   $��1��6|    J� RenderTransformOrigin$ 0.522,0.549&�6�   $	��340��6�   $	��Top=�6�   z�5b   "   V� 5c   &   .~�5d   *   �� �� 5e   *    �� AngleX$ 0.268Q�68   �� 5f   *   T� 5g   *    T� X$ 0.873Q�6=   5h   '   .+�5j   "   � .+�5k   &   � .+�5l   *   �� ���#3A89FF
�������$	��Top=�6\   $��16(�5m   $   $��Center=�63   $��30,40,215,270q�5n   $   $��Account��6;   5o   '   � 5q   &   $��0,0,0,0q�6+   $	��116��6<   .+�5r   *   �� $��Personal Details��61   $��Center=�6M   
�������$��-57,100,-50,220q�6~   $	��223��6�   $��Inter)�6�   �� 5s   *   $��Generate QR Code��61   $��Center=�6M   
�������$��-57,125,-50,195q�6   $	��223��6�   �� 5t   *   $��Notifcations��61   $��Center=�6I   
�������$��-57,150,-50,170q�6{   $	��223��6�   �� 5u   *   $"��Generate Vaccine Certificate��61   $��Center=�6Z   
�������$��-57,175,-50,145q�6�   $	��223��6�   �� 5v   *   $��Report an Issue��61   $��Center=�6M   
�������$��-57,200,-50,121q�6~   $	��223��6�   �� 5w   *   $��Settings��61   $��Center=�6F   
�������$��-57,224,-50,97q�6w   $	��223��6�   5x   '   � 5z   &   .+�5{   *   �� -   5        $��Close��5{   M   $��17,255,248,44q�6]   $��Center=�5|   !   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.087,0.689&�6�   $��39��6�   �� 5~   *   -   5        $��Logout��5~   M   $��242,255,17,44q�6^   $��Center=�5   "   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.574,0.693&�6�   $��45��6�   $��Inter)�6�   5�   '   5�   #   5�      5�      5�      5�      5�      � 5�      .+�5�      �� $!��Your Covid-19 Certificate: ��6   $
��Left=�6>   $��50��5�      $��Inter)�6$   $
��Bold"�67   $��32(�6I   $��50,0,0,0q�6W   5�      � 5�      .+�5�      �� 
�������$��Center=�6)   $	��196��6F   
���   �$��Center=�5�   $   $	��987��6?   $��0,10,0,-11.2q�6K   $	 0.3Q�6a   � 5�      $��15q�6   .+�5�      �� ���#D9D9D9$	 0.4Q�6/   $
��Left=�6=   $	��677��6X   
���   �$	��Top=�6t   $
��1091��6�   $��140,10,0,-29.8q�6�   $��0��6�   �� 5�      
�������$
��Left=�6-   $	��640��6H   
���   �$	��Top=�6d   $
��1050��6|   $��165,29,0,-11.8q�6�   $��0��6�   �� 5�      .+�5�      � .+�5�      �� $	��Top=�6$   $��/Resources/images/NZ.png��6<   $��180,44,898.2,0q�6^   $��75��6v   5�      � 5�      .+�5�      �� $0��*/Resources/images/My Covid Record Logo.png��6$   $	��110��6X   $��	0,0,800,0q�6e   �� 5�      $!��My Covid Record Certificate��6(   $��	ExtraBold"�6K   $
��Wrap=�6b    �� TextAlignment$ Center=�6v   $��Center=�6�   $��Inter)�6�   $��48(�6�   5�      � 5�      $��25q�6   .+�5�      �� 
�������$��Center=�65   $	��196��6R   
���   �$��Center=�5�   $   $	��987��6?   $��0,10,0,-11.2q�6K   $	 0.3Q�6a   �� 5�      $��Center=�6)   .+�5�   "   � $��2,20,0,0q�6(   .+�5�   &   �� $��Personal Details��60   $��	ExtraBold"�6H   $
��Wrap=�6_   $
 Left=�6s   $��Inter)�6�   $��28(�6�   $��183,0,147.6,-1.2q�6�   5�   #   � 5�   "   .+�5�   &   � $��10,5,0,0q�6+   .+�5�   *   �� $@��:/Resources/images/QR_Placeholder_Code-removebg-preview.png��60   $	��130��6u   $��180,0,1003.6,0q�6�   5�   '   � 5�   &   .+�5�   *   � $��330,0,158.6,0.4q�6/   .+�5�   .   � .+�5�   2   �� $
��Name��6<   $��0,20,554.8,90.4q�6H   $��Roboto)�6a   $��Medium"�6u   $��20(�6�   5�   /   � 5�   .   .+�5�   2   �� $��Address��6<   $��Roboto)�6K   $��Medium"�6_   $��20(�6s   $��280,19,273.8,90.4q�6�   5�   /   � 5�   .   .+�5�   2   �� $��Certificate ID��6<   $��Roboto)�6R   $��Medium"�6f   $��20(�6z   $��559,19,-0.2,90.4q�6�   5�   /   5�   +   � 5�   *   .+�5�   .   � $��330,0,158.6,0.4q�63   .+�5�   2   � .+�5�   6   �� $��Date of Birth��6@   $��0,74,554.8,36.4q�6U   $��Roboto)�6n   $��Medium"�6�   $��20(�6�   5�   3   � 5�   2   .+�5�   6   �� $��Date Issued��6@   $��Roboto)�6S   $��Medium"�6g   $��20(�6{   $��280,74,273.8,35.4q�6�   5�   3   5�   /   5�   +   5�   '   5�   #   5�      5�      � 5�      $��
25,0,25,25q�6    .+�5�      �� 
�������$��Center=�68   $	��209��6U   $��1q�5�   !   
���   �$��Center=�5�   4   $	��987��6O   $��0,10,0,-11.2q�5�       $	 0.3Q�66   ._�5�   "   �� -   5        $��lvUsers��5�   7   $��10q�6+    �� View 5�   &   �� 5�   *   .P�5�   .   �� .��5�   2   �� $��Dose No.��6<   
���   �$
��Bold"�6_   $��11(�6q   $��70��6   5�   /   �� 5�   .   .��5�   2   �� $��Date of Vaccination��6<   
���   �$
��Bold"�6j   $��11(�6|   $	��120��6�   5�   /   �� 5�   .   .��5�   2   �� $��Vaccine��6<   
���   �$
��Bold"�6^   $��11(�6p   $��70��6~   5�   /   �� 5�   .   .��5�   2   �� $��Brand��6<   
���   �$
��Bold"�6\   $��11(�6n   $��70��6|   5�   /   �� 5�   .   .��5�   2   �� $��Country of Vaccination��6<   
���   �$
��Bold"�6m   $��11(�6   5�   /   5�   +   5�   #   5�      �� 5�      .+�5�   "   � 5�   #   � 5�   "    5�   &   �� 5�   *   $��* �6;   �� 5�   *   $��* �6;   �� 5�   *   $��* �6;   �� 5�   *   $��* �6;   �� 5�   *   $��* �6;    � RowDefinitions 5�   &   �� 5   *   5	  #   5
     5     5     5     5     � 5      5     �� 5     $��* �6'   �� 5     $
��auto �6'   �� 5     $��* �6'   .+�5     �� $
��0,20q�6   $ 
Horizontal=�6+   $��1��6D   .+�5     �� -   5        $��Edit Certificate��5     $��Medium"�68   $	��210��6L   $
��50,0q�5     ���#3A89FF
�������$��Roboto)�5  E   $��34��6Y   $��16(�6e   $��0q�6s    5     ��%c   '��       �� 5      " ��6$   .�5!  "   ��  �@��CornerRadius$
 8��6A   6M   5"     5#     5$     �� 5%     -	   5        $��Download Certificate��5%     $��Medium"�6<   $	��205��6P   ���#3A89FF$
��50,0q�5&     
�������$��Roboto)�5'  0   $��34��6D   $��16(�6P    � UseLayoutRounding . $��0q�5(      5)     ��%c   '��       �� 5*     " ��6$   .�5+  "   ��  �@��CornerRadius$
 8��6A   6M   5,     5-     5.     5/     51     53     54     57     