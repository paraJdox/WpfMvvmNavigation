   M S B A M L   `   `   `  ����I  ENavigationMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:NavigationMVVM.ComponentsNavigationMVVM.Components  5      -    'NavigationMVVM.Components.NavigationBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:NavigationMVVM.Components     5      
���\\��  � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value    BooleanToVisibilityConverter��%3  '��       &	      �� 5   
   " ��6   .�5      ��  � ��
 ���� 5      �� 5       � ��
 �����5      �� 5       � ��$ 0q�5      �� 5       �@�Cursor$
 Hand��5      �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   5      5       5      P� 5       �@J�IsMouseOver$
 True��5      . �5      ��  � �� 5       �� 5!      " ��6.   .R�5"   "   �� #��z��6,   $��	Underline{�5#   ,   5$      5&      5'      5)      �� 5*   
   6'   5+      .��5,      � $
��1000��6   $��20,10q�5-       � ColumnDefinitions 5.   
   �� 5/      $��* �6   �� 50      $
��auto �6   �� 51      $
��auto �6   �� 52      $
��auto �6   �� 53      $
��auto �6   .+�56   
   �� $��0��6   $��Navigation Demo��57      
�������$��14(�59      �� 5;   
   $��1��6   $��10,0,0,0q�5<      $
��Home��5=      ��5>      �� *NavigateHomeCommand+�� 5@   
   $��2��6   $��10,0,0,0q�5A      $��Login��5B      ��5C      �� *NavigateLoginCommand+�� 5E   
   $��3��6   $��10,0,0,0q�5F      $��Account��5G      y�5H      �� *
IsLoggedIn+	 �� 	Converter#	 [  ��5I      �� *NavigateAccountCommand+�� 5K   
   $��4��6   $��10,0,0,0q�5L      $��Logout��5M      y�5N      �� *
IsLoggedIn+#	 [  ��5O      �� *LogoutCommand+5P      5Q      