// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

double [,]  CreateMatrix(int row, int column, int minRandomNumber  , int maxRandomNumber) {
        double [,] matrix  = new double[row, column];
        var random= new Random();
        string [] typeNumber = {"double", "int"};
        string [] rangeNumber = {"negative", "positive"}; 
        for(int i = 0; i < matrix.GetLength(0); i++) {
           for(int k = 0; k < matrix.GetLength(1); k++) {
                 int indexRandom = random.Next(0, 2);
                 double randomNumber = random.NextDouble();
                 randomNumber = random.Next(minRandomNumber, maxRandomNumber) + randomNumber;
                 randomNumber = typeNumber[indexRandom] == "double" ? Math.Round(randomNumber, 2) : Math.Round(randomNumber);
                 matrix[i , k] = randomNumber;
                 Console.Write($"{randomNumber}  ");
           }
          Console.WriteLine("");
        }

        return matrix;
}

double [,] matrix = CreateMatrix(3, 3, -5 , 10);