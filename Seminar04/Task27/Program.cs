// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberInnerSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }

    return sum;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 27");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    System.Console.WriteLine("Ошибка! Число B должно быть положительным");
    return;
}

Console.WriteLine(NumberInnerSum(number));
