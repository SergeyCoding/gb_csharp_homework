// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRow(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (array[row, i] < array[row, j])
            {
                int temp = array[row, j];
                array[row, j] = array[row, i];
                array[row, i] = temp;
            }
        }
    }
}

void SortIntraRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        SortRow(arr, i);
}

#pragma warning disable CS8604 
Console.WriteLine("Task 54");

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

SortIntraRows(arr);

PrintArray(arr);

Console.WriteLine();
