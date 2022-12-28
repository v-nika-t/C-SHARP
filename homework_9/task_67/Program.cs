// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int showSumNumber(int number) {
   if (number < 10) return number ;
   return number % 10 + showSumNumber(number / 10);
}

int sum = showSumNumber(453);
Console.WriteLine(sum);