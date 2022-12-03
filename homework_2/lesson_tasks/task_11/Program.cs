// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int randomNumber = new Random().Next(100, 1000);
int number_1 = (randomNumber / 100) * 10;
int number_2 = randomNumber % 10 ;
int result = number_1 + number_2;

Console.WriteLine($"Рандомное число: {randomNumber}");
Console.WriteLine($"Изменённое число: {result}");