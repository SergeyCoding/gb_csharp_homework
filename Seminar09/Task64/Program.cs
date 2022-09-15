// Задача 64: Задайте M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N

void PrintNatural(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
        return;
    }

    PrintNatural(m, n - 1);
    Console.Write($", {n}");
}

#pragma warning disable CS8604 
Console.WriteLine("Task 64");

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

PrintNatural(m, n);