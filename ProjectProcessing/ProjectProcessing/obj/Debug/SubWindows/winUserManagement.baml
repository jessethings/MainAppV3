   M S B A M L   `   `   `  ����L  HProjectProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProjectProcessing.SubWindowsProjectProcessing.SubWindows  5   	   4    .ProjectProcessing.SubWindows.winUserManagement   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ProjectProcessing.SubWindows     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	   $	��275��5      $	��645��6'     � 
ResizeMode$  NoResize=�63    � WindowStartupLocation$ CenterOwner=�6I    � WindowStyle$
 None=�6m    � ShowInTaskbar .  .��5	      � .+�5
   
   �� -   5         ��Name$ 	butCancel��5
      $��Cancel��6$   $��Center=�65   $��328,0,11,92q�6R   $��Bottom=�6g   $	��306��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�    � Cursor$
 Hand��6�   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Normal=�6�   $��40��6  $��0q�6  )  #MahApps.Metro.Controls.ButtonHelper   CornerRadius$ 0��6-  ���	#FFD1D1D16i  �� 5   
   -   5        $ butEdit��5      $��	Edit User��6"   $��Center=�66   $��328,92,11,0q�6S   $	��Top=�6h   $	��306��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6  $��0q�6  $ 0��6+  ���	#FFD1D1D16g  �� 5   
   -   5         ��Name$ userList��5      $
��Left=�6$   $	��255��6?   $	��Top=�6L   $	��304��6d   $��	10,10,0,0q�6p   
�������$��16(�6�   6�   �� 5   
   -   5        	 ��Name$	 panEditUser��5      $
��Left=�6*   $	��255��6E   $	��Top=�6R   $	��307��6j   $��
328,10,0,0q�6v   
�������$y�Hidden=�6�   .+�5      �� -   5        
 ��Name$
 txtNameEdit��5      $
��Left=�6+   $	��Top=�6F   $	��307��6^   $��Calibri Light)�6j   $��26(�6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$
 Name��6�   $��0,0,0,2q�6�   ���	#FF424242 � ToolTip$ Your preferred name��6�   $ IBeam��6  $��0,5,0,0q�6  " �� VerticalScrollBarVisibility$ Disabled=�6(  �� 5      -   5        $
 txtEmailEdit��5      $
��Left=�6,   $	��Top=�6G   $	��307��6_   $��Calibri Light)�6k   $��26(�6�   $ Email��6�   $��0,0,0,2q�6�   ���	#FF424242$ Your email address��6�   $ IBeam��6	  $��0q�6  $ Disabled=�6#  G� 5      -   5         G�Name$ txtPasswordEdit��5      $
��Left=�63   $	��Top=�6N   $	��307��6f   $��Calibri Light)�6r   $��26(�6�   $ Password��6�   $��0,0,0,2q�6�   ���	#FF424242$ Your desired password��6�   $ IBeam��6  $��0q�6%  �� 5      -   5         ��Name$ cmboPermission��5      $��22(�6/   $��0,5,0,0q�6=   �� 5      -	   5        $ 
cmboBranch��5      $��22(�6+   $��0,5,0,0q�69   �� 5      -
   5        $ butSaveEdit��5      $
��Save��6*   $
��Left=�69   $��0,5,1,0q�6T   $��Bottom=�6e   $	��150��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6  $��0q�6  $ 0��6+  ���	#FFFEE5386g  �� 5      -   5        $ butCancelEdit��5      $��Cancel��6,   $��Right=�6=   $��	0,-40,1,0q�6Y   $	��Top=�6l   $	��150��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6  $��0q�6  $ 0��6/  ���	#FFD1D1D1$��Center=�6�  5      5      5      