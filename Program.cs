// Написать программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

int a = 5 , b = 7 ;
int max = b ;
int min = a ;

if (b > a) max = b ;
if (b > a) min = a ;

Console.Write ("max = ") ;
Console.WriteLine ( max ) ;

Console.Write ("min =") ;
Console.WriteLine ( min ) ;