   M S B A M L   `   `   `  ????K  GKnapsack_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Knapsack_ProjectKnapsack_Project  5   	   !    Knapsack_Project.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	 cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah
 dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai  eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj! fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af# bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj$ fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak% gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah& dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!    	 
                        ! " # $ % & 5   	   jlocalclr-namespace:Knapsack_Project!    	 
                        ! " # $ % & 5   	     ? Title$  
MainWindow??5	   	   $	??780??6   $
??1175??6)    ? WindowStartupLocation$ CenterScreen=?66    ? AllowsTransparency$
 True??6[   
??????  ? WindowStyle$
 None=?5
   "    ? 	Resources 5         	BoolToVis??%   &	        ?? 5   
   6'   5      .??5      ?? -   5         ?? CornerRadius$ 30??5      ???#EFF2F7._?5   
   ? .+?5      ? $	??100??6   $??50??6!   $??78,37,997,693q?6-   .+?5      ?? $??36,24,-36,-24q?6   ._?5      ?? $??	0 10 0 30q?6!   .+?5      ??  ?? Orientation$ 
Horizontal=?6%   $
??Left=?6>   .+?5      A? -   5        ???#ff6258$??10??5   W   $??10??6b   5      A? 5      ???#ffbf2f$??10??65   $??10??6@   $??7 0 7 0q?6L   6`   A? 5       ???#2acb42$??10??65   $??10??6@   6O   5!      5"      5#      5%      ?? 5&      ???#6741D9$
??1185??6*   $ 40 40 0  0 ??67   $??38??6R   $??-6,-2,-4,744q?6^   ._?5'      ? $??	-2,-2,2,2q?6   5)      5+      ?? 5,      ???#6741D9$ 
0 40 40 0 ??6*   $??38??6D   $??1140,4,-3,-4q?6O   ._?5-      ? 5/      50      ?? 51      ???#6741D9$ 
0 0 40 40 ??6*   $??38??6D   $??-2,751,2,-9q?6P   ._?52      ? 54      55      ?? 56      ???#6741D9$ 
40 0 0 40 ??6*   $??38??6E   $??-6,0,1143,0q?6P   ._?57      ? 59      5:      ? 5;      $??45,45,45,45q?6    ? RowDefinitions 5<      ?? 5=      $
??auto ?6$   ?? 5>      $
??auto ?6$   ?? 5?      $
??auto ?6$   ?? 5@      $
??auto ?6$   ?? 5A      $
??auto ?6$   ?? 5B      $??* ?6$   ?? 5C      $
??auto ?6$   ?? 5D      $
??auto ?6$   ?? 5E      $
??Auto ?6$   64   .+?5L      ??   	topButton#??[ 6   $??0 0 20 0q?6<   ???#dcdcdc.??5M      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$	 Cog=?6,   5N      ?? 5P      #??[ 6   $??0 0 55 0q?6<   .??5Q        $
 Bell=?6,   5R      ?? 5U      $??Stock Market??6   $??1??60   $??32(?6=   $??SemiBold"?6K   $??0 20 0 0q?6a   ???#121518$
??Left=?6?   ? 5X      $??2??6   	 ? ColumnDefinitions	 5Z      ?? 5[      $??2* ?6+   ?? 5\      $??1* ?6+   .+?5`      ? $??20 0 0 0q?6   	 5a      ?? 5b      $??1* ?6/   ?? 5c      $??1* ?6/   ?? 5d      $??1* ?6/   .+?5g      ? $??0??6   $??	22,0,10,0q?6/   	 5h      ?? 5i   "   $	??69* ?63   ?? 5j   "   $
??131* ?63   .+?5l      ?? $??
Stock name??6(   $??13(?6;   $??SemiBold"?6I   ???#121518$
??Left=?6u   $??Center=?6?   $??12,0,0,0q?6?   $??2??6?   ?? 5m      $??	15,0,15,0q?6(   $??Center=?6;   ???#B0B9C6
 J? IsHitTestVisible$
 False??6k    K? ZIndex$ 1??5n   (   $??
Stock name??69   $??2??5o   ?   y?6(   ??  ?? ElementName$ stocknametextbox?? ?? 	Converter# [  6?   ?? 5q      -   5        $??stocknametextbox??5q   &   
???????  filterTextBox#??[ 6P   $??1??6w   $??
15,0,-84,0q?6?   5s        5t      -   5        $??stocknameicon??5t   1   $??15??6G   $??15??6R   
???  ??$??1??6p   $??Center=?6?   $??50,0,0,0q?6?   ? 5u      $	??200??6   $??1??6+   	 5v      ?? 5w   "   $	??69* ?63   ?? 5x   "   $
??131* ?63   .+?5z      ?? $??Stock value??6(   $??13(?6<   $??SemiBold"?6J   ???#121518$
??Left=?6v   $??Center=?6?   $??66,0,0,0q?6?   $??2??6?   ?? 5{      $??	15,0,15,0q?6(   $??Center=?6;   ???#B0B9C6$
 False??6k   $ 1??5|   (   $??Stock value??69   $??2??5}   ?   y?6(   ?? $ stockvaluetextbox??# [  6?   ?? 5      -   5        $??stockvaluetextbox??5   &   
???????#??[ 6Q    J? RenderTransformOrigin$ 0.506,0.608&?6x   $??1??6?   $??73,10,-142,0q?6?   $	??Top=?6?   5?        5?      -   5        $??stockvalueicon??5?   1   $??15??6G   $??Center=?6S   
???  ??$??2??6   $??
92,0,126,0q?6?   $??Stretch=?6?   ? 5?      $	??200??6   $??2??6+   	 5?      ?? 5?   "   $	??69* ?63   ?? 5?   "   $
??131* ?63   .+?5?      ?? $??Dividend??6(   $??13(?69   $??SemiBold"?6G   ???#121518$
??Left=?6s   $??Center=?6?   $??1??6?   $??47,0,0,0q?6?   ?? 5?      $??	15,0,15,0q?6(   $??Center=?6;   ???#B0B9C6$
 False??6k   $ 1??5?   (   $??Dividend for a month??69   $??2??5?   ?   y?6(   ?? $ Dividendtextbox??# [  6?   ?? 5?      -   5        $??Dividendtextbox??5?   &   
???????#??[ 6O   $??1??6v   $??113,10,-182,0q?6?   $	??Top=?6?   5?      5?      ? 5?      $??	10,6,25,0q?6   $??1??6.   .+?5?        -   5        $??Dividendicon??5?   >   $??5??61   $??15??6S   $??15??6^   
???  ??$??
124,12,0,0q?6|   ?? 5?      -	   5          	addButton#??[ 5?   !   $??0 0 0 8q?6D   .??5?      ?? $ 
Horizontal=?6)   .+?5?   "     $
 Plus=?68   $??Center=?6D   $??0 1 8 0q?6_   $??11??6p   $??11??6{   ?? 5?   "   $??Add New Company??6,   5?      5?      5?      5?      ?? 5?      -
   5        $??numbercompany??5?   ?   $?? ??6   $??4??6$   $??18(?61   $??SemiBold"?6?   ???#121518$
??Left=?6j   $??Center=?6?   6?   ?? 5?      $??Capital??6   $??4??6+   $??13(?68   $??SemiBold"?6F   $??	0 0 215 0q?6\   ???#121518$??Right=?6?   $??Center=?6?   ? 5?      $	??200??6   $??Right=?6#   $??4??6?   .+?5?      ?? $
??15 0q?6    $??Center=?6.   ???#B0B9C6$
 False??6^   $ 1??5?       $??Search in Members ...??61   y?5?       ?? $ capitaltextbox??# [  ?? 5?      -   5        $??capitaltextbox??5?   0   
???????#??[ 6F     5?      -   5        $??capitalicon??5?   -   $??15??6A   $??15??6L   $??Center=?6X   $??	173,0,0,0q?6s   
???  ??6?   5?      &   System.Windows.Controls.DataGrid  5?      -   5          Name$ companiesDataGrid??5?   ?     DataGridRowStyle1   RowStyle# ?  6     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6K     DataGridCellStyle1   	CellStyle# ?  6?     DataGridStyle1#???  6?    5?      *  $System.Windows.Controls.DataGridCell ?? 
TargetType ?? Property ?? Value??%[   '        ?? 5?      "  6    .?5?      ??  ? ??$ Center=?6D   6U   5?      5?         Columns 5?      4  .System.Windows.Controls.DataGridCheckBoxColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ C??62      CanUserResize$ False??6=      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6S     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6`      HeaderTemplate 5?      ?? 5?   "   .R?5?   &   ?? #??[ 6/   5?   #   5?      0  *System.Windows.Controls.DataGridTextColumn  5?      $ #??6.      
IsReadOnly$
 True??69   $ False??6K   $
 auto 6a      Binding 6n   ?? *Number+4	  .System.Windows.Controls.DataGridTemplateColumn	  5?      $ Stock symbol of company??61   $
 True??6R   $ * 6d    	  CellTemplate 5?      ?? 5?   "   .R?5?   &   ?? $ 
Horizontal=?61   .+?5?   *   ?? $??25??61   $??25??6<   $ 50??6H   $??0 0 10 0q?6Z   ??6l   ?? *	BgColor+._?5?   .   ?? $??Center=?6S   $??Center=?6n   
???????$??0 0 0 1q?6?   ??68   ?? *	Character+6?   5?   +   ?? 5?   *   $??Center=?6O   ??64   ?? *	StockName+6O   5?   '   5?   #   5?        5?      $ Stock value??6-   $
 True??6a   $ * 6s    6B   ?? *
StockValue+6s     5?      $ Dividend for a month??6-   $
 True??6i   $ * 6{    6K   ?? *	Dividened+6{   	  5?      $ Greedy??61   $
 True??6B   $ * 6T    5?      ?? 5?   "   .R?5?   &     $ check=?6\   $??15??6i   $??15??6t   $??Center=?6?   ???#02be68y?6<   ?? *Greedy+6?   5?   #   5?      	  5?      $ Dynamic??61   $
 True??6B   $ * 6T    5?      ?? 5?   "   .R?5?   &     $??dynamicicon??6[   $ check=?6n   $??15??6{   $??15??6?   $??Center=?6?   ???#02be68y?6<   ?? *	Dynamic+6?   5?   #   5?      	  5?      $ BackTracking??61   $
 True??6G   $ * 6Y    5?      ?? 5?   "   .R?5?   &     $??backtrackingicon??6a   $ Check=?6y   $??15??6?   $??15??6?   $??Center=?6?   ???#02be68y?6<   ?? *BackTracking+6?   5?   #   5?      	  5?      $ 
Operations??61   $
 True??6E   $
 auto 6W    5?      ?? 5?   "   .R?5?   &   ?? $ 
Horizontal=?61   .+?5?   *   ?? -   5         	 gridEditButton#??[	 5?   1   
 ? Tag 6Y   ?? *Number+.??5?   .     $ PencilOutline=?6F    
 gridButtonIcon#??[
 6[   5?   +   ?? 5?   *   -   5        $??5 0 0 0q?5?   H     gridRemoveButton#??[ 6Y    61   ?? *Number+.??5?   .     $ DeleteOutline=?6D   #??[
 6Y   5?   +   5?   '   5?   #   5?      5?      ?? 5?      $??6??6   $??Center=?6&   ???#DEE4EC$??1q?6Y   $ 5??6m     ?? Padding$  5q?6~   ???#ffffff$??
0 10 10 10q?6?   ._?5?      ?? $ 
Horizontal=?6!   .+?5?      ??   pagingButton#??[ 6!   .??5?        $ ChevronLeft=?64     pagingButtonIcon#??[ 6G   5?      ?? 5?      $??1??6$   ???#DEE4EC$	??3 7q?6=   ?? 5?      #??[ 6!   $??1??6G   ???#7950F2???#ffffff6h   ?? 5     $??1??6$   ???#DEE4EC$	??3 7q?6=   ?? 5     #??[ 6!   .??5       $ ChevronRight=?64   #??[ 6H   5     5     5     ? 5     $??7??6   $??75??6$   .+?5       -   5        $ answersDataGrid??5  ?   # ?  6    # ?  6O   #???  6?    5       5       	Centering# [ 62   $ Greedy Algorithm??6]   $
 True??6?   $ * 6?    6w   ?? *greedyalgorithm+5       5     # [ 62   $ Dynamic Algorithm??6\   $
 True??6?   $ * 6?    6w   ?? *dynamicalgorithm+6?     5     # [ 62   $ BackTracking Algorithm??6\   $
 True??6?   $ * 6?    6|   ?? *backtrackingalgorithm+6?   5     5     ? 5     $??8??6   $??	0 0 110 0q?6%   .+?5     ?? -   5        #??[ 5     $??0,15,2,0q?6A   $	??Top=?6T   .??5      ?? $ 
Horizontal=?6%   .+?5!       $ Check=?64   $??Center=?6A   $??0 1 8 0q?6\   $??11??6m   $??11??6x   ?? 5"     $??Check??6(   5#     5$     5%     5(     50     51     52     