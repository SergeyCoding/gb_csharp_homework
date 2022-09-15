// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

var bracketOpen = new[] { '{', '[', '(' };
var bracketClose = new[] { '}', ']', ')' };

bool Brackets(string s)
{
    var stack = new Stack<char>();

    foreach (var c in s)
    {
        for (int i = 0; i < bracketOpen.Length; i++)
        {
            if (bracketOpen[i] == c)
                stack.Push(c);
        }

        for (int i = 0; i < bracketOpen.Length; i++)
        {
            if (bracketClose[i] == c)
            {
                if (stack.Count == 0 || stack.Pop() != bracketOpen[i])
                    return false;
            }
        }
    }

    return stack.Count == 0;
}

#pragma warning disable CS8604 
Console.WriteLine("Task 9-Star");

Console.Write("Выражение: ");
var str = Console.ReadLine();
PrintResult(str);


//PrintResult("())");
//PrintResult("()()");
//PrintResult("()[{]");
//PrintResult("{()[]}");
//PrintResult(")())");
//PrintResult("())");
//PrintResult("[()({{{}}})]");

void PrintResult(string str)
{
    Console.WriteLine($"{str} - {Brackets(str)}");
}