   M S B A M L   `   `   `  ����L  HProjectProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProjectProcessing.SubWindowsProjectProcessing.SubWindows  5   	   6    0ProjectProcessing.SubWindows.winBranchManagement   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ProjectProcessing.SubWindows     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	   $	��275��5      $	��645��6'     � 
ResizeMode$  NoResize=�63    � WindowStartupLocation$ CenterOwner=�6I    � WindowStyle$
 None=�6m    � ShowInTaskbar .  .��5	      � .+�5
   
   �� -   5         ��Name$ 
branchList��5
      $
��Left=�6&   $	��255��6A   $	��Top=�6N   $	��304��6f   $��	10,10,0,0q�6r   
�������$��16(�6�   6�   �� 5   
   -   5         ��Name$ 	butCancel��5      $��Cancel��6$   $��Center=�65   $��328,0,11,92q�6R   $��Bottom=�6g   $	��306��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�    � Cursor$
 Hand��6�   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Normal=�6�   $��40��6  $��0q�6  )  #MahApps.Metro.Controls.ButtonHelper   CornerRadius$ 0��6-  ���	#FFD1D1D16i  �� 5   
   -   5        $ butEdit��5      $��Edit Branch��6"   $��Center=�68   $��328,92,11,0q�6U   $	��Top=�6j   $	��306��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6  $��0q�6  $ 0��6-  ���	#FFD1D1D16i  �� 5   
   -   5        	 ��Name$	 panEditBranch��5      $
��Left=�6,   $	��255��6G   $	��Top=�6T   $	��307��6l   $��
328,10,0,0q�6x   
�������$y�Hidden=�6�   .+�5      �� -   5        
 ��Name$
 	txtIdEdit��5      $
��Left=�6)   $	��Top=�6D   $	��307��6\   $��Calibri Light)�6h   $��26(�6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ ID��6�   $��0,0,0,2q�6�   ���	#FF424242 � ToolTip$ 	Branch ID��6�   $ IBeam��6�   $��0,5,0,0q�6	  " �� VerticalScrollBarVisibility$ Disabled=�6   �� 
IsReadOnly . 6A  �� 5      -   5        $
 txtNameEdit��5      $
��Left=�6+   $	��Top=�6F   $	��307��6^   $��Calibri Light)�6j   $��26(�6�   $
 Name��6�   $��0,0,0,2q�6�   ���	#FF424242$ The branch name��6�   $ IBeam��6  $��0q�6  $ Disabled=�6  �� 5      -   5        $
 txtAreaEdit��5      $
��Left=�6+   $	��Top=�6F   $	��307��6^   $��Calibri Light)�6j   $��26(�6�   $
 Area��6�   $��0,0,0,2q�6�   ���	#FF424242$ Branch area m^2��6�   $ IBeam��6  $��0q�6  $ Disabled=�6  �� 5      -   5        $ butSaveEdit��5      $
��Save��6*   $��Center=�69   $��0,44,1,0q�6V   $	��306��6h   $��22(�6t   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6�   $��0q�6�   $ 0��6  ���	#FFFEE538$	��Top=�6i  $	��Top=�6�  �� 5      -	   5        $ butCancelEdit��5      $��Cancel��6,   $��Right=�6=   $��0,6,1,0q�6Y   $��Bottom=�6j   $	��150��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6  $��0q�6  $ 0��60  ���	#FFD1D1D16l  �� 5      -
   5        $ butCreateEdit��5      $��Create Branch��6,   $
��Left=�6D   $��	0,-40,1,0q�6_   $	��Top=�6r   $	��150��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6  $��0q�6!  $ 0��65  ���	#FFD1D1D1$��Center=�6�  5      5      5      