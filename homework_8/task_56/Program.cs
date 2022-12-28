// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int [,] CreateMatrix(int row, int column, int minRandomNumber, int maxRandomNumber) {
        int [,] matrix = new int[row, column];
        var random = new Random();
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = 0; k < matrix.GetLength(1); k++) {
               matrix[i , k] = random.Next(minRandomNumber, maxRandomNumber + 1);
               Console.Write($"{matrix[i , k]} ");
           }
          Console.WriteLine("");
        }
      Console.WriteLine("");
        return matrix;
}

int ShowRowWithSmallestSum(int [,] matrix) {
  int index = 0;
  int sum = 0;
  for(int i = 0; i < matrix.GetLength(0); i++) {
          int currentSum = 0;
          for(int k = 0; k < matrix.GetLength(1); k++) {
            currentSum += matrix[i , k];
          }
          if(i == 0) {
             sum = currentSum;
          }
           if(currentSum < sum) {
            sum = currentSum;
            index = i;
           }
        }
  return index;
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
int index = ShowRowWithSmallestSum(matrix);
Console.WriteLine($"Строка с индексом {index} имеет наименьшую сумму");

