// Задача 38: Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] fillRandomNumber(int length, int rangeMin, int rangeMax) {
    int[] arrayRandomNumber = new int [length];
    Random random = new Random();
    for( int i = 0; i < arrayRandomNumber.Length; i++ ) {
        arrayRandomNumber[i] = random.Next(rangeMin, rangeMax);
        Console.WriteLine(arrayRandomNumber[i]);
    }
    return arrayRandomNumber;
}

int[] arrayRandomNumber = fillRandomNumber(6, 1, 11);

int min = arrayRandomNumber[0];
int max = arrayRandomNumber[0];

for( int i = 0; i < arrayRandomNumber.Length; i++ ) {
  if(arrayRandomNumber[i] < min) min = arrayRandomNumber[i];
  if(arrayRandomNumber[i] > max) max = arrayRandomNumber[i];   
}

Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(max - min);