   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5       ContactManager*   $ContactManager.Views.ContactListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5      @d2http://schemas.microsoft.com/expression/blend/2008      5      SComponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase      5        � 	Resources  5	         
clueSource �� Source �� SortDescriptions+   %System.ComponentModel.SortDescription   PropertyName��%q   &	        �� 5
   
    5      �� *
AllClues+ 5        5      $ 
LookupClue��61   5      5      .��5      ]� $��5q�6   .+�5   
   �� $	��Top=�6    
 header#��[ 5      ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $�� ��6   �� 5      ��6   �� *AllClues.Count+�� 5      $�� Clues��6   5      5      �� 5   
   $��Bottom=�6     buttonPanel#��[ 5      .+�5      �� -   5        $��Close��5      5      5      �� 5    
   $��5q�6   ��5!      ��  �� Source# [   �� View 5"      �� 5#      .P�5$      ��  �� CellTemplate 5%      �� 5&      .R�5(   "   �� -   5          
openButton#��[ 5(   )   5)   )   5*      5,      �� 5-      $��	Clue Text��6%    �� DisplayMemberBinding 5.   %   �� *
ClueText+�� 50      $��Date Entered��6%    51   %   �� 	 �� Path$	 DateEntered�52      54      55      56      