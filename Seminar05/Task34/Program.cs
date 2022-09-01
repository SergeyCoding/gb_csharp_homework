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

void Proizv(int[] arr)
{
    for (int i = 0; i < arr.Length / 2 + arr.Length % 2; i++)
    {
        int k = arr.Length - 1 - i;
        if (arr.Length % 2 == 1 && i == k)
            Console.Write($"{arr[i]} ");
        else
            Console.Write($"{arr[i] * arr[k]} ");
    }
}

int[] ProductionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];
    return result;

}

// если поставить диапазон от 10 до 99, тогда все попадут
int[] myArray = GetArray(10, -10, 100);
// myArray = new int[] { 1, 2 };
Console.WriteLine(String.Join(" ", myArray));

Proizv(myArray);
System.Console.WriteLine();
Console.WriteLine(String.Join(" ", ProductionArray(myArray)));

#pragma warning disable CS8604 
Console.WriteLine("Task 25");