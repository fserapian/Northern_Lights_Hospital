   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.PreposeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Gestion d'admission��5   	   $	��700��6%   $	��900��62   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��	37,23,0,0q�6/   $
��Wrap=�6B   $��Liste des admissions��6V   $	��Top=�6r   $��25(�6�   $
��Bold"�6�   $��30��6�   $	��257��6�   �� 5   
   -   5         ��Name$ 	txtSearch��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Recherche par NSS��6%   $
��Left=�6X   $��23��6s   $��	37,79,0,0q�6    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��203��6�   6�   �� 5   
   -   5        $ txtSearchName��5      $" Recherche par nom de patient��6)   $
��Left=�6g   $��23��6�   $��
283,79,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   6�   �� 5   
   -   5        $ txtSearchMed��5      $# Recherche par nom de médecin��6(   $
��Left=�6f   $��23��6�   $��
533,79,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   6�   �� 5   
   -   5         ��Name$ btnEnregistrer��5      $ ��Enregister nouveau patient��6)   $
��Left=�6N   $��
663,23,0,0q�6i   $	��Top=�6}   $	��201��6�   
���P��6�   �� 5   
   -   5        $ btnAdmission��5      $��Ouvrir dossier admission��6'   $
��Left=�6J   $��
452,23,0,0q�6e   $	��Top=�6y   $	��192��6�   
���   �
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridDossiers��5      $
��Left=�6)   $	��532��6D   $��
10,128,0,0q�6Q   $	��Top=�6e   $	��874��6}   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Dossier.IdAdmission+6Y   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 	Chirurgie��6)      CanUserResize .  $ 80 6R      CellTemplate 5       �� 5!      .R�5"      �� ��5#   "   �� 5$   &    �� 
TargetType" ��6,   .�5%   *   ��  �� Property � �� �� Value$	 Non��6A    �� Triggers 5&   *   �� 5'   .    �� Binding 6:   �� *Dossier.Chirurgie+ �� Value True6`   .a�5(   2   ��  � ��$	 Oui��6I   5)   /   5+   '   5-      5.      50        52      $
 Date Admission��6%   $	 175 6g    6=   �� *Dossier.DateAdmission+6g     53      $
 Date Congé��6%   $	 175 6t    69   �� *Dossier.DateConge+ �� TargetNullValue$	 N/A��6t     54      $	
 NSS��6%   $ 60 6R    62   �� *Dossier.NSS+6R     55      $
 Patient��6%   $	 100 6[    66   �� *Patient.FullName+6[     56      $
 N. Lit��6%   $ 60 6X    65   �� *Dossier.NumLit+6X     57      $
 Médecin��6%   $ * 6[    66   �� *Medecin.FullName+6[    � 	Resources 59      =	  7System.Windows.Controls.Primitives.DataGridColumnHeader��%Y   '	        �� 5:      " 	 6   .�5;      ��  � ��$
 Bold"�63   6B   5<      5=      5>      5?      5@      