   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5          WpfApp1.Views.Homepage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5        N� Title$  Homepage��5      .��5
      �� .��5   
   �� $��20q�6   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $
��Left=�6   $��Center=�5      $��60��5      $'��!/Resources/images/NZ Gov Logo.png��5      �� 5      $��60��6   $��1��5      $��Right=�5      $��Center=�5      $"��/Resources/images/NZ Gov.png��5      5      � 5       5       �� 5!      $
��829* �6'   �� 5"      $
��auto �6'   �� 5#      $
��776* �6'   �� 5$      $	��53* �6'   .+�5&      �� $0��*/Resources/images/My Covid Record Logo.png��5'      $	��120��5(      $��Right=�5)      $��	0,0,0.4,0q�6-   �� 5,      $��My Covid Record��6   $��1��5-      $��Center=�5.      $��Inter)�5/      $��29.6,13,30,13q�50      $
��Bold"�51      $��70(�6#   53      �� 55      $��Welcome back��6   $��Center=�56      $��Inter)�57      $��20(�6#   �� 59      $
��60,0q�6   .+�5:      �  5;      �� 5<      $��* �6+   �� 5=      $��* �6+   .+�5@      �� -   5         ��Name$ SearchTermTextBox��5A      $
��Left=�5@      $��30��69   $��Center=�6G   $	��253��5A   9   $��Inter)�6g   $��8,0,0,0q�5B      $��Center=�5C      �� 5F       J� IsHitTestVisible .  $��Enter Search Term Here��69   $��Center=�5G       $
��Left=�6;   $��Inter)�5H       $��10,0,0,0q�5I       
���������5J      �� 5K       �� 
TargetType" ��6$   .�5L   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?    �� Triggers 5M   "   �� 5N   &    �� Binding 62   �� *Text+	 �� ElementName$	 SearchTermTextBox��
 �� Value
  6j   .a�5O   *   ��  � y�$ Visible=�6G   5P   '   5R      5T      �� 5V      $��2��6!   $��74��65   $	��Top=�6A   .+�5W      �� -   5        $��btnShowPopup��5W   !   $��Account��65   $��Medium"�6G   $��Right=�6[   $	��Top=�6w   $	��105��6�   $��74��6�   $��25(�5X   ,   $��0q�6:   
�������$��Roboto)�6b   $��1��6v   $��0,0,0,0q�6�    � 	Resources 5Y      ��%^   '��       �� 5Z   "   " ��6(   .�5[   &   ��  �@��CornerRadius$ 8��6E   5\   #   5]      5^      � 5b      -   5         �Name$ myPopup��5b   Q    � AllowsTransparency .  � HorizontalOffset$	 1cm��6:   $��Relative=�5c       � 	StaysOpen . $��0q�5d       � PlacementTarget 5c   :   �� $	 btnShowPopup��.��5f      �� $	��304��6%   $	��301��61   ._�5g   "   ]� ���#3A89FF��. $��0,0,0,-39.2q�6V   $��3��6l   $��1��6�    J� RenderTransformOrigin$ 0.522,0.549&�6�   $	��340��6�   $	��Top=�6�   z�5h   &   V� 5i   *   .~�5j   .   �� �� 5k   .    �� AngleX$ 0.268Q�6<   �� 5l   .   T� 5m   .    T� X$ 0.873Q�6A   5n   +   .+�5p   &   � .+�5q   *   � .+�5r   .   �� ���#3A89FF
�������$	��Top=�6`   $��16(�5s   $   $��Center=�63   $��30,40,215,270q�5t   $   $��Account��6;   5u   +   � 5w   *   $��0,0,0,0q�6/   $	��116��6@   .+�5x   .   �� -   5        $��Personal Details��5x   5   $��Center=�6l   
�������$��-57,100,-50,220q�6�   $	��223��6�   $��Inter)�6�   �� 5y   .   -   5        $��Generate QR Code��5y   5   $��Center=�6i   
�������$��-57,125,-50,195q�6�   $	��223��6�   �� 5z   .   -   5        $"��Generate Vaccine Certificate��5z   5   $��Center=�6v   
�������$��-57,150,-50,170q�6�   $	��223��6�   �� 5{   .   -   5        $��Vaccine Details��5{   5   $��Center=�6c   
�������$��-57,175,-50,145q�6�   $	��223��6�   �� 5|   .   -   5        $��Report an Issue��5|   5   $��Center=�6d   
�������$��-57,200,-50,121q�6�   $	��223��6�   �� 5}   .   -	   5        $��Settings��5}   5   $��Center=�6`   
�������$��-57,224,-50,97q�6�   $	��223��6�   5~   +   � 5�   *   .+�5�   .   �� -
   5        $��Close��5�   Q   $��17,255,248,44q�6a   $��Center=�5�   !   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.087,0.689&�6�   $��39��6�   �� 5�   .   -   5        $��Logout��5�   5   $��242,255,17,44q�6[   $��Center=�5�   "   $��0q�6?   ���#3A89FF
�������$��23��6{   $ 0.574,0.693&�6�   $��45��6�   $��Inter)�6�   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�      $
��60,0q�6   .+�5�      �  5�      �� 5�      $��* �6+   .+�5�      �� $X��R/Resources/images/COVID19_SouthAfrica_Hospital_2021_ChrisAllen_MSB56360_3800px.png��6   $��Center=�5�      $��0,30,0,0q�65   5�      5�      �� 5�      $
��60,0q�6   .+�5�      �  5�      �� 5�      $��* �6+   .+�5�      �� $��Your COVID Details:��6   $
��Left=�6:   $��1��5�      $��1��6(   $	��Top=�65   $��Inter)�5�      $��42��6+   $	��290��67   $��30(�5�      $
��Bold"�6&   $��0,50,0,0q�68   5�      5�      � 5�      $
��0,30q�6    5�      �� 5�      $��* �6'   �� 5�      $
��auto �6'   �� 5�      $��* �6'   .+�5�      �� -   5        $��87��5�      $	��292��6%   $��Center=�5�      $��Right=�5�      $��Inter)�5�   .   
�������$��10(�5�   ,   ��5�      �� 5�      .+�5�      �� $)��#/Resources/images/Overview Icon.png��6$   $��UniformToFill=�6Q   $��50��6i   $��40��6u   �� 5�      $��Overview��6$   5�       5�      ��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      5�      �� 5�      -   5        $��1��5�      $��87��5�      $	��292��6%   $��Center=�5�      $��Center=�5�      $
��20,0q�5�      $��Inter)�5�   .   
�������$��10(�5�   ,   ��5�      �� 5�      .+�5�      �� $-��'/Resources/images/Appointments Icon.png��6$   $��UniformToFill=�6U   $��50��6m   $��40��6y   �� 5�      $��Appointments��6$   5�       5�      ��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      5�      �� 5�      -   5        $��2��5�      $��87��5�      $	��292��6%   $��Center=�5�      $
��Left=�5�      $��Inter)�5�   -   
�������$��10(�5�   ,   ��5�      �� 5�      .+�5�      �� $0��*/Resources/images/Vaccine Details Icon.png��6$   $��UniformToFill=�6X   $��50��6p   $��50��6|   �� 5�      $��Vaccine Details��6$   5�       5�      ��%_   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 10��6=   5�      5�      5�      5�      � 5�      .+�5�      �� $��Why Covid Vaccine?��6   $
��Left=�5�      $��1��63   $��1��5�      $��90,0,0,0q�6%   $	��Top=�5�      $	��180��60   $��Inter)�5�      $��18(�6+   $
��Bold"�69   5�      � 5�      .+�5�      ��  �� Orientation$ 
Horizontal=�6   $��	105,0,0,0q�66   .+�5�      �� $7��1/Resources/images/Shield_Pic-removebg-preview.png��6   $��40��6W   5�      �� 5     $��Protect Yourself��6   $
��Left=�63   $��1��5     $��1��6(   $��	150,0,0,0q�65   $	��Top=�5     $	��151��60   $��Inter)�6<   $��15(�5     �� 5     $��Be immune to the disease��6   $
��Left=�5     $��1��63   $��1��5     $��
150,20,0,0q�6%   $	��Top=�5	     $	��151��60   $��Inter)�5
     ���	#FF8585856+   5     � 5     .+�5     �� $ 
Horizontal=�6   $��	105,0,0,0q�66   .+�5     �� $A��;/Resources/images/Hands_Together_Emoji-removebg-preview.png��6   $��30��6a   5     �� 5     $��Protect the Community��6   $
��Left=�68   $��1��5     $��1��6(   $��	150,0,0,0q�65   $	��Top=�5     $	��165��60   $��Inter)�6<   $��15(�5     �� 5     $��Stop the spread of Covid��6   $
��Left=�5     $��1��63   $��1��5     $��
150,20,0,0q�6%   $	��Top=�5     $	��151��60   $��Inter)�5     ���	#FF8585856+   5!     � 5#     .+�5%     �� $ 
Horizontal=�6   $��	105,0,0,0q�66   .+�5&     �� $7��1/Resources/images/Sick_Emoji-removebg-preview.png��6   $��30��6W   5)     �� 5+     $��Reduce Symptoms��6   $
��Left=�62   $��1��5,     $��1��6(   $��	150,0,0,0q�65   $	��Top=�5-     $	��165��60   $��Inter)�6<   $��15(�5.     �� 50     $ ��Experience milder symptoms��6   $
��Left=�51     $��1��63   $��1��52     $��
150,20,0,0q�6%   $	��Top=�53     $	��151��60   $��Inter)�54     ���	#FF8585856+   56     � 58     .+�5:     �� $��Vaccination Certificate��6   $��Center=�5;     $��1��65   $��1��5<     $	��Top=�6%   $	��187��6=   $��Inter)�5=     $��16(�6+   $��	500,0,0,0q�69   $
��Bold"�5>     �� 5@     $��Unique QR Code��6   $��Center=�61   $��1��5A     $��1��6(   $	��Top=�65   $	��187��5B     $��Inter)�6$   $��16(�67   $
��Bold"�5C     $��	0,0,500,0q�6*   5E     � 5G     .+�5I     �� -   5        $��Generate QR Code��5I     $��1��6M   $��Center=�5J     $��41��66   $��1��5K     $	��Top=�6&   $	��292��5L     $��Inter)�6%   
���   �$��17(�5M  ,   
�������$
��Bold"�5N  ,   $��
0,0,500,50q�5O     �� 5Q     -   5        $"��Generate Vaccine Certificate��5Q     $��1��6@   $��Center=�5R     $��41��66   $��1��6B   $	��Top=�5S     $	��292��61   $��Inter)�5T     
���   �$��17(�6?   
�������$
��Bold"�5U  ,   $��
500,0,0,50q�5V     5X     � 5Z     $��
0,0,60,100q�6    5\     �� 5]     $
��auto �6'   �� 5^     $��* �6'   .+�5a     �� $'��!/Resources/images/Discussions.png��6   $	��300��6C   $
��Left=�5b     $��100,0q�63   $��0��6B   �� 5d     ���#3A89FF���#3A89FF$��1,1,1,1q�5e      �� CornerRadius$ 30,30,30,30��63    �� Padding$ 20,10,20,20q�5f     $��1��6/   $��0,0,0,0q�6?   ._�5h     �  5i     �� 5j     $
��auto �6/   �� 5k     $
��auto �6/   �� 5l     $��* �6/   �� 5m     $
��auto �6/   �� 5n     $
��auto �6/    � RowDefinitions 5p     �� 5q     $
��auto �6,   �� 5r     $��* �6,   .+�5v     �� -   5        $��0��5v  !   $��Top Comments��5w     $��20��5x     $��90��6%   $��Center=�5y     $
��Left=�5z     $
��Bold"�5{     $��Inter)�5|  .   
�������$��10(�5}  ,    5     ��%_   '��       �� 5�  "   " ��6(   .�5�  &   ��  �@��CornerRadius$ 10��6E   5�  #   5�     5�     �� 5�     -   5        $��0��5�  !   $��Newest Comments��5�     $��20��5�     $	��100��6%   $��Center=�5�     $
��Left=�5�     $
��Bold"�5�     $��	100,0,0,0q�6+   $��Inter)�5�  .   
�������$��10(�5�  ,    5�     ��%_   '��       �� 5�  "   " ��6(   .�5�  &   ��  �@��CornerRadius$ 10��6E   5�  #   5�     5�     �� 5�     $��Show comments��6    $��20(�68   $
��Bold"�6F   $��3��6X   �� 5�     $��2q�6!   $��50��65   $��22��5�  !   $��4��6-   $��10,0,0,0q�6=   $ 11��5�  !   
���   ���5�  !   �� *BackgroundValue+ �� UpdateSourceTrigger$ PropertyChanged=�._�5�     �� -   5        $��18��5�  %   $��18��61   ��5�  %   �� *HorizontalAlignmentValue+$ PropertyChanged=� 5�  "   ��%_   '��       �� 5�  &   " ��6,   .�5�  *   ��  �@��CornerRadius$ 23��6I   5�  '   5�  #   5�     5�     �� 5�     $��Stretch=�6#   $��1��6A   $��0��5�  #   $��5��63   ���#3A89FF���#3A89FF��5�     �� 5�  "   .R�5�  &   �� $ 
Horizontal=�61   5�  #   .@�5�     �� .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .    �� ImageSource$) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     �� 5�     .��5�  "   �� .+�5�  &   �� $	��330��60   $	��200��6<   ��5�  *   �� 5�  .   $) #/Resources/images/Comment Image.png��69   5�  '   5�  #   5�     5�     5�     5�     5�     � 5�     $��100,0q�6    5�     �� 5�     $��* �6'   �� 5�     $��* �6'    5�     �� 5�     �� 5�     �� 5�     �� 5�     �� 5�     �� 5�     .+�5�     �� ���#3A89FF���#3A89FF$��1,1,1,1q�6D   $ 30,30,30,30��6^   $ 20,10,20,20q�6y   ._�5�     �� .+�5�     �� $!��1/ What is My Covid Record?��6    $��20(�6F   $
��Bold"�6T   
�������6f   �� 5�     $��14(�5�  $   $
��Wrap=�62   
�������
�5�     �� 5   "   $
��Bold"�6&   $�My��68   ., Covid Record is a secure and user-friendly �� 5  "   $
��Bold"�6&   $�NZ COVID��68   ca Vaccine Information System that allows you to effortlessly manage your test and vaccine records.5     �� 5     $!��2/ Is My Covid Record safe?��6    $��20(�6F   $
��Bold"�6T   
�������6f   �� 5     $��14(�5  $   $
��Wrap=�62   
�������
�5	     ��Absolutely! We prioritize your safety by ensuring a clean and secure browsing experience. We only have one non-intrusive ad to cover server costs, and we continuously monitor and scan ads 24/7 to remove any suspicious content.5     �� 5     $L��F3/ What makes My Covid Record the ultimate vaccine information system?��6    $��20(�6q   $
��Bold"�6   
�������6�   �� 5     $��14(�5  $   $
��Wrap=�62   
�������
�5     ��Before developing My Covid Record, we extensively researched existing systems and learned from their strengths and weaknesses. We carefully selected the best features and removed any shortcomings, resulting in a superior platform for managing your health records. Here's why we confidently claim to be the best vaccine information system:�� 5  "   �� 5  "   �� 5  "   $
��Bold"�6&   $�Safety��68   �� : Our top priority is to provide a safe browsing experience, free from harmful content. Comprehensive Content: My Covid Record focuses exclusively on health records, offering a wide range of COVID-19 test and vaccine information. You'll find comprehensive records across various categories, ensuring all your health-related data is in one place.�� 5  "   �� 5  "   �� 5   "   $
��Bold"�6&   $�Quality and Accuracy��68   �� : We ensure that all records are of the highest quality and accuracy. My Covid Record allows you to view and download your certificates in the best resolution available, ensuring clarity and readability.�� 5#  "   �� 5$  "   �� 5%  "   $
��Bold"�6&   $ �Effortless User Experience��68   �� : Compared to other systems, My Covid Record offers faster loading speeds and a seamless streaming experience. You can easily access and download your records for offline use, making it convenient for reference or travel requirements.�� 5(  "   �� 5)  "   �� 5*  "   $
��Bold"�6&   $�Regular Updates��68   �� : We regularly update our database with the latest test results and vaccine information, ensuring you always have the most up-to-date records at your fingertips.�� 5,  "   �� 5-  "   �� 5.  "   $
��Bold"�6&   $�User-Friendly Interface��68   �� : Our intuitive UI and UX design make navigating My Covid Record a breeze for users of all backgrounds. Whether you're searching for specific records or exploring categories, our site is designed to be user-friendly and accessible.�� 51  "   �� 52  "   �� 53  "   $
��Bold"�6&   $�Compatibility��68   �� : My Covid Record is optimized for both desktop and mobile devices, allowing you to access your health records anytime, anywhere.�� 55  "   �� 56  "   �� 57  "   $
��Bold"�6&   $ �Dedicated Customer Support��68   �� : Our customer support team is available 24/7 to assist you with any inquiries, concerns, or technical issues. We pride ourselves on providing exceptional support to ensure a smooth and satisfactory user experience. If you're seeking a reliable and secure vaccine information system, we invite you to experience VaxTrackNZ. Help us spread the word and bookmark our site to stay connected with the latest health updates.5>     �� 5@     $9��34/ Can't access My Covid Record? Here's what to do:��6    $��20(�6^   $
��Bold"�6l   
�������6~   �� 5B     $��14(�5C  $   $
��Wrap=�62   
�������
�5D     ��If your ISP has blocked the My Covid Record.to domain, you can still access My Covid Record through our Proxy sites network. Simply visit https://VaxTrackNZ.net for uninterrupted access. We continuously update the list of domains, so be sure to bookmark My Covid Record.net to stay informed.�� 5I  "   �� 5J  "   �~Thank you for choosing My Covid Record, and please help us spread the word by bookmarking our site and sharing it with others.5M     5O     5P     �� 5R     $ 
Horizontal=�6   $��0,50,0,0q�66   $��1��6H   .+�5S     �� $A��;/Resources/images/Custom_COVID-19_Logo-removebg-preview.png��6   $	��120��5T     $
��Left=�6%   �� 5V     $��9(�6    $
��Bold"�6-   $��Center=�6?   $	��5,0q�6Z   Join�� 5X     Now5Z     �� 5\     $:��4/Resources/images/FaceBook_Icon-removebg-preview.png��6   $��30��5]     $��Center=�6(   $	��5,0q�6C   �� 5_     $9��3/Resources/images/Twitter_Icon-removebg-preview.png��6   $��30��5`     $��Center=�6(   $	��5,0q�6C   �� 5b     $7��1/Resources/images/Redit_Icon-removebg-preview.png��6   $��30��5c     $��Center=�6(   $	��5,0q�6C   �� 5e     $<��6/Resources/images/Paperplane_Icon-removebg-preview.png��6   $��30��5f     $��Center=�6(   $	��5,0q�6C   5h     �� 5k     $��1��6   $��0��6-   .+�5l     �� $#��/Resources/images/Doctors.png��6   $	��200��6C   $��Center=�5m     $��Center=�65   �� 5p     $��Trending Posts��6   $
��Left=�65   $��2��5q     $��1��6(   $��
50,20,0,10q�65   $��Center=�5r     $��Inter)�63   $��26(�5s     $
��Bold"�6&   �� 5v     ���#E4E4E4���#E4E4E4$��1,1,1,1q�6H   $ 30,30,30,30��5w     $ 20,10,20,20q�64   $��2��6J   $��2��6Z   $��100,0,100,20q�5x     ._�5y     �� .+�5z     �� $ 
Horizontal=�6)   .+�5{  "   �� $3��-/Resources/images/Ministry of Health Icon.png��6(   $��40��6_   � 5}  "   $��10,0,0,0q�6'    5~  &   �� 5  *   $��2* �68   �� 5�  *   $��3* �68   .+�5�  &   �� $��Ministry of Health��6,   $��22(�6I   $
��Bold"�6W   $��0q�6i   �� 5�  &   $��1��60   $��7(�5�  (   $
��Wrap=�65   
�5�  *   kiClick here: https://covid19.govt.nz/news-and-data/latest-news/covid-19-media-conference-23-february-2023/5�  '   5�  #   5�     �� 5�     $4��.COVID-19 media conference — 23 February 2023��6$   $��20(�6[   $
��Bold"�6i   �� 5�     $��12(�5�  $   $
��Wrap=�62   
�5�  "   23 Feb 20235�     �� 5�     $��10(�5�  $   $
��Wrap=�62   
�5�  "   ��The Government is reiterating advice to international travellers to test if they have COVID-19 symptoms when they arrive and to take free RATs at the airport.5�     5�     5�     �� 5�     ���#E4E4E4���#E4E4E4$��1,1,1,1q�6H   $ 30,30,30,30��5�     $ 20,10,20,20q�64   $��2��6J   $��3��6Z   $��100,0,100,20q�5�     ._�5�     �� .+�5�     �� $ 
Horizontal=�6)   .+�5�  "   �� $3��-/Resources/images/Ministry of Health Icon.png��6(   $��40��6_   � 5�  "   $��10,0,0,0q�6'    5�  &   �� 5�  *   $��2* �68   �� 5�  *   $��3* �68   .+�5�  &   �� $��Ministry of Health��6,   $��22(�6I   $
��Bold"�6W   $��0q�6i   �� 5�  &   $��1��60   $��7(�5�  (   $
��Wrap=�65   
�5�  *   }Click here: https://covid19.govt.nz/news-and-data/latest-news/government-reminds-international-arrivals-to-test-for-covid-19/5�  '   5�  #   5�     �� 5�     $)��#New booster plan in time for winter��6$   $��20(�6R   $
��Bold"�6`   �� 5�     $��12(�5�  $   $
��Wrap=�62   
�5�  "   23 Feb 20235�     �� 5�     $��10(�5�  $   $
��Wrap=�62   
�5�  "   ECWatch the COVID-19 bivalent vaccine rollout announcement. Speakers:�� 5�  &   �� 5�  &   $��10,0,0,0q�66    �� Bullet 5�  *   A� 5�  .   $��5��66   $��5��6A   
���   �6K   5�  '   %# Minister of Health Ayesha Verrall.5�     5�     5�     �� 5�     ���#E4E4E4���#E4E4E4$��1,1,1,1q�6H   $ 30,30,30,30��5�     $ 20,10,20,20q�64   $��2��6J   $��4��6Z   $��100,0,100,20q�5�     ._�5�     �� .+�5�     �� $ 
Horizontal=�6)   .+�5�  "   �� $3��-/Resources/images/Ministry of Health Icon.png��6(   $��40��6_   � 5�  "   $��10,0,0,0q�6'    5�  &   �� 5�  *   $��2* �68   �� 5�  *   $��3* �68   .+�5�  &   �� $��Ministry of Health��6,   $��22(�6I   $
��Bold"�6W   $��0q�6i   �� 5�  &   $��1��60   $��7(�5�  (   $
��Wrap=�65   
�5�  *   }Click here: https://covid19.govt.nz/news-and-data/latest-news/government-reminds-international-arrivals-to-test-for-covid-19/5�  '   5�  #   5�     �� 5�     $D��>Government reminds international arrivals to test for COVID-19��6$   $��20(�6m   $
��Bold"�6{   �� 5�     $��12(�5�  $   $
��Wrap=�62   
�5�  "   23 Feb 20235�     �� 5�     $��10(�5�  $   $
��Wrap=�62   
�5�  "   ��The Government is reiterating advice to international travellers to test if they have COVID-19 symptoms when they arrive and to take free RATs at the airport.5�     5�     5�     �� 5�     -   5        $��50��5�     $	��500��6)   $��Center=�5�     $��Center=�5�     $
��40,0q�5�     $��Inter)�5   .   ���#3A89FF$��25(�5  .   ���#3A89FF��5     �� 5     .+�5  "   �� $��	Read more��6(   
�������6<   5      5     ��%_   '��       �� 5     " ��6$   .�5	  "   ��  �@��CornerRadius$ 25��6A   5
     5     5     5     5     5     5     5     