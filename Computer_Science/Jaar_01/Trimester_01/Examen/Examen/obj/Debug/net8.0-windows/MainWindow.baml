   M S B A M L   `   `   `  ����A  =Examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ExamenExamen  5   	       Examen.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Examen     5   	     � Title$  Pxl Padel 2024��5   	   $	��450��6    $	��800��6-   .��5	      � $��0,2,0,39q�6   
����� � � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   ]� $��False��6   5      o� 5   
   $��2��6   $��
0,0,-1,372q�6#   4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�67   .@�5      m� -   5        $��Nieuwe Padel Club��5      6L   m� 5      -   5        $��Nieuwe Wedstrijd��5      6M   m� 5      -   5        $��	Afsluiten��5      6F   5      �� 5   
   -   5         ��Name$ SkpLinks��5      $��5,23,6,8q�6'   
������.+�5      �� $��
Klassement��6   $��0,21,0,0q�6)   	� 5      -   5         	�Name$ RdbP100��5   ;    	� 	GroupName$ OnlyOneCanGetChecked��6   $
��P100��6L   	� 5      -   5        $ RdbP200��5   ;   $ OnlyOneCanGetChecked��6   $
��P200��6L   	� 5       -   5        $ RdbP300��5    ;   $ OnlyOneCanGetChecked��6   $
��P300��6L   � 5!      $	��415��6   $��62��6$   $��0,25,0,0q�60   .+�5"      �� $��
ThuisPloeg��6   $	��114��6.   �� 5#      $��	Bezoekers��6   $��35,0,0,0q�6,   �� 5$      $��Uitslag��6   $��90,0,0,0q�6*   �� 5%      -   5         ��Name$ CbThuisPloeg��5%      $	��145��62   $��2,2,2,2q�6>   �� 5&      -	   5        $ CbBezoekers��5&      $	��145��60   $��2,2,2,2q�6<   �� 5'      -
   5         ��Name$ 
TxtUitslag��5'       �� TextWrapping$
 Wrap=�6/   $��70��6C   $��2,2,2,2q�6N   5(      �� 5)      -   5        	 ��Name$	 ChkHandicap��5)      $��Speler met een handicap��6,   $��15,15,15,15q�6N   � 5+      $��60��6   $	��416��6$   .+�5,      �� -   5        
 ��Name$
 
BtnOpslaan��5,      $��Opslaan��6-    K� ZIndex$	 125��6?   $��5,5,5,5q�6R   $	��125��6c   6o   �� 5-      -   5        $
 BtnAnnuleren��5-      $��	Annuleren��6/   $��5,6,5,5q�6C   $	��125��6T   6`   5.      5/      �� 51   
   $��1��6   $��	8,24,5,10q�6%   
�������.+�52      �� -   5         ��Name$ LbUitleg��52      $��	Uitslagen��6&   �� 53      -   5         ��Name$ LstUitslagen��53      $	��150��6,   $	��375��6d   $��10,10,10,10q�6p   $��Consolas)�6�    �� SelectedIndex$ 0��6�   6�   �� 54      -   5        $ LbKostPrijs��54      $��	KostPrijs��6)   �� 55      -   5         ��Name$ TxtKostPrijs��55      $
��Wrap=�6.   $
��Test��6B   $	��100��6N   $	��375��6[   $��10,10,10,10q�6g   
���   �
�������6�   57      � 59   
   $��0,396,-2,-40q�6   $��2��6*   .+�5:      �� -   5        $ CbTeams��5:      $	��120��6(   $
��Left=�64   $��5,5,0,5q�6O   6`   �� 5;      -   5        $ LbTijd��5;      $
��Tijd��6$   $	��143��63   $��	10,5,0,10q�6?   $��27��6R   �� 5<      -   5         ��Name$ ImgPadel��5<      $��41��6&   $	��178��62   $��10,0,0,0q�6?   $��/padelStart.jpg��6Q    J� OpacityMask 5=      �� 5>       �� ImageSource$ /padelStart.jpg��6!   5A      5B      5D      5E      