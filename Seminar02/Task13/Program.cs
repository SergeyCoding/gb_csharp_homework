// Задача 13: Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Task 13");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
    Console.WriteLine("Ошибка! Необходимо ввести положительное число");
else
{
    if (number < 100)
        Console.WriteLine("третьей цифры нет");
    else
        Console.WriteLine(number / 100 % 10);
}