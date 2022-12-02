
Console.WriteLine("Задача 2 и 4 объеденненная . На вход принимает два/три числа и выдает, max и min число");
Console.WriteLine("Введите 1-ое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ое число");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number1;

if( number2 > number1 ) {
    max = number2;
} else {
    min= number2;
}


if( number3 > max ) max = number3;
if( number3 < min ) min = number3;

Console.WriteLine("max: {0} min: {1}" , max, min); 


Console.WriteLine("Задача 6 . На вход принимает число и выдает, является ли число четным");
Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());

string answer = "";

if(number % 2 == 0) {
    answer = "Число  чётное";
} else {
    answer = "Число нечётное";
}


Console.WriteLine(answer); 

Console.WriteLine("Задача 8: Принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите  число");
int endNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= endNumber; i++) {
    if(i % 2 == 0) Console.WriteLine(i);
}
