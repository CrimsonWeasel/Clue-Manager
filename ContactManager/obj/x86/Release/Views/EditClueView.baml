   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem   ContactManager*   $ContactManager.Views.EditContactView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6sys&clr-namespace:System;assembly=mscorlib     .��]� $��5q�.+��� $	��Top=� 
  header#��[  ._�]� ��.  .+��� $
��Left=����� *Clue.ClueText+�� $��Right=�  buttonPanel#��[ .+��� -   $
��Save���� -   $��Delete���� -   $��Close��� .+��   � ColumnDefinitions  �� $
��Auto ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $
��Auto �.+���   lightBlueBrush#��[ $��0��$��0������ #��[   groupBoxHeader#��[ ._��� $
��Clue��.���   �� $
��Auto ��� $
��Auto ��� $	��140 ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��1��$��_Clue:�� �� Target ��  �� ElementName$ clueText���� -    ��Name$
 clue��$��2������ *Clue.ClueText+�� $��1��$��1��$��_New Answer:�� �� $ answer���� -   $ newAnswerTextBox��$��1��$��2��$��Type new answer���� -   $��
add_Answer��$��1��$��3��.��Add�� $��2��$��1��$��_Date Entered:�� �� $ dateEntered��(  "System.Windows.Controls.DatePicker  -     Name$ dateEntered��$��2��$��2��   SelectedDate �� *Clue.DateEntered+�� #��[ $��0��$��1��$��2������ #��[ #��[ ._��� $��Answer List��.���   �� $
��Auto �$��70���� $
��Auto �$��70�� �� $
��Auto �$��80���� $
��Auto �.+�� $��1��$��2��.+��� #��[ $��2q�
������  �� CornerRadius$ 6��$��0 0 2 2q��� -    ��Name$ answersListBox��
�������#��[ #��[ ���� *Clue.AnswerCollectionForClue+	 � DataContext	 �� ���� .R��� ���� *
AnswerText+�� -	   $��selectAnswer��$��20��$��0��.��Select�� -
   $��deleteAnswer��$��20��$��1��.��Remove�� -   
 ��Name$
 answerGroupBox��$��1��$��0��#��[ ���� #��[ #��[ ._��� $��Answer Detail��.���   �� $
��Auto ��� $	��150 ��� $��40 ��� $
��auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��_Answer:�� �� $ 
AnswerText���� -   $ 
answerText��$��0��$��1������ $ answersListBox�� �� Path$ SelectedItem.AnswerText��� $��1��$��_Explanation:�� �� $ explanation���� -   $ explanation��$��1��$��1��$��2������ $ answersListBox��$ SelectedItem.Explanation��� $��2��$��Example:�� �� $ example���� -   $ example��$��2��$��1��$��2������ $ answersListBox��$ SelectedItem.Example��� $��3��$��0��$��Origin:�� �� $ origin���� -    ��Name$ origin��
�������$��3��$��1������   
originList �� Source# [  �� SelectedItem �� $ answersListBox��$ SelectedItem.Origin��� $��4��$��0��$��Date Entered:�� �� $ enteredDate��  -   $ dateAnswerEntered��$��4��$��1�� �� $ answersListBox��$$ SelectedItem.DateAnswerEntered��� $��5��$��0��$��Puzzle Number:�� �� $ puzzleNumber���� -   $ puzzleNumber��$��5��$��1������ $ answersListBox��$ SelectedItem.PuzzleNumber�