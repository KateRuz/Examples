//  Часть 2. Написать программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел

int a = 44 ;
int b = 5 ;
int c = 78 ;

int max = a ;

if ( a > max ) max = a ;
if ( b > max ) max = b ;
if ( c > max ) max = c ;

Console.Write ("max=") ;
Console.WriteLine ( max ) ;
