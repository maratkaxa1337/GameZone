   M S B A M L   `   `   `  ����?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Shop.Views.PagesShop.Views.Pages  5      &     Shop.Views.Pages.ViewsClientPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Shop.Views.Pages     5      -   5          N� Title$  ViewsClientPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $
��0.4* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� .+�5      �� -   5         ��Name$ BtnBack��5      $��
Назад��5      $	��150��5      $��30��5      5      5      �� 5      $ 
Horizontal=�6   $��
 300 0 0 0q�62   $��Center=�6F   $��Center=�6a   .+�5      �� $��
Поиск��6   $��30(�5      �� 5      -   5         ��Name$ 
SearchFile��5      $	��300��5      $��30��5       5"      5$      &   System.Windows.Controls.DataGrid  5&      -   5          Name$ DataView��5&   U      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 63      
IsReadOnly . $��1��6g   	   Columns	 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+  5)      $
 Фамилия��6)    6:   �� *
LastName+  5*      $
 Имя��6)    66   �� *	FirstName+  5+      $
 Отчество��6)    6;   �� *
Patronymic+  5,      $
 Пол��6)    66   �� *Gender.Title+  5-      $
 Телефон��6)    6:   �� *Phone+  5.      $
 Дата Рождения��6%    6<   �� *DateOfBirth+ �� StringFormat$ {0:dd.MM.yyyy}��  5/      $
 
Почта��6)    68   �� *Email+  50      $%
 Дата Регистрации��6%    6?   �� *DateRegister+$ {0:dd.MM.yyyy}��52      �� 55   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�56      �� -   5        $ 	Btndelete��56      $��Удалить��57      $	��200��58      $��30��59      5:      �� 5;      -   5        $ BtnEdit��5;      $"��Редактирование��5=      $	��200��5>      $��30��5?      $��15 0 0 0q�5@      5A      5B      5C      