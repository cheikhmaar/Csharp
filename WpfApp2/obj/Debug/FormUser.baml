   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.FormUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  FormUser��5   	   $��761.252��6   $
��1043��6+   .��5	      � $��Center=�6   .+�5
   
   �� $��Username��6   $
��Left=�6#   $��
134,24,0,0q�6>   $	��Top=�6R   $	��126��6j   $��22(�6v   �� 5   
   $��Prenom & Nom��6   $
��Left=�6+   $��	82,78,0,0q�6F   $	��Top=�6Y   $��22(�6q   �� 5   
   $��	Telephone��6   $
��Left=�6$   $��128,138,0,0q�6?   $	��Top=�6T   $��22(�6l   �� 5   
   $��Adresse��6   $
��Left=�6"   $��140,206,0,0q�6=   $	��Top=�6R   $��22(�6j   �� 5   
   $��Profil��6   $
��Left=�6!   $��162,264,0,0q�6<   $	��Top=�6Q   $��22(�6i   �� 5   
   -   5         ��Name$ TextBoxUsername��5      $
��Left=�6+   $��38��6F   $��
303,26,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��271��6�   �� 5   
   -   5        $ TextBoxNomComplet��5      $
��Left=�6-   $��37��6H   $��
303,82,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��271��6�   �� 5   
   -   5        $ TextBoxTelephone��5      $
��Left=�6,   $��39��6G   $��303,142,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��271��6�   �� 5   
   -   5        $ TextBoxAdresse��5      $
��Left=�6*   $��39��6E   $��306,206,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��268��6�   �� 5   
   -   5         ��Name$ ComboBoxProfil��5      $
��Left=�6+   $��306,268,0,0q�6F   $	��Top=�6[   $	��270��6s   $��36��6   �� 5   
   -   5         ��Name$ 	ViewImage��5      $
��Left=�6#   $	��222��6>   $��
673,82,0,0q�6K   $	��Top=�6_   $	��244��6w   �� 5   
   -   5         ��Name$ ButtonChoixPhoto��5      $��Choisir photo��6+   $
��Left=�6C   $��
673,24,0,0q�6^   $	��Top=�6r   $	��244��6�   $��38��6�   $��22(�6�   6�   �� 5   
   -   5        $ ButtonNouveau��5      $��Nouveau��6(   $
��Left=�6:   $��
62,353,0,0q�6U   $	��Top=�6i   $	��171��6�   $��36��6�   $��22(�6�   6�   �� 5   
   -	   5        $ ButtonEnregistrer��5      $��Enregistrer��6,   $
��Left=�6B   $��292,353,0,0q�6]   $	��Top=�6r   $	��171��6�   $��36��6�   $��22(�6�   6�   �� 5   
   -
   5        $ ButtonModifier��5      $��Modifier��6)   $
��Left=�6<   $��530,352,0,0q�6W   $	��Top=�6l   $	��171��6�   $��36��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��22(�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.926Q�6&   T� 5      5      5!      �� 5"   
   -   5        $ ButtonSupprimer��5"      $��	Supprimer��6*   $
��Left=�6>   $��790,353,0,0q�6Y   $	��Top=�6n   $	��171��6�   $��36��6�   $��22(�6�   6�   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ dataGridUsers��5#   �   $��0,0,2,-8q�6   	 �� TextAlignment$	 Center=�6&   $��19(�6G   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6_      AutoGenerateColumns .  $��Center=�6�   $	��283��6�   $��
62,418,0,0q�6�   $	��Top=�6�   $	��899��6�      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      $��15(�6%   ,  &System.Windows.Controls.DataGridColumn   Header$ USERNAME��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *
username+  5&      $��15(�6%   $ PRENOM et NOM��6?    6V   �� *
nomComplet+  5'      $��15(�6%   $ 	TELEPHONE��6?    6R   �� *tel+  5(      $��15(�6%   $ ADRESSE��6?    6P   �� *	adresse+4  .System.Windows.Controls.DataGridTemplateColumn  5)      $ PHOTO��6)      Width$ SizeToCells 68      CellTemplate 5*      �� 5+      .R�5,      �� $
��40px��6$   $
��70px��62   ��6@   �� *photo+5-      5/        50      $��15(�6%   $ PROFIL��6?    6O   �� *profil.libelle+52      53      54      