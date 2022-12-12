// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = 0;
do {
    Console.WriteLine("Введите число больше 0");
    number = Convert.ToInt32(Console.ReadLine());
    if(number == 1) Console.WriteLine("Вы ввели не верное число");
} while ( number == 0);


for(int i = 1; i < number + 1; i++ ) {
   Console.WriteLine($"Куб числа {i}: {Math.Pow(i, 3)}");
}