// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++)
        result *= a;

    return result;
}

Console.WriteLine(Pow(3, 5));
Console.WriteLine(Pow(2, 4));
