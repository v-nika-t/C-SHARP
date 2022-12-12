// Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int remainder = number;

while(number != 0) {
    result += number % 10;
    number = number / 10;
}

number = (number / 10 ) % 10 ;
Console.WriteLine($"Cумма чисел равна:  {result}");