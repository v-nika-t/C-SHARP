// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int randomNumber = new Random().Next(10, 100);
int number_1 = randomNumber / 10;
int number_2 = randomNumber % 10 ;

int max = number_1;
if(number_2 > number_1) max = number_2;

Console.WriteLine($"Рандомное число: {randomNumber}");
Console.WriteLine($"max = {max}");