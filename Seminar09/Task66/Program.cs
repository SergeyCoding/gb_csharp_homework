// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if (m == n)
        return m;

    return m + Sum(m + 1, n);
}

#pragma warning disable CS8604 
Console.WriteLine("Task 66");

Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine();

if (m < 1 || n < 1)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

Console.WriteLine(Sum(m, n));

