// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Строки и массивы использовать нельзя!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

#pragma warning disable CS8604 
Console.WriteLine("Task 19");

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number > 99999)
    Console.WriteLine("Ошибка! Необходимо ввести пятизначное число");
else
{
    int c1 = number / 10000;
    int c2 = number / 1000 % 10;

    if (number % 100 == c2 * 10 + c1)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");

}