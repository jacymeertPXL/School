   M S B A M L   `   `   `  ����G  CProef_Examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Proef_ExamenProef_Examen  5   	       Proef_Examen.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Proef_Examen     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$
 Grid��5
      $��0,4,3,36q�6   $��Right=�6+   $	��796��6G    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ PanelLinksBoveb��5      $��10q�6.   
����p��.+�5      �� $$��Who wants to  be a millionaire��6   $��Center=�6=   $��22(�6a   $
��Bold"�6o   �� 5      $��88��6   $	��264��6    $#��/WhoWantsToBeAMillionaire.jpg��6,    J� OpacityMask 5      �� 5       �� ImageSource$# /WhoWantsToBeAMillionaire.jpg��6!   5      �� 5      -   5         ��Name$ LbPrijs��5      $��0��6%   $��Center=�61   $��36��6U   $��24(�6a   $��Center=�6o   $	��394��6�   5      �� 5   
   -   5        $ PanelRechtsBoven��5      $��10q�6/   $��1��6;   #��� ��6K   .+�5       �� -   5         ��Name$ TxtWeergaven��5       $��1��6,   $
��Left=�6<   $��	19,19,0,0q�6W   	 �� TextWrapping$
	 Wrap=�6j   $	��341��6~   $	��143��6�   ${�False��6�   $��Courier New)�6�   $��14(�6�   ���	#FFE4DCDC#��� ��6�   5!      �� 5#   
   -   5        $ PanelLinksOnder��5#      $��10q�6.   $��1��6:   .+�5$      	� -   5        
 	�Name$
 RdbEen��5$   <    	� 	GroupName$ OnlyOneCanGetChecked2��6   $��50/50��6L   $��30��6\   $
��auto��6h   6u   	� 5%      -   5        $
 RbdTwee��5%   <   $ OnlyOneCanGetChecked2��6   $��50/50��6M   $��30��6]   $
��auto��6i   6v   	� 5&      -	   5        $
 RdbDrie��5&   <   $ OnlyOneCanGetChecked2��6   $��50/50��6M   $��30��6]   $
��auto��6i   6v   �� 5'      -
   5         ��Name$ LstHint��5'      $��73��6'   $	��366��63   5(      �� 5*   
   -   5        $ PanelRechtsOnder��5*      $��10q�6/   $��1��6;   $��1��6K   ���	#FFE0DDDD.+�5+      	� -   5        $
 RdbAnswerOne��5+      $ OnlyOneCanGetChecked��60   $
��Test��6Q   $��25��6`   $	��368��6l   $��0,25,0,0q�6x   	� 5,      -   5        $
 RdbAnswerTwo��5,      $ OnlyOneCanGetChecked��60   $
��Test��6Q   $��25��6`   $	��368��6l   	� 5-      -   5        $
 RdbAnswerThree��5-      $ OnlyOneCanGetChecked��62   $
��Test��6S   $��25��6b   $	��368��6n   	� 5.      -   5        $
 RdbAnswerFour��5.      $ OnlyOneCanGetChecked��61   $
��Test��6R   $��25��6a   $	��368��6m   �� 5/      -   5         ��Name$ 	BtnAnswer��5/      $��Final Answer��6(   $	��366��6?   6K   50      � 52   
   $��1��6   $��0,194,173,-46q�6!   .+�53      �� -   5        $ LbTijd��53      $��De tijd��6$   $��42��66   $	��111��6B   $	��Top=�6N   $��Center=�6f   �� 54      -   5         ��Name$ CbWeergaven��54      $	��107��6,   $��23��68   .@�55      �� -   5         ��Name$ CbTijd��55      $
��Tijd��6/    �� 
IsSelected$
 True��6>   �� 56      -   5        $ CbDag��56      $	��Dag��6.   �� 57      -   5        $ CbTijdEnDag��57      $��Dag en Tijd��64   58      59      5<      5=      