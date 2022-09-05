// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int PositiveCount(int[] array)
{
    int counter = 0;
    foreach (var item in array)
    {
        if (item > 0)
            counter++;
    }

    return counter;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 43");

Console.Write("Введите k1 b1: ");
var line1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.Write("Введите k2 b2: ");
var line2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"y = {line1[0]} * x + {line1[1]}");
Console.WriteLine($"y = {line2[0]} * x + {line2[1]}");

