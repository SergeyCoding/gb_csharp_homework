// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = minValue + new Random().NextDouble() * (maxValue - minValue);
    }

    return res;
}

double MaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];

        if (min > array[i])
            min = array[i];
    }

    return max - min;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 38");

Console.Write("Введите размер массива: ");
int numCount = int.Parse(Console.ReadLine());

double[] arr = GetArray(numCount, -100, 100);
Console.WriteLine(String.Join(", ", arr));

Console.WriteLine($"Разность: {MaxMinDiff(arr):f5}");