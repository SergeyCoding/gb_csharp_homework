// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Task 04");
Console.Write("Первое число: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Третье число: ");
int x3 = int.Parse(Console.ReadLine());

int max = x1;

if (max < x2) max = x2;
if (max < x3) max = x3;

System.Console.WriteLine(max);
