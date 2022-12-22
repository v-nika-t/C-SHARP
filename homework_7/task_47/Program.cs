// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

int[] fillRandomNumber(int length, int rangeMin, int rangeMax) {
    int[] arrayRandomNumber = new int [length];
    Random random = new Random();
    for( int i = 0; i < arrayRandomNumber.Length; i++ ) {
        arrayRandomNumber[i] = random.Next(rangeMin, rangeMax);
        Console.WriteLine(arrayRandomNumber[i]);
    }
    return arrayRandomNumber;
}

int[] arrayRandomNumber = fillRandomNumber(123, 0, 151);

int quantity = 0;

for( int i = 0; i < arrayRandomNumber.Length; i++ ) {
    if( arrayRandomNumber[i] <= 99 && arrayRandomNumber[i] >= 10 ) quantity++;
   
}

Console.WriteLine(quantity);