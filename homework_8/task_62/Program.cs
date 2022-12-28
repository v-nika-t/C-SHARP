// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7


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