// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

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

void SwapRowColumn(int [,] matrix) { // попробовать поменять.Разные строки и столбцы
//Решение проще https://prnt.sc/6HyW-c-vMorB
    int startIndex = 1;
    if(matrix.GetLength(0) != matrix.GetLength(1)) {
        Console.WriteLine("Невозможно выполнить");
        return;
    }
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = startIndex; k < matrix.GetLength(1); k++) {
                matrix[i, k] =  matrix[i, k] + matrix[k, i];
                matrix[k, i] = matrix[i, k] - matrix[k, i];
                matrix[i, k] = matrix[i, k] - matrix[k, i];
           }
        startIndex++;
        }
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
SwapRowColumn(matrix);
ShowMatrix(matrix); 

