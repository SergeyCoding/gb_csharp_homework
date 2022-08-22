// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Task 15");
Console.Write("Введите число, соответсвующее дню недели: ");
int dayWeek = int.Parse(Console.ReadLine());

if (dayWeek < 1 || dayWeek > 7)
    Console.WriteLine("Ошибка! Необходимо ввести число от 1 до 7");
else
{
    if (dayWeek == 6 || dayWeek == 7)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}