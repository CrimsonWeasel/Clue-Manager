   M S B A M L   `   `   `  ����I  EContactManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ContactManager.UserControlsContactManager.UserControls  5   	       ContactManager.Shell   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8uc)clr-namespace:ContactManager.UserControls     5   	     � Title$  Contact Manager��5   	   $	��600��5   	   $	��800��5   	   .��5      ]� .+�5	   
   +   %ContactManager.UserControls.SearchBar  $	��Top=�6   �� 5
   
   $��Bottom=�5   	   .@�5      �� $��Right=�5   	   .��5      �� -   5         ��Name$ 
zoomSlider��5   	   $	��125��5   	    � Value$ 1Q�5   	    � Minimum$ .5Q�5   	    � Maximum$ 2Q�5   	   5      �� 5      $��Right=�5   	   .��5      �� Zoom:6#   5      �� 5      .��5      �� ��5   	   �� *
StatusText+5      5      9� 5   
   $
��Left=�5    	    9� ExpandDirection$ Right=�5!   	    9� 
IsExpanded . $��0 1 1 1q�5#   	   
�������$��0 2 0 0q�5%   	   $��2q�5&   	   ��5'      �� 5(      $��Contacts��5)   	   $��14(�5*   	   $
��Bold"�5+   	    � LayoutTransform 5,   
   �� 5-   
    �� Angle$ 90Q�5.   	   50      .��52      )   #ContactManager.UserControls.SideBar  53      �� 54   
   -   5        	 ��Name$
	 tabs��55   	   $��2��56   	   $	��5 0q�57   	    58      �� 59      
 �� ScaleX
 5:   	   ��  �� ElementName$ 
zoomSlider�� �� Path$ Value� �� ScaleY 5=   	   �� $ 
zoomSlider��$ Value�5A      5B      5C      