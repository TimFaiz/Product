   M S B A M L   `   `   `  ????@  <Gotov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Gotov.PagesGotov.Pages  5          Gotov.Pages.ListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Gotov.Pages     5      -   5          N? Title$  ListPage??5
      .??5      ? 
?????d? ? ColumnDefinitions 5   
   ?? 5      ?? 5      $??5* ?6   .+?5   
   ?? .+?5      ?? -   5         ??Name$
 BAdd??5   #   $	??Add??6   61   ?? 5      -   5        $ BEdit??5   $   $
??Edit??6   63   ?? 5      -   5        $ BDelete??5   &   $??Delete??6   67   ?? 5      -   5        $ 
BBasketAdd??5   ,   
????  ?$??Add in basket??5   -   $??10q?6E   
??? ???5   @   ?? 5      -   5        $ BSave??5   ,   
????  ?$??Save basket??5   -   $
??10 0q?6C   
??? ???5   ;   ?? 5      -   5        $ BDeleteBasket??5   ,   
????  ?$??Delete to basket??5   -   $	??10 q?6H   
??? ???5   C   5      ?? 5   
   $??1??6   $??Продукты??6    $??Center=?63   $??18(?6P   ?? 5   
   -   5         ??Name$ 	LVProduct??5   ;   $	??Top=?6   $	??300??6+   $??1??6N   $??Disabled=?5      $??10 30q?6G   ??5      ?? 5       .R?5!      ? 6"   5"      ??5$      ?? 5%      .R?5&      ?? 
???   ?$??2q?61   ._?5'      ?? .+?5(      ??  ?? Orientation$ 
Horizontal=?6)   .+?5)   "   ?? $
??ID: ??6,   ?? 5*   "   ??6,   ?? *ID+5+      ?? 5,      $ 
Horizontal=?6)   .+?5-   "   ?? $??Name: ??6,   ?? 5.   "   ??6,   ?? *Name+5/      ?? 50      $ 
Horizontal=?6)   .+?51   "   ?? $??Price: ??6,   ?? 52   "   ??6,   ?? *Price+53      ?? 54      $ 
Horizontal=?6)   ??55   "   ?? 56   &    ?? 
TargetType" ??6,    ?? Triggers 57   *   ?? 58   .    ?? Binding 6:   ?? *IsSale+ ?? Value true6U   .a?59   2   ?? 	 ?? Property	 ? ??
 ?? Value

 ? ? ?6P   5:   /   ?? 5;   .    6:   ?? *IsSale+	 false6U   .a?5<   2   ?? 	 ? ??

 ???? 6P   5=   /   5?   '   .+?5A   "   ?? $??Sale: ??6,   ?? 5B   "    ??Name$ TBSale??6B   ??6,   ?? *Sale+6B   5C      5D      5E      5F      5H      ?? 5I   
   $??1??6   $??Center=?6&   $??Bottom=?6C   .+?5J   
   ?? $??Center=?6   $??Корзина??6-   $??18(?6?   &   System.Windows.Controls.DataGrid  5K   
   -	   5          Name$ DGBasket??5K         AutoGenerateColumns .  $	??150??6A   $??10q?5L      $	??330??6   
??? ???   Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ?? *Product.Name+  5O      $ Price??6%   $	 100 64    6@   ?? *Product.Price+  5P      $
 Sale??6%   $	 100 63    6?   ?? *Product.Sale+5R      5S      5T      5U      