// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Строки и массивы использовать нельзя!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Task 19");
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number == 0)
{
    number = new Random().Next((int)Math.Pow(10, 4), (int)Math.Pow(10, 5) - 1);
    System.Console.WriteLine((int)Math.Pow(10, 6) - 1);
}

System.Console.WriteLine(number);

if (number < 10000 || number > 99999)
    Console.WriteLine("Ошибка! Необходимо ввести пятизначное число");
else
{
    System.Console.WriteLine(number);

    int c1 = number / 10_000;
    int c2 = number / 1_000 % 10;

    System.Console.WriteLine(c1);
    System.Console.WriteLine(c2);

    if (number % 100 == c2 * 10 + c1)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");

}