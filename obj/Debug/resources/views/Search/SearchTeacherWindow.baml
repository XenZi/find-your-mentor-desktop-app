   M S B A M L   `   `   `  ����L  HSR38-2021-POP2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:SR38_2021_POP2022.resources.views.Search(SR38_2021_POP2022.resources.views.Search  5   	   B    <SR38_2021_POP2022.resources.views.Search.SearchTeacherWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:SR38_2021_POP2022.resources.views.Search     5   	     � Title$  SearchTeacherWindow��5   	   $	��450��6%   $	��800��62   .��5	      � $��25 25 25 25q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataUsers��5
   P   $��Center=�63   $	��180��6a   $��0,54,0,0q�6n   $	��Top=�6�   $	��730��6�      AutoGenerateColumns .     CanUserAddRows .  ��6   �� *	Student+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *PersonalIdentityNumber+  5      $ 
First Name��6%    69   �� *	FirstName+  5      $ 	Last Name��6%    68   �� *
LastName+  5      $ Email��6%    64   �� *Email+  5      $ Gender��6%    65   �� *Gender+5      �� 5   
   $��20(�6   $
��Bold"�6"   $��Center=�64   $
��Wrap=�6Q   $��Search for teacher��6e   $	��Top=�6   $��0,10,0,0q�6�   �� 5   
   -   5        $��txtFirstName��5   -   $
��Left=�6   $��
10,287,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   6�   �� 5   
   -   5        $��txtLastName��5   B   $
��Left=�6   $��163,287,0,0q�6-   $
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $��
txtAddress��5   B   $��Center=�6   $��	0,287,0,0q�6/   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   6�   �� 5   
   -   5        $��txtMail��5   V   $
��Left=�6   $��465,287,0,0q�6-   $
 Wrap=�6B   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $��listBoxLanguages��5   -   $
��Left=�6   $��87��6E   $��615,287,0,0q�6Q   $	��Top=�6f   $	��125��6~    �� SelectionMode$ Extended=�6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��
10,261,0,0q�6@   $	��Top=�6T   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��163,261,0,0q�6?   $	��Top=�6T   �� 5   
   $��Address��6   $
��Left=�6"   $��315,261,0,0q�6=   $	��Top=�6R   �� 5   
   $
��Mail��6   $
��Left=�6   $��465,261,0,0q�6:   $	��Top=�6O   �� 5   
   $��	Languages��6   $
��Left=�6$   $��615,261,0,0q�6?   $	��Top=�6T   �� 5   
   -   5        $��txtCity��5   /   $��Center=�6   $��20��6>   $��	0,330,0,0q�6J   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   6�   �� 5   
   $
��City��6   $
��Left=�6   $��315,305,0,0q�6:   $	��Top=�6O   5!      5"      