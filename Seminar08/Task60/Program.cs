
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetUniqueArray(int size)
{
    int[] buf = new int[100];
    int[,,] res = new int[size, size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                while (true)
                {
                    var rnd = new Random().Next(10, 100);
                    if (buf[rnd] == 0)
                    {
                        buf[rnd] = 1;
                        res[i, j, k] = rnd;
                        break;
                    }
                }
            }
        }
    }
    return res;
}

void PrintArray(int[,,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[row, col, k]} ({row}, {col}, {k})");
            }
        }
    }
}

#pragma warning disable CS8604 
Console.WriteLine("Task 60");

Console.Write("Размерность: ");
var size = int.Parse(Console.ReadLine());

Console.WriteLine();

if (size < 1 || size > 4)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

PrintArray(GetUniqueArray(size));
