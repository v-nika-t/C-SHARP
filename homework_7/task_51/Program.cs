// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

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