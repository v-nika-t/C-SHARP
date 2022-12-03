// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number;

do {
    Console.WriteLine("Введите число до 8 знаков");
    number = Convert.ToInt32(Console.ReadLine());
    if(number > 100000000) {
        Console.WriteLine("Вы ввели число больше 8 знаков");
        continue;
    }
} while ( number > 100000000);


while(number != 0) 
{
        if(number / 100 == 0)  {
            Console.WriteLine("Третьей цифры нет");
            break;
        } 
        if(number / 1000 == 0) {
            Console.WriteLine($"Третья цифра {number % 10}");
            break;
        }
        number = number / 10;
}


