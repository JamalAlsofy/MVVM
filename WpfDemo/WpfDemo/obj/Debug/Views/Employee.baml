   M S B A M L   `   `   `  ????B  >WpfDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfDemo.ViewsWpfDemo.Views  5   	       WpfDemo.Views.Employee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfDemo.Views     5   	     ? Title$  Employee??5   	   $	??450??6   $	??800??6'   .??5
      ? $??15q?6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??Employee Management??6   $??0??5      $??0??5      $??2??5      $??20(?5      $
??Bold"?5      $??Center=?5      $	??5,8q?5        ?? Padding$ 3q?5!      ?? 5"   
   $??Enter Id??6   $??1??5#      $??0??5$      $	??5,8q?5%      $ 3q?5&      ?? 5'   
   $??
Enter Name??6   $??2??5(      $??0??5)      $	??5,8q?5*      $ 3q?5+      ?? 5,   
   $??	Enter Age??6   $??3??5-      $??0??5.      $	??5,8q?5/      $ 3q?50      ?? 52   
   -   5        $??txtId??52      $??1??53      $??1??54      $	??5,8q?55      $??3q?56      ??57      ??  ?? Path$ CurrentEmployee.Id? ?? Mode$ TwoWay=??? 58   
   -   5        $??txtName??58      $??2??59      $??1??5:      $	??5,8q?5;      $??3q?5<      ??5=      ?? $ CurrentEmployee.Name?$ TwoWay=??? 5>   
   -   5        $??txtAge??5>      $??3??5?      $??1??5@      $	??5,8q?5A      $??3q?5B      ??5C      ?? $ CurrentEmployee.Age?$ TwoWay=??? 5E   
    ?? Orientation$ 
Horizontal=?6   $??4??5F      $??1??5G      .+?5H      ?? -   5        $??btnAdd??5H      $	??ADD??5I      $	??5,8q?5J      $??3q?5K      ??5L      ?? $ SaveCommand??? 5M      -   5        $??	btnSearch??5M      $??SEARCH??5N      $	??5,8q?5O      $??3q?5P      ??5Q      ?? $ SearchCommand??? 5R      -   5        $??	btnUpdate??5R      $??UPDATE??5S      $	??5,8q?5T      $??3q?5U      ??5V      ?? $ UpdateCommand??? 5W      -   5        $??	btnDelete??5W      $??DELETE??5X      $	??5,8q?5Y      $??3q?5Z      ??5[      ?? $ DeleteCommand?5\      ?? 5]   
   -   5        $??txtBlockMessage??5]      $??5??5^      $??1??5_      $	??5,8q?5`      $ 3q?5a      ??5b      ?? $ Message?&   System.Windows.Controls.DataGrid  5c   
   -	   5        $??dgEmployees??5c         AutoGenerateColumns .  $??6??5e      $??1??5f      $	??5,8q?5g      $??3q?5h      ??5i      ?? $ EmployeesList?$ TwoWay=?   Columns 5j      0  *System.Windows.Controls.DataGridTextColumn  5k      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Employee Id??6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 5l   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5m   %   ?? $ Id?  5n      $	 Employee Name??6%   $

 auto 5o   %    5p   %   ?? $
 Name?  5q      $	 Employee Age??6%   $

 auto 5r   %    5s   %   ?? $	 Age?5u      5v      5x      