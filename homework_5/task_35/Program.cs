// Задача 35: Задайте одномерный массив из 123 случайных чисел 
//в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат 
//в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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