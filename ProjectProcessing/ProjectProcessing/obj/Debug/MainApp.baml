   M S B A M L   `   `   `  ����L  HProjectProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjectProcessingProjectProcessing  5   	       ProjectProcessing.MainApp   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Y UMahApps.Metro.IconPacks.Entypo, Version=1.9.1.0, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   +localclr-namespace:ProjectProcessing  5   	   $	��500��5	      $	��645��6'     � 
ResizeMode$  CanMinimize=�63    � WindowStartupLocation$ CenterOwner=�6L    � Icon$ Logo_1502795232226.png��6p   .��5
      � .+�5   
   �� -   5         ��Name$
 logo��5      $
��Left=�6   $	��155��69   $	��Top=�6F   $	��516��6^   $��11,3,0,0q�6j   $��logolong.png��6|   !  MahApps.Metro.Controls.Tile  5   
   -   5          Name$ butDownload��5         Title$ Download��6-      HorizontalTitleAlignment$ Center=�6>      TitleFontSize$ 32Q�6`      
TiltFactor$ 4��5      $	��305��5      $	��150��6!   	   Count$	  ��5      $��10,309,322,10q�6   )  #MahApps.Metro.Controls.ButtonHelper
   CornerRadius$
 0��65    � Cursor$
 Hand��6\   $��Calibri Light)�6j   $��36(�6�   ���	#FF2FB1BE$�� ��6�   
�������6�     5   
   -   5        $ 
butWebsite��5      $ Website��6,   $ Center=�6<   $ 32Q�6^   $ 2��5      $	��150��5      $	��150��6   $	  ��5      $��10,154,477,165q�6   $
 0��6.   $
 Hand��6U   $��Calibri Light)�6c   $��36(�6~   ���	#FFFEE538
�������6�     5   
   -   5        $ butManagement��5      $ 
Management��6/   $ Center=�6B   $ 32Q�6d   $ 2��5      $	��305��5      $	��150��6   $	  ��5      $��320,309,12,10q�6   $
 0��6-   $
 Hand��6T   $��Calibri Light)�6b   $��36(�6}   ���	#FFEF3A5B
�������6�     5   
   -   5        $ 	butUpload��5      $ Upload��6+   $ Center=�6:   $ 32Q�6\   $ 2��5      $	��305��5      $	��150��6   $	  ��5      $��165,154,167,165q�6   $
 0��6/   $
 Hand��6V   $��Calibri Light)�6d   $��36(�6   ���	#FF8DB932
�������6�     5   
   -   5        $ butSettings��5      $ Settings��6-   $ Center=�6>   $ 32Q�6`   $ 2��5      $	��150��5      $	��150��6   $	  ��5      $��475,154,12,165q�6   $
 0��6.   $
 Hand��6U   $��Calibri Light)�6c   $��36(�6~   ���	#FF395F83$�� ��6�   
�������6�   �� 5    
   -   5         ��Name$ txtUser��5       $��Bob Robbins��6!   $
��Left=�67   $	��Top=�6R   $��182,108,0,0q�6j   $��24(�6   �� 5!   
   -   5         ��Name$ chkchk��5!      $��CheckBox��6#   $
��Left=�66   $	��Top=�6Q   $y�Hidden=�6i   ,  &MahApps.Metro.IconPacks.PackIconEntypo  5"   
   -	   5          Name$ iconDownload��5"   #   �  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconEntypoKind, MahApps.Metro.IconPacks.Entypo, Version=1.9.1.0, Culture=neutral, PublicKeyToken=null]]   Kind$ Download=�69   $��90��6I   $��90��6U   $��119,324,0,0q�6`   
������� J� IsHitTestVisible .  |�.  6�     5#   
   -
   5        $ 
iconUpload��5#   #   $ UploadToCloud=�67   $��90��6L   $
��Auto��6X   
�������$��Stretch=�6x   $��275,168,274,0q�6�    .  |�.  6�     5$   
   -   5        $ 	iconGlobe��5$   #   $ Globe=�66   $��90��6C   $��90��6N   
�������$��
40,168,0,0q�6m    .  |�.  6�     5%   
   -   5        $ iconCog��5%   #   $	 Cog=�64   
�������$��90��6R   $��90��6]   $��505,168,0,0q�6i    .  |�.  6�     5&   
   -   5        $ iconDatabase��5&   #   $ Database=�69   $��90��6I   $��90��6T   
�������$��429,324,0,0q�6s    .  |�.  6�   �� 5'   
   -   5         ��Name$ Overlay��5'      $��Center=�6&   $��Center=�6C   ���	#BF000000$
��1000��6u   $
��1000��6�   $y�Hidden=�6�   5(      5)      