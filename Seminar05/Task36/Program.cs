// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int OddPosSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }

    return sum;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 36");

Console.Write("Введите размер массива: ");
int numCount = int.Parse(Console.ReadLine());
if (numCount < 1)
{
    System.Console.WriteLine("Ошибка! Введите корректный размер массива");
    return;
}

int[] arr = GetArray(numCount, -100, 100);
Console.WriteLine(String.Join(", ", arr));

Console.WriteLine($"Сумма на нечетных позициях: {OddPosSum(arr)}");