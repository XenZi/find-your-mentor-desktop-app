   M S B A M L   `   `   `  ����L  HSR38-2021-POP2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SR38_2021_POP2022.resources.views!SR38_2021_POP2022.resources.views  5   	   3    -SR38_2021_POP2022.resources.views.GuestWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:SR38_2021_POP2022.resources.views     5   	     � Title$  Guest��5   	   $	��450��6   $	��800��6$   .��5	      � $��25, 25, 25, 25q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $
��Left=�6   $��	28,10,0,0q�6/   $��1��6B   $
��Wrap=�6O   $��Pick up place��6c   $	��Top=�6x   �� 5   
   -   5        $��cmbPlace��5      $
��Left=�6#   $��	28,33,0,0q�6>   $��1��6Q   $	��Top=�6^   $	��120��6v   6�   �� 5   
   $
��Left=�6   $��
188,13,0,0q�6/   $��1��6C   $
��Wrap=�6P   $��Pick languages��6d   $	��Top=�6z   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataSchools��5   �   $��Center=�6   $	��115��60   $��	0,140,0,0q�6=   $	��Top=�6P   $	��696��6h   $��1��6�      CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly . 5      �� 5   
   -   5        $��btnExit��5      $
��Exit��6    $
��Left=�6/   $��24��6J   $��
63,298,0,0q�6V   $	��Top=�6j   $	��111��6�   $��1��6�   �� 5   
   -   5        $��btnSearchTeacher��5      $"��Search for teacher in school��6)   $
��Left=�6P   $��24��6k   $��316,298,0,0q�6w   $	��Top=�6�   $	��179��6�   $��1��6�   �� 5   
   $
��Left=�6   $
��Bold"�6/   $��18(�6A   $��
308,10,0,0q�6O   $
��Wrap=�6c   $��Hello guest, welcome!��6w   $	��Top=�6�   �� 5   
   $
��Left=�6   $��365,109,0,0q�6/   $��1��6D   $
��Wrap=�6Q   $��Schools��6e   $��16(�6t   $��Black"�6�   $	��Top=�6�   �� 5   
   -   5        $��listLanguages��5      $
��Left=�6'   $��72��6B   $��
188,33,0,0q�6N   $��1��6b   $	��Top=�6o   $	��166��6�    �� SelectionMode$ Extended=�6�   �� 5   
   -   5        $��btnSearchForTeacher��5   �   $��Search for teacher��6   $
��Left=�6.   $��24��6I   $��188,298,0,0q�6U   $��1��6j   $	��Top=�6w   $	��108��6�   6�   5      5      