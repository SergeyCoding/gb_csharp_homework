// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int[] RandomArray(int count, int low, int high)
{
    int[] arr = new int[count];

    for (int i = 0; i < count; i++)
        arr[i] = new Random().Next(low, high);

    return arr;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 29");

Console.Write("Введите размер массива: ");
int numCount = int.Parse(Console.ReadLine());

Console.Write("Введите нижний диапазон: ");
int lowNumber = int.Parse(Console.ReadLine());

Console.Write("Введите верхний диапазон: ");
int highNumber = int.Parse(Console.ReadLine());

if (numCount < 1 || lowNumber > highNumber)
{
    System.Console.WriteLine("Ошибка! Проверьте введенные данные");
    return;
}

Console.WriteLine(string.Join(", ", RandomArray(numCount, lowNumber, highNumber)));
