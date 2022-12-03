/* // Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
 */

int prod = 0;
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

prod = min * min ;
result = prod == max ? "да" : "нет";
Console.WriteLine(result);
