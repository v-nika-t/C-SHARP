// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int remainder = 0;
string result = "";

Console.WriteLine("Введите первое число");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = Convert.ToInt32(Console.ReadLine());

int max = number_1;
int min = number_2;
if(number_2 > number_1) {
    max = number_2;
    min = number_1;
}

remainder = max % min;
result = remainder != 0 ? $"Не кратно, остаток {remainder}" : "кратно";
Console.WriteLine(result);


