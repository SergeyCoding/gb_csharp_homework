// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],5}");
        }

        Console.WriteLine();
    }
}

bool MoveNext(int[,] arr, int[,] mask, int row, int col, int drow, int dcol, int counter)
{
    col = col + dcol;
    row = row + drow;

    if (col < 0 || col >= arr.GetLength(1))
        return false;

    if (row < 0 || row >= arr.GetLength(0))
        return false;

    if (col < arr.GetLength(1) && mask[row, col] == 1)
        return false;

    mask[row, col] = 1;
    arr[row, col] = counter;
    counter++;

    if (MoveNext(arr, mask, row, col, drow, dcol, counter))
        return true;

    if (drow == 0 && dcol == 1)
        return MoveNext(arr, mask, row, col, 1, 0, counter);
    if (drow == 1 && dcol == 0)
        return MoveNext(arr, mask, row, col, 0, -1, counter);
    if (drow == 0 && dcol == -1)
        return MoveNext(arr, mask, row, col, -1, 0, counter);
    if (drow == -1 && dcol == 0)
        return MoveNext(arr, mask, row, col, 0, 1, counter);


    return false;
}

void FillSpiral(int[,] arr)
{
    int[,] mask = new int[arr.GetLength(0), arr.GetLength(1)];

    MoveNext(arr, mask, 0, -1, 0, 1, 1);
}


#pragma warning disable CS8604 
Console.WriteLine("Task 62");

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

var arr = new int[rows, cols];
FillSpiral(arr);
PrintArray(arr);