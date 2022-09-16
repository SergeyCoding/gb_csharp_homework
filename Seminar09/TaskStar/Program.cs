// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool Brackets(string s)
{
    var bracketOpen = new[] { '{', '[', '(' };
    var bracketClose = new[] { '}', ']', ')' };

    var stack = new Stack<char>();

    foreach (var c in s)
    {
        if (bracketOpen.Contains(c))
        {
            stack.Push(c);
            continue;
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

void PrintResult(string str)
{
    Console.WriteLine($"{str} - {Brackets(str)}");
}