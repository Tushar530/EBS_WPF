   M S B A M L   `   `   `  ����A  =EBS_PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EBS_PLEBS_PL  5          EBS_PL.AddEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:EBS_PL     5        N� Title$  AddEmployee��5	      .��5      � ��5   
   �� 5       �� ImageSource$ images (6).jpg��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��40 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5    
   �� -   5         ��Name$ 
lblHeading��5       $��Add Employee Form��6$   $��0��6@   $��0��6P   $��	0,0,128,1q�6]   $��Center=�6p   $��24(�6�   $	��472��6�   $��2��6�   �� 5!   
   -   5        $ lblName��5!      $��Name:��6!   $��0��61   $��2��6A   $��1,1,9,0q�6N   $
��Left=�6z   $
��Bold"�6�   �� 5"   
   -   5        $ lblDesignation��5"      $��Designation:��6(   $��0��6?   $��3��6O   $��1,1,9,0q�6\   $
��Left=�6�   $
��Bold"�6�   �� 5#   
   -   5        $ lblPassword��5#      $��	Password:��6%   $��0��69   $��4��6I   $��1,1,9,0q�6V   $
��Left=�6�   $
��Bold"�6�   �� 5$   
   -   5        $ lblConfirmPassword��5$      $��Confirm Password:��6,   $��0��6H   $��5��6X   $��1,1,9,0q�6e   $
��Left=�6�   $
��Bold"�6�   �� 5&   
   -   5         ��Name$ txtName��5&      $��1��6#   $��2��63    �� TextWrapping$
 Wrap=�6@   $
��auto��6T   G� 5'   
   -   5         G�Name$ psdPassword��5'      $��1��6+   $��4��6<   $
��auto��6J   G� 5(   
   -   5        $ psdConfirmPassword��5(      $��1��62   $��5��6C   $
��auto��6Q   �� 5)   
   -	   5         ��Name$ 	btnSubmit��5)      $��Submit��6$   $��1��65   $
��Left=�6E   $��6��6a   $��Bottom=�6n   $��75��6�   $
��Bold"�6�   �� 5*   
   -
   5        	 ��Name$	 cmbDesignation��5*      $��1��6+   $��3��6;   .@�5,      �� $��A3��6   �� 5-      $��A4��6   �� 5.      $��B1��6   �� 5/      $��B2��6   50      �� 51   
   -   5        
 ��Name$
 errormessage��51   `   $��7��6   $��1��6!   $��2��61   $
��Left=�6E   $	��Top=�6v   52      53      