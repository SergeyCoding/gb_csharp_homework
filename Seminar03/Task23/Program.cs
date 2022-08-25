// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

#pragma warning disable CS8604 
Console.WriteLine("Task 23");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int n = 1;

while (n <= number)
{
    Console.Write(n * n * n);

    if (n < number)
        Console.Write(", ");

    n++;
}

Console.WriteLine();