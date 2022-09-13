// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int MulMatrixSingle(int[,] arr, int[,] arr2, int row, int col2)
{
    int s = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
        s += arr[row, i] * arr2[i, col2];
    return s;
}

int[,] MulMatrix(int[,] arr, int[,] arr2)
{
    int[,] result = new int[arr.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            result[i, j] = MulMatrixSingle(arr, arr2, i, j);
        }
    }

    return result;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 58");

Console.Write("Введите rows1: ");
var rows = int.Parse(Console.ReadLine());
Console.Write("Введите cols1: ");
var cols = int.Parse(Console.ReadLine());
var rows2 = cols;
Console.WriteLine($"Определена rows2: {rows2}");
Console.Write("Введите cols2: ");
var cols2 = int.Parse(Console.ReadLine());
Console.WriteLine();

if (rows < 1 || cols < 1 || cols2 < 1)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

var arr = GetArray(rows, cols, 1, 10);
var arr2 = GetArray(rows2, cols2, 1, 10);
PrintArray(arr);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine("Результат:");
PrintArray(MulMatrix(arr, arr2));
