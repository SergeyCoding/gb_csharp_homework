// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

string[] RomeSymbols = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
int[] RomeSymbolsValue = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

int GetRomeValue(string rome)
{
    var s = 0;

    for (int i = 0; i < RomeSymbols.Length; i++)
    {
        if (RomeSymbols[i].Length != 2)
            continue;

        if (rome.Contains(RomeSymbols[i]))
        {
            s += RomeSymbolsValue[i];
            rome = rome.Replace(RomeSymbols[i], string.Empty);
        }
    }

    foreach (var item in rome)
    {
        for (int i = 0; i < RomeSymbols.Length; i++)
        {
            if (item.ToString() == RomeSymbols[i])
            {
                s += RomeSymbolsValue[i];
                break;
            }
        }
    }

    return s;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 7-Star");

Console.Write("Число римскими цифрами:");
var romeString = Console.ReadLine();

Console.WriteLine(romeString);
Console.WriteLine(GetRomeValue(romeString));
