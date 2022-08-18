// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Task 08");
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N < 2)
{
    System.Console.WriteLine("Нет чисел для вывода");
}
else
{
    System.Console.Write(2);

    int nCurrent = 4;

    while (nCurrent <= N)
    {
        if (nCurrent % 2 == 0)
            System.Console.Write($", {nCurrent}");

        nCurrent++;
    }

    System.Console.WriteLine();
}