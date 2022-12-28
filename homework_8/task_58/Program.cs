// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49




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
int [,]?  ShowPowTwoMatrix(int [,] matrix_1, int [,] matrix_2 ) {
      bool result =  ( matrix_1.GetLength(0) == matrix_2.GetLength(0) ) &&  ( matrix_1.GetLength(1) == matrix_2.GetLength(1) ); 
      if(!result) {
            Console.WriteLine("Матрицы разного размера. Введите матрицы одинакового размера");
            return null;
      }
      int [,] matrixPow =  new int[matrix_1.GetLength(0), matrix_1.GetLength(1)];
      for(int i = 0; i < matrixPow.GetLength(0); i++) {
          for(int k = 0; k < matrixPow.GetLength(1); k++) {
            matrixPow[i, k] = matrix_1[i, k] * matrix_2[i, k];
          }
      }
      return matrixPow;
}

int [,] matrix_1 = CreateMatrix(3, 2, 0 , 10);
int [,] matrix_2 = CreateMatrix(3, 3, 0 , 10);
int [,]? matrix = ShowPowTwoMatrix(matrix_1, matrix_2);
if(matrix != null) ShowMatrix(matrix);

