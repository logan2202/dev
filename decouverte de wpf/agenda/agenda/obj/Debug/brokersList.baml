   M S B A M L   `   `   `  ����A  =agenda, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:agendaagenda  5          agenda.brokersList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:agenda     5        N� Title$  brokersList��5	       N� 
Background 5      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ White��6   � 5      $ 	#FFDADADA��6    � Offset$ 1Q�6-   5      .��5      � .+�5   
   �� ���	#FF4B6AA2$
��Bold"�6+   $��18(�6=   $��	30,10,0,0q�6K   Liste des Courtiers6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ listBrokersDataGrid��5   7      AutoGenerateColumns .  	   AlternatingRowBackground	 �	#FFEEEEEE
 �� AlternationCount$
 2��5   8      CanUserAddRows .     CanUserResizeRows .  $	��Top=�5      $
��Left=�6+   $��	30,50,0,0q�6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *
lastname+  5      $ Prénom��6%    65   �� *	firstname+  5      $
 Mail��6%    63   �� *mail+  5      $	 Tel��6%    62   �� *phoneNumber+5       � 5!   
   -   5         �Name$ 
EditBroker��5!      $	��Top=�6#   $��Right=�6;   $��0,0,20,0q�6W   $y�Hidden=�6i   ��5"      �� 5#      $ 0.5,1&�6&   $ 0.5,0&�67   .��5$      � $ 	#FFE2E2E2��6#   $ 1Q�65   � 5%      $ White��6#   5&      .+�5(      �� ���	#FF4B6AA2$��4q�6-   ._�5)      �� $	��250��6   $��20q�6)   .+�5*      �� -   5         ��Name$ Cancel��5*      $��30��6-   
�������$��Right=�6`   ��5+      �� 5,       �� Color$ 	#FFD81E1E��6.   .��5-   -   X5.      �� 5/      ���	#FF4B6AA2$
��Bold"�67   $��18(�6I   $��0,0,0,10q�6W   Modifier un courtier6   �� 50      $
��Bold"�6   ���	#FF4B6AA2$	��Nom��6E   �� 51      -   5         ��Name$ BrokerLastName��51      �� 52      $
��Bold"�6   ���	#FF4B6AA2$��Prénom��6E   �� 53      -   5        $ BrokerFirstName��53      �� 54      $
��Bold"�6   ���	#FF4B6AA2$
��Mail��6E   �� 55      -   5        $ 
BrokerMail��55      �� 56      $
��Bold"�6   ���	#FF4B6AA2$	��Tel��6E   �� 57      -   5        $ BrokerPhone��57      �� 58      -   5        $
 Save��58      $	��100��6+   ���	#FF4B6AA2
�������$��0,20,0,5q�6a   .��6�   Enregistrer6�   �� 59      -	   5        $ Delete��59      $	��100��6-   ���	#FFD81E1E
�������.��6x   	Supprimer6�   5:      5;      5<      5=      5>      