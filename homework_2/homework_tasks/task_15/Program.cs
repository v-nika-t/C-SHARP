// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string[] daysOfTheWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"} ;
int day;
int index = 0;
bool isDayOff=false;
do {
    Console.WriteLine("Введите число дня недели от 1 до 7");
    day = Convert.ToInt32(Console.ReadLine());
    if(day > 8 || day < 0) {
        Console.WriteLine("Вы ввели не верное число");
        continue;
    } 
    index = day -1;
    if(index == 5 || index == 6 ) isDayOff = true;
    string text = isDayOff ? "выходной" : "будний";
    Console.WriteLine($"{daysOfTheWeek[index]} - это {text}");

} while ( day > 8 || day < 0);


