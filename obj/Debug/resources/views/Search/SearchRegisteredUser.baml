   M S B A M L   `   `   `  ????L  HSR38-2021-POP2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:SR38_2021_POP2022.resources.views.Search(SR38_2021_POP2022.resources.views.Search  5   	   C    =SR38_2021_POP2022.resources.views.Search.SearchRegisteredUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:SR38_2021_POP2022.resources.views.Search     5   	     ? Title$  Search Registered User??5   	   $	??450??6(   $	??800??65   .??5	      ? $??25 25 25 25q?6   .+?5
   
   &   System.Windows.Controls.DataGrid  -   5        $??	dataUsers??5
   P   $??Center=?63   $	??180??6a   $??0,54,0,0q?6n   $	??Top=?6?   $	??730??6?      AutoGenerateColumns .     CanUserAddRows .  ??6   ?? *	Student+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ?? *PersonalIdentityNumber+  5      $ 
First Name??6%    69   ?? *	FirstName+  5      $ 	Last Name??6%    68   ?? *
LastName+  5      $ Email??6%    64   ?? *Email+  5      $ Gender??6%    65   ?? *Gender+5      ?? 5   
   $??Center=?6   $??20(?61   $??0,13,0,0q?6?   $
??Wrap=?6Q   $??Search registered users??6e   $	??Top=?6?   ?? 5   
   -   5        $??txtFirstName??5   ]   $
??Left=?6   $??
96,293,0,0q?6-    ?? TextWrapping$
 Wrap=?6A   $?? ??6U   $	??Top=?6q   $	??120??6?   6?   ?? 5   
   -   5        $??txtLastName??5   ^   $
??Left=?6   $??247,293,0,0q?6-   $
 Wrap=?6B   $?? ??6V   $	??Top=?6q   $	??120??6?   6?   ?? 5   
   -   5        $??txtMail??5   ^   $
??Left=?6   $??402,293,0,0q?6-   $
 Wrap=?6B   $?? ??6V   $	??Top=?6m   $	??120??6?   6?   ?? 5   
   -   5        $??cmbType??5   .   $
??Left=?6   $??563,293,0,0q?6=   $	??Top=?6R   $	??120??6j   6v   ?? 5   
   $??
First Name??6   $
??Left=?6%   $??
96,262,0,0q?6@   $	??Top=?6T   ?? 5   
   $??	Last Name??6   $
??Left=?6$   $??247,262,0,0q?6?   $	??Top=?6T   ?? 5   
   $??E-mail??6   $
??Left=?6!   $??402,262,0,0q?6<   $	??Top=?6Q   ?? 5   
   $
??Type??6   $
??Left=?6   $??563,262,0,0q?6:   $	??Top=?6O    J? RenderTransformOrigin$ 0.518,-0.376&?6g   ?? 5   
   -   5        $??	btnCancel??5   "   $??Cancel??6   $??Center=?63   $??	0,336,0,0q?6P   $	??Top=?6c   $??25??6{   $??78??6?   6?   5      5      