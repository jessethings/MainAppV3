   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   L HProjectProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjectProcessingProjectProcessing 5   	   #   ProjectProcessing.LoginWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjectProcessing     5   	   $	��500��5      $	��400��6'     � 
ResizeMode$  CanMinimize=�63    � WindowStartupLocation$ CenterScreen=�6L    � Icon$ Logo_1502795232226.png��6q   .��5	      � -   5        .+�5
   
   �� -   5         ��Name$
 logo��5
      $	��205��6   $	��Top=�6+   $��Logo_1502795232226.png��6C   $��100,10,100,0q�6c   �� 5   
   -   5         ��Name$ txtEmailLogin��5      $
��Left=�6)   $��48��6D   $��
46,200,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��300��6�   $��Calibri Light)�6�   $��36(�6�   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Email��6�   $��0,0,0,2q�6�   ���	#FF424242 � Cursor$ IBeam��6   � ToolTip$. (Your account's username or email address��6.  G� 5   
   -   5        	 G�Name$	 txtPasswordLogin��5      $
��Left=�60   $��
46,253,0,0q�6K   $	��Top=�6_   $	��300��6w   $��48��6�   $��Calibri Light)�6�   $��32(�6�   $ Password��6�   $��0,0,0,2q�6�   ���	#FF424242$ IBeam��6  $ You account's password��6$  �� 5   
   -   5        
 ��Name$
 butLogin��5      $��Log in��6#   $
��Left=�64   $	��Top=�6O   $	��300��6g   $��
46,358,0,0q�6s   )   #MahApps.Metro.Controls.ButtonHelper   CornerRadius$ 0��6�   $��Calibri Light)�6�   $��32(�6�   +   %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Normal=�6�   
���   ����	#FFFEE538$��0q�69  
���   �$
 Hand��6v  $
��Bold"�6�  $ Log into the system��6�  �� 5   
   -   5        $
 butCreatePanel��5      $��or create a new account��6)   $��Center=�6K   $��46,424,48,13q�6h   $��Center=�6~   $	��300��6�   ���	#FF424242$ 0��6�   $ Normal=�6  $��Calibri Light)�6H  $��18(�6c  $��0q�6q  $
 Hand��6�  $ Create a new user account��6�  ��6�   Z� ��6�   Z� 6�  �� 5   
   -   5         ��Name$ chkRemembner��5      $��Remember Me��6)   $
��Left=�6?   $	��Top=�6Z   $��
46,321,0,0q�6r   ���	#FF424242$ 0��6�   $
 Hand��6�   $8 2Remember password and username for automatic login��6�   �� 5   
   -   5         ��Name$ CreateAccountPan��5      $
��Left=�6/   $	��258��6J   $��
46,200,0,0q�6W   $	��Top=�6k   $	��300��6�   
�������$y�Hidden=�6�   .+�5      �� -	   5        $ txtNameCreate��5      $
��Left=�6-   $��48��6H   $
 Wrap=�6T   $	��Top=�6h   $	��300��6�   $��Calibri Light)�6�   $��36(�6�   $
 Name��6�   $��0,0,0,2q�6�   ���	#FF424242$ Your preferred name��6  $ IBeam��6,  $	��300��6;  �� 5      -
   5        $ txtEmailCreate��5      $
��Left=�6.   $��48��6I   $
 Wrap=�6U   $	��Top=�6i   $	��300��6�   $��Calibri Light)�6�   $��36(�6�   $ Email��6�   $��0,0,0,2q�6�   ���	#FF424242$ Your email address��6  $ IBeam��6-  $��0,5,0,0q�6<  $	��300��6M  
�������6\  G� 5      -   5        $	 txtPasswordCreate��5      $
��Left=�65   $	��Top=�6P   $	��300��6h   $��48��6t   $��Calibri Light)�6�   $��32(�6�   $ Password��6�   $��0,0,0,2q�6�   ���	#FF424242$ Your desired password��6  $ IBeam��6&  $��0,5,0,0q�65  $	��300��6F  �� 5      -   5        $
 butCreateNew��5      $��Create New Account��6+   $
��Left=�6H   $	��Top=�6c   $	��300��6{   $ 0��6�   $��Calibri Light)�6�   $��32(�6�   $ Normal=�6�   
���   ����	#FFFEE538$��0q�69  
���   �$
 Hand��6a  $
��Bold"�6o  $��0,5,0,0q�6�  $	��300��6�  �� 5      -   5        $
 butCancelCreate��5      $��cancel��6.   $��Center=�6?   $��Center=�6\   $	��300��6w   ���	#FF424242$ 0��6�   $ Normal=�6�   $��Calibri Light)�6&  $��18(�6A  $��0q�6O  $
 Hand��6c  $ Take me back to login��6q  $��0,13,0,0q�6�  $	��300��6�  ��6�   Z� ��6�   Z� 6�  5      �� 5   
   -   5        $ chkchk��5      $��CheckBox��6#   $
��Left=�66   $	��Top=�6Q   $y�Hidden=�6i   5      5      