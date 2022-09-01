// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

#pragma warning disable CS8604 
Console.WriteLine("Task Star");

Console.Write("Введите размер массива: ");
int numCount = int.Parse(Console.ReadLine());
if (numCount < 1)
{
    System.Console.WriteLine("Ошибка! Введите корректный размер массива");
    return;
}

int[] arr = GetArray(numCount, -100, 100);
Console.WriteLine(String.Join(", ", arr));

Sort(arr);
Console.WriteLine(String.Join(", ", arr));