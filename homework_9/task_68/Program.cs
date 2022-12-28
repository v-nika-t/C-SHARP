// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

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

//int [,] matrix = CreateMatrix(3, 3, 0 , 10); //  square
//int [,] matrix = CreateMatrix(3, 2, 0 , 10); // rectangle
int [,] matrix = CreateMatrix(2, 3, 0 , 10);  // rectangle
int sum = 0;
 for(int i = 0; i < matrix.GetLength(0); i++) {
    if(i == matrix.GetLength(1)) break;
    sum += matrix[i, i];
}

Console.WriteLine($"sum = {sum}");