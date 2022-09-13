// Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное 
// значение x и возвращает целую часть квадратного корня от введенного числа.
// Нельзя использовать встроенные функции библиотеки Math!

int OrderNumber(int number)
{
    int count = 0;

    while (number >= 10)
    {
        number /= 10;
        count++;
    }

    return count;
}

int Power10(int order)
{
    int result = 1;

    for (int i = 0; i < order; i++)
        result *= 10;

    return result;
}

int Sqrt(int number)
{
    int left = Power10(OrderNumber(number) / 2);
    int right = left * 10;

    while (left < right - 1)
    {
        int checkNumber = (left + right) / 2;
        if (checkNumber * checkNumber < number)
            left = checkNumber;
        else
            right = checkNumber;

        Console.WriteLine($"{left} {right}");
    }

    return right * right == number ? right : left;

}

#pragma warning disable CS8604 
Console.WriteLine("Task 52");

Console.Write("Введите число: ");
var number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

System.Console.WriteLine(Sqrt(number));