// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] arrayParams = new int [4];
string[] arrayTitle = {"b1", "b2", "k1", "k2"};
int number = 0;
int i = 0;
do {
    Console.WriteLine($"Введите {arrayTitle[i]}");
    number = Convert.ToInt32(Console.ReadLine());
    arrayParams[i] = number;
    i++;
} while (i < 4);

for (int k = 0 ; k < arrayParams.Length ; k++) {
  Console.WriteLine(arrayParams[k]);
}


double x =  Convert.ToDouble(arrayParams[1] - arrayParams[0]) / Convert.ToDouble(arrayParams[2] - arrayParams[3]);
double y = (arrayParams[3] * x) + arrayParams[1]; 
Console.WriteLine($"Координаты: ({x}, {y})");