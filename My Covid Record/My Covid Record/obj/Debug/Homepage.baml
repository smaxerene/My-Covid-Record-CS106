   M S B A M L   `   `   `  ����J  FMy Covid Record, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:My_Covid_RecordMy_Covid_Record  5   	       My_Covid_Record.Homepage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:My_Covid_Record     5   	     � WindowState$  	Maximized=�5   	    � Title$ Homepage��5	   	   .��5
      �� .��5   
   �� $��20q�6   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $
��Left=�6   $��Center=�5      $��60��5      $'��!/Resources/images/NZ Gov Logo.png��5      �� 5      $��60��6   $��1��5      $��Right=�5      $��Center=�5      $"��/Resources/images/NZ Gov.png��5      5      � 5       5       �� 5!      $��* �6'   �� 5"      $
��auto �6'   �� 5#      $��* �6'   .+�5%      �� $0��*/Resources/images/My Covid Record Logo.png��5&      $	��120��5'      $��Right=�5(      �� 5+      $��My Covid Record��6   $��1��5,      $��1��6    $��Center=�5-      $��Inter)�5.      $
��30,0q�5/      $
��Bold"�50      $��70(�6#   52      �� 54      $��Welcome back��6   $��Center=�55      $��Inter)�56      $��20(�6#   �� 58      $
��60,0q�6   .+�59      �  5:      �� 5;      $��* �6+   �� 5<      $��* �6+   .+�5?      �� -   5         ��Name$ SearchTermTextBox��5@      $
��Left=�5?      $��30��69   $��Center=�6G   $	��253��5@   9   $��Inter)�6g   $��8,0,0,0q�5A      $��Center=�5B      �� 5E       J� IsHitTestVisible .  $��Enter Search Term Here��69   $��Center=�5F       $
��Left=�6;   $��Inter)�5G       $��10,0,0,0q�5H       
���������5I      �� 5J       �� 
TargetType" ��6$   .�5K   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?    �� Triggers 5L   "   �� 5M   &   	 �� Binding	 62   �� *Text+
 �� ElementName$
 SearchTermTextBox�� �� Value  6j   .a�5N   *   ��  � y�$ Visible=�6G   5O   '   5Q      5S      �� 5U      $��2��6!   $��74��65   $	��Top=�6A   .+�5V      �� -   5        $��btnShowPopup��5V   !   $��Account��65   $��Medium"�6G   $��Right=�6\   $	��Top=�6x   $	��105��6�   $��74��6�   $��25(�5W   ,   $��0q�6:   
�������$��Roboto)�6b   $��1��6v   $��0,0,0,0q�6�    � 	Resources 5X      ��%^   '��       �� 5Y   "   " ��6(   .�5Z   &   ��  �@��CornerRadius$ 8��6E   5[   #   5\      5]      � 5a      -   5         �Name$ myPopup��5a   Q    � AllowsTransparency .  � HorizontalOffset$	 1cm��6:   $��Relative=�5b       � 	StaysOpen . $��0q�5c       � PlacementTarget 5b   :   �� $
 btnShowPopup��.��5e      �� $	��304��6%   $	��301��61   ._�5f   "   ]� ���#3A89FF��. $��0,0,0,-39.2q�6V   $��3��6l   $��1��6�    J� RenderTransformOrigin$ 0.522,0.549&�6�   $	��340��6�   $	��Top=�6�   z�5g   &   V� 5h   *   .~�5i   .   �� �� 5j   .    �� AngleX$ 0.268Q�6<   �� 5k   .   T� 5l   .    T� X$ 0.873Q�6A   5m   +   .+�5o   &   � .+�5p   *   � .+�5q   .   �� ���#3A89FF
�������$	��Top=�6`   $��16(�5r   $   $��Center=�63   $��30,40,215,270q�5s   $   $��Account��6;   5t   +   � 5x   *   $��0,0,0,0q�6/   $	��116��6@   .+�5y   .   �� $��Personal Details��65   $��Center=�6Q   
�������$��-57,100,-50,220q�6�   $	��223��6�   $��Inter)�6�   �� 5z   .   $��Generate QR Code��65   $��Center=�6Q   
�������$��-57,125,-50,195q�6�   $	��223��6�   �� 5{   .   $��Notifcations��65   $��Center=�6M   
�������$��-57,150,-50,170q�6   $	��223��6�   �� 5|   .   $"��Generate Vaccine Certificate��65   $��Center=�6^   
�������$��-57,175,-50,145q�6�   $	��223��6�   �� 5}   .   $��Report an Issue��65   $��Center=�6Q   
�������$��-57,200,-50,121q�6�   $	��223��6�   �� 5~   .   $��Settings��65   $��Center=�6J   
�������$��-57,224,-50,97q�6{   $	��223��6�   5   +   � 5�   *   .+�5�   .   �� -   5        $��Close��5�   Q   $��17,255,248,44q�6a   $��Center=�5�   !   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.087,0.689&�6�   $��39��6�   �� 5�   .   -   5        $��Logout��5�   Q   $��242,255,17,44q�6b   $��Center=�5�   "   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.574,0.693&�6�   $��45��6�   $��Inter)�6�   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�      $
��60,0q�6   .+�5�      �  5�      �� 5�      $��* �6+   .+�5�      �� $X��R/Resources/images/COVID19_SouthAfrica_Hospital_2021_ChrisAllen_MSB56360_3800px.png��6   $��Center=�5�      $��0,30,0,0q�65   5�      5�      �� 5�      $
��60,0q�6   .+�5�      �  5�      �� 5�      $��* �6+   .+�5�      �� $��Your COVID Details:��6   $
��Left=�6:   $��1��5�      $��1��6(   $	��Top=�65   $��Inter)�5�      $��42��6+   $	��290��67   $��30(�5�      $
��Bold"�6&   $��0,50,0,0q�68   5�      5�      � 5�      $
��0,30q�6    5�      �� 5�      $��* �6'   �� 5�      $
��auto �6'   �� 5�      $��* �6'   .+�5�      �� $��87��5�      $	��292��6%   $��Center=�5�      $��Right=�5�      $��Inter)�5�      
�������$��10(�5�   ,   ��5�      �� 5�      .+�5�      �� $)��#/Resources/images/Overview Icon.png��6$   $��UniformToFill=�6Q   $��50��6i   $��40��6u   �� 5�      $��Overview��6$   5�       5�      ��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      5�      �� 5�      $��1��6   $��87��5�      $	��292��6%   $��Center=�5�      $��Center=�5�      $
��20,0q�5�      $��Inter)�5�      
�������$��10(�5�   ,   ��5�      �� 5�      .+�5�      �� $-��'/Resources/images/Appointments Icon.png��6$   $��UniformToFill=�6U   $��50��6m   $��40��6y   �� 5�      $��Appointments��6$   5�       5�      ��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      5�      �� 5�      $��2��6   $��87��5�      $	��292��6%   $��Center=�5�      $
��Left=�5�      $��Inter)�5�      
�������$��10(�5�   ,   ��5�      �� 5�      .+�5�      �� $0��*/Resources/images/Vaccine Details Icon.png��6$   $��UniformToFill=�6X   $��50��6p   $��50��6|   �� 5�      $��Vaccine Details��6$   5�       5�      ��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      5�      5�      � 5�      .+�5�      �� $��Why Covid Vaccine?��6   $
��Left=�5�      $��1��63   $��1��5�      $��90,0,0,0q�6%   $	��Top=�5�      $	��180��60   $��Inter)�5�      $��18(�6+   $
��Bold"�69   5�      � 5      .+�5     ��  �� Orientation$ 
Horizontal=�6   $��	105,0,0,0q�66   .+�5     �� $7��1/Resources/images/Shield_Pic-removebg-preview.png��6   $��40��6W   5     �� 5     $��Protect Yourself��6   $
��Left=�63   $��1��5	     $��1��6(   $��	150,0,0,0q�65   $	��Top=�5
     $	��151��60   $��Inter)�6<   $��15(�5     �� 5     $��Be immune to the disease��6   $
��Left=�5     $��1��63   $��1��5     $��
150,20,0,0q�6%   $	��Top=�5     $	��151��60   $��Inter)�5     ���	#FF8585856+   5     � 5     .+�5     �� $ 
Horizontal=�6   $��	105,0,0,0q�66   .+�5     �� $A��;/Resources/images/Hands_Together_Emoji-removebg-preview.png��6   $��30��6a   5     �� 5     $��Protect the Community��6   $
��Left=�68   $��1��5     $��1��6(   $��	150,0,0,0q�65   $	��Top=�5     $	��165��60   $��Inter)�6<   $��15(�5      �� 5"     $��Stop the spread of Covid��6   $
��Left=�5#     $��1��63   $��1��5$     $��
150,20,0,0q�6%   $	��Top=�5%     $	��151��60   $��Inter)�5&     ���	#FF8585856+   5(     � 5*     .+�5,     �� $ 
Horizontal=�6   $��	105,0,0,0q�66   .+�5-     �� $7��1/Resources/images/Sick_Emoji-removebg-preview.png��6   $��30��6W   50     �� 52     $��Reduce Symptoms��6   $
��Left=�62   $��1��53     $��1��6(   $��	150,0,0,0q�65   $	��Top=�54     $	��165��60   $��Inter)�6<   $��15(�55     �� 57     $ ��Experience milder symptoms��6   $
��Left=�58     $��1��63   $��1��59     $��
150,20,0,0q�6%   $	��Top=�5:     $	��151��60   $��Inter)�5;     ���	#FF8585856+   5=     � 5?     .+�5A     �� $��Vaccination Certificate��6   $��Center=�5B     $��1��65   $��1��5C     $	��Top=�6%   $	��187��6=   $��Inter)�5D     $��16(�6+   $��	500,0,0,0q�69   $
��Bold"�5E     �� 5G     $��Unique QR Code��6   $��Center=�61   $��1��5H     $��1��6(   $	��Top=�65   $	��187��5I     $��Inter)�6$   $��16(�67   $
��Bold"�5J     $��	0,0,500,0q�6*   5L     � 5N     .+�5P     �� -   5        $��Generate QR Code��5P     $��1��64   $��Center=�5Q     $��41��66   $��1��5R     $	��Top=�6&   $	��292��5S     $��Inter)�6=   
���   �$��17(�5T  ,   
�������$
��Bold"�5U  ,   $��
0,0,500,50q�5V     �� 5X     -   5        $"��Generate Vaccine Certificate��5X     $��1��6@   $��Center=�5Y     $��41��66   $��1��6B   $	��Top=�5Z     $	��292��61   $��Inter)�5[     
���   �$��17(�6?   
�������$
��Bold"�5\  ,   $��
500,0,0,50q�5]     5_     � 5a     $��
0,0,60,100q�6    5c     �� 5d     $
��auto �6'   �� 5e     $��* �6'   .+�5h     �� $'��!/Resources/images/Discussions.png��6   $	��300��6C   $
��Left=�5i     $��100,0q�63   $��0��6B   �� 5k     ���#3A89FF���#3A89FF$��1,1,1,1q�5l      �� CornerRadius$ 30,30,30,30��63    �� Padding$ 20,10,20,20q�5m     $��1��6/   $��0,0,0,0q�6?   ._�5o     �  5p     �� 5q     $
��auto �6/   �� 5r     $
��auto �6/   �� 5s     $��* �6/   �� 5t     $
��auto �6/   �� 5u     $
��auto �6/    � RowDefinitions 5w     �� 5x     $
��auto �6,   �� 5y     $��* �6,   .+�5}     �� $��0��6!   $��Top Comments��5~     $��20��5     $��90��6%   $��Center=�5�     $
��Left=�5�     $
��Bold"�5�     $��Inter)�5�     
�������$��10(�5�  ,    5�     ��%_   '��       �� 5�  "   " ��6(   .�5�  &   ��  �@��CornerRadius$ 10��6E   5�  #   5�     5�     �� 5�     $��0��6!   $��Newest Comments��5�     $��20��5�     $	��100��6%   $��Center=�5�     $
��Left=�5�     $
��Bold"�5�     $��	100,0,0,0q�6+   $��Inter)�5�     
�������$��10(�5�  ,    5�     ��%_   '��       �� 5�  "   " ��6(   .�5�  &   ��  �@��CornerRadius$ 10��6E   5�  #   5�     5�     �� 5�     $��Show comments��6    $��20(�68   $
��Bold"�6F   $��3��6X   �� 5�     $��2q�6!   $��50��65   $��22��5�  !   $��4��6-   $��10,0,0,0q�6=   $ 11��5�  !   
���   ���5�  !   �� *BackgroundValue+ �� UpdateSourceTrigger$ PropertyChanged=�._�5�     �� -   5        $��18��5�  %   $��18��61   ��5�  %   �� *HorizontalAlignmentValue+$ PropertyChanged=� 5�  "   ��%_   '��       �� 5�  &   " ��6,   .�5�  *   ��  �@��CornerRadius$ 23��6I   5�  '   5�  #   5�     5�     �� 5�     $��Stretch=�6#   $��1��6A   $��0��5�  #   $��5��63   ���#3A89FF���#3A89FF��5�     �� 5�  "   .R�5�  &   �� $ 
Horizontal=�61   5�  #   .@�5�     �� .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .    �� ImageSource$) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     5�     5�     5�     5�     � 5�     $��100,0q�6    5�     �� 5�     $��* �6'   �� 5�     $��* �6'    5�     �� 5�     �� 5�     �� 5�     �� 5�     �� 5�     �� 5�     .+�5�     �� ���#3A89FF���#3A89FF$��1,1,1,1q�6D   $ 30,30,30,30��6^   $ 20,10,20,20q�6y   ._�5      �� .+�5     �� $!��1/ What is My Covid Record?��6    $��20(�6F   $
��Bold"�6T   
�������6f   �� 5     $��14(�5  $   $
��Wrap=�62   
�������
�5     �� 5  "   $
��Bold"�6&   $�My��68   ., Covid Record is a secure and user-friendly �� 5  "   $
��Bold"�6&   $�NZ COVID��68   ca Vaccine Information System that allows you to effortlessly manage your test and vaccine records.5
     �� 5     $!��2/ Is My Covid Record safe?��6    $��20(�6F   $
��Bold"�6T   
�������6f   �� 5     $��14(�5  $   $
��Wrap=�62   
�������
�5     ��Absolutely! We prioritize your safety by ensuring a clean and secure browsing experience. We only have one non-intrusive ad to cover server costs, and we continuously monitor and scan ads 24/7 to remove any suspicious content.5     �� 5     $L��F3/ What makes My Covid Record the ultimate vaccine information system?��6    $��20(�6q   $
��Bold"�6   
�������6�   �� 5     $��14(�5  $   $
��Wrap=�62   
�������
�5     ��Before developing My Covid Record, we extensively researched existing systems and learned from their strengths and weaknesses. We carefully selected the best features and removed any shortcomings, resulting in a superior platform for managing your health records. Here's why we confidently claim to be the best vaccine information system:�� 5  "   �� 5   "   �� 5!  "   $
��Bold"�6&   $�Safety��68   �� : Our top priority is to provide a safe browsing experience, free from harmful content. Comprehensive Content: My Covid Record focuses exclusively on health records, offering a wide range of COVID-19 test and vaccine information. You'll find comprehensive records across various categories, ensuring all your health-related data is in one place.�� 5%  "   �� 5&  "   �� 5'  "   $
��Bold"�6&   $�Quality and Accuracy��68   �� : We ensure that all records are of the highest quality and accuracy. My Covid Record allows you to view and download your certificates in the best resolution available, ensuring clarity and readability.�� 5*  "   �� 5+  "   �� 5,  "   $
��Bold"�6&   $ �Effortless User Experience��68   �� : Compared to other systems, My Covid Record offers faster loading speeds and a seamless streaming experience. You can easily access and download your records for offline use, making it convenient for reference or travel requirements.�� 5/  "   �� 50  "   �� 51  "   $
��Bold"�6&   $�Regular Updates��68   �� : We regularly update our database with the latest test results and vaccine information, ensuring you always have the most up-to-date records at your fingertips.�� 53  "   �� 54  "   �� 55  "   $
��Bold"�6&   $�User-Friendly Interface��68   �� : Our intuitive UI and UX design make navigating My Covid Record a breeze for users of all backgrounds. Whether you're searching for specific records or exploring categories, our site is designed to be user-friendly and accessible.�� 58  "   �� 59  "   �� 5:  "   $
��Bold"�6&   $�Compatibility��68   �� : My Covid Record is optimized for both desktop and mobile devices, allowing you to access your health records anytime, anywhere.�� 5<  "   �� 5=  "   �� 5>  "   $
��Bold"�6&   $ �Dedicated Customer Support��68   �� : Our customer support team is available 24/7 to assist you with any inquiries, concerns, or technical issues. We pride ourselves on providing exceptional support to ensure a smooth and satisfactory user experience. If you're seeking a reliable and secure vaccine information system, we invite you to experience VaxTrackNZ. Help us spread the word and bookmark our site to stay connected with the latest health updates.5E     �� 5G     $9��34/ Can't access My Covid Record? Here's what to do:��6    $��20(�6^   $
��Bold"�6l   
�������6~   �� 5I     $��14(�5J  $   $
��Wrap=�62   
�������
�5K     ��If your ISP has blocked the My Covid Record.to domain, you can still access My Covid Record through our Proxy sites network. Simply visit https://VaxTrackNZ.net for uninterrupted access. We continuously update the list of domains, so be sure to bookmark My Covid Record.net to stay informed.�� 5P  "   �� 5Q  "   �~Thank you for choosing My Covid Record, and please help us spread the word by bookmarking our site and sharing it with others.5T     5V     5W     �� 5Y     $ 
Horizontal=�6   $��0,50,0,0q�66   $��1��6H   .+�5Z     �� $A��;/Resources/images/Custom_COVID-19_Logo-removebg-preview.png��6   $	��120��5[     $
��Left=�6%   �� 5]     $��9(�6    $
��Bold"�6-   $��Center=�6?   $	��5,0q�6Z   Join�� 5_     Now5a     �� 5c     $:��4/Resources/images/FaceBook_Icon-removebg-preview.png��6   $��30��5d     $��Center=�6(   $	��5,0q�6C   �� 5f     $9��3/Resources/images/Twitter_Icon-removebg-preview.png��6   $��30��5g     $��Center=�6(   $	��5,0q�6C   �� 5i     $7��1/Resources/images/Redit_Icon-removebg-preview.png��6   $��30��5j     $��Center=�6(   $	��5,0q�6C   �� 5l     $<��6/Resources/images/Paperplane_Icon-removebg-preview.png��6   $��30��5m     $��Center=�6(   $	��5,0q�6C   5o     �� 5r     $��1��6   $��0��6-   .+�5s     �� $#��/Resources/images/Doctors.png��6   $	��200��6C   $��Center=�5t     $��Center=�65   �� 5w     $��Trending Posts��6   $
��Left=�65   $��2��5x     $��1��6(   $��
50,20,0,10q�65   $��Center=�5y     $��Inter)�63   $��26(�5z     $
��Bold"�6&   �� 5}     ���#E4E4E4���#E4E4E4$��1,1,1,1q�6H   $ 30,30,30,30��5~     $ 20,10,20,20q�64   $��2��6J   $��2��6Z   $��100,0,100,20q�5     ._�5�     �� .+�5�     �� $ 
Horizontal=�6)   .+�5�  "   �� $3��-/Resources/images/Ministry of Health Icon.png��6(   $��40��6_   � 5�  "   $��10,0,0,0q�6'    5�  &   �� 5�  *   $��2* �68   �� 5�  *   $��3* �68   .+�5�  &   �� $��Ministry of Health��6,   $��22(�6I   $
��Bold"�6W   $��0q�6i   �� 5�  &   $��1��60   $��7(�5�  (   $
��Wrap=�65   
�5�  *   kiClick here: https://covid19.govt.nz/news-and-data/latest-news/covid-19-media-conference-23-february-2023/5�  '   5�  #   5�     �� 5�     $4��.COVID-19 media conference — 23 February 2023��6$   $��20(�6[   $
��Bold"�6i   �� 5�     $��12(�5�  $   $
��Wrap=�62   
�5�  "   23 Feb 20235�     �� 5�     $��10(�5�  $   $
��Wrap=�62   
�5�  "   ��The Government is reiterating advice to international travellers to test if they have COVID-19 symptoms when they arrive and to take free RATs at the airport.5�     5�     5�     �� 5�     ���#E4E4E4���#E4E4E4$��1,1,1,1q�6H   $ 30,30,30,30��5�     $ 20,10,20,20q�64   $��2��6J   $��3��6Z   $��100,0,100,20q�5�     ._�5�     �� .+�5�     �� $ 
Horizontal=�6)   .+�5�  "   �� $3��-/Resources/images/Ministry of Health Icon.png��6(   $��40��6_   � 5�  "   $��10,0,0,0q�6'    5�  &   �� 5�  *   $��2* �68   �� 5�  *   $��3* �68   .+�5�  &   �� $��Ministry of Health��6,   $��22(�6I   $
��Bold"�6W   $��0q�6i   �� 5�  &   $��1��60   $��7(�5�  (   $
��Wrap=�65   
�5�  *   }Click here: https://covid19.govt.nz/news-and-data/latest-news/government-reminds-international-arrivals-to-test-for-covid-19/5�  '   5�  #   5�     �� 5�     $)��#New booster plan in time for winter��6$   $��20(�6R   $
��Bold"�6`   �� 5�     $��12(�5�  $   $
��Wrap=�62   
�5�  "   23 Feb 20235�     �� 5�     $��10(�5�  $   $
��Wrap=�62   
�5�  "   ECWatch the COVID-19 bivalent vaccine rollout announcement. Speakers:�� 5�  &   �� 5�  &   $��10,0,0,0q�66    �� Bullet 5�  *   A� 5�  .   $��5��66   $��5��6A   
���   �6K   5�  '   %# Minister of Health Ayesha Verrall.5�     5�     5�     �� 5�     ���#E4E4E4���#E4E4E4$��1,1,1,1q�6H   $ 30,30,30,30��5�     $ 20,10,20,20q�64   $��2��6J   $��4��6Z   $��100,0,100,20q�5�     ._�5�     �� .+�5�     �� $ 
Horizontal=�6)   .+�5�  "   �� $3��-/Resources/images/Ministry of Health Icon.png��6(   $��40��6_   � 5�  "   $��10,0,0,0q�6'    5�  &   �� 5�  *   $��2* �68   �� 5�  *   $��3* �68   .+�5�  &   �� $��Ministry of Health��6,   $��22(�6I   $
��Bold"�6W   $��0q�6i   �� 5�  &   $��1��60   $��7(�5�  (   $
��Wrap=�65   
�5�  *   }Click here: https://covid19.govt.nz/news-and-data/latest-news/government-reminds-international-arrivals-to-test-for-covid-19/5�  '   5�  #   5�     �� 5�     $D��>Government reminds international arrivals to test for COVID-19��6$   $��20(�6m   $
��Bold"�6{   �� 5�     $��12(�5�  $   $
��Wrap=�62   
�5�  "   23 Feb 20235�     �� 5�     $��10(�5�  $   $
��Wrap=�62   
�5�  "   ��The Government is reiterating advice to international travellers to test if they have COVID-19 symptoms when they arrive and to take free RATs at the airport.5�     5      5     �� 5     $��50��6   $	��500��6)   $��Center=�5     $��Center=�5     $
��40,0q�5     $��Inter)�5     ���#3A89FF$��25(�5  .   ���#3A89FF��5	     �� 5
     .+�5  "   �� $��	Read more��6(   
�������6<   5      5     ��%_   '��       �� 5     " ��6$   .�5  "   ��  �@��CornerRadius$ 25��6A   5     5     5     5     5     5     5     5     