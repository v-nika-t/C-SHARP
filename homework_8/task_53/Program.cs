// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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


void ChangeFirstLastRow(int [,] matrix) {
        int lengthColumns = matrix.GetLength(0);
            for(int k = 0; k < matrix.GetLength(1); k++) {
               int firstItemRow =  matrix[0 , k];
               matrix[0 , k] = matrix[lengthColumns-1 , k];
               matrix[lengthColumns-1 , k] = firstItemRow ;
           }
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
ChangeFirstLastRow(matrix);
ShowMatrix(matrix);
