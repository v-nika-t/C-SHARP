// Напишите программу, которая 
//задаёт массив из 8 элементов и выводит их на экран. 
//Данные вводятся с консоли пользователем

string [] info = {};

do {
        Console.WriteLine("Введите через запятую 8 элементов' через запятую");
        info = Console.ReadLine().Split(",");
        if(info.Length < 8) {
            info = new string[0];
            Console.WriteLine("Вы ввели меньше слов");
        }
} while ( info.Length == 0);


for(int i = 0; i < info.Length; i++) {
  Console.WriteLine($"Элемент {i} массива равен {info[i]}");
}