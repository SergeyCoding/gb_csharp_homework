// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++)
        result *= a;

    return result;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 25");

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

if (numberB < 1)
{
    Console.WriteLine("Ошибка! Число B должно быть натуральным");
    return;
}

Console.WriteLine(Pow(numberA, numberB));
