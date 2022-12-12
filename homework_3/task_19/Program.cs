// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int number = 10000;
int reverseNumber = 10000;

Console.WriteLine($"Палиндромом:  {12345 % 10000}");
 do {
    Console.WriteLine("Введите пятизначное  число");
    number = Convert.ToInt32(Console.ReadLine());
    if(number / 100000 != 0) Console.WriteLine("Вы ввели не пятизачное число");
} while ( number / 100000 != 0);

int notReverseNumber = number; 
int count = 1 ;
for(int i = 10000 ; i > 0 ; i = i / 10) {
    if( i == 1) {
        reverseNumber += (notReverseNumber - 1 ) * count ;
        break;
    }
    reverseNumber += (notReverseNumber / i) * count ;
    notReverseNumber = notReverseNumber % i;
    count = count * 10; 
} 

string result = reverseNumber == number ? "Да" : "Нет"; 
Console.WriteLine($"{number } палиндромом ? :  {result}");