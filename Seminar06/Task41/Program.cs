// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveCount(int[] array)
{
    int counter = 0;
    foreach (var item in array)
    {
        if (item > 0)
            counter++;
    }

    return counter;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 41");

Console.Write("Введите размер массива: ");
int numCount = int.Parse(Console.ReadLine());
if (numCount < 1)
{
    System.Console.WriteLine("Ошибка! Введите корректный размер массива");
    return;
}

int[] arr = new int[numCount];

for (int i = 0; i < numCount; i++)
{
    Console.Write($"Введите {i}-ое число: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(String.Join(", ", arr));
Console.WriteLine($"Чисел больше нуля: {PositiveCount(arr)}");