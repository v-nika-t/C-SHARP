// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

string result = "";

Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());

result = ( (number % 23 != 0)  || (number % 7 != 0) )  ? "нет" : "да";
Console.WriteLine(result);
