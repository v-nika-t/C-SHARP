// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

        return matrix;
}


int[] GetColumnValueAverageOfMatrix (int[,] matrix) {
  int quantituColumn = matrix.GetLength(1);
  int [] average = new int[quantituColumn];
  for(int i = 0; i < matrix.GetLength(1); i++) {
      for(int k = 0; k < quantituColumn; k++) {
          average[i] += matrix[k, i];
      }
  Console.WriteLine(average[i]);
}
  return average;
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
int[] average= GetColumnValueAverageOfMatrix(matrix);