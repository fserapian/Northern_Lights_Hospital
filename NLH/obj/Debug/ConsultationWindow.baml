   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.ConsultationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	     � Title$  Tableau de consultation��5   	   $	��600��6)   $
��1100��66   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridPatients��5
      $
��Left=�6-   $	��448��6H   $��
10,114,0,0q�6U   $	��Top=�6i   $
��1075��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Patient.FullName+6W     5      $ Date de naissance��6%   $	 155 6j    6@   �� *Patient.DateNaissance+6j     5      $ Adresse��6%   $	 150 6Z    66   �� *Patient.Adresse+6Z     5      $ Ville��6%   $	 100 6V    64   �� *Patient.Ville+6V     5      $ Province��6%   $	 100 6\    67   �� *Patient.Province+6\     5      $ Code Postal��6%   $	 110 6a    6:   �� *Patient.CodePostal+6a     5      $ Téléphone��6%   $	 100 6^    68   �� *Patient.Telephone+6^     5      $ 	Assurance��6%   $	 100 6X    68   �� *CompanyName+6X     5      $ Parent��6%   $ * 6Z    65   �� *Parent.FullName+6Z    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value��%Y   '        �� 5      "  6   .�5      ��  � ��$
	 Bold"�63   6B   5      5      5      �� 5   
   -   5        
 ��Name$
 	btnCancel��5      $��Annuler��6$   $
��Left=�66   $��
436,26,0,0q�6Q   $	��Top=�6e   $��94��6}   
���   �6�   �� 5   
   $ ��Le tableau de consultation��6   $
��Left=�66   $��	10,15,0,0q�6Q   $	��Top=�6d   $��30(�6|   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��	10,60,0,0q�6/   $
��Wrap=�6B   $��Liste de patients��6V   $	��Top=�6o   $��25(�6�   5       5!      