   M S B A M L   `   `   `  ����b  ^Registeration&Login-Desktop_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Registeration_Login_Desktop_Application'Registeration_Login_Desktop_Application  5      8    2Registeration_Login_Desktop_Application.SignINPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:Registeration_Login_Desktop_Application     5        N� Title$  
SignINPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��47* �6   �� 5      $	��82* �6   ��5   
   �� 5       �� ImageSource$ /BackGround.png��6    � RowDefinitions 5   
   �� 5      $	��85* �6   �� 5      $	��75* �6   �� 5      $	��65* �6   �� 5      $	��85* �6   �� 5      $	��50* �6   �� 5      $	��60* �6   �� 5      $
��143* �6   �� 5      $	��97* �6   .+�5   
   �� $��Sign-In Page��6      HeaderLabelStyle#��[  6'   $��50��6Q   $	��620��6]   $��2��6i   $
��Left=�6}   $��20,0,0,0q�6�   �� 5   
   $��	UserName:��6     NormalLabStyle#��[ 6$   $��
107,17,0,0q�6L   $��2��6`   $��36��6m   $	��100��6y   �� 5   
   $��	Password:��6   #��[ 6$   $��	107,0,0,0q�6L   $��3��6_   $��36��6l   $��Center=�6x   $	��100��6�   �� 5    
   -   5        $��txt_userName��5    -   $
��Left=�6   $��	10,17,0,0q�6A   $��2��6T    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��320��6�   $��36��6�   $��1��6�   $��22(�6�   �� 5!   
   -   5        $��txt_password��5!   -   $
��Left=�6   $��3��6A   $
 Wrap=�6N   $��Center=�6b   $	��317��6}   $��36��6�   $��10,0,0,0q�6�   $��1��6�   $��22(�6�   �� 5"   
   -   5        $��	btn_login��5"   "   $��SignIn��6     btnSyle#��[ 63   $��10,0,0,0q�6U   $��4��6g   $��42��6t   $	��317��6�   ���	#FFF0121D$��Center=�6�   $��1��6�   �� 5#   
   $��Don't have Account?��6   $��Center=�6.   $��0,10,0,0q�6K   $��6��6]   $	��Top=�6j   ���	#FFF9F7F7$	��173��6�   $��18(�6�   $��34��6�   �� 5$   
   -   5         ��Name$ 
btn_SignUp��5$   "   $��SignUp��6   #��[ 66   $��10,8,0,0q�6d   $��6��6v   $��42��6�   $	��317��6�   ���	#FFF0121D$��1��6�   �� 5%   
   -   5        $ btn_foregetPassword��5%   ,   $��Foreget Password��6   #��[ 6I   $��10,0,0,0q�6w   $��5��6�   $��42��6�   $	��317��6�   ���	#FFF0121D$��1��6�   $��Center=�6�   �� 5&   
   $��Who are you��6   #��[ 6&   $��	107,0,0,0q�6N   $��1��6a   $��36��6n   $	��108��6z   $��Center=�6�   �� 5'   
   -   5        $��CombWho��5'   >   $��1��6   $
��Left=�6#   $��10,0,0,0q�6M   $��1��6_   $��Center=�6l   $	��120��6�   $��36��6�   $��18(�6�    �� SelectedIndex$ 0��6�   .@�5(      �� .��6   User6!   �� 5)      .��6   Admin6"   5*      5,      5-      