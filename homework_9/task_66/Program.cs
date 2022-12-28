// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int showSumNumber(int m, int n) {
   if (m == n) return m ;
   return m + showSumNumber(++m, n);
}

int sum = showSumNumber(0, 5);
Console.WriteLine(sum);