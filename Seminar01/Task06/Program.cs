// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Task 06");
Console.Write("Введите число: ");
int x1 = int.Parse(Console.ReadLine());


if (x1 % 2 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");

