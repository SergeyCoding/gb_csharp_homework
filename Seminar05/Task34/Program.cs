// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenCount(int[] array)
{
    int counter = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
            counter++;
    }

    return counter;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 34");

Console.Write("Введите размер массива: ");
int numCount = int.Parse(Console.ReadLine());

int[] arr = GetArray(numCount, 10, 99);
Console.WriteLine(String.Join(", ", arr));

Console.WriteLine($"Четных: {EvenCount(arr)}");