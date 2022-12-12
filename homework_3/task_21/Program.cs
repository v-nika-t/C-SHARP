// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


string [] coordinatePoint1 = {};
string [] coordinatePoint2 = {};

do {
    if(coordinatePoint1.Length == 0) {
        Console.WriteLine("Введите через запятую координаты первой точки");
        coordinatePoint1 = Console.ReadLine().Split(",");
        if(coordinatePoint1.Length < 3) coordinatePoint1 = new string[0];
    }

     if(coordinatePoint2.Length == 0) {
        Console.WriteLine("Введите через запятую координаты второй точки");
        coordinatePoint2 = Console.ReadLine().Split(",");

        if(coordinatePoint2.Length < 3) coordinatePoint2 = new string[0];
    }
   
    if(coordinatePoint1.Length == 0 || coordinatePoint2.Length == 0) Console.WriteLine("Вы ввели не верные координаты");
} while ( coordinatePoint1.Length == 0 || coordinatePoint2.Length == 0);


double result = 0;

for (int i = 0; i < coordinatePoint1.Length ; i++ ) {
     result += Math.Pow(Convert.ToDouble(coordinatePoint2[i]) - Convert.ToDouble(coordinatePoint1[i]) , 2);
}

result = Math.Sqrt(result);
Console.WriteLine($"Расстояние между точками:  {result:f2}");