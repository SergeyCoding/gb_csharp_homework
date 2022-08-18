// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Первое число: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int x2 = int.Parse(Console.ReadLine());

if (x1 > x2)
    System.Console.WriteLine($"max = {x1}");
else
    System.Console.WriteLine($"max = {x2}");