   M S B A M L   `   `   `  ����A  =EBS_PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EBS_PLEBS_PL  5          EBS_PL.TravelPlan   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:EBS_PL     5        N� Title$  
TravelPlan��5	      .��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6   ��5   
   �� 5       �� Opacity$	 0.8Q�6    j� TileMode$
 Tile=�6'    �� ImageSource$  getty_583734066_335273.jpg��67    �� RelativeTransform 5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6)    �� ScaleX$ -1Q�64   �� 5       �� AngleY$ 0Q�6(   	 �� AngleX$	 0Q�63   �� 5      
 �� Angle$
 0Q�6*   T� 5      5      5       � RowDefinitions 5   
   �� 5      $
��auto �6   $��80��6*   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5!      $��40 �6    � ColumnDefinitions 5$   
   �� 5%      $
��auto �6   $��27��6,   �� 5&      $
��auto �6   $	��254��6,   �� 5'      $	��353 �6   �� 5(      $��51 �6   .+�5*   
   �� -   5         ��Name$ 
lbl_Source��5*      $��	Source   ��6$   $
��Left=�68   $��0��6S   $��0,54,0,1q�6`   $��75��6r   $��1��6}   
���   �$
��Bold"�6�   ��6�   Z� 6�   �� 5+   
   -   5        $ lbl_Destination��5+      $��Destination��6)   $
��Left=�6?   $��0,14,0,0q�6Z   $��1��6l   $	��118��6y   $��1��6�   
���   �$
��Bold"�6�   $��27��6�   $	��Top=�6�   ��6�   Z� 6�   �� 5,   
   -   5        $ lbl_From��5,      $��	From Date��6"   $��1��66   $
��Left=�6F   $��0,14,0,0q�6a   $��2��6s   $	��Top=�6�   $��23��6�   $	��118��6�   
���   �$
��Bold"�6�   ��6�   Z� 6�   �� 5-   
   -   5        $ lbl_To��5-      $��To Date��6    $
��Left=�62   $��0,14,0,0q�6M   $��3��6_   $	��Top=�6l   $��23��6�   $��72��6�   $��1��6�   
���   �$
��Bold"�6�   ��6�   Z� 6�   �� 5.   
   -   5        $ lbl_Days��5.      $��
No of Days��6"   $
��Left=�67   $��0,14,0,0q�6R   $��4��6d   $	��Top=�6q   $��26��6�   $��71��6�   $��1��6�   
���   �$
��Bold"�6�   ��6�   Z� 6�   �� 5/   
   -   5         ��Name$ 
cmb_Source��5/      $��2��6'   $
��Left=�67   $��23��6R   $��	10,53,0,0q�6^    �� Text$  ��6r   $	��Top=�6z   $	��200��6�   
���   �.@�50      �� $��Chennai��6   �� 51      $��Mumbai��6   �� 52      $��Delhi��6   �� 53      $��	Hyderabad��6   �� 54      $��GandhiNagar��6   56      �� 57   
   -   5        $ cmb_Destination��57      $��2��6,   $
��Left=�6<   $��23��6W   $��	10,14,0,0q�6c   $��1��6v   $  ��6�   $	��Top=�6�   $	��200��6�   
���   �.@�58      �� $��Chennai��6   �� 59      $��Mumbai��6   �� 5:      $��Delhi��6   �� 5;      $��	Hyderabad��6   �� 5<      $��GandhiNagar��6   5=      (  "System.Windows.Controls.DatePicker  5>   
   -   5          Name$ DateFrom��5>      $��2��6(   $
��Left=�68   $��	10,15,0,0q�6S   $��2��6f   $	��Top=�6s   $	��200��6�   $��24��6�   
���   �6�     5?   
   -	   5        $ DateTo��5?      $��2��6&   $
��Left=�66   $��	10,15,0,0q�6Q   $��3��6d   $	��Top=�6q   $	��200��6�   $��24��6�   
���   �6�   �� 5@   
   -
   5         ��Name$ txt_Days��5@      $��2��6$   $
��Left=�64   $��23��6O   $��	10,14,0,0q�6[   $��4��6n    �� TextWrapping$
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��200��6�   
���   �6�   �� 5A   
   -   5        $ 
lbl_Status��5A      $��Status��6$   $��1��65   $
��Left=�6E   $��0,14,0,0q�6`   $��5��6r   $	��Top=�6   $��26��6�   $��75��6�   
���   �$
��Bold"�6�   ��6�   Z� 6�   �� 5B   
   -   5        $ 	cmbStatus��5B      $��2��6&   $
��Left=�66   $��	10,14,0,0q�6Q   $��5��6d   $	��Top=�6q   $	��200��6�   $��22��6�   
���   �.@�5C      �� $��Accepted��6   �� 5D      $��Rejected��6   5E      �� 5F   
   -   5         ��Name$ 
btb_Submit��5F      $��Submit��6%   $��2��66   $
��Left=�6F   $��	55,10,0,0q�6a   $��6��6t   $	��Top=�6�   $	��107��6�   $��28��6�   
���   �$
��Bold"�6�   �� 5G   
   -   5         ��Name$ image��5G      $��3��6   $
��Left=�6/   $��67��6J   $��74��6V   $��
48,4,-70,0q�6a   $	��Top=�6u   $!��capgemini-cybersecurity.png��6�   $
��Fill=�6�   �� 5H   
   -   5         ��Name$ errormessage��5H   L   $��7��6   $��2��6!   $
��Left=�61   $	��Top=�6c   $��16��6{   $��0��6�   5I      5J      