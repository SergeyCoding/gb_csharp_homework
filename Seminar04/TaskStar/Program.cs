// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

string LineFormat(int rowNumber, int width)
{
    int starsCount = rowNumber * 2 - 1;
    return new string(' ', (width - starsCount) / 2) + new String('*', starsCount);
}

void TreeDraw(int lineCount)
{
    int width = lineCount * 2 - 1;

    for (int i = 1; i <= lineCount; i++)
        Console.WriteLine(LineFormat(i, width));
}

#pragma warning disable CS8604 
Console.WriteLine("Task Star");

Console.Write("Введите высоту: ");
int height = int.Parse(Console.ReadLine());

if (height < 1)
{
    Console.WriteLine("Ошибка! Высота должна быть больше 0");
    return;
}

TreeDraw(height);