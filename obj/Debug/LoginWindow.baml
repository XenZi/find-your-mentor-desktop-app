   M S B A M L   `   `   `  ����L  HSR38-2021-POP2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SR38_2021_POP2022SR38_2021_POP2022  5   	   #    SR38_2021_POP2022.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SR38_2021_POP2022     5   	     � Title$  Login Screen��5   	   $	��450��6   $	��450��6+   .��5	      � $��25, 25, 25, 25q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ lblIntro��5   3   $��0��6   $
��Bold"�6!   $��15(�6E   $��Center=�6S   $��
0,54,0,303q�6p   $0��*Hello, please, login or continue as guest!��6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $��txtPersonalIdentityNumber��5      $��Center=�63   $��	0,112,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��330��6�   �� 5   
   $��Personal Identity Number��6   $
��Left=�63   $��	26,86,0,0q�6N   $	��Top=�6a   G� 5   
   -   5        $��txtPassword��5      $��Center=�6)   $��	0,174,0,0q�6G   $	��Top=�6[   $	��330��6s   �� 5   
   $��Password��6   $
��Left=�6#   $��
26,146,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $��btnLogin��5   !   $��Login��6   $
��Left=�61   $��24��6L   $��
28,206,0,0q�6X   $	��Top=�6l   $��77��6�   6�   �� 5   
   $
��Left=�6   $
��Bold"�6/   $��21��6A   $��
28,252,0,0q�6M   $
��Wrap=�6a   $��Doesn't have account?��6u   $	��Top=�6�   $	��158��6�   �� 5   
   -   5        $��btnRegister��5   $   $��Register��6   $
��Left=�67   $��23��6R   $��
28,278,0,0q�6^   $	��Top=�6r   $��89��6�   6�   �� 5   
   -   5        $��btnContinueAsGuest��5   -   $��Continue as guest��6   $��Center=�6G   $��23��6d   $��	0,278,0,0q�6p   $	��Top=�6�   $	��110��6�   6�   5      5      