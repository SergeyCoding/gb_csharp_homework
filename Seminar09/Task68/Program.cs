// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);

    return Akkerman(m - 1, Akkerman(m, n - 1));
}

#pragma warning disable CS8604 
Console.WriteLine("Task 68");

Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(Akkerman(m, n));
