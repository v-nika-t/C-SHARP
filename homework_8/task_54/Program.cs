// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8


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

void ShowArray(int [] array) {
        for(int i = 0; i < array.Length; i++) {
          Console.Write($"{array[i]} ");
          Console.WriteLine("");
        }
        Console.WriteLine("");

}



void SortByAge(int[] array) {
    Console.WriteLine("Hello");
    for(int i=0; i < array.Length -1; i++) {
       int indexMin = i;
       for(int k=i; k < array.Length; k++) {
         if(array[k] < array[indexMin]) indexMin = k;
       }
       if(array[i] !=  array[indexMin]) { // change 
          array[i] =  array[i] + array[indexMin];
          array[indexMin] = array[i] - array[indexMin];
          array[i] = array[i] - array[indexMin];
       }
      
    }
}

void SortByAgeMatrix(int[ , ] matrix) {
    for(int e = 0; e < matrix.GetLength(0); e++) {
        for(int i=0; i < matrix.GetLength(1) -1; i++) {
            int indexMin = i;
            for(int k=i; k < matrix.GetLength(1); k++) {
                if(matrix[e, k] < matrix[e, indexMin]) indexMin = k;
            }
            if(matrix[e, i] !=  matrix[e, indexMin]) { // change 
                matrix[e, i]=  matrix[e, i] + matrix[e, indexMin];
                matrix[e, indexMin] = matrix[e, i] - matrix[e, indexMin];
                matrix[e, i] = matrix[e, i] - matrix[e, indexMin];
            }
        }
    }
}

int [,] matrix = CreateMatrix(3, 3, 0 , 10);
SortByAgeMatrix(matrix);
ShowMatrix(matrix); 


