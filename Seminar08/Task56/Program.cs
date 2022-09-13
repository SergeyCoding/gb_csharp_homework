// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] res = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],10}");
        }

        Console.WriteLine();
    }
}

int SumRow(int[,] array, int row)
{
    int s = array[row, 0];
    for (int col = 1; col < array.GetLength(1) - 1; col++)
    {
        if (s > array[row, col])
            s = array[row, col];
    }

    return s;
}

int GetMinSumRow(int[,] arr)
{
    int s = SumRow(arr, 0);
    int ind = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int curSum = SumRow(arr, i);
        if (s < curSum)
        {
            s = curSum;
            ind = i;
        }
    }

    return ind;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 56");

Console.Write("Введите rows: ");
var rows = int.Parse(Console.ReadLine());
Console.Write("Введите cols: ");
var cols = int.Parse(Console.ReadLine());
Console.WriteLine();

if (rows < 1 || cols < 1)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

var arr = GetArray(rows, cols, 1, 100);
PrintArray(arr);
Console.WriteLine();


System.Console.WriteLine($"{GetMinSumRow(arr)} строка");
