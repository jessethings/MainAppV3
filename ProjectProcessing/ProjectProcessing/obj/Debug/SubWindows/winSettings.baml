   M S B A M L   `   `   `  ����L  HProjectProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProjectProcessing.SubWindowsProjectProcessing.SubWindows  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   E   .    (ProjectProcessing.SubWindows.winSettings   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ProjectProcessing.SubWindows     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	   3System&clr-namespace:System;assembly=mscorlib  6E   -   5          � Title$  winSettings��5	   	   $��290.294��6   $	��645��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterOwner=�6P    � ShowInTaskbar .   � WindowStyle$
 None=�6�   .��5
      � -   5         �Name$ 	GridThing��5
      .+�5   
   �� $��Settings��6   $��Center=�6#   $��242,0q�6@   $	��Top=�6O   $��Calibri Light)�6g   $��48(�6�   �� 5   
   $��Temporary files folder��6   $
��Left=�61   $	��Top=�6L   $��
150,69,0,0q�6d   $��26(�6x   $��Calibri Light)�6�   �� 5   
   $��Theme settings��6   $
��Left=�6)   $	��Top=�6D   $��150,156,0,0q�6\   $��26(�6q   $��Calibri Light)�6   �� 5   
   -   5         ��Name$ 
txtTempLoc��5      $
��Left=�6&   $��40��6A   $��150,111,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��253��6�   $��26(�6�   $��Calibri Light)�6�    � Cursor$ Arrow��6�   {�.  6�   �� 5   
   -   5        	 ��Name$	 butSetTempLoc��5      $��Select��6(   $
��Left=�69   $��408,111,0,0q�6T   $	��Top=�6i   $��87��6�   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   +  %MahApps.Metro.Controls.ControlsHelper
   ContentCharacterCasing$
 Normal=�6�   $��40��6  )  #MahApps.Metro.Controls.ButtonHelper   CornerRadius$ 0��6  $��0q�6<  ���	#FFD1D1D16g  �� 5   
   -   5         ��Name$ cmboWinColour��5      $
��Left=�6*   $��150,198,0,0q�6E   $	��Top=�6Z   $	��170��6r   $��22(�6~    �� 
IsReadOnly . 6�   �� 5   
   -   5        $ cmboWinTheme��5      $
��Left=�6)   $��325,198,0,0q�6D   $	��Top=�6Y   $	��170��6q   $��22(�6}    . 6�   �� 5   
   -   5        $	 	butCancel��5      $��Cancel��6$   $
��Left=�65   $��150,240,0,0q�6P   $	��Top=�6e   $	��170��6}   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $
 Normal=�6�   $��40��6  $��0q�6  $ 0��6(  ���	#FFD1D1D16d  �� 5   
   -   5        $	 butSave��5      $
��Save��6"   $
��Left=�61   $��325,240,0,0q�6L   $	��Top=�6a   $	��170��6y   $��22(�6�   $��Calibri Light)�6�   $
��Bold"�6�   $
 Hand��6�   $
 Normal=�6�   $��40��6  $��0q�6  $ 0��6$  ���	#FFFEE5386`  �� 5   
   -	   5        $	 butResetSettings��5      $��reset settings��6+   $��Center=�6D   $��544,256,0,0q�6a   $	��Top=�6v   $	��101��6�   $
 Normal=�6�   $ 0��6�   $��Calibri Light)�6"  $��16(�6=  ���	#FFB2B2B2$
 Hand��6�  ��6�   Z� ��6  Z� 6�  5      5      