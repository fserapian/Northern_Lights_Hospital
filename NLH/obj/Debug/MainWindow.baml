   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ NLH  |  Authentification��5   	   $	��500��6*   $	��350��67   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      ��5      #fff��6(   5      �� 5   
   $��img/hospital_logo.png��6   $	��150��6/   $	��150��6;   $	��top=�5      $��20q�6(   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0, 50q�6U    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ #fbbb��6#      	Direction$ 0Q�61      
BlurRadius$ 15Q�6?      RenderingBias$ Quality=�5   #      ShadowDepth$ 1Q�6;   5       � 5!   
   $	��280��6   $	��240��6   $��Bottom=�6(   $
��0,50q�5"      .+�5#      �� $��Authentification��6   $��Center=�60   $	��Top=�6N   $��5q�5$      
�������$��18(�63   �� 5%      $��Center=�6   $��10q�64   .+�5&      �� -   5        	 ��Name$	 txtUsername��5&      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Username��6/   $
��0,10q�6Y   G� 5'      -   5         G�Name$ txtPassword��5'      $
 Password��63   $
��0,10q�6]   5(      5)      �� 5*   
   -   5         ��Name$ btnLogin��5*      $��Bottom=�6#   $	��100��6>   $��30��6J   $
��0,40q�6V   $��Login��6d    �� 	IsDefault . 
���   �6�   5+      5,      