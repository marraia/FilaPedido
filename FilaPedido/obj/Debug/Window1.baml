   M S B A M L   `   `   `  ����E  AFilaPedido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FilaPedido
FilaPedido  5   	   b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5   	       FilaPedido.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:FilaPedido     5   	   ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5   	   -   5          � Title$  Gerenciador de Fila��5	   	   $��417.143��6%   $��888.571��66    � 
ResizeMode$ NoResize=�6F   ���	#FF060606 � WindowStyle$
 None=�6�   .��5      � 
���   �.+�5   
   �� 
�������$��1q�6%   $��1��69   $
��Left=�6I   $��49��6d   $��	10,10,0,0q�6p   $	��Top=�6�   $	��870��6�   $��4��6�   ._�5      �� -   5         ��Name$ cboItem��5      
���   ����	#FF7030A0 �� SelectedValuePath$ Id��6R    �� DisplayMemberPath$
 Nome��6i   $��30(�6�   $
��Bold"�6�   $��Center=�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �   �67   �� 5       � ��
 �   �68   5      5      5      �� 5   
   
�������$��1q�6%   $��1��69   $
��Left=�6I   $	��100��6d   $��	10,64,0,0q�6q   $	��Top=�6�   $	��190��6�   ._�5      �� -   5        	 ��Name$	 
lblEntrada��5      $��Label��6(   $��1��68   5      �� 5   
   
�������$��1q�6%   $��1��69   $
��Left=�6I   $	��100��6d   $��
10,170,0,0q�6q   $	��Top=�6�   $	��190��6�   ._�5      �� -   5        $	 lblPreparacao��5      $��Label��6+   $��1��6;   5      �� 5   
   
�������$��1q�6%   $��1��69   $
��Left=�6I   $	��100��6d   $��
10,277,0,0q�6q   $	��Top=�6�   $	��190��6�   ._�5      �� -   5        $	 lblSaida��5      $��Label��6&   $��1��66   5      �� 5   
   -   5        
 ��Name$
 gridItem��5      
�������$��1q�67   $��1��6K   $
��Left=�6[   $	��313��6v   $��
205,64,0,0q�6�   $	��Top=�6�   $	��675��6�   $��4��6�   ._�5       &   System.Windows.Controls.DataGrid  -   5          Name$ dgItem��5          
IsReadOnly .    AutoGenerateColumns .  
���   �   HeadersVisibility$
 None=�6h      RowBackground
 �   �   GridLinesVisibility$
 None=�6�   ���	#FFF9FBFD � ContextMenu 5!      �� 5"      -   5        .@�5#      m� -	   5        $��opNovo��5#   #   $
��Novo��61   m� 5$      -
   5        $��
opPreparar��5$   #   $��Em Preparação��65   m� 5%      -   5        $��opExibir��5%   #   $��Exibir no Painel��63   6M   5&         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      -   5        
Pedido��,  &System.Windows.Controls.DataGridColumn   Header$ Pedido��5+         
FontFamily$ Calibri)�5,         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5-      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*      �� *Pedido+5-        5.      -   5        	Descricao��$ 	Descricao��50      $ Calibri)�51      $	 200 52       5/      �� *	Descricao+52        53      -   5        
Quantidade��$ 
Quantidade��55      $ Calibri)�56      $	 200 57       54      �� *
Quantidade+57        58      -   5        Tipo��$
 Tipo��5:      $ Calibri)�5;      $	 150 5<       59      �� *Tipo+   ElementStyle 5=      �� 5>      " ��6$   .�5?   "   ��  � ��$ Right=�6H   5@      5B      5D      5E      �� 5F   
   -   5         ��Name$ 	btnFechar��5F      $��Fechar��6$   $
��Left=�65   $��778,382,0,0q�6P   $	��Top=�6e   $	��101��6}   $��27��6�   ���	#FF0224FF
�������6�   5G      5H      