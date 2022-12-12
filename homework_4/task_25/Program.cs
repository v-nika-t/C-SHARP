// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!


int number_1 = 0;
int number_2 = 0;

do{
    Console.WriteLine("Введите число больше 0");
    number_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень больше 0");
    number_2 = Convert.ToInt32(Console.ReadLine());

    if(number_1 <= 0 || number_2 <= 0) Console.WriteLine("Вы ввели число меньше или равное 0");

}while(number_1 <= 0 || number_2 <= 0);

int powRecursive(int number, int power) {
    if(power == 1) {
       return number;   
    }
    return number * powRecursive(number, power - 1);
}

int powСycle(int number, int power) {
    int resultСycle = 1;
    while(number_2 != 0) {
        resultСycle *= number_1;
        number_2 =  number_2 - 1;
    }
    return resultСycle;
} 


int resultPowRecursive = powRecursive(number_1, number_2);
Console.WriteLine($"Результат цикла: {powСycle(number_1, number_2)}");
Console.WriteLine($"Результат рекурсии: {resultPowRecursive}");