   M S B A M L   `   `   `  ����J  FGestionScolaire, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GestionScolaireGestionScolaire  5   	        GestionScolaire.MainWindow   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:GestionScolaire     5   	     � Title$  
MainWindow��5   	   $	��466��6   $��730.667��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $��
295,35,0,0q�6+   $	��Top=�6?   �� 5   
   $��CLASSE AJOUTEE��6   $
��Left=�6)   $��	269,4,0,0q�6D   $	��Top=�6W   $	��186��6o   $��20(�6{   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��24��6/   $��	10,35,0,0q�6;   $	��Top=�6N   $
��1164��6f   �� 5   
   $��CODE :��6   $
��Left=�6!   $��	81,58,0,0q�6<   $	��Top=�6O   $	��111��6g   $
��Bold"�6s   $��14(�6�   �� 5   
   -   5         ��Name$ codeTbx��5      $
��Left=�6#   $��23��6>   $��
229,64,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��395��6�   $��14(�6�    �� TextDecorations 6�   Z� �� 5   
   $��	LIBELLE :��6   $
��Left=�6$   $��	81,92,0,0q�6?   $	��Top=�6R   $	��111��6j   $
��Bold"�6v   $��14(�6�   �� 5   
   -   5        $ 
libelleTbx��5      $
��Left=�6&   $��23��6A   $��
229,92,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��395��6�   $��14(�6�    6�   Z� �� 5   
   $��FRAIS D'INSCRIPTION :��6   $
��Left=�60   $��
34,120,0,0q�6K   $	��Top=�6_   $	��158��6w   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5        $ fraisinscriptionTbx��5      $
��Left=�6/   $��23��6J   $��229,120,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��395��6�   $��14(�6�    6�   Z� �� 5   
   $��MENSUALITE :��6   $
��Left=�6'   $��
81,148,0,0q�6B   $	��Top=�6V   $	��111��6n   $
��Bold"�6z   $��14(�6�   �� 5   
   -   5        $ mensualiteTbx��5      $
��Left=�6)   $��23��6D   $��229,148,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��395��6�   $��14(�6�    6�   Z� �� 5   
   $��	FILIERE :��6   $
��Left=�6$   $��
81,177,0,0q�6?   $	��Top=�6S   $	��111��6k   $
��Bold"�6w   $��14(�6�   �� 5   
   -   5         ��Name$ 
filiereCbx��5      $
��Left=�6'   $��229,177,0,0q�6B   $	��Top=�6W   $	��395��6o   $��29��6{   �� 5   
   -   5         ��Name$ saveBtn��5      $��ENREGISTRER��6"   $
��Left=�68   $��229,233,0,0q�6S   $	��Top=�6h   $	��126��6�   $��31��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	classeDtg��5   a      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6      AlternatingRowBackground
 � ���	   AutoGenerateColumns	 .  $
��Left=�6t   $	��142��6�   $��
81,285,0,0q�6�   $	��Top=�6�   $	��590��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 CODE��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *code+  5      $ LIBELLE��6%    66   �� *	libelle+  5      $ FRAIS D'INSCRIPTION��6%    6B   �� *fraisinscription+  5      $ 
MENSUALITE��6%    69   �� *
mensualite+  5      $ FILIERE��6%    66   �� *Filiere.libelle+5       �� 5!   
   -   5        $ 
nouveauBtn��5!      $��NOUVEAU��6%   $
��Left=�67   $��
81,233,0,0q�6R   $	��Top=�6f   $	��122��6~    J� RenderTransformOrigin$ 0.436,-0.839&�6�   $��31��6�   6�   �� 5"   
   -	   5        $ 	deleteBtn��5"      $��	SUPPRIMER��6$   $
��Left=�68   $��559,233,0,0q�6S   $	��Top=�6h   $	��112��6�   $��31��6�   6�   �� 5#   
   -
   5        $ 	updateBtn��5#      $��MODIFIER��6$   $
��Left=�67   $��383,233,0,0q�6R   $	��Top=�6g   $	��140��6   $��31��6�   6�   5'      5(      