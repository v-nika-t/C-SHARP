// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int number;
do {
    Console.WriteLine("Введите трехзначное число");
    number = Convert.ToInt32(Console.ReadLine());
    if(number / 1000 != 0) Console.WriteLine("Вы ввели не трехзначное число");
} while ( number / 1000 != 0 );

number = (number / 10 ) % 10 ;
Console.WriteLine($"Второе число:  {number}");

