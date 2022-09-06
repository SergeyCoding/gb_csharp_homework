// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool IsExistLineCross(int[] l1, int[] l2)
{
    return l1[0] != l2[0];
}

double[] LinesCross(int[] l1, int[] l2)
{
    double x0 = -(double)(l2[1] - l1[1]) / (l2[0] - l1[0]);
    double y0 = l1[0] * x0 + l1[1];
    return new double[] { x0, y0 };
}

#pragma warning disable CS8604 
Console.WriteLine("Task 43");

Console.Write("Введите k1 b1: ");
var line1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.Write("Введите k2 b2: ");
var line2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"y = {line1[0]} * x + {line1[1]}");
Console.WriteLine($"y = {line2[0]} * x + {line2[1]}");

if (IsExistLineCross(line1, line2))
{
    var coord = LinesCross(line1, line2);
    System.Console.WriteLine($"({coord[0]}; {coord[1]}) ");
}
else System.Console.WriteLine("Решения нет");



