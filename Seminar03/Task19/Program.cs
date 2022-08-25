// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Строки и массивы использовать нельзя!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Task 19");
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number > 99999)
    Console.WriteLine("Ошибка! Необходимо ввести пятизначное число");
else
{
    bool result = true;

    int s1 = 10_000;
    int s2 = 1;

    while (s1 > s2)
    {
        Console.WriteLine($"{s1}, {s2}, {number / s1 % 10}, {number / s2 % 10}");
        if (number / s1 % 10 != number / s2 % 10)
        {
            Console.WriteLine("нет");
        }

        s1 = s1 / 10;
        s2 = s2 * 10;
    }

    Console.WriteLine("да");
}