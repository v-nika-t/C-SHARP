// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Ввод чисел останавливается 
//  при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


int quantity = 0;
 Console.WriteLine("Введите число. Если хотите узнать кол-во введите stop");
 do {
    Console.WriteLine("Введите число. Если хотите узнать кол-во введите stop");
    string? result = Console.ReadLine();
    if(result == "stop") {
        Console.WriteLine(quantity);
        break;
    }
    int number = Convert.ToInt32(result);
    if(number > 0) quantity++;

} while (true);
 

