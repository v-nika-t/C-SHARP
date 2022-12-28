// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

void ShowMatrix(int [,] matrix) {
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = 0; k < matrix.GetLength(1); k++) {
               Console.Write($"{matrix[i , k]} ");
           }
          Console.WriteLine("");
        }
        Console.WriteLine("");

}
int [,] DeleteRowColumnWithCrossSmalestNumber(int [,] matrix) {
      int[] coordinateMinNumber = {0, 0};
      for(int i = 0; i < matrix.GetLength(0); i++) {
          for(int k = 0; k < matrix.GetLength(1); k++) {
            if(matrix[i, k] < matrix[coordinateMinNumber[0], coordinateMinNumber[1]]) { 
                  coordinateMinNumber[0] = i;
                  coordinateMinNumber[1] = k;  
            };
          }
      }
      int [,] newMatrix =  new int[matrix.GetLength(0) - 1, matrix.GetLength(1) -1];
      int rowOffset = 0;
      int columnOffset = 0;
       for(int i = 0; i < newMatrix.GetLength(0); i++) {
          if(i >= coordinateMinNumber[0]) rowOffset = 1;
          for(int k = 0; k < newMatrix.GetLength(1); k++) {
              if(k >= coordinateMinNumber[1]) columnOffset = 1;
              newMatrix[i, k] = matrix[i + rowOffset, k + columnOffset];
          }
      }
      return newMatrix ;
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
int [,] newMatrix = DeleteRowColumnWithCrossSmalestNumber(matrix);
ShowMatrix(newMatrix);

