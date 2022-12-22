// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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



int[] fillRandomNumber(int length, int rangeMin, int rangeMax) {
    int[] arrayRandomNumber = new int [length];
    Random random = new Random();
    for( int i = 0; i < arrayRandomNumber.Length; i++ ) {
        arrayRandomNumber[i] = random.Next(rangeMin, rangeMax);
        Console.WriteLine(arrayRandomNumber[i]);
    }
    return arrayRandomNumber;
}

int[] arrayRandomNumber = fillRandomNumber(6, 0, 10);

int quantity = 0;

for( int i = 0; i < arrayRandomNumber.Length; i++ ) {
    if( i  % 2 != 0 ) quantity += arrayRandomNumber[i] ;
   
}

Console.WriteLine(quantity);