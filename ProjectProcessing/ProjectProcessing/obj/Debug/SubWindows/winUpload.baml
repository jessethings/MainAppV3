   M S B A M L   `   `   `  ����L  HProjectProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProjectProcessing.SubWindowsProjectProcessing.SubWindows  5   	   ,    &ProjectProcessing.SubWindows.winUpload   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ProjectProcessing.SubWindows     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	   $	��300��5      $	��645��6'     � WindowStyle$
  None=�63    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterOwner=�6\    � ShowInTaskbar .  .��5	      � -   5        .+�5
   
   �� $��Upload��6   $��Center=�6!   $��242,0q�6>   $	��Top=�6M   $��Calibri Light)�6e   $��48(�6�   �� 5   
   -   5         ��Name$ 	labSelect��5      $��File is selected��6#   $
��Left=�6>   $	��Top=�6Y   $��
169,74,0,0q�6q   $��26(�6�   $��Calibri Light)�6�   �� 5   
   -   5        $ 
labProcess��5      $��File is processed��6$   $
��Left=�6@   $	��Top=�6[   $��169,116,0,0q�6s   $��26(�6�   $��Calibri Light)�6�   �� 5   
   -   5        $ 	labUpload��5      $��Processed is uploaded��6#   $
��Left=�6C   $	��Top=�6^   $��169,158,0,0q�6v   $��26(�6�   $��Calibri Light)�6�   �� 5   
   -   5         ��Name$ 	butUpload��5      $��Placeholder��6$   $
��Left=�6:   $	��Top=�6U   $	��310��6m   $��22(�6y   $��Calibri Light)�6�   $
��Bold"�6�    � Cursor$
 Hand��6�   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Normal=�6�   $��40��6�   $��0q�6  )  #MahApps.Metro.Controls.ButtonHelper   CornerRadius$ 0��6  ���	#FFFEE538$��169,205,0,0q�6T  {�.  6�  �� 5   
   -   5        $ 	butCancel��5      $��169,250,324,0q�6$   $	��Top=�6;   $��22(�6S   $��Calibri Light)�6a   $
��Bold"�6|   $
 Hand��6�   $ Normal=�6�   $��40��6�   $��0q�6�   $ 0��6�   ���	#FFD1D1D1$	��152��6.  $��Cancel��6R  �� 5   
   -   5        $ 
butRestart��5      $��Restart Upload��6%   $��326,250,167,0q�6>   $	��Top=�6U   $��22(�6m   $��Calibri Light)�6{   $
��Bold"�6�   $
 Hand��6�   $ Normal=�6�   $��40��6�   $��0q�6�   $ 0��6  ���	#FFD1D1D1$	��152��6H  6T  �� 5   
   -   5        $ labSelectStatus��5      $	��✓��6)   $
��Left=�65   $	��Top=�6P   $��
450,74,0,0q�6h   $��26(�6|   $��Calibri Light)�6�   {�.  6�   �� 5   
   -	   5        $ labProcessStatus��5      $	��✓��6*   $
��Left=�66   $	��Top=�6Q   $��450,116,0,0q�6i   $��26(�6~   $��Calibri Light)�6�   {�.  6�   �� 5   
   -
   5        $ labUploadStatus��5      $	��✓��6)   $
��Left=�65   $	��Top=�6P   $��450,158,0,0q�6h   $��26(�6}   $��Calibri Light)�6�   {�.  6�   5      5      