   M S B A M L   `   `   `  ���� L  HSR38-2021-POP2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SR38_2021_POP2022SR38_2021_POP2022  #    SR38_2021_POP2022.LoginWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:SR38_2021_POP2022       � Title$  Login Screen��$	��450��$	��450��.��� $��25, 25, 25, 25q� � RowDefinitions �� $
��Auto ��� $��* �.+��� -    ��Name$ lblIntro��$��0��$
��Bold"�$��15(�$��Center=�$��
0,54,0,303q�$0��*Hello, please, login or continue as guest!�� �� TextAlignment$ Center=��� -   $��txtPersonalIdentityNumber��$��Center=�$��	0,112,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��330���� $��Personal Identity Number��$
��Left=�$��	26,86,0,0q�$	��Top=�G� -   $��txtPassword��$��Center=�$��	0,174,0,0q�$	��Top=�$	��330���� $��Password��$
��Left=�$��
26,146,0,0q�$	��Top=��� -   $��btnLogin��$��Login��$
��Left=�$��24��$��
28,206,0,0q�$	��Top=�$��77���� $
��Left=�$
��Bold"�$��21��$��
28,252,0,0q�$
��Wrap=�$��Doesn't have account?��$	��Top=�$	��158���� -   $��btnRegister��$��Register��$
��Left=�$��23��$��
28,278,0,0q�$	��Top=�$��89���� -   $��btnContinueAsGuest��$��Continue as guest��$��Center=�$��23��$��	0,278,0,0q�$	��Top=�$	��110��