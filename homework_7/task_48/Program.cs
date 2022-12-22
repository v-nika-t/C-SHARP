
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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