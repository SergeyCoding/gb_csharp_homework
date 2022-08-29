// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void DrawTree(int lineCount)
{
    int width = lineCount * 2 - 1;
    string starsString = "*";

    for (int i = 0; i < lineCount; i++)
    {
        //Console.Write(new string(' ', (width - i * 2 - 1) / 2));
        for (int j = 0; j < (width - i * 2 - 1) / 2; j++)
            Console.Write(' ');

        Console.WriteLine(starsString);

        starsString = starsString + "**";
    }
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

DrawTree(height);