// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

#pragma warning disable CS8604 
Console.WriteLine("Task 21");

Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = int.Parse(Console.ReadLine());

int dx = x1 - x2;
int dy = y1 - y2;
int dz = z1 - z2;

double dist = Math.Sqrt(dx * dx + dy * dy + dz * dz);

Console.WriteLine($"Расстояние: {dist:f2}");
