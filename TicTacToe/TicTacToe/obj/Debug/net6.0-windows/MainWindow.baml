   M S B A M L   `   `   `  ????D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     ? Title$  	Main Menu??5   	   $	??450??6   $	??422??6(    ? 
ResizeMode$ NoResize=?64    ? WindowStartupLocation$ CenterScreen=?6J   .??5	      ? ??5
   
   
? 5      .??5      ?  ? Color$ 	#FFF56A09??6    ? Offset$ 0.561Q?61   ? 5      $ 	#FF1F07CC??6   $ 1Q?61   5       ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   6,   ?? 5      $??5* ?6   6,   ?? 5      $??1* ?6   6,    ? RowDefinitions 5   
   ?? 5      $??1* ?6   6*   ?? 5      $??2* ?6   6*   ?? 5      $??5* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??3* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??3* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??2* ?6   6*   ?? 5       $??1* ?6   6*   .+?5"   
   ?? $??1??6   $??
Welcome to??6    $??Center=?65   $??1??6R   $??Center=?6_   $??24(?6z   $??Italic$?6?   ?? 5#   
   $??1??6   $??Tic-Tac-Toe??6    $??Center=?66   $??2??6S   $??Center=?6`   $??48(?6{   $
??Bold"?6?   ?? 5$   
   -   5         ??Name$ singleplyBtn??5$      $??1??6'   $??Single Player??67   $??Center=?6O   $??4??6l   $??Center=?6y   $??34??6?   $	??220??6?   
????  ?$
??Bold"?6?   6?   ?? 5%   
   -   5        $ multiplyBtn??5%      $??1??6&   $??Multiplayer??66   $??Center=?6L   $??6??6i   $??Center=?6v   $??34??6?   $	??220??6?   
??? ???$
??Bold"?6?   6?   ?? 5&   
   -   5        $ howtoBtn??5&      $??1??6#   $??How to Play??63   $??Center=?6I   $??8??6f   $??Center=?6s   $??34??6?   $	??220??6?   $
??Bold"?6?   6?   5'      5(      