// Напишите программу, которая реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против часовой стрелки

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
            Console.Write($"{array[row, col],5}");
        }

        Console.WriteLine();
    }
}

int[] GetLineArray(int[,] arr, int row, int col, int drow, int dcol, int count)
{
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        row = row + drow;
        col = col + dcol;
        result[i] = arr[row, col];
    }
    return result;
}

int[] FlatArray(int[,] arr)
{
    int[] result = new int[arr.Length];

    int row = arr.GetLength(0) - 1;
    int col = -1;
    var rowCount = arr.GetLength(0) - 1;
    var colCount = arr.GetLength(1);
    var drow = -1;
    var dcol = 1;

    while (rowCount > 0 || colCount > 0)
    {
        result = GetLineArray(arr, row, col, 0, dcol, colCount);
        Console.WriteLine(string.Join(", ", result));
        col = col + dcol * colCount;

        result = GetLineArray(arr, row, col, drow, 0, rowCount);
        Console.WriteLine(string.Join(", ", result));
        row = row + drow * rowCount;

        colCount = colCount - 1;
        rowCount = rowCount - 1;

        drow = -drow;
        dcol = -dcol;
    }

    return result;
}


#pragma warning disable CS8604 
Console.WriteLine("Task 6-Star");

Console.Write("Введите rows: ");
var rows = 3;// int.Parse(Console.ReadLine());
Console.Write("Введите cols: ");
var cols = 4;//int.Parse(Console.ReadLine());

Console.WriteLine();

var arr = GetArray(rows, cols, 1, 100);
PrintArray(arr);

// var flatArr = new int[arr.Length];
// System.Console.WriteLine(string.Join(", ", flatArr));
FlatArray(arr);