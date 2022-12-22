// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет


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

int[] GetPositionElement () {
    Console.WriteLine("Enter two number separated by comma. That is position getting value in array");
    string [] stringPosition = Console.ReadLine().Split(',');
    int [] intPosition = new int[stringPosition.Length];
    for(int i =0 ; i < stringPosition.Length; i++) {
        intPosition[i] = Convert.ToInt32(stringPosition[i]);
        Console.WriteLine(intPosition[i]);
    }
    return intPosition;
}

int? GetValueElement (int [,] matrix, int row, int column) {
    bool isRow = (row < matrix.GetLength(0)) & (row >= 0);
    bool isColumn = (column < matrix.GetLength(1)) & (column >= 0);
    if ( isRow & isColumn ) {
        return matrix[row,  column];
   }; 
   return null;
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
int[] position = GetPositionElement(); 
int? value = GetValueElement(matrix, position[0], position[1]);
Console.WriteLine($"{(value == null ? "Такой позиции нет" : value)}");
