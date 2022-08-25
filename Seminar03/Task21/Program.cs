// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

// округление
//dist = Math.Floor(dist * 100) / 100;

Console.WriteLine($"Расстояние: {dist:f2}");
